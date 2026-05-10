Public Class adminDepartmentsControl
    Private Sub DepartmentsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartmentList()
    End Sub

    Dim selectedDepartmentID As Integer = 0

    Private Sub pnlDept_AddDept_Click(sender As Object, e As EventArgs) Handles pnlDept_AddDept.Click
        If pnlDept_txtDeptName.Text.Trim = "" Then
            MsgBox("Please fill in Department Name")
            Exit Sub
        End If

        Dim STRSQL As String = ""

        STRSQL = "INSERT INTO Department (DepartmentName) VALUES ("
        STRSQL &= "'" & Replace(pnlDept_txtDeptName.Text, "'", "''") & "')"

        CNN.Execute(STRSQL)

        MsgBox("Department added successfully.")
        DeptPanelClearFields()
        LoadDepartmentList()
    End Sub

    Private Sub pnlDept_Clear_txtboxs_Click(sender As Object, e As EventArgs) Handles pnl_DeptClearFields.Click
        DeptPanelClearFields()
    End Sub

    Private Sub pnlDept_UpdateDept_Click(sender As Object, e As EventArgs) Handles pnlDept_UpdateDept.Click
        If selectedDepartmentID = 0 Then
            MsgBox("Select a Department first.")
            Exit Sub
        End If

        If pnlDept_txtDeptName.Text.Trim = "" Then
            MsgBox("Please fill in Department Name")
            Exit Sub
        End If

        Dim STRSQL As String = ""

        STRSQL = "UPDATE Department SET "
        STRSQL &= "DepartmentName = '" & Replace(pnlDept_txtDeptName.Text, "'", "''") & "' "
        STRSQL &= "WHERE DepartmentID = " & selectedDepartmentID

        CNN.Execute(STRSQL)

        MsgBox("Department Name changed successfully.")

        DeptPanelClearFields()
        LoadDepartmentList()
    End Sub

    Private Sub pnlDept_DeleteDept_Click(sender As Object, e As EventArgs) Handles pnlDept_DeleteDept.Click
        If selectedDepartmentID = 0 Then
            MsgBox("Select a Department first.")
            Exit Sub
        End If

        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT COUNT(*) AS EmployeeCount FROM Employees WHERE DepartmentID = " & selectedDepartmentID
        RST = CNN.Execute(STRSQL)

        If CInt(RST.Fields("EmployeeCount").Value) > 0 Then
            MsgBox("Cannot delete this department because it still has employees assigned to it.")
            Exit Sub
        End If

        STRSQL = "DELETE FROM Department WHERE DepartmentID = " & selectedDepartmentID
        CNN.Execute(STRSQL)

        MsgBox("Department deleted successfully.")

        DeptPanelClearFields()
        LoadDepartmentList()
    End Sub

    Private Sub DeptPanelClearFields()
        selectedDepartmentID = 0
        pnlDept_txtDeptName.Clear()
    End Sub

    Private Sub LoadDepartmentList()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT D.DepartmentID, D.DepartmentName, COUNT(E.EmployeeID) AS EmployeeCount"
        STRSQL &= " FROM Department D"
        STRSQL &= " LEFT JOIN Employees E ON D.DepartmentID = E.DepartmentID"
        STRSQL &= " GROUP BY D.DepartmentID, D.DepartmentName"
        STRSQL &= " ORDER BY D.DepartmentName"

        RST = CNN.Execute(STRSQL)

        dgvDepartments.Rows.Clear()
        dgvDepartments.Columns.Clear()
        dgvDepartments.AllowUserToAddRows = False
        dgvDepartments.ReadOnly = True
        dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDepartments.MultiSelect = False

        dgvDepartments.Columns.Add("DepartmentID", "Department ID")
        dgvDepartments.Columns.Add("DepartmentName", "Department Name")
        dgvDepartments.Columns.Add("EmployeeCount", "No. of Employees")

        Do While Not RST.EOF
            dgvDepartments.Rows.Add(
                RST.Fields("DepartmentID").Value,
                RST.Fields("DepartmentName").Value,
                RST.Fields("EmployeeCount").Value
            )

            RST.MoveNext()
        Loop
    End Sub

    Private Sub dgvDepartments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartments.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If dgvDepartments.Rows.Count = 0 Then Exit Sub
        If dgvDepartments.Rows(e.RowIndex).IsNewRow Then Exit Sub

        Dim row = dgvDepartments.Rows(e.RowIndex)

        If row.Cells("DepartmentID").Value Is Nothing OrElse IsDBNull(row.Cells("DepartmentID").Value) Then
            Exit Sub
        End If

        selectedDepartmentID = CInt(row.Cells("DepartmentID").Value)
        pnlDept_txtDeptName.Text = row.Cells("DepartmentName").Value.ToString
    End Sub
End Class
