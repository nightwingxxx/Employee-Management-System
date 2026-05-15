Public Class adminDepartmentsControl
    Private Sub DepartmentsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadDepartmentList()
    End Sub

    Private Sub SetupListView()
        lvDepartments.View = View.Details
        lvDepartments.FullRowSelect = True
        lvDepartments.GridLines = True
        lvDepartments.MultiSelect = False

        lvDepartments.Columns.Clear()
        lvDepartments.Columns.Add("ID", 80)
        lvDepartments.Columns.Add("Department Name", 220)
        lvDepartments.Columns.Add("No. of Employees", 140)
    End Sub

    Private Sub LoadDepartmentList(Optional searchText As String = "")
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT D.DepartmentID, D.DepartmentName, COUNT(E.EmployeeID) AS EmployeeCount "
        STRSQL &= "FROM Department D "
        STRSQL &= "LEFT JOIN Employees E ON D.DepartmentID = E.DepartmentID "

        If searchText.Trim() <> "" Then
            STRSQL &= "WHERE D.DepartmentName LIKE '%" & Replace(searchText, "'", "''") & "%' "
        End If

        STRSQL &= "GROUP BY D.DepartmentID, D.DepartmentName "
        STRSQL &= "ORDER BY D.DepartmentName"

        RST = CNN.Execute(STRSQL)

        lvDepartments.Items.Clear()

        Do While Not RST.EOF
            Dim item As New ListViewItem(RST.Fields("DepartmentID").Value.ToString())
            item.SubItems.Add(RST.Fields("DepartmentName").Value.ToString())
            item.SubItems.Add(RST.Fields("EmployeeCount").Value.ToString())

            lvDepartments.Items.Add(item)
            RST.MoveNext()
        Loop
    End Sub

    Private Sub txtSearchDept_TextChanged(sender As Object, e As EventArgs) Handles txtSearchDept.TextChanged
        LoadDepartmentList(txtSearchDept.Text)
    End Sub

    Private Sub btnSearchDept_Click(sender As Object, e As EventArgs) Handles btnSearchDept.Click
        LoadDepartmentList(txtSearchDept.Text)
    End Sub

    Private Sub btnAddDept_Click(sender As Object, e As EventArgs) Handles btnAddDept.Click
        Dim frm As New DepartmentDetailsForm(0)
        frm.ShowDialog()
        LoadDepartmentList(txtSearchDept.Text)
    End Sub

    Private Sub lvDepartments_DoubleClick(sender As Object, e As EventArgs) Handles lvDepartments.DoubleClick
        If lvDepartments.SelectedItems.Count = 0 Then Exit Sub

        Dim departmentID As Integer = CInt(lvDepartments.SelectedItems(0).Text)

        Dim frm As New DepartmentDetailsForm(departmentID)
        frm.ShowDialog()
        LoadDepartmentList(txtSearchDept.Text)
    End Sub
End Class
