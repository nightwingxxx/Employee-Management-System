Public Class Form3
    Private Sub LoadControl(ctrl As UserControl)
        splitEmployee.Panel2.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        splitEmployee.Panel2.Controls.Add(ctrl)
    End Sub


    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Form1.username.Clear()
        Form1.password.Clear()
        Form1.username.Focus()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub splitEmployee_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles splitEmployee.Panel2.Paint

    End Sub
End Class