Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form2

    Private activeNavButton As Button = Nothing
    Private normalNavColor As Color = Color.Transparent
    Private hoverNavColor As Color = Color.FromArgb(96, 165, 250)
    Private activeNavColor As Color = Color.FromArgb(30, 120, 255)

    Private employeesPage As New adminEmployeeControl()
    Private departmentsPage As New adminDepartmentsControl()
    Private usersPage As New adminUsersControl()
    Private appointmentsPage As New adminAppointment()
    Private dashboardPage As New adminDashboard()

    Private Sub AddRoundedHoverEffect(btn As Button, radius As Integer)
        MakeButtonRounded(btn, radius)

        AddHandler btn.MouseEnter,
        Sub(sender As Object, e As EventArgs)
            If btn IsNot activeNavButton Then
                btn.BackColor = hoverNavColor
            End If

            MakeButtonRounded(btn, radius)
        End Sub

        AddHandler btn.MouseLeave,
        Sub(sender As Object, e As EventArgs)
            If btn Is activeNavButton Then
                btn.BackColor = activeNavColor
            Else
                btn.BackColor = normalNavColor
            End If

            MakeButtonRounded(btn, radius)
        End Sub

        AddHandler btn.Resize,
        Sub(sender As Object, e As EventArgs)
            MakeButtonRounded(btn, radius)
        End Sub
    End Sub

    Private Sub SetActiveNavButton(btn As Button)
        If activeNavButton IsNot Nothing Then
            activeNavButton.BackColor = normalNavColor
            MakeButtonRounded(activeNavButton, 8)
        End If

        activeNavButton = btn
        activeNavButton.BackColor = activeNavColor
        MakeButtonRounded(activeNavButton, 8)
    End Sub

    Private Sub MakeButtonRounded(btn As Button, radius As Integer)
        Using path As GraphicsPath = GetRoundedPath(btn.ClientRectangle, radius)
            btn.Region = New Region(path)
        End Using

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.UseVisualStyleBackColor = False
    End Sub

    Private Function GetRoundedPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim diameter As Integer = radius * 2

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter - 1, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter - 1, rect.Bottom - diameter - 1, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter - 1, diameter, diameter, 90, 90)
        path.CloseFigure()

        Return path
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveButtonBorder(btnEmployeesPanel)
        RemoveButtonBorder(btnDepartmentsPanel)
        RemoveButtonBorder(btnAppointmentsPanel)
        RemoveButtonBorder(btnDashboardPanel)
        RemoveButtonBorder(btnUsersPanel)
        RemoveButtonBorder(btnLogOut)

        MakeButtonRounded(btnLogOut, 8)

        AddRoundedHoverEffect(btnDashboardPanel, 8)
        AddRoundedHoverEffect(btnEmployeesPanel, 8)
        AddRoundedHoverEffect(btnDepartmentsPanel, 8)
        AddRoundedHoverEffect(btnAppointmentsPanel, 8)
        AddRoundedHoverEffect(btnUsersPanel, 8)
        AddRoundedHoverEffect(btnLogOut, 8)


        ShowPage(dashboardPage)
        SetActiveNavButton(btnDashboardPanel)
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
        SetActiveNavButton(btnEmployeesPanel)
    End Sub

    Private Sub btnDepartmentsPanel_Click(sender As Object, e As EventArgs) Handles btnDepartmentsPanel.Click
        departmentsPage = New adminDepartmentsControl
        ShowPage(departmentsPage)
        SetActiveNavButton(btnDepartmentsPanel)
    End Sub

    Private Sub btnUsersPanel_Click(sender As Object, e As EventArgs) Handles btnUsersPanel.Click
        usersPage = New adminUsersControl()
        ShowPage(usersPage)
        SetActiveNavButton(btnUsersPanel)
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
        SetActiveNavButton(btnAppointmentsPanel)

    End Sub

    Private Sub btnDashboardPanel_Click(sender As Object, e As EventArgs) Handles btnDashboardPanel.Click
        dashboardPage = New adminDashboard()
        ShowPage(dashboardPage)
        SetActiveNavButton(btnDashboardPanel)
    End Sub

    Private Sub splitAdmin_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles splitAdmin.Panel2.Paint

    End Sub

    Private Sub splitAdmin_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles splitAdmin.Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class