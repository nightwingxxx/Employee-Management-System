<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentDetailsForm
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
        txtDepartmentName = New TextBox()
        btnDelete = New Button()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' txtDepartmentName
        ' 
        txtDepartmentName.Location = New Point(76, 48)
        txtDepartmentName.Name = "txtDepartmentName"
        txtDepartmentName.Size = New Size(237, 27)
        txtDepartmentName.TabIndex = 0
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(350, 87)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(350, 46)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' DepartmentDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSave)
        Controls.Add(btnDelete)
        Controls.Add(txtDepartmentName)
        Name = "DepartmentDetailsForm"
        Text = "DepartmentDetailsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDepartmentName As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
End Class
