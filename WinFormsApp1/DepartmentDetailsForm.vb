Public Class DepartmentDetailsForm

    Private departmentID As Integer = 0

    Public Sub New(selectedDepartmentID As Integer)
        InitializeComponent()
        departmentID = selectedDepartmentID
    End Sub

    Private Sub DepartmentDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If departmentID = 0 Then
            Me.Text = "Add Department"
            btnSave.Text = "Add"
            btnDelete.Visible = False
        Else
            Me.Text = "Department Details"
            btnSave.Text = "Update"
            btnDelete.Visible = True
            LoadDepartmentDetails()
        End If
    End Sub

    Private Sub LoadDepartmentDetails()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = "SELECT * FROM Department WHERE DepartmentID = " & departmentID

        RST = CNN.Execute(STRSQL)

        If RST.EOF Then
            MsgBox("Department not found.")
            Me.Close()
            Exit Sub
        End If

        txtDepartmentName.Text = RST.Fields("DepartmentName").Value.ToString()
    End Sub

    Private Function ValidateFields() As Boolean
        If txtDepartmentName.Text.Trim() = "" Then
            MsgBox("Please fill in Department Name.")
            Return False
        End If

        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateFields() Then Exit Sub

        If departmentID = 0 Then
            AddDepartment()
        Else
            UpdateDepartment()
        End If

        Me.Close()
    End Sub

    Private Sub AddDepartment()
        Dim STRSQL As String = ""

        STRSQL = "INSERT INTO Department (DepartmentName) VALUES ("
        STRSQL &= "'" & Replace(txtDepartmentName.Text, "'", "''") & "')"

        CNN.Execute(STRSQL)

        MsgBox("Department added successfully.")
    End Sub

    Private Sub UpdateDepartment()
        Dim STRSQL As String = ""

        STRSQL = "UPDATE Department SET "
        STRSQL &= "DepartmentName = '" & Replace(txtDepartmentName.Text, "'", "''") & "' "
        STRSQL &= "WHERE DepartmentID = " & departmentID

        CNN.Execute(STRSQL)

        MsgBox("Department updated successfully.")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If departmentID = 0 Then Exit Sub

        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT COUNT(*) AS EmployeeCount FROM Employees WHERE DepartmentID = " & departmentID
        RST = CNN.Execute(STRSQL)

        If CInt(RST.Fields("EmployeeCount").Value) > 0 Then
            MsgBox("Cannot delete this department because it still has employees assigned to it.")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this department?", vbYesNo + vbQuestion) = vbNo Then
            Exit Sub
        End If

        CNN.Execute("DELETE FROM Department WHERE DepartmentID = " & departmentID)

        MsgBox("Department deleted successfully.")
        Me.Close()
    End Sub

End Class
