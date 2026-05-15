Public Class adminAppointment

    Private Sub adminAppointmentControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadAppointments()
    End Sub

    Private Sub SetupListView()
        lvAppointments.View = View.Details
        lvAppointments.FullRowSelect = True
        lvAppointments.GridLines = True
        lvAppointments.MultiSelect = False

        lvAppointments.Columns.Clear()
        lvAppointments.Columns.Add("Appointment ID", 100)
        lvAppointments.Columns.Add("Employee", 200)
        lvAppointments.Columns.Add("Position", 160)
        lvAppointments.Columns.Add("Department", 160)
        lvAppointments.Columns.Add("Start Date", 120)
        lvAppointments.Columns.Add("End Date", 120)
        lvAppointments.Columns.Add("Status", 100)
    End Sub

    Private Sub LoadAppointments(Optional searchText As String = "")
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT A.AppointmentID, E.FirstName + ' ' + E.LastName AS EmployeeName, "
        STRSQL &= "A.Position, D.DepartmentName, A.StartDate, A.EndDate, A.Status "
        STRSQL &= "FROM EmployeeAppointments A "
        STRSQL &= "INNER JOIN Employees E ON A.EmployeeID = E.EmployeeID "
        STRSQL &= "INNER JOIN Department D ON A.DepartmentID = D.DepartmentID "

        If searchText.Trim() <> "" Then
            STRSQL &= "WHERE E.FirstName LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR E.LastName LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR A.Position LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR D.DepartmentName LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR A.Status LIKE '%" & Replace(searchText, "'", "''") & "%' "
        End If

        STRSQL &= "ORDER BY A.AppointmentID DESC"

        RST = CNN.Execute(STRSQL)

        lvAppointments.Items.Clear()

        Do While Not RST.EOF
            Dim item As New ListViewItem(RST.Fields("AppointmentID").Value.ToString())
            item.SubItems.Add(RST.Fields("EmployeeName").Value.ToString())
            item.SubItems.Add(RST.Fields("Position").Value.ToString())
            item.SubItems.Add(RST.Fields("DepartmentName").Value.ToString())
            item.SubItems.Add(CDate(RST.Fields("StartDate").Value).ToShortDateString())

            If IsDBNull(RST.Fields("EndDate").Value) Then
                item.SubItems.Add("")
            Else
                item.SubItems.Add(CDate(RST.Fields("EndDate").Value).ToShortDateString())
            End If

            item.SubItems.Add(RST.Fields("Status").Value.ToString())

            lvAppointments.Items.Add(item)
            RST.MoveNext()
        Loop
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAppointments(txtSearch.Text)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadAppointments(txtSearch.Text)
    End Sub

    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        Dim frm As New AppointmentDetailsForm(0)
        frm.ShowDialog()
        LoadAppointments(txtSearch.Text)
    End Sub

    Private Sub lvAppointments_DoubleClick(sender As Object, e As EventArgs) Handles lvAppointments.DoubleClick
        If lvAppointments.SelectedItems.Count = 0 Then Exit Sub

        Dim appointmentID As Integer = CInt(lvAppointments.SelectedItems(0).Text)

        Dim frm As New AppointmentDetailsForm(appointmentID)
        frm.ShowDialog()
        LoadAppointments(txtSearch.Text)
    End Sub

End Class
