Public Class AppointmentDetailsForm
    Private appointmentID As Integer = 0

    Public Sub New(selectedAppointmentID As Integer)
        InitializeComponent()
        appointmentID = selectedAppointmentID
    End Sub

    Private Sub AppointmentDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
        LoadDepartments()
        LoadStatusOptions()

        If appointmentID = 0 Then
            Me.Text = "Add Appointment"
            btnSave.Text = "Add"
            btnDelete.Visible = False
            chkNoEndDate.Checked = True
            dtpEndDate.Enabled = False
        Else
            Me.Text = "Appointment Details"
            btnSave.Text = "Update"
            btnDelete.Visible = True
            LoadAppointmentDetails()
        End If
    End Sub

    Private Sub LoadEmployees()
        Dim RST As New ADODB.Recordset
        RST = CNN.Execute("SELECT EmployeeID, FirstName + ' ' + LastName AS EmployeeName FROM Employees ORDER BY FirstName, LastName")

        cmbEmployee.Items.Clear()

        Do While Not RST.EOF
            cmbEmployee.Items.Add(RST.Fields("EmployeeID").Value & " - " & RST.Fields("EmployeeName").Value)
            RST.MoveNext()
        Loop
    End Sub

    Private Sub LoadDepartments()
        Dim RST As New ADODB.Recordset
        RST = CNN.Execute("SELECT DepartmentID, DepartmentName FROM Department ORDER BY DepartmentName")

        cmbDepartment.Items.Clear()

        Do While Not RST.EOF
            cmbDepartment.Items.Add(RST.Fields("DepartmentID").Value & " - " & RST.Fields("DepartmentName").Value)
            RST.MoveNext()
        Loop
    End Sub

    Private Sub LoadStatus()
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Active")
        cmbStatus.Items.Add("Renewed")
        cmbStatus.Items.Add("Expired")
        cmbStatus.Items.Add("Ended")
        cmbStatus.SelectedIndex = 0
    End Sub

    Private Sub LoadStatusOptions()
        cmbStatus.Items.Clear()

        If chkNoEndDate.Checked Then
            cmbStatus.Items.Add("Active")
            cmbStatus.Items.Add("Renewed")

            If HasPreviousExpiredAppointment(GetSelectedEmployeeID()) Then
                cmbStatus.SelectedItem = "Renewed"
            Else
                cmbStatus.SelectedItem = "Active"
            End If
        Else
            cmbStatus.Items.Add("Expired")
            cmbStatus.Items.Add("Ended")
            cmbStatus.SelectedItem = "Expired"
        End If
    End Sub

    Private Function HasPreviousExpiredAppointment(employeeID As Integer) As Boolean
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT TOP 1 Status "
        STRSQL &= "FROM EmployeeAppointments "
        STRSQL &= "WHERE EmployeeID = " & employeeID & " "
        STRSQL &= "ORDER BY StartDate DESC, AppointmentID DESC"

        RST = CNN.Execute(STRSQL)

        If RST.EOF Then Return False

        Return RST.Fields("Status").Value.ToString() = "Expired"
    End Function

    Private Sub cmbEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployee.SelectedIndexChanged
        If cmbEmployee.SelectedIndex = -1 Then Exit Sub

        Dim empID As Integer = GetSelectedEmployeeID()

        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT Position, DepartmentID FROM Employees WHERE EmployeeID = " & empID

        RST = CNN.Execute(STRSQL)

        If RST.EOF Then Exit Sub

        txtPosition.Text = RST.Fields("Position").Value.ToString()

        If Not IsDBNull(RST.Fields("DepartmentID").Value) Then
            SelectComboByID(cmbDepartment, CInt(RST.Fields("DepartmentID").Value))
        End If

        LoadStatusOptions()
    End Sub

    Private Function GetSelectedEmployeeID() As Integer
        Return CInt(cmbEmployee.Text.Split("-"c)(0).Trim())
    End Function

    Private Function GetSelectedDepartmentID() As Integer
        Return CInt(cmbDepartment.Text.Split("-"c)(0).Trim())
    End Function

    Private Function GetAppointmentStatus(employeeID As Integer, position As String, departmentID As Integer) As String
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT TOP 1 Position, DepartmentID "
        STRSQL &= "FROM EmployeeAppointments "
        STRSQL &= "WHERE EmployeeID = " & employeeID & " "
        STRSQL &= "ORDER BY StartDate DESC, AppointmentID DESC"

        RST = CNN.Execute(STRSQL)

        If RST.EOF Then Return "Active"

        If RST.Fields("Position").Value.ToString() = position AndAlso CInt(RST.Fields("DepartmentID").Value) = departmentID Then
            Return "Renewed"
        End If

        Return "Active"
    End Function

    Private Function ValidateFields() As Boolean
        If cmbEmployee.SelectedIndex = -1 Then
            MsgBox("Please select an employee.")
            Return False
        End If

        If txtPosition.Text.Trim() = "" Then
            MsgBox("Please enter position.")
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

        If appointmentID = 0 Then
            AddAppointment()
        Else
            UpdateAppointment()
        End If

        Me.Close()
    End Sub

    Private Sub AddAppointment()
        Dim empID As Integer = GetSelectedEmployeeID()
        Dim deptID As Integer = GetSelectedDepartmentID()

        Dim endDateValue As String

        If chkNoEndDate.Checked Then
            endDateValue = "NULL"
        Else
            endDateValue = "'" & dtpEndDate.Value.ToString("yyyy-MM-dd") & "'"
        End If

        Dim STRSQL As String = ""

        STRSQL = "INSERT INTO EmployeeAppointments (EmployeeID, Position, DepartmentID, StartDate, EndDate, Status) VALUES ("
        STRSQL &= empID & ", "
        STRSQL &= "'" & Replace(txtPosition.Text, "'", "''") & "', "
        STRSQL &= deptID & ", "
        STRSQL &= "'" & dtpStartDate.Value.ToString("yyyy-MM-dd") & "', "
        STRSQL &= endDateValue & ", "
        STRSQL &= "'" & Replace(cmbStatus.Text, "'", "''") & "')"

        CNN.Execute(STRSQL)

        CNN.Execute("UPDATE Employees SET Position = '" & Replace(txtPosition.Text, "'", "''") & "', DepartmentID = " & deptID & " WHERE EmployeeID = " & empID)

        MsgBox("Appointment added successfully.")
    End Sub


    Private Sub UpdateAppointment()
        Dim empID As Integer = GetSelectedEmployeeID()
        Dim deptID As Integer = GetSelectedDepartmentID()

        Dim endDateValue As String

        If chkNoEndDate.Checked Then
            endDateValue = "NULL"
        Else
            endDateValue = "'" & dtpEndDate.Value.ToString("yyyy-MM-dd") & "'"
        End If

        Dim STRSQL As String = ""

        STRSQL = "UPDATE EmployeeAppointments SET "
        STRSQL &= "EmployeeID = " & empID & ", "
        STRSQL &= "Position = '" & Replace(txtPosition.Text, "'", "''") & "', "
        STRSQL &= "DepartmentID = " & deptID & ", "
        STRSQL &= "StartDate = '" & dtpStartDate.Value.ToString("yyyy-MM-dd") & "', "
        STRSQL &= "EndDate = " & endDateValue & ", "
        STRSQL &= "Status = '" & Replace(cmbStatus.Text, "'", "''") & "' "
        STRSQL &= "WHERE AppointmentID = " & appointmentID

        CNN.Execute(STRSQL)

        CNN.Execute("UPDATE Employees SET Position = '" & Replace(txtPosition.Text, "'", "''") & "', DepartmentID = " & deptID & " WHERE EmployeeID = " & empID)

        MsgBox("Appointment updated successfully.")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If appointmentID = 0 Then Exit Sub

        If MsgBox("Are you sure you want to delete this appointment?", vbYesNo + vbQuestion) = vbNo Then Exit Sub

        CNN.Execute("DELETE FROM EmployeeAppointments WHERE AppointmentID = " & appointmentID)

        MsgBox("Appointment deleted successfully.")
        Me.Close()
    End Sub

    Private Sub chkNoEndDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoEndDate.CheckedChanged
        dtpEndDate.Enabled = Not chkNoEndDate.Checked

        If cmbEmployee.SelectedIndex <> -1 Then
            LoadStatusOptions()
        End If
    End Sub

    Private Sub LoadAppointmentDetails()
        Dim RST As New ADODB.Recordset
        RST = CNN.Execute("SELECT * FROM EmployeeAppointments WHERE AppointmentID = " & appointmentID)

        If RST.EOF Then
            MsgBox("Appointment not found.")
            Me.Close()
            Exit Sub
        End If

        SelectComboByID(cmbEmployee, CInt(RST.Fields("EmployeeID").Value))
        txtPosition.Text = RST.Fields("Position").Value.ToString()
        SelectComboByID(cmbDepartment, CInt(RST.Fields("DepartmentID").Value))
        dtpStartDate.Value = CDate(RST.Fields("StartDate").Value)

        If IsDBNull(RST.Fields("EndDate").Value) Then
            chkNoEndDate.Checked = True
            dtpEndDate.Enabled = False
        Else
            chkNoEndDate.Checked = False
            dtpEndDate.Enabled = True
            dtpEndDate.Value = CDate(RST.Fields("EndDate").Value)
        End If

        cmbStatus.Text = RST.Fields("Status").Value.ToString()

    End Sub

    Private Sub SelectComboByID(cmb As ComboBox, id As Integer)
        For i As Integer = 0 To cmb.Items.Count - 1
            If cmb.Items(i).ToString().StartsWith(id & " -") Then
                cmb.SelectedIndex = i
                Exit Sub
            End If
        Next
    End Sub
End Class