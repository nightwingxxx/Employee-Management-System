Public Class adminEmployeeControl
    Private Sub EmployeeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
        LoadEmployees()
    End Sub

    Dim selectedEmployeeID As Integer = 0

    Private Sub LoadDepartments()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = "SELECT DepartmentID, DepartmentName FROM Department ORDER BY DepartmentName"

        RST = CNN.Execute(STRSQL)

        cmbDepartment.Items.Clear()

        Do While Not RST.EOF
            cmbDepartment.Items.Add(RST.Fields("DepartmentID").Value & " - " & RST.Fields("DepartmentName").Value)
            RST.MoveNext()
        Loop
    End Sub

    Private Sub LoadEmployees()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT E.EmployeeID, E.FirstName, E.LastName, E.Position, E.DepartmentID, D.DepartmentName, E.ContactNo, E.Email, E.SalaryRate"
        STRSQL &= " FROM Employees E"
        STRSQL &= " LEFT JOIN Department D ON E.DepartmentID = D.DepartmentID"
        STRSQL &= " ORDER BY E.EmployeeID DESC"

        RST = CNN.Execute(STRSQL)

        dgvEmployees.Rows.Clear()
        dgvEmployees.Columns.Clear()
        dgvEmployees.AllowUserToAddRows = False
        dgvEmployees.ReadOnly = True
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployees.MultiSelect = False


        dgvEmployees.Columns.Add("EmployeeID", "Employee ID")
        dgvEmployees.Columns.Add("FirstName", "First Name")
        dgvEmployees.Columns.Add("LastName", "Last Name")
        dgvEmployees.Columns.Add("FullName", "Full Name")
        dgvEmployees.Columns.Add("Position", "Position")
        dgvEmployees.Columns.Add("DepartmentID", "Department ID")
        dgvEmployees.Columns.Add("DepartmentName", "Department")
        dgvEmployees.Columns.Add("ContactNo", "Contact No")
        dgvEmployees.Columns.Add("Email", "Email")
        dgvEmployees.Columns.Add("SalaryRate", "Salary Rate")

        Do While Not RST.EOF
            Dim firstName As String = RST.Fields("FirstName").Value.ToString()
            Dim lastName As String = RST.Fields("LastName").Value.ToString()
            Dim fullName As String = firstName & " " & lastName

            dgvEmployees.Rows.Add(
            RST.Fields("EmployeeID").Value,
            firstName,
            lastName,
            fullName,
            RST.Fields("Position").Value,
            RST.Fields("DepartmentID").Value,
            RST.Fields("DepartmentName").Value,
            RST.Fields("ContactNo").Value,
            RST.Fields("Email").Value,
            RST.Fields("SalaryRate").Value
        )

            RST.MoveNext()
        Loop

        dgvEmployees.Columns("FirstName").Visible = False
        dgvEmployees.Columns("LastName").Visible = False
        dgvEmployees.Columns("DepartmentID").Visible = False
    End Sub


    Private Function GetSelectedDepartmentID() As Integer
        If cmbDepartment.SelectedIndex = -1 Then
            Return 0
        End If

        Dim selectedText As String = cmbDepartment.Text
        Dim deptID As Integer = CInt(selectedText.Split("-"c)(0).Trim())

        Return deptID
    End Function

    Private Sub ClearEmployeeFields()
        selectedEmployeeID = 0
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPosition.Clear()
        cmbDepartment.SelectedIndex = -1
        txtContactNo.Clear()
        txtEmail.Clear()
        txtSalaryRate.Clear()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        If txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Or txtSalaryRate.Text.Trim() = "" Then
            MsgBox("Please fill in First Name, Last Name, and Salary Rate.")
            Exit Sub
        End If

        If cmbDepartment.SelectedIndex = -1 Then
            MsgBox("Please select a department.")
            Exit Sub
        End If

        Dim STRSQL As String = ""

        STRSQL = "INSERT INTO Employees (FirstName, LastName, Position, DepartmentID, ContactNo, Email, SalaryRate) VALUES ("
        STRSQL &= "'" & Replace(txtFirstName.Text, "'", "''") & "', "
        STRSQL &= "'" & Replace(txtLastName.Text, "'", "''") & "', "
        STRSQL &= "'" & Replace(txtPosition.Text, "'", "''") & "', "
        STRSQL &= GetSelectedDepartmentID() & ", "
        STRSQL &= "'" & Replace(txtContactNo.Text, "'", "''") & "', "
        STRSQL &= "'" & Replace(txtEmail.Text, "'", "''") & "', "
        STRSQL &= Val(txtSalaryRate.Text) & ")"

        CNN.Execute(STRSQL)

        MsgBox("Employee added successfully.")
        ClearEmployeeFields()
        LoadEmployees()

    End Sub



    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        ClearEmployeeFields()
    End Sub


    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click

        If selectedEmployeeID = 0 Then
            MsgBox("Select an Employee first.")
            Exit Sub
        End If

        Dim STRSQL = "DELETE FROM Employees WHERE EmployeeID = " & selectedEmployeeID

        CNN.Execute(STRSQL)

        MsgBox("Employee deleted successfully.")

        selectedEmployeeID = 0
        ClearEmployeeFields()
        LoadEmployees()

    End Sub

    Private Sub btnUpdateEmployeeInfo_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        If selectedEmployeeID = 0 Then
            MsgBox("Select an Employee first.")
            Exit Sub
        End If

        If txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Or txtSalaryRate.Text.Trim() = "" Then
            MsgBox("Please fill in First Name, Last Name, and Salary Rate.")
            Exit Sub
        End If

        If cmbDepartment.SelectedIndex = -1 Then
            MsgBox("Please select a department.")
            Exit Sub
        End If

        Dim STRSQL = ""

        STRSQL = "UPDATE Employees SET "
        STRSQL &= "FirstName = '" & Replace(txtFirstName.Text, "'", "''") & "', "
        STRSQL &= "LastName = '" & Replace(txtLastName.Text, "'", "''") & "', "
        STRSQL &= "Position = '" & Replace(txtPosition.Text, "'", "''") & "', "
        STRSQL &= "DepartmentID = " & GetSelectedDepartmentID() & ", "
        STRSQL &= "ContactNo = '" & Replace(txtContactNo.Text, "'", "''") & "', "
        STRSQL &= "Email = '" & Replace(txtEmail.Text, "'", "''") & "', "
        STRSQL &= "SalaryRate = " & Val(txtSalaryRate.Text)
        STRSQL &= " WHERE EmployeeID = " & selectedEmployeeID

        CNN.Execute(STRSQL)

        MsgBox("Employee updated successfully.")

        ClearEmployeeFields()
        LoadEmployees()
    End Sub

    Private Sub dgvEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If dgvEmployees.Rows.Count = 0 Then Exit Sub
        If dgvEmployees.Rows(e.RowIndex).IsNewRow Then Exit Sub

        Dim row = dgvEmployees.Rows(e.RowIndex)

        If row.Cells("EmployeeID").Value Is Nothing Then Exit Sub
        If IsDBNull(row.Cells("EmployeeID").Value) Then Exit Sub

        selectedEmployeeID = CInt(row.Cells("EmployeeID").Value)

        txtFirstName.Text = row.Cells("FirstName").Value.ToString
        txtLastName.Text = row.Cells("LastName").Value.ToString
        txtPosition.Text = row.Cells("Position").Value.ToString
        txtContactNo.Text = row.Cells("ContactNo").Value.ToString
        txtEmail.Text = row.Cells("Email").Value.ToString
        txtSalaryRate.Text = row.Cells("SalaryRate").Value.ToString

        Dim deptID = row.Cells("DepartmentID").Value.ToString

        For i = 0 To cmbDepartment.Items.Count - 1
            If cmbDepartment.Items(i).ToString.StartsWith(deptID & " - ") Then
                cmbDepartment.SelectedIndex = i
                Exit For
            End If
        Next

    End Sub
End Class
