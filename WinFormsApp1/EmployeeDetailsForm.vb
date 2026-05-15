Public Class EmployeeDetailsForm

    Private employeeID As Integer = 0

    Public Sub New(selectedEmployeeID As Integer)
        InitializeComponent()
        employeeID = selectedEmployeeID
    End Sub

    Private Sub EmployeeDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()

        If employeeID = 0 Then
            Me.Text = "Add Employee"
            btnSave.Text = "Add"
            btnDelete.Visible = False
        Else
            Me.Text = "Employee Details"
            btnSave.Text = "Update"
            btnDelete.Visible = True
            LoadEmployeeDetails()
        End If
    End Sub

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

    Private Function GetSelectedDepartmentID() As Integer
        If cmbDepartment.SelectedIndex = -1 Then
            Return 0
        End If

        Return CInt(cmbDepartment.Text.Split("-"c)(0).Trim())
    End Function

    Private Sub LoadEmployeeDetails()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = "SELECT * FROM Employees WHERE EmployeeID = " & employeeID

        RST = CNN.Execute(STRSQL)

        If RST.EOF Then
            MsgBox("Employee not found.")
            Me.Close()
            Exit Sub
        End If

        txtFirstName.Text = RST.Fields("FirstName").Value.ToString()
        txtLastName.Text = RST.Fields("LastName").Value.ToString()
        txtPosition.Text = RST.Fields("Position").Value.ToString()
        txtContactNo.Text = RST.Fields("ContactNo").Value.ToString()
        txtEmail.Text = RST.Fields("Email").Value.ToString()
        txtSalaryRate.Text = RST.Fields("SalaryRate").Value.ToString()

        SelectDepartment(CInt(RST.Fields("DepartmentID").Value))
    End Sub

    Private Sub SelectDepartment(departmentID As Integer)
        For i As Integer = 0 To cmbDepartment.Items.Count - 1
            If cmbDepartment.Items(i).ToString().StartsWith(departmentID & " -") Then
                cmbDepartment.SelectedIndex = i
                Exit Sub
            End If
        Next
    End Sub

    Private Function ValidateFields() As Boolean
        If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or txtSalaryRate.Text.Trim() = "" Then
            MsgBox("Please fill in First Name, Last Name, and Salary Rate.")
            Return False
        End If

        If cmbDepartment.SelectedIndex = -1 Then
            MsgBox("Please select a department.")
            Return False
        End If

        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateFields() Then Exit Sub

        If employeeID = 0 Then
            AddEmployee()
        Else
            UpdateEmployee()
        End If

        Me.Close()
    End Sub

    Private Sub AddEmployee()
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
    End Sub

    Private Sub UpdateEmployee()
        Dim STRSQL As String = ""

        STRSQL = "UPDATE Employees SET "
        STRSQL &= "FirstName = '" & Replace(txtFirstName.Text, "'", "''") & "', "
        STRSQL &= "LastName = '" & Replace(txtLastName.Text, "'", "''") & "', "
        STRSQL &= "Position = '" & Replace(txtPosition.Text, "'", "''") & "', "
        STRSQL &= "DepartmentID = " & GetSelectedDepartmentID() & ", "
        STRSQL &= "ContactNo = '" & Replace(txtContactNo.Text, "'", "''") & "', "
        STRSQL &= "Email = '" & Replace(txtEmail.Text, "'", "''") & "', "
        STRSQL &= "SalaryRate = " & Val(txtSalaryRate.Text) & " "
        STRSQL &= "WHERE EmployeeID = " & employeeID

        CNN.Execute(STRSQL)

        MsgBox("Employee updated successfully.")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If employeeID = 0 Then Exit Sub

        If MsgBox("Are you sure you want to delete this employee?", vbYesNo + vbQuestion) = vbNo Then
            Exit Sub
        End If

        CNN.Execute("DELETE FROM Employees WHERE EmployeeID = " & employeeID)

        MsgBox("Employee deleted successfully.")
        Me.Close()
    End Sub

End Class
