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
        txtSearchUser = New MaskedTextBox()
        btnSearchUser = New Button()
        btnAddUser = New Button()
        lvUsers = New ListView()
        SuspendLayout()
        ' 
        ' txtSearchUser
        ' 
        txtSearchUser.Location = New Point(50, 51)
        txtSearchUser.Margin = New Padding(3, 4, 3, 4)
        txtSearchUser.Name = "txtSearchUser"
        txtSearchUser.Size = New Size(206, 27)
        txtSearchUser.TabIndex = 1
        ' 
        ' btnSearchUser
        ' 
        btnSearchUser.Location = New Point(262, 49)
        btnSearchUser.Margin = New Padding(3, 4, 3, 4)
        btnSearchUser.Name = "btnSearchUser"
        btnSearchUser.Size = New Size(86, 31)
        btnSearchUser.TabIndex = 10
        btnSearchUser.Text = "Search"
        btnSearchUser.UseVisualStyleBackColor = True
        ' 
        ' btnAddUser
        ' 
        btnAddUser.Location = New Point(382, 49)
        btnAddUser.Margin = New Padding(3, 4, 3, 4)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(86, 31)
        btnAddUser.TabIndex = 11
        btnAddUser.Text = "Add"
        btnAddUser.UseVisualStyleBackColor = True
        ' 
        ' lvUsers
        ' 
        lvUsers.Location = New Point(0, 142)
        lvUsers.Name = "lvUsers"
        lvUsers.Size = New Size(877, 406)
        lvUsers.TabIndex = 12
        lvUsers.UseCompatibleStateImageBehavior = False
        ' 
        ' adminUsersControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lvUsers)
        Controls.Add(btnAddUser)
        Controls.Add(btnSearchUser)
        Controls.Add(txtSearchUser)
        Margin = New Padding(3, 4, 3, 4)
        Name = "adminUsersControl"
        Size = New Size(877, 548)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtSearchUser As MaskedTextBox
    Friend WithEvents btnSearchUser As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents lvUsers As ListView

End Class
