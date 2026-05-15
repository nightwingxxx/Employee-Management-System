Imports System.Drawing.Drawing2D

Public Class adminEmployeeControl

    Private Sub EmployeeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView()
        LoadEmployees()
    End Sub

    Private Sub ListView()
        lvEmployees.View = View.Details
        lvEmployees.FullRowSelect = True
        lvEmployees.GridLines = True
        lvEmployees.MultiSelect = False

        lvEmployees.Columns.Clear()
        lvEmployees.Columns.Add("ID", 80)
        lvEmployees.Columns.Add("Full Name", 200)
        lvEmployees.Columns.Add("Position", 160)
        lvEmployees.Columns.Add("Department", 160)
        lvEmployees.Columns.Add("Contact No", 140)
        lvEmployees.Columns.Add("Email", 200)
        lvEmployees.Columns.Add("Salary Rate", 120)
        lvEmployees.Columns.Add("Status", 100)

    End Sub

    Private Sub LoadEmployees(Optional searchText As String = "")
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT E.EmployeeID, E.FirstName, E.LastName, E.Position, "
        STRSQL &= "D.DepartmentName, E.ContactNo, E.Email, E.SalaryRate, "
        STRSQL &= "CASE WHEN EXISTS ("
        STRSQL &= "SELECT 1 FROM EmployeeAppointments A "
        STRSQL &= "WHERE A.EmployeeID = E.EmployeeID "
        STRSQL &= "AND A.EndDate IS NULL "
        STRSQL &= "AND A.Status IN ('Active', 'Renewed')"
        STRSQL &= ") THEN 'Active' ELSE 'Inactive' END AS EmployeeStatus "
        STRSQL &= "FROM Employees E "
        STRSQL &= "LEFT JOIN Department D ON E.DepartmentID = D.DepartmentID "

        If searchText.Trim() <> "" Then
            STRSQL &= "WHERE E.FirstName LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR E.LastName LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR E.Position LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR D.DepartmentName LIKE '%" & Replace(searchText, "'", "''") & "%' "
        End If

        STRSQL &= "ORDER BY E.EmployeeID DESC"

        RST = CNN.Execute(STRSQL)

        lvEmployees.Items.Clear()

        Do While Not RST.EOF
            Dim firstName As String = RST.Fields("FirstName").Value.ToString()
            Dim lastName As String = RST.Fields("LastName").Value.ToString()
            Dim fullName As String = firstName & " " & lastName

            Dim item As New ListViewItem(RST.Fields("EmployeeID").Value.ToString())
            item.SubItems.Add(fullName)
            item.SubItems.Add(RST.Fields("Position").Value.ToString())
            item.SubItems.Add(RST.Fields("DepartmentName").Value.ToString())
            item.SubItems.Add(RST.Fields("ContactNo").Value.ToString())
            item.SubItems.Add(RST.Fields("Email").Value.ToString())
            item.SubItems.Add(RST.Fields("SalaryRate").Value.ToString())
            item.SubItems.Add(RST.Fields("EmployeeStatus").Value.ToString())

            lvEmployees.Items.Add(item)

            RST.MoveNext()
        Loop
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadEmployees(txtSearch.Text)
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadEmployees(txtSearch.Text)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadEmployees(txtSearch.Text)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim frm As New EmployeeDetailsForm(0)
        frm.ShowDialog()

        LoadEmployees(txtSearch.Text)
    End Sub

    Private Sub lvEmployees_DoubleClick(sender As Object, e As EventArgs) Handles lvEmployees.DoubleClick
        If lvEmployees.SelectedItems.Count = 0 Then Exit Sub

        Dim employeeID As Integer = CInt(lvEmployees.SelectedItems(0).Text)

        Dim frm As New EmployeeDetailsForm(employeeID)
        frm.ShowDialog()

        LoadEmployees(txtSearch.Text)
    End Sub

End Class