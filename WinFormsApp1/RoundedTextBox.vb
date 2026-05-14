Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class RoundedTextBox
    Inherits Panel

    Private WithEvents innerTextBox As New TextBox()

    <Category("Appearance")>
    <DefaultValue(10)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderRadius As Integer = 10

    <Category("Appearance")>
    <DefaultValue(GetType(Color), "Gray")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderColor As Color = Color.Gray

    <Category("Appearance")>
    <DefaultValue(1)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderSize As Integer = 1


    Public Overrides Property Text As String
        Get
            Return innerTextBox.Text
        End Get
        Set(value As String)
            innerTextBox.Text = value
        End Set
    End Property

    Public Sub New()
        Me.Padding = New Padding(8, 5, 8, 5)
        Me.BackColor = Color.White

        innerTextBox.BorderStyle = BorderStyle.None
        innerTextBox.Dock = DockStyle.Fill
        innerTextBox.BackColor = Color.White

        Me.Controls.Add(innerTextBox)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using path As GraphicsPath = GetRoundedPath(Me.ClientRectangle, BorderRadius)
            Using pen As New Pen(BorderColor, BorderSize)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
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

End Class
