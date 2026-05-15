Public Class adminDashboard
    Private Sub adminDashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboard()
    End Sub

    Private Sub LoadDashboard()
        lblTotalEmployees.Text = GetCount("SELECT COUNT(*) FROM Employees").ToString()
        lblTotalDepartments.Text = GetCount("SELECT COUNT(*) FROM Department").ToString()
        lblTotalUsers.Text = GetCount("SELECT COUNT(*) FROM Users").ToString()

        lblActiveAppointments.Text = GetCount(
            "SELECT COUNT(*) FROM EmployeeAppointments " &
            "WHERE EndDate IS NULL AND Status IN ('Active', 'Renewed')"
        ).ToString()

        lblActiveEmployees.Text = GetCount(
            "SELECT COUNT(*) FROM Employees E " &
            "WHERE EXISTS (" &
            "SELECT 1 FROM EmployeeAppointments A " &
            "WHERE A.EmployeeID = E.EmployeeID " &
            "AND A.EndDate IS NULL " &
            "AND A.Status IN ('Active', 'Renewed'))"
        ).ToString()

        lblInactiveEmployees.Text = GetCount(
            "SELECT COUNT(*) FROM Employees E " &
            "WHERE NOT EXISTS (" &
            "SELECT 1 FROM EmployeeAppointments A " &
            "WHERE A.EmployeeID = E.EmployeeID " &
            "AND A.EndDate IS NULL " &
            "AND A.Status IN ('Active', 'Renewed'))"
        ).ToString()
    End Sub

    Private Function GetCount(sql As String) As Integer
        Dim RST As New ADODB.Recordset
        RST = CNN.Execute(sql)

        If RST.EOF Then Return 0

        Return CInt(RST.Fields(0).Value)
    End Function

End Class
