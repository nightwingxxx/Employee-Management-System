Public Class UserDetailsForm

    Private userID As Integer = 0

    Public Sub New(selectedUserID As Integer)
        InitializeComponent()
        userID = selectedUserID
    End Sub

    Private Sub UserDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPasscode.UseSystemPasswordChar = True

        LoadRoles()
        LoadEmployees()

        If userID = 0 Then
            Me.Text = "Add User"
            btnSave.Text = "Add"
            btnDelete.Visible = False
        Else
            Me.Text = "User Details"
            btnSave.Text = "Update"
            btnDelete.Visible = True
            LoadUserDetails()
        End If
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

    Private Sub LoadUserDetails()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = "SELECT * FROM Users WHERE UserID = " & userID

        RST = CNN.Execute(STRSQL)

        If RST.EOF Then
            MsgBox("User not found.")
            Me.Close()
            Exit Sub
        End If

        txtUsername.Text = RST.Fields("UserName").Value.ToString()
        txtPasscode.Text = RST.Fields("Passcode").Value.ToString()
        cmbRole.Text = RST.Fields("Roles").Value.ToString()

        If IsDBNull(RST.Fields("EmployeeID").Value) Then
            cmbEmployee.SelectedIndex = 0
        Else
            SelectEmployeeInCombo(CInt(RST.Fields("EmployeeID").Value))
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

    Private Function ValidateFields() As Boolean
        If txtUsername.Text.Trim() = "" Or txtPasscode.Text.Trim() = "" Then
            MsgBox("Please enter username and passcode.")
            Return False
        End If

        If cmbRole.Text = "Employee" AndAlso GetSelectedEmployeeID() = 0 Then
            MsgBox("Please select an employee for this account.")
            Return False
        End If

        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateFields() Then Exit Sub

        If userID = 0 Then
            AddUser()
        Else
            UpdateUser()
        End If

        Me.Close()
    End Sub

    Private Sub AddUser()
        Dim employeeValue As String = If(GetSelectedEmployeeID() = 0, "NULL", GetSelectedEmployeeID().ToString())
        Dim STRSQL As String = ""

        STRSQL = "INSERT INTO Users (UserName, Passcode, Roles, EmployeeID) VALUES ("
        STRSQL &= "'" & Replace(txtUsername.Text, "'", "''") & "', "
        STRSQL &= "'" & Replace(txtPasscode.Text, "'", "''") & "', "
        STRSQL &= "'" & Replace(cmbRole.Text, "'", "''") & "', "
        STRSQL &= employeeValue & ")"

        CNN.Execute(STRSQL)

        MsgBox("User account added successfully.")
    End Sub

    Private Sub UpdateUser()
        Dim employeeValue As String = If(GetSelectedEmployeeID() = 0, "NULL", GetSelectedEmployeeID().ToString())
        Dim STRSQL As String = ""

        STRSQL = "UPDATE Users SET "
        STRSQL &= "UserName = '" & Replace(txtUsername.Text, "'", "''") & "', "
        STRSQL &= "Passcode = '" & Replace(txtPasscode.Text, "'", "''") & "', "
        STRSQL &= "Roles = '" & Replace(cmbRole.Text, "'", "''") & "', "
        STRSQL &= "EmployeeID = " & employeeValue & " "
        STRSQL &= "WHERE UserID = " & userID

        CNN.Execute(STRSQL)

        MsgBox("User account updated successfully.")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If userID = 0 Then Exit Sub

        If MsgBox("Are you sure you want to delete this user account?", vbYesNo + vbQuestion) = vbNo Then
            Exit Sub
        End If

        CNN.Execute("DELETE FROM Users WHERE UserID = " & userID)

        MsgBox("User account deleted successfully.")
        Me.Close()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPasscode.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

End Class
