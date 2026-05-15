<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDetailsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtUsername = New TextBox()
        txtPasscode = New TextBox()
        cmbRole = New ComboBox()
        cmbEmployee = New ComboBox()
        chkShowPassword = New CheckBox()
        btnSave = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(107, 54)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(187, 27)
        txtUsername.TabIndex = 0
        ' 
        ' txtPasscode
        ' 
        txtPasscode.Location = New Point(107, 122)
        txtPasscode.Name = "txtPasscode"
        txtPasscode.Size = New Size(187, 27)
        txtPasscode.TabIndex = 1
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(107, 181)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(151, 28)
        cmbRole.TabIndex = 2
        ' 
        ' cmbEmployee
        ' 
        cmbEmployee.FormattingEnabled = True
        cmbEmployee.Location = New Point(107, 239)
        cmbEmployee.Name = "cmbEmployee"
        cmbEmployee.Size = New Size(151, 28)
        cmbEmployee.TabIndex = 3
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(311, 125)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(103, 24)
        chkShowPassword.TabIndex = 4
        chkShowPassword.Text = "CheckBox1"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(510, 74)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(510, 125)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' UserDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(chkShowPassword)
        Controls.Add(cmbEmployee)
        Controls.Add(cmbRole)
        Controls.Add(txtPasscode)
        Controls.Add(txtUsername)
        Name = "UserDetailsForm"
        Text = "UserDetailsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPasscode As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
End Class
