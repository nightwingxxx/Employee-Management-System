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
        password = New TextBox()
        Label3 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Label2 = New Label()
        Button5 = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 10.2F)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(104, 270)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 19)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' username
        ' 
        username.BorderStyle = BorderStyle.None
        username.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        username.ForeColor = Color.DimGray
        username.Location = New Point(104, 303)
        username.Margin = New Padding(3, 5, 3, 5)
        username.Name = "username"
        username.Size = New Size(273, 20)
        username.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(104, 424)
        Button1.Margin = New Padding(3, 5, 3, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(295, 51)
        Button1.TabIndex = 2
        Button1.Text = "Sign In"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' password
        ' 
        password.Cursor = Cursors.IBeam
        password.Font = New Font("Segoe UI Light", 9F)
        password.ForeColor = Color.DimGray
        password.Location = New Point(104, 370)
        password.Margin = New Padding(3, 5, 3, 5)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(273, 27)
        password.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(197, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 41)
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
        Button3.Location = New Point(358, 370)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(29, 27)
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 10.2F)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(104, 346)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 19)
        Label2.TabIndex = 8
        Label2.Text = "Password"
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.MenuBar
        Button5.BackgroundImage = My.Resources.Resources.eye_open
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = SystemColors.MenuBar
        Button5.Location = New Point(358, 370)
        Button5.Name = "Button5"
        Button5.Size = New Size(28, 29)
        Button5.TabIndex = 9
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 10.2F)
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(104, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 19)
        Label4.TabIndex = 0
        Label4.Text = "Username"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1054, 632)
        Controls.Add(Button5)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(password)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(username)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Margin = New Padding(3, 5, 3, 5)
        Name = "Form1"
        Text = "Employee Management System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label

End Class
