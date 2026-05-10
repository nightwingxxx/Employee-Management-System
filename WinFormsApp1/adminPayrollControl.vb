Public Class adminPayrollControl
    Dim selectedPayrollID As Integer = 0
    Dim selectedEmployeeID As Integer = 0

    Private Sub PayrollControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPayroll.AllowUserToAddRows = False
        dgvPayroll.ReadOnly = True
        dgvPayroll.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPayroll.MultiSelect = False

        txtGrossPay.ReadOnly = True
        txtNetPay.ReadOnly = True
        txtDeductions.Text = "0"


        dtpPayPeriodStart.Value = Date.Today
        dtpPayPeriodEnd.Value = Date.Today

        LoadEmployees()
        LoadPayroll()
    End Sub


    Private Sub LoadEmployees()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT EmployeeID, FirstName + ' ' + LastName AS EmployeeName FROM Employees ORDER BY FirstName, LastName"

        RST = CNN.Execute(STRSQL)

        cmbEmployee.Items.Clear()
        cmbEmployee.Items.Add("Select Employee")

        Do While Not RST.EOF
            cmbEmployee.Items.Add(RST.Fields("EmployeeID").Value & " - " & RST.Fields("EmployeeName").Value)
            RST.MoveNext()
        Loop

        cmbEmployee.SelectedIndex = 0
    End Sub

    Private Function GetSelectedEmployeeID() As Integer
        If cmbEmployee.SelectedIndex <= 0 Then
            Return 0
        End If

        Return CInt(cmbEmployee.Text.Split("-"c)(0).Trim())
    End Function

    Private Sub SelectEmployeeInCombo(employeeID As Integer)
        For i As Integer = 0 To cmbEmployee.Items.Count - 1
            If cmbEmployee.Items(i).ToString().StartsWith(employeeID & " -") Then
                cmbEmployee.SelectedIndex = i
                Exit Sub
            End If
        Next
    End Sub


    Private Sub LoadPayroll()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT P.PayrollID, P.EmployeeID, E.FirstName + ' ' + E.LastName AS EmployeeName, "
        STRSQL &= "P.PayPeriodStart, P.PayPeriodEnd, P.GrossPay, P.Deductions, P.NetPay "
        STRSQL &= "FROM Payroll P "
        STRSQL &= "INNER JOIN Employees E ON P.EmployeeID = E.EmployeeID "
        STRSQL &= "ORDER BY P.PayrollID DESC"

        RST = CNN.Execute(STRSQL)

        dgvPayroll.Rows.Clear()
        dgvPayroll.Columns.Clear()

        dgvPayroll.Columns.Add("PayrollID", "Payroll ID")
        dgvPayroll.Columns.Add("EmployeeID", "Employee ID")
        dgvPayroll.Columns.Add("EmployeeName", "Employee Name")
        dgvPayroll.Columns.Add("PayPeriodStart", "Period Start")
        dgvPayroll.Columns.Add("PayPeriodEnd", "Period End")
        dgvPayroll.Columns.Add("GrossPay", "Gross Pay")
        dgvPayroll.Columns.Add("Deductions", "Deductions")
        dgvPayroll.Columns.Add("NetPay", "Net Pay")

        Do While Not RST.EOF
            dgvPayroll.Rows.Add(
                RST.Fields("PayrollID").Value,
                RST.Fields("EmployeeID").Value,
                RST.Fields("EmployeeName").Value,
                If(IsDBNull(RST.Fields("PayPeriodStart").Value), "", CDate(RST.Fields("PayPeriodStart").Value).ToShortDateString()),
                If(IsDBNull(RST.Fields("PayPeriodEnd").Value), "", CDate(RST.Fields("PayPeriodEnd").Value).ToShortDateString()),
                FormatNumber(RST.Fields("GrossPay").Value, 2),
                FormatNumber(RST.Fields("Deductions").Value, 2),
                FormatNumber(RST.Fields("NetPay").Value, 2)
            )

            RST.MoveNext()
        Loop
    End Sub

    Private Sub btnComputePayroll_Click(sender As Object, e As EventArgs) Handles btnComputePayroll.Click
        If GetSelectedEmployeeID() = 0 Then
            MsgBox("Please select an employee.")
            Exit Sub
        End If

        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT E.SalaryRate, "
        STRSQL &= "ISNULL(SUM(DATEDIFF(MINUTE, A.TimeIn, A.TimeOff)) / 60.0, 0) AS TotalHours "
        STRSQL &= "FROM Employees E "
        STRSQL &= "LEFT JOIN Attendance A ON E.EmployeeID = A.EmployeeID "
        STRSQL &= "AND A.DateRec BETWEEN '" & dtpPayPeriodStart.Value.ToString("yyyy-MM-dd") & "' "
        STRSQL &= "AND '" & dtpPayPeriodEnd.Value.ToString("yyyy-MM-dd") & "' "
        STRSQL &= "AND A.TimeIn IS NOT NULL "
        STRSQL &= "AND A.TimeOff IS NOT NULL "
        STRSQL &= "WHERE E.EmployeeID = " & GetSelectedEmployeeID() & " "
        STRSQL &= "GROUP BY E.SalaryRate"

        RST = CNN.Execute(STRSQL)

        If RST.EOF Then
            MsgBox("No attendance found for this employee in this pay period.")
            Exit Sub
        End If

        Dim salaryRate As Decimal = CDec(RST.Fields("SalaryRate").Value)
        Dim totalHours As Decimal = CDec(RST.Fields("TotalHours").Value)
        Dim grossPay As Decimal = salaryRate * totalHours
        Dim deductions As Decimal = Val(txtDeductions.Text)
        Dim netPay As Decimal = grossPay - deductions

        txtGrossPay.Text = grossPay.ToString("0.00")
        txtNetPay.Text = netPay.ToString("0.00")
    End Sub

    Private Sub txtDeductions_TextChanged(sender As Object, e As EventArgs) Handles txtDeductions.TextChanged
        Dim grossPay As Decimal = Val(txtGrossPay.Text)
        Dim deductions As Decimal = Val(txtDeductions.Text)

        txtNetPay.Text = (grossPay - deductions).ToString("0.00")
    End Sub

    Private Sub btnSavePayroll_Click(sender As Object, e As EventArgs) Handles btnSavePayroll.Click
        If GetSelectedEmployeeID() = 0 Then
            MsgBox("Please select an employee.")
            Exit Sub
        End If

        If txtGrossPay.Text.Trim() = "" Or txtNetPay.Text.Trim() = "" Then
            MsgBox("Please compute payroll first.")
            Exit Sub
        End If

        Dim RST As New ADODB.Recordset
        Dim CHECKSQL As String = ""

        CHECKSQL = "SELECT COUNT(*) AS PayrollCount FROM Payroll "
        CHECKSQL &= "WHERE EmployeeID = " & GetSelectedEmployeeID() & " "
        CHECKSQL &= "AND PayPeriodStart = '" & dtpPayPeriodStart.Value.ToString("yyyy-MM-dd") & "' "
        CHECKSQL &= "AND PayPeriodEnd = '" & dtpPayPeriodEnd.Value.ToString("yyyy-MM-dd") & "'"

        RST = CNN.Execute(CHECKSQL)

        If CInt(RST.Fields("PayrollCount").Value) > 0 Then
            MsgBox("Payroll already exists for this employee and pay period.")
            Exit Sub
        End If



        Dim STRSQL As String = ""

        STRSQL = "INSERT INTO Payroll (EmployeeID, PayPeriodStart, PayPeriodEnd, GrossPay, Deductions, NetPay) VALUES ("
        STRSQL &= GetSelectedEmployeeID() & ", "
        STRSQL &= "'" & dtpPayPeriodStart.Value.ToString("yyyy-MM-dd") & "', "
        STRSQL &= "'" & dtpPayPeriodEnd.Value.ToString("yyyy-MM-dd") & "', "
        STRSQL &= Val(txtGrossPay.Text) & ", "
        STRSQL &= Val(txtDeductions.Text) & ", "
        STRSQL &= Val(txtNetPay.Text) & ")"

        CNN.Execute(STRSQL)

        MsgBox("Payroll saved successfully.")
        ClearPayrollFields()
        LoadPayroll()
    End Sub

    Private Sub btnDeletePayroll_Click(sender As Object, e As EventArgs) Handles btnDeletePayroll.Click
        If selectedPayrollID = 0 Then
            MsgBox("Please select a payroll record to delete.")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this payroll record?", vbYesNo + vbQuestion) = vbNo Then
            Exit Sub
        End If

        CNN.Execute("DELETE FROM Payroll WHERE PayrollID = " & selectedPayrollID)

        MsgBox("Payroll deleted successfully.")
        ClearPayrollFields()
        LoadPayroll()
    End Sub

    Private Sub dgvPayroll_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayroll.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If dgvPayroll.Rows.Count = 0 Then Exit Sub
        If dgvPayroll.Rows(e.RowIndex).IsNewRow Then Exit Sub

        Dim row = dgvPayroll.Rows(e.RowIndex)

        If row.Cells("PayrollID").Value Is Nothing OrElse IsDBNull(row.Cells("PayrollID").Value) Then Exit Sub
        If row.Cells("EmployeeID").Value Is Nothing OrElse IsDBNull(row.Cells("EmployeeID").Value) Then Exit Sub

        selectedPayrollID = CInt(row.Cells("PayrollID").Value)
        selectedEmployeeID = CInt(row.Cells("EmployeeID").Value)

        SelectEmployeeInCombo(selectedEmployeeID)

        Dim startValue As Object = row.Cells("PayPeriodStart").Value
        Dim endValue As Object = row.Cells("PayPeriodEnd").Value

        If startValue IsNot Nothing AndAlso startValue.ToString().Trim() <> "" Then
            dtpPayPeriodStart.Value = CDate(startValue)
        Else
            dtpPayPeriodStart.Value = Date.Today
        End If

        If endValue IsNot Nothing AndAlso endValue.ToString().Trim() <> "" Then
            dtpPayPeriodEnd.Value = CDate(endValue)
        Else
            dtpPayPeriodEnd.Value = Date.Today
        End If

        txtGrossPay.Text = row.Cells("GrossPay").Value.ToString()
        txtDeductions.Text = row.Cells("Deductions").Value.ToString()
        txtNetPay.Text = row.Cells("NetPay").Value.ToString()
    End Sub


    Private Sub ClearPayrollFields()
        selectedPayrollID = 0
        selectedEmployeeID = 0
        cmbEmployee.SelectedIndex = 0
        dtpPayPeriodStart.Value = Date.Today
        dtpPayPeriodEnd.Value = Date.Today
        txtGrossPay.Clear()
        txtDeductions.Text = "0"
        txtNetPay.Clear()
    End Sub

    Private Sub btnClearPayroll_Click(sender As Object, e As EventArgs) Handles btnClearPayroll.Click
        ClearPayrollFields()
    End Sub

    Private Sub btnRefreshPayroll_Click(sender As Object, e As EventArgs) Handles btnRefreshPayroll.Click
        LoadPayroll()
    End Sub
End Class
