<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDepartmentsControl
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        pnlDept_txtDeptName = New TextBox()
        pnlDept_AddDept = New Button()
        dgvDepartments = New DataGridView()
        pnl_DeptClearFields = New Button()
        pnlDept_UpdateDept = New Button()
        pnlDept_DeleteDept = New Button()
        BindingSource1 = New BindingSource(components)
        CType(dgvDepartments, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 20)
        Label1.TabIndex = 0
        Label1.Text = "Department Name:"
        ' 
        ' pnlDept_txtDeptName
        ' 
        pnlDept_txtDeptName.Location = New Point(234, 40)
        pnlDept_txtDeptName.Margin = New Padding(3, 4, 3, 4)
        pnlDept_txtDeptName.Name = "pnlDept_txtDeptName"
        pnlDept_txtDeptName.Size = New Size(204, 27)
        pnlDept_txtDeptName.TabIndex = 1
        ' 
        ' pnlDept_AddDept
        ' 
        pnlDept_AddDept.Location = New Point(514, 28)
        pnlDept_AddDept.Margin = New Padding(3, 4, 3, 4)
        pnlDept_AddDept.Name = "pnlDept_AddDept"
        pnlDept_AddDept.Size = New Size(86, 31)
        pnlDept_AddDept.TabIndex = 2
        pnlDept_AddDept.Text = "Add"
        pnlDept_AddDept.UseVisualStyleBackColor = True
        ' 
        ' dgvDepartments
        ' 
        dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDepartments.Location = New Point(0, 219)
        dgvDepartments.Margin = New Padding(3, 4, 3, 4)
        dgvDepartments.Name = "dgvDepartments"
        dgvDepartments.RowHeadersWidth = 51
        dgvDepartments.Size = New Size(874, 307)
        dgvDepartments.TabIndex = 3
        ' 
        ' pnl_DeptClearFields
        ' 
        pnl_DeptClearFields.Location = New Point(514, 67)
        pnl_DeptClearFields.Margin = New Padding(3, 4, 3, 4)
        pnl_DeptClearFields.Name = "pnl_DeptClearFields"
        pnl_DeptClearFields.Size = New Size(86, 31)
        pnl_DeptClearFields.TabIndex = 6
        pnl_DeptClearFields.Text = "Clear"
        pnl_DeptClearFields.UseVisualStyleBackColor = True
        ' 
        ' pnlDept_UpdateDept
        ' 
        pnlDept_UpdateDept.Location = New Point(514, 105)
        pnlDept_UpdateDept.Margin = New Padding(3, 4, 3, 4)
        pnlDept_UpdateDept.Name = "pnlDept_UpdateDept"
        pnlDept_UpdateDept.Size = New Size(86, 31)
        pnlDept_UpdateDept.TabIndex = 7
        pnlDept_UpdateDept.Text = "Update"
        pnlDept_UpdateDept.UseVisualStyleBackColor = True
        ' 
        ' pnlDept_DeleteDept
        ' 
        pnlDept_DeleteDept.Location = New Point(514, 144)
        pnlDept_DeleteDept.Margin = New Padding(3, 4, 3, 4)
        pnlDept_DeleteDept.Name = "pnlDept_DeleteDept"
        pnlDept_DeleteDept.Size = New Size(86, 31)
        pnlDept_DeleteDept.TabIndex = 8
        pnlDept_DeleteDept.Text = "Delete"
        pnlDept_DeleteDept.UseVisualStyleBackColor = True
        ' 
        ' adminDepartmentsControl
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlDept_DeleteDept)
        Controls.Add(pnlDept_UpdateDept)
        Controls.Add(pnl_DeptClearFields)
        Controls.Add(dgvDepartments)
        Controls.Add(pnlDept_AddDept)
        Controls.Add(pnlDept_txtDeptName)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "adminDepartmentsControl"
        Size = New Size(874, 529)
        CType(dgvDepartments, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlDept_txtDeptName As TextBox
    Friend WithEvents pnlDept_AddDept As Button
    Friend WithEvents dgvDepartments As DataGridView
    Friend WithEvents pnl_DeptClearFields As Button
    Friend WithEvents pnlDept_UpdateDept As Button
    Friend WithEvents pnlDept_DeleteDept As Button
    Friend WithEvents BindingSource1 As BindingSource

End Class
