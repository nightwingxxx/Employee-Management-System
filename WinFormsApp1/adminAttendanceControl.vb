Public Class adminAttendanceControl

    Private Sub AttendanceControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = Date.Today
        dtpTo.Value = Date.Today

        LoadEmployeeFilter()
        LoadDepartmentFilter()
        LoadAttendance()
    End Sub

    Private Sub LoadEmployeeFilter()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT EmployeeID, FirstName + ' ' + LastName AS EmployeeName FROM Employees ORDER BY FirstName, LastName"

        RST = CNN.Execute(STRSQL)

        cmbEmployeeFilter.Items.Clear()
        cmbEmployeeFilter.Items.Add("All Employees")

        Do While Not RST.EOF
            cmbEmployeeFilter.Items.Add(RST.Fields("EmployeeID").Value & " - " & RST.Fields("EmployeeName").Value)
            RST.MoveNext()
        Loop

        cmbEmployeeFilter.SelectedIndex = 0
    End Sub

    Private Sub LoadDepartmentFilter()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT DepartmentID, DepartmentName FROM Department ORDER BY DepartmentName"

        RST = CNN.Execute(STRSQL)

        cmbDepartmentFilter.Items.Clear()
        cmbDepartmentFilter.Items.Add("All Departments")

        Do While Not RST.EOF
            cmbDepartmentFilter.Items.Add(RST.Fields("DepartmentID").Value & " - " & RST.Fields("DepartmentName").Value)
            RST.MoveNext()
        Loop

        cmbDepartmentFilter.SelectedIndex = 0
    End Sub

    Private Function GetSelectedEmployeeID() As Integer
        If cmbEmployeeFilter.SelectedIndex <= 0 Then
            Return 0
        End If

        Return CInt(cmbEmployeeFilter.Text.Split("-"c)(0).Trim())
    End Function

    Private Function GetSelectedDepartmentID() As Integer
        If cmbDepartmentFilter.SelectedIndex <= 0 Then
            Return 0
        End If

        Return CInt(cmbDepartmentFilter.Text.Split("-"c)(0).Trim())
    End Function

    Private Sub LoadAttendance()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT A.AttendanceID, E.EmployeeID, E.FirstName + ' ' + E.LastName AS EmployeeName, "
        STRSQL &= "D.DepartmentName, A.DateRec, A.TimeIn, A.TimeOff "
        STRSQL &= "FROM Attendance A "
        STRSQL &= "INNER JOIN Employees E ON A.EmployeeID = E.EmployeeID "
        STRSQL &= "LEFT JOIN Department D ON E.DepartmentID = D.DepartmentID "
        STRSQL &= "WHERE A.DateRec BETWEEN '" & dtpFrom.Value.ToString("yyyy-MM-dd") & "' "
        STRSQL &= "AND '" & dtpTo.Value.ToString("yyyy-MM-dd") & "' "

        If GetSelectedEmployeeID() <> 0 Then
            STRSQL &= "AND E.EmployeeID = " & GetSelectedEmployeeID() & " "
        End If

        If GetSelectedDepartmentID() <> 0 Then
            STRSQL &= "AND D.DepartmentID = " & GetSelectedDepartmentID() & " "
        End If

        STRSQL &= "ORDER BY A.DateRec DESC, A.TimeIn DESC"

        RST = CNN.Execute(STRSQL)

        dgvAttendance.Rows.Clear()
        dgvAttendance.Columns.Clear()
        dgvAttendance.AllowUserToAddRows = False
        dgvAttendance.ReadOnly = True
        dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAttendance.MultiSelect = False

        dgvAttendance.Columns.Add("AttendanceID", "Attendance ID")
        dgvAttendance.Columns.Add("EmployeeID", "Employee ID")
        dgvAttendance.Columns.Add("EmployeeName", "Employee Name")
        dgvAttendance.Columns.Add("DepartmentName", "Department")
        dgvAttendance.Columns.Add("DateRec", "Date")
        dgvAttendance.Columns.Add("TimeIn", "Time In")
        dgvAttendance.Columns.Add("TimeOff", "Time Out")

        dgvAttendance.Columns("EmployeeID").Visible = False

        Do While Not RST.EOF
            dgvAttendance.Rows.Add(
            RST.Fields("AttendanceID").Value,
            RST.Fields("EmployeeID").Value,
            RST.Fields("EmployeeName").Value,
            RST.Fields("DepartmentName").Value,
            CDate(RST.Fields("DateRec").Value).ToShortDateString(),
            If(IsDBNull(RST.Fields("TimeIn").Value), "", Format(CDate(RST.Fields("TimeIn").Value), "hh:mm tt")),
            If(IsDBNull(RST.Fields("TimeOff").Value), "", Format(CDate(RST.Fields("TimeOff").Value), "hh:mm tt"))
            )

            RST.MoveNext()
        Loop

        LoadAttendanceSummary()
    End Sub

    Private Sub LoadAttendanceSummary()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT "
        STRSQL &= "COUNT(CASE WHEN A.TimeIn IS NOT NULL THEN 1 END) AS TotalTimedIn, "
        STRSQL &= "COUNT(CASE WHEN A.TimeOff IS NOT NULL THEN 1 END) AS TotalTimedOut, "
        STRSQL &= "COUNT(CASE WHEN A.TimeIn IS NOT NULL AND A.TimeOff IS NULL THEN 1 END) AS NotTimedOut "
        STRSQL &= "FROM Attendance A "
        STRSQL &= "INNER JOIN Employees E ON A.EmployeeID = E.EmployeeID "
        STRSQL &= "LEFT JOIN Department D ON E.DepartmentID = D.DepartmentID "
        STRSQL &= "WHERE A.DateRec BETWEEN '" & dtpFrom.Value.ToString("yyyy-MM-dd") & "' "
        STRSQL &= "AND '" & dtpTo.Value.ToString("yyyy-MM-dd") & "' "

        If GetSelectedEmployeeID() <> 0 Then
            STRSQL &= "AND E.EmployeeID = " & GetSelectedEmployeeID() & " "
        End If

        If GetSelectedDepartmentID() <> 0 Then
            STRSQL &= "AND D.DepartmentID = " & GetSelectedDepartmentID() & " "
        End If

        RST = CNN.Execute(STRSQL)

        totalTimedIn.Text = "Timed In: " & RST.Fields("TotalTimedIn").Value.ToString()
        totalTimedOut.Text = "Timed Out: " & RST.Fields("TotalTimedOut").Value.ToString()
        totalNotTimedOut.Text = "Not Timed Out: " & RST.Fields("NotTimedOut").Value.ToString()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadAttendance()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAttendance()
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        cmbEmployeeFilter.SelectedIndex = 0
        cmbDepartmentFilter.SelectedIndex = 0
        dtpFrom.Value = Date.Today
        dtpTo.Value = Date.Today

        LoadAttendance()
    End Sub

End Class


