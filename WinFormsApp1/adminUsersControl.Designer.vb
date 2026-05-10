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
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvUsers
        ' 
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Location = New Point(0, 207)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.Size = New Size(767, 204)
        dgvUsers.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(98, 37)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 1
        ' 
        ' txtPasscode
        ' 
        txtPasscode.Location = New Point(98, 75)
        txtPasscode.Name = "txtPasscode"
        txtPasscode.Size = New Size(100, 23)
        txtPasscode.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 3
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' cmbEmployee
        ' 
        cmbEmployee.FormattingEnabled = True
        cmbEmployee.Location = New Point(292, 37)
        cmbEmployee.Name = "cmbEmployee"
        cmbEmployee.Size = New Size(121, 23)
        cmbEmployee.TabIndex = 5
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(292, 78)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(121, 23)
        cmbRole.TabIndex = 6
        ' 
        ' btnAddUser
        ' 
        btnAddUser.Location = New Point(14, 142)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(75, 23)
        btnAddUser.TabIndex = 7
        btnAddUser.Text = "Add"
        btnAddUser.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateUser
        ' 
        btnUpdateUser.Location = New Point(95, 142)
        btnUpdateUser.Name = "btnUpdateUser"
        btnUpdateUser.Size = New Size(75, 23)
        btnUpdateUser.TabIndex = 8
        btnUpdateUser.Text = "Update"
        btnUpdateUser.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteUser
        ' 
        btnDeleteUser.Location = New Point(176, 142)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.Size = New Size(75, 23)
        btnDeleteUser.TabIndex = 9
        btnDeleteUser.Text = "Delete"
        btnDeleteUser.UseVisualStyleBackColor = True
        ' 
        ' btnClearUser
        ' 
        btnClearUser.Location = New Point(257, 142)
        btnClearUser.Name = "btnClearUser"
        btnClearUser.Size = New Size(75, 23)
        btnClearUser.TabIndex = 10
        btnClearUser.Text = "Clear"
        btnClearUser.UseVisualStyleBackColor = True
        ' 
        ' btnRefreshUser
        ' 
        btnRefreshUser.Location = New Point(338, 142)
        btnRefreshUser.Name = "btnRefreshUser"
        btnRefreshUser.Size = New Size(75, 23)
        btnRefreshUser.TabIndex = 11
        btnRefreshUser.Text = "Refresh"
        btnRefreshUser.UseVisualStyleBackColor = True
        ' 
        ' adminUsersControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
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
        Name = "adminUsersControl"
        Size = New Size(767, 411)
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

End Class
