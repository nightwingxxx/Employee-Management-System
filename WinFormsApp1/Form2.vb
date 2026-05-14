Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form2



    Private employeesPage As New adminEmployeeControl()
    Private departmentsPage As New adminDepartmentsControl()
    Private attendancePage As New adminAttendanceControl()
    Private payrollPage As New adminPayrollControl()
    Private usersPage As New adminUsersControl()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ShowPage(employeesPage)
    End Sub

    Private Sub ShowPage(page As UserControl)
        splitAdmin.Panel2.Controls.Clear()

        page.Dock = DockStyle.Fill
        splitAdmin.Panel2.Controls.Add(page)
        page.BringToFront()
    End Sub

    Private Sub btnEmployeesPanel_Click(sender As Object, e As EventArgs) Handles btnEmployeesPanel.Click
        employeesPage = New adminEmployeeControl()
        ShowPage(employeesPage)
    End Sub

    Private Sub btnDepartmentsPanel_Click(sender As Object, e As EventArgs) Handles btnDepartmentsPanel.Click
        departmentsPage = New adminDepartmentsControl()
        ShowPage(departmentsPage)
    End Sub

    Private Sub btnAttendancePanel_Click(sender As Object, e As EventArgs) Handles btnAttendancePanel.Click
        attendancePage = New adminAttendanceControl()
        ShowPage(attendancePage)
    End Sub

    Private Sub btnPayrollPanel_Click(sender As Object, e As EventArgs) Handles btnPayrollPanel.Click
        payrollPage = New adminPayrollControl()
        ShowPage(payrollPage)
    End Sub

    Private Sub btnUsersPanel_Click(sender As Object, e As EventArgs) Handles btnUsersPanel.Click
        usersPage = New adminUsersControl()
        ShowPage(usersPage)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Form1.username.Clear()
        Form1.password.Clear()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class