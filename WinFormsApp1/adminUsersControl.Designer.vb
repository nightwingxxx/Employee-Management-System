<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminUsersControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        dgvUsers = New DataGridView()
        txtUsername = New MaskedTextBox()
        txtPasscode = New MaskedTextBox()
        Label1 = New Label()
        Label2 = New Label()
        cmbEmployee = New ComboBox()
        cmbRole = New ComboBox()
        btnAddUser = New Button()
        btnUpdateUser = New Button()
        btnDeleteUser = New Button()
        btnClearUser = New Button()
        btnRefreshUser = New Button()
        CheckBox1 = New CheckBox()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvUsers
        ' 
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Location = New Point(0, 276)
        dgvUsers.Margin = New Padding(3, 4, 3, 4)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.Size = New Size(877, 272)
        dgvUsers.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(112, 49)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(114, 27)
        txtUsername.TabIndex = 1
        ' 
        ' txtPasscode
        ' 
        txtPasscode.Location = New Point(112, 100)
        txtPasscode.Margin = New Padding(3, 4, 3, 4)
        txtPasscode.Name = "txtPasscode"
        txtPasscode.Size = New Size(114, 27)
        txtPasscode.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 3
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' cmbEmployee
        ' 
        cmbEmployee.FormattingEnabled = True
        cmbEmployee.Location = New Point(334, 49)
        cmbEmployee.Margin = New Padding(3, 4, 3, 4)
        cmbEmployee.Name = "cmbEmployee"
        cmbEmployee.Size = New Size(138, 28)
        cmbEmployee.TabIndex = 5
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(334, 104)
        cmbRole.Margin = New Padding(3, 4, 3, 4)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(138, 28)
        cmbRole.TabIndex = 6
        ' 
        ' btnAddUser
        ' 
        btnAddUser.Location = New Point(16, 189)
        btnAddUser.Margin = New Padding(3, 4, 3, 4)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(86, 31)
        btnAddUser.TabIndex = 7
        btnAddUser.Text = "Add"
        btnAddUser.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateUser
        ' 
        btnUpdateUser.Location = New Point(109, 189)
        btnUpdateUser.Margin = New Padding(3, 4, 3, 4)
        btnUpdateUser.Name = "btnUpdateUser"
        btnUpdateUser.Size = New Size(86, 31)
        btnUpdateUser.TabIndex = 8
        btnUpdateUser.Text = "Update"
        btnUpdateUser.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteUser
        ' 
        btnDeleteUser.Location = New Point(201, 189)
        btnDeleteUser.Margin = New Padding(3, 4, 3, 4)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.Size = New Size(86, 31)
        btnDeleteUser.TabIndex = 9
        btnDeleteUser.Text = "Delete"
        btnDeleteUser.UseVisualStyleBackColor = True
        ' 
        ' btnClearUser
        ' 
        btnClearUser.Location = New Point(294, 189)
        btnClearUser.Margin = New Padding(3, 4, 3, 4)
        btnClearUser.Name = "btnClearUser"
        btnClearUser.Size = New Size(86, 31)
        btnClearUser.TabIndex = 10
        btnClearUser.Text = "Clear"
        btnClearUser.UseVisualStyleBackColor = True
        ' 
        ' btnRefreshUser
        ' 
        btnRefreshUser.Location = New Point(386, 189)
        btnRefreshUser.Margin = New Padding(3, 4, 3, 4)
        btnRefreshUser.Name = "btnRefreshUser"
        btnRefreshUser.Size = New Size(86, 31)
        btnRefreshUser.TabIndex = 11
        btnRefreshUser.Text = "Refresh"
        btnRefreshUser.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(112, 134)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(121, 21)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' adminUsersControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(CheckBox1)
        Controls.Add(btnRefreshUser)
        Controls.Add(btnClearUser)
        Controls.Add(btnDeleteUser)
        Controls.Add(btnUpdateUser)
        Controls.Add(btnAddUser)
        Controls.Add(cmbRole)
        Controls.Add(cmbEmployee)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPasscode)
        Controls.Add(txtUsername)
        Controls.Add(dgvUsers)
        Margin = New Padding(3, 4, 3, 4)
        Name = "adminUsersControl"
        Size = New Size(877, 548)
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents txtUsername As MaskedTextBox
    Friend WithEvents txtPasscode As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnClearUser As Button
    Friend WithEvents btnRefreshUser As Button
    Friend WithEvents CheckBox1 As CheckBox

End Class
