<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        username = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        password = New TextBox()
        Label3 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 10.2F)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(91, 248)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 16)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' username
        ' 
        username.BorderStyle = BorderStyle.None
        username.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        username.ForeColor = Color.DimGray
        username.Location = New Point(91, 272)
        username.Margin = New Padding(3, 4, 3, 4)
        username.Name = "username"
        username.Size = New Size(239, 16)
        username.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(65, 360)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(296, 38)
        Button1.TabIndex = 2
        Button1.Text = "Sign In"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MediumBlue
        Label2.Location = New Point(91, 292)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 21)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' password
        ' 
        password.Cursor = Cursors.IBeam
        password.Font = New Font("Segoe UI Light", 9F)
        password.ForeColor = Color.DimGray
        password.Location = New Point(91, 316)
        password.Margin = New Padding(3, 4, 3, 4)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(239, 23)
        password.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(194, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 32)
        Label3.TabIndex = 5
        Label3.Text = "Login"
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.MenuBar
        Button3.BackgroundImage = My.Resources.Resources.eye_closed
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.MenuBar
        Button3.Location = New Point(336, 314)
        Button3.Name = "Button3"
        Button3.Size = New Size(25, 25)
        Button3.TabIndex = 7
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.MenuBar
        Button4.BackgroundImage = My.Resources.Resources.eye_open
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.MenuBar
        Button4.Location = New Point(362, 348)
        Button4.Name = "Button4"
        Button4.Size = New Size(25, 25)
        Button4.TabIndex = 8
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(922, 474)
        Controls.Add(password)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(username)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Employee Management System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
