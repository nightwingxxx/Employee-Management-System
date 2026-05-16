
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Drawing.Drawing2D


Public Class Form1


    Private Sub MakeButtonRounded(btn As Button, radius As Integer)
        Using path As GraphicsPath = GetRoundedPath(btn.ClientRectangle, radius)
            btn.Region = New Region(path)
        End Using

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub MakeTextBoxRounded(txt As TextBox, radius As Integer, borderColor As Color)
        txt.BorderStyle = BorderStyle.None

        Dim fillColor As Color = Color.FromArgb(245, 245, 245)

        Dim panel As New Panel()
        panel.Size = New Size(txt.Width + 16, txt.Height + 12)
        panel.Location = txt.Location
        panel.BackColor = fillColor
        panel.Padding = New Padding(8, 6, 8, 6)

        Using regionPath As GraphicsPath = GetRoundedPath(panel.ClientRectangle, radius)
            panel.Region = New Region(regionPath)
        End Using

        AddHandler panel.Paint,
        Sub(sender As Object, e As PaintEventArgs)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

            Using path As GraphicsPath = GetRoundedPath(panel.ClientRectangle, radius)
                Using brush As New SolidBrush(fillColor)
                    e.Graphics.FillPath(brush, path)
                End Using

                Using pen As New Pen(borderColor, 2)
                    e.Graphics.DrawPath(pen, path)
                End Using
            End Using
        End Sub

        txt.BackColor = fillColor

        txt.Parent.Controls.Add(panel)
        panel.BringToFront()

        txt.Parent = panel
        txt.Location = New Point(8, 6)
        txt.Width = panel.Width - 16
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
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label4.Click

    End Sub

    Public Sub ClearLoginFields()
        username.Clear()
        password.Clear()
        username.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
        Button3.BringToFront()
        Button5.BringToFront()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DBconnect()

        MakeTextBoxRounded(username, 8, Color.WhiteSmoke)
        MakeTextBoxRounded(password, 8, Color.WhiteSmoke)
        MakeButtonRounded(Button1, 8)

        Button3.BringToFront()
        Button5.BringToFront()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim isALLOk = True

        Dim MSG = ""

        Dim RST As New ADODB.Recordset

        Dim STRSQL = ""

        If Trim(username.Text) = "" Then

            isALLOk = False

            MSG = MSG & vbCrLf & "Enter Username"

        End If

        If Trim(password.Text) = "" Then

            isALLOk = False

            MSG = MSG & vbCrLf & "Enter Password"

        End If

        If isALLOk Then

            STRSQL = "Select * From Users"

            STRSQL &= vbCrLf & " WHERE UserName ='" & Replace(username.Text, "'", "''") & "'"

            STRSQL &= vbCrLf & " AND Passcode = '" & Replace(password.Text, "'", "''") & "'"

            RST = CNN.Execute(STRSQL)

            If RST.EOF Then

                MsgBox("Invalid Credentials")

            Else
                LoggedInUserID = CInt(RST.Fields("UserID").Value)
                LoggedInUserName = RST.Fields("UserName").Value.ToString
                LoggedInRole = RST.Fields("Roles").Value.ToString

                If IsDBNull(RST.Fields("EmployeeID").Value) Then
                    LoggedInEmployeeID = 0
                Else
                    LoggedInEmployeeID = CInt(RST.Fields("EmployeeID").Value)
                End If

                If LoggedInRole = "Admin" Then
                    Form2.Show()
                    Hide()

                ElseIf LoggedInRole = "Employee" Then
                    Form3.Show()
                    Hide()

                Else
                    MsgBox("Unknown user role.")
                End If

            End If

        Else

            MsgBox(MSG)

        End If

    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If password.PasswordChar = "*"c Then
            Button3.BringToFront()
            ' In VB, setting PasswordChar to ControlChars.NullChar or Chr(0) reveals the text
            password.PasswordChar = ControlChars.NullChar

            Button5.Visible = False
            Button3.Visible = True
            Button3.BringToFront()

            password.Focus()
        End If
    End Sub

    ' Handler for the button that hides the password
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If password.PasswordChar = ControlChars.NullChar Then
            Button5.BringToFront()
            password.PasswordChar = "*"c


            Button3.Visible = False
            Button5.Visible = True
            Button5.BringToFront()

            password.Focus()

        End If
    End Sub


End Class
