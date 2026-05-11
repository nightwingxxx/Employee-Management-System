Public Class EmployeeAttendanceControl
    Private Sub EmployeeAttendanceControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMyAttendance.AllowUserToAddRows = False
        dgvMyAttendance.ReadOnly = True
        dgvMyAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMyAttendance.MultiSelect = False

        LoadTodayStatus()
        LoadMyAttendance()
    End Sub

    Private Sub LoadTodayStatus()
        If LoginSession.LoggedInEmployeeID = 0 Then
            todayStatus.Text = "No employee account linked."
            btnTimeIn.Enabled = False
            btnTimeOut.Enabled = False
            Exit Sub
        End If

        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT TOP 1 * FROM Attendance "
        STRSQL &= "WHERE EmployeeID = " & LoginSession.LoggedInEmployeeID & " "
        STRSQL &= "AND DateRec = CAST(GETDATE() AS DATE) "
        STRSQL &= "ORDER BY AttendanceID DESC"

        RST = CNN.Execute(STRSQL)

        If RST.EOF Then
            todayStatus.Text = "Status: Not timed in today"
            btnTimeIn.Enabled = True
            btnTimeOut.Enabled = False
        ElseIf IsDBNull(RST.Fields("TimeOff").Value) Then
            todayStatus.Text = "Status: Timed in at " & Format(CDate(RST.Fields("TimeIn").Value), "hh:mm tt")
            btnTimeIn.Enabled = False
            btnTimeOut.Enabled = True
        Else
            todayStatus.Text = "Status: Completed today. Time out: " & Format(CDate(RST.Fields("TimeOff").Value), "hh:mm tt")
            btnTimeIn.Enabled = False
            btnTimeOut.Enabled = False
        End If
    End Sub

    Private Sub LoadMyAttendance()
        If LoginSession.LoggedInEmployeeID = 0 Then Exit Sub

        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT AttendanceID, DateRec, TimeIn, TimeOff "
        STRSQL &= "FROM Attendance "
        STRSQL &= "WHERE EmployeeID = " & LoginSession.LoggedInEmployeeID & " "
        STRSQL &= "ORDER BY DateRec DESC, AttendanceID DESC"

        RST = CNN.Execute(STRSQL)

        dgvMyAttendance.Rows.Clear()
        dgvMyAttendance.Columns.Clear()

        dgvMyAttendance.Columns.Add("AttendanceID", "Attendance ID")
        dgvMyAttendance.Columns.Add("DateRec", "Date")
        dgvMyAttendance.Columns.Add("TimeIn", "Time In")
        dgvMyAttendance.Columns.Add("TimeOff", "Time Out")

        Do While Not RST.EOF
            dgvMyAttendance.Rows.Add(
                RST.Fields("AttendanceID").Value,
                CDate(RST.Fields("DateRec").Value).ToShortDateString(),
                If(IsDBNull(RST.Fields("TimeIn").Value), "", Format(CDate(RST.Fields("TimeIn").Value), "hh:mm tt")),
                If(IsDBNull(RST.Fields("TimeOff").Value), "", Format(CDate(RST.Fields("TimeOff").Value), "hh:mm tt"))
            )

            RST.MoveNext()
        Loop
    End Sub

    Private Sub btnTimeIn_Click(sender As Object, e As EventArgs) Handles btnTimeIn.Click
        If LoginSession.LoggedInEmployeeID = 0 Then
            MsgBox("This account is not linked to an employee record.")
            Exit Sub
        End If

        Dim RST As New ADODB.Recordset
        Dim CHECKSQL As String = ""

        CHECKSQL = "SELECT COUNT(*) AS TimeInCount FROM Attendance "
        CHECKSQL &= "WHERE EmployeeID = " & LoginSession.LoggedInEmployeeID & " "
        CHECKSQL &= "AND DateRec = CAST(GETDATE() AS DATE)"

        RST = CNN.Execute(CHECKSQL)

        If CInt(RST.Fields("TimeInCount").Value) > 0 Then
            MsgBox("You already timed in today.")
            LoadTodayStatus()
            Exit Sub
        End If

        Dim STRSQL As String = ""

        STRSQL = "INSERT INTO Attendance (EmployeeID, DateRec, TimeIn, TimeOff) VALUES ("
        STRSQL &= LoginSession.LoggedInEmployeeID & ", "
        STRSQL &= "CAST(GETDATE() AS DATE), "
        STRSQL &= "CAST(GETDATE() AS TIME), "
        STRSQL &= "NULL)"

        CNN.Execute(STRSQL)

        MsgBox("Time in successful.")
        LoadTodayStatus()
        LoadMyAttendance()
    End Sub

    Private Sub btnTimeOut_Click(sender As Object, e As EventArgs) Handles btnTimeOut.Click
        If LoginSession.LoggedInEmployeeID = 0 Then
            MsgBox("This account is not linked to an employee record.")
            Exit Sub
        End If

        Dim RST As New ADODB.Recordset
        Dim CHECKSQL As String = ""

        CHECKSQL = "SELECT TOP 1 AttendanceID FROM Attendance "
        CHECKSQL &= "WHERE EmployeeID = " & LoginSession.LoggedInEmployeeID & " "
        CHECKSQL &= "AND DateRec = CAST(GETDATE() AS DATE) "
        CHECKSQL &= "AND TimeIn IS NOT NULL "
        CHECKSQL &= "AND TimeOff IS NULL "
        CHECKSQL &= "ORDER BY AttendanceID DESC"

        RST = CNN.Execute(CHECKSQL)

        If RST.EOF Then
            MsgBox("No active time-in record found for today.")
            LoadTodayStatus()
            Exit Sub
        End If

        Dim attendanceID As Integer = CInt(RST.Fields("AttendanceID").Value)

        Dim STRSQL As String = ""

        STRSQL = "UPDATE Attendance SET "
        STRSQL &= "TimeOff = CAST(GETDATE() AS TIME) "
        STRSQL &= "WHERE AttendanceID = " & attendanceID

        CNN.Execute(STRSQL)

        MsgBox("Time out successful.")
        LoadTodayStatus()
        LoadMyAttendance()
    End Sub

    Private Sub btnRefreshAttendance_Click(sender As Object, e As EventArgs) Handles btnRefreshAttendance.Click
        LoadTodayStatus()
        LoadMyAttendance()
    End Sub
End Class
