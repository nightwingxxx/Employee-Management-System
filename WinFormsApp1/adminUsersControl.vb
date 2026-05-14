Public Class adminUsersControl
    Dim selectedUserID As Integer = 0

    Private Sub UsersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.ReadOnly = True
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.MultiSelect = False

        txtPasscode.UseSystemPasswordChar = True

        LoadRoles()
        LoadEmployees()
        LoadUsers()
    End Sub

    Private Sub LoadRoles()
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Employee")
        cmbRole.SelectedIndex = 0
    End Sub

    Private Sub LoadEmployees()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT EmployeeID, FirstName + ' ' + LastName AS EmployeeName FROM Employees ORDER BY FirstName, LastName"

        RST = CNN.Execute(STRSQL)

        cmbEmployee.Items.Clear()
        cmbEmployee.Items.Add("No Linked Employee")

        Do While Not RST.EOF
            cmbEmployee.Items.Add(RST.Fields("EmployeeID").Value & " - " & RST.Fields("EmployeeName").Value)
            RST.MoveNext()
        Loop

        cmbEmployee.SelectedIndex = 0
    End Sub

    Private Function GetSelectedEmployeeID() As Integer
        If cmbEmployee.SelectedIndex <= 0 Then
            Return 0
        End If

        Return CInt(cmbEmployee.Text.Split("-"c)(0).Trim())
    End Function

    Private Sub LoadUsers()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT U.UserID, U.UserName, U.Passcode, U.Roles, U.EmployeeID, "
        STRSQL &= "E.FirstName + ' ' + E.LastName AS EmployeeName "
        STRSQL &= "FROM Users U "
        STRSQL &= "LEFT JOIN Employees E ON U.EmployeeID = E.EmployeeID "
        STRSQL &= "ORDER BY U.UserID DESC"

        RST = CNN.Execute(STRSQL)

        dgvUsers.Rows.Clear()
        dgvUsers.Columns.Clear()

        dgvUsers.Columns.Add("UserID", "User ID")
        dgvUsers.Columns.Add("UserName", "Username")
        dgvUsers.Columns.Add("Passcode", "Passcode")
        dgvUsers.Columns.Add("Roles", "Role")
        dgvUsers.Columns.Add("EmployeeID", "Employee ID")
        dgvUsers.Columns.Add("EmployeeName", "Linked Employee")

        Do While Not RST.EOF
            dgvUsers.Rows.Add(
                RST.Fields("UserID").Value,
                RST.Fields("UserName").Value,
                RST.Fields("Passcode").Value,
                RST.Fields("Roles").Value,
                If(IsDBNull(RST.Fields("EmployeeID").Value), "", RST.Fields("EmployeeID").Value),
                If(IsDBNull(RST.Fields("EmployeeName").Value), "No Linked Employee", RST.Fields("EmployeeName").Value)
            )

            RST.MoveNext()
        Loop

        dgvUsers.Columns("Passcode").Visible = False
        dgvUsers.Columns("EmployeeID").Visible = False
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If txtUsername.Text.Trim() = "" Or txtPasscode.Text.Trim() = "" Then
            MsgBox("Please enter username and passcode.")
            Exit Sub
        End If

        If cmbRole.Text = "Employee" AndAlso GetSelectedEmployeeID() = 0 Then
            MsgBox("Please select an employee for this account.")
            Exit Sub
        End If

        Dim employeeValue As String

        If GetSelectedEmployeeID() = 0 Then
            employeeValue = "NULL"
        Else
            employeeValue = GetSelectedEmployeeID().ToString()
        End If

        Dim STRSQL As String = ""

        STRSQL = "INSERT INTO Users (UserName, Passcode, Roles, EmployeeID) VALUES ("
        STRSQL &= "'" & Replace(txtUsername.Text, "'", "''") & "', "
        STRSQL &= "'" & Replace(txtPasscode.Text, "'", "''") & "', "
        STRSQL &= "'" & Replace(cmbRole.Text, "'", "''") & "', "
        STRSQL &= employeeValue & ")"

        CNN.Execute(STRSQL)

        MsgBox("User account added successfully.")
        ClearUserFields()
        LoadUsers()
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        If selectedUserID = 0 Then
            MsgBox("Please select a user first.")
            Exit Sub
        End If

        If txtUsername.Text.Trim() = "" Or txtPasscode.Text.Trim() = "" Then
            MsgBox("Please enter username and passcode.")
            Exit Sub
        End If

        If cmbRole.Text = "Employee" AndAlso GetSelectedEmployeeID() = 0 Then
            MsgBox("Please select an employee for this account.")
            Exit Sub
        End If

        Dim employeeValue As String

        If GetSelectedEmployeeID() = 0 Then
            employeeValue = "NULL"
        Else
            employeeValue = GetSelectedEmployeeID().ToString()
        End If

        Dim STRSQL As String = ""

        STRSQL = "UPDATE Users SET "
        STRSQL &= "UserName = '" & Replace(txtUsername.Text, "'", "''") & "', "
        STRSQL &= "Passcode = '" & Replace(txtPasscode.Text, "'", "''") & "', "
        STRSQL &= "Roles = '" & Replace(cmbRole.Text, "'", "''") & "', "
        STRSQL &= "EmployeeID = " & employeeValue & " "
        STRSQL &= "WHERE UserID = " & selectedUserID

        CNN.Execute(STRSQL)

        MsgBox("User account updated successfully.")
        ClearUserFields()
        LoadUsers()
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If selectedUserID = 0 Then
            MsgBox("Please select a user first.")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this user account?", vbYesNo + vbQuestion) = vbNo Then
            Exit Sub
        End If

        CNN.Execute("DELETE FROM Users WHERE UserID = " & selectedUserID)

        MsgBox("User account deleted successfully.")
        ClearUserFields()
        LoadUsers()
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If dgvUsers.Rows.Count = 0 Then Exit Sub
        If dgvUsers.Rows(e.RowIndex).IsNewRow Then Exit Sub

        Dim row = dgvUsers.Rows(e.RowIndex)

        If row.Cells("UserID").Value Is Nothing OrElse IsDBNull(row.Cells("UserID").Value) Then Exit Sub

        selectedUserID = CInt(row.Cells("UserID").Value)

        txtUsername.Text = row.Cells("UserName").Value.ToString()
        txtPasscode.Text = row.Cells("Passcode").Value.ToString()
        cmbRole.Text = row.Cells("Roles").Value.ToString()

        If row.Cells("EmployeeID").Value Is Nothing OrElse row.Cells("EmployeeID").Value.ToString().Trim() = "" Then
            cmbEmployee.SelectedIndex = 0
        Else
            SelectEmployeeInCombo(CInt(row.Cells("EmployeeID").Value))
        End If
    End Sub

    Private Sub SelectEmployeeInCombo(employeeID As Integer)
        For i As Integer = 0 To cmbEmployee.Items.Count - 1
            If cmbEmployee.Items(i).ToString().StartsWith(employeeID & " -") Then
                cmbEmployee.SelectedIndex = i
                Exit Sub
            End If
        Next
    End Sub

    Private Sub ClearUserFields()
        selectedUserID = 0
        txtUsername.Clear()
        txtPasscode.Clear()
        cmbRole.SelectedIndex = 0
        cmbEmployee.SelectedIndex = 0
    End Sub

    Private Sub btnClearUser_Click(sender As Object, e As EventArgs) Handles btnClearUser.Click
        ClearUserFields()
    End Sub

    Private Sub btnRefreshUser_Click(sender As Object, e As EventArgs) Handles btnRefreshUser.Click
        LoadEmployees()
        LoadUsers()
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPasscode.UseSystemPasswordChar = False
        Else
            txtPasscode.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPasscode_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPasscode.MaskInputRejected

    End Sub
End Class
