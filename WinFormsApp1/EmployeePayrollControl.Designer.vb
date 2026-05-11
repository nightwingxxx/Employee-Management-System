<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeePayrollControl
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
        dgvMyPayroll = New DataGridView()
        btnRefreshPayroll = New Button()
        Label1 = New Label()
        CType(dgvMyPayroll, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvMyPayroll
        ' 
        dgvMyPayroll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMyPayroll.Location = New Point(0, 185)
        dgvMyPayroll.Name = "dgvMyPayroll"
        dgvMyPayroll.Size = New Size(727, 202)
        dgvMyPayroll.TabIndex = 0
        ' 
        ' btnRefreshPayroll
        ' 
        btnRefreshPayroll.Location = New Point(117, 82)
        btnRefreshPayroll.Name = "btnRefreshPayroll"
        btnRefreshPayroll.Size = New Size(75, 23)
        btnRefreshPayroll.TabIndex = 1
        btnRefreshPayroll.Text = "Refresh"
        btnRefreshPayroll.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(409, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' EmployeePayrollControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label1)
        Controls.Add(btnRefreshPayroll)
        Controls.Add(dgvMyPayroll)
        Name = "EmployeePayrollControl"
        Size = New Size(727, 387)
        CType(dgvMyPayroll, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvMyPayroll As DataGridView
    Friend WithEvents btnRefreshPayroll As Button
    Friend WithEvents Label1 As Label

End Class
