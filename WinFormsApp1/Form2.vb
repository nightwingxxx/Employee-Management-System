Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form2



    Private employeesPage As New adminEmployeeControl()
    Private departmentsPage As New adminDepartmentsControl()
    Private usersPage As New adminUsersControl()
    Private appointmentsPage As New adminAppointment()


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveButtonBorder(btnEmployeesPanel)
        RemoveButtonBorder(btnDepartmentsPanel)
        RemoveButtonBorder(btnUsersPanel)

        ShowPage(employeesPage)
    End Sub

    Private Sub RemoveButtonBorder(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.UseVisualStyleBackColor = False
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
        departmentsPage = New adminDepartmentsControl
        ShowPage(departmentsPage)
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

    Private Sub btnAppointmentsPanel_Click(sender As Object, e As EventArgs) Handles btnAppointmentsPanel.Click
        appointmentsPage = New adminAppointment()
        ShowPage(appointmentsPage)

    End Sub

End Class