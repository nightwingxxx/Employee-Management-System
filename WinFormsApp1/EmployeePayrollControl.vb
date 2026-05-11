Public Class EmployeePayrollControl

    Private Sub EmployeePayrollControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMyPayroll.AllowUserToAddRows = False
        dgvMyPayroll.ReadOnly = True
        dgvMyPayroll.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMyPayroll.MultiSelect = False

        LoadMyPayroll()
    End Sub

    Private Sub LoadMyPayroll()
        If LoginSession.LoggedInEmployeeID = 0 Then
            MsgBox("This account is not linked to an employee record.")
            Exit Sub
        End If

        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT PayrollID, PayPeriodStart, PayPeriodEnd, GrossPay, Deductions, NetPay "
        STRSQL &= "FROM Payroll "
        STRSQL &= "WHERE EmployeeID = " & LoginSession.LoggedInEmployeeID & " "
        STRSQL &= "ORDER BY PayPeriodStart DESC, PayrollID DESC"

        RST = CNN.Execute(STRSQL)

        dgvMyPayroll.Rows.Clear()
        dgvMyPayroll.Columns.Clear()

        dgvMyPayroll.Columns.Add("PayrollID", "Payroll ID")
        dgvMyPayroll.Columns.Add("PayPeriodStart", "Period Start")
        dgvMyPayroll.Columns.Add("PayPeriodEnd", "Period End")
        dgvMyPayroll.Columns.Add("GrossPay", "Gross Pay")
        dgvMyPayroll.Columns.Add("Deductions", "Deductions")
        dgvMyPayroll.Columns.Add("NetPay", "Net Pay")

        Do While Not RST.EOF
            dgvMyPayroll.Rows.Add(
                RST.Fields("PayrollID").Value,
                CDate(RST.Fields("PayPeriodStart").Value).ToShortDateString(),
                CDate(RST.Fields("PayPeriodEnd").Value).ToShortDateString(),
                FormatNumber(RST.Fields("GrossPay").Value, 2),
                FormatNumber(RST.Fields("Deductions").Value, 2),
                FormatNumber(RST.Fields("NetPay").Value, 2)
            )

            RST.MoveNext()
        Loop
    End Sub

    Private Sub btnRefreshPayroll_Click(sender As Object, e As EventArgs) Handles btnRefreshPayroll.Click
        LoadMyPayroll()
    End Sub

End Class
