<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminPayrollControl
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
        dgvPayroll = New DataGridView()
        cmbEmployee = New ComboBox()
        dtpPayPeriodStart = New DateTimePicker()
        dtpPayPeriodEnd = New DateTimePicker()
        txtGrossPay = New MaskedTextBox()
        txtNetPay = New MaskedTextBox()
        txtDeductions = New MaskedTextBox()
        btnComputePayroll = New Button()
        btnSavePayroll = New Button()
        btnRefreshPayroll = New Button()
        btnClearPayroll = New Button()
        btnDeletePayroll = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(dgvPayroll, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvPayroll
        ' 
        dgvPayroll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPayroll.Location = New Point(0, 191)
        dgvPayroll.Name = "dgvPayroll"
        dgvPayroll.Size = New Size(793, 229)
        dgvPayroll.TabIndex = 0
        ' 
        ' cmbEmployee
        ' 
        cmbEmployee.FormattingEnabled = True
        cmbEmployee.Location = New Point(62, 27)
        cmbEmployee.Name = "cmbEmployee"
        cmbEmployee.Size = New Size(121, 23)
        cmbEmployee.TabIndex = 1
        ' 
        ' dtpPayPeriodStart
        ' 
        dtpPayPeriodStart.Location = New Point(23, 72)
        dtpPayPeriodStart.Name = "dtpPayPeriodStart"
        dtpPayPeriodStart.Size = New Size(200, 23)
        dtpPayPeriodStart.TabIndex = 2
        ' 
        ' dtpPayPeriodEnd
        ' 
        dtpPayPeriodEnd.Location = New Point(23, 130)
        dtpPayPeriodEnd.Name = "dtpPayPeriodEnd"
        dtpPayPeriodEnd.Size = New Size(200, 23)
        dtpPayPeriodEnd.TabIndex = 3
        ' 
        ' txtGrossPay
        ' 
        txtGrossPay.Location = New Point(370, 27)
        txtGrossPay.Name = "txtGrossPay"
        txtGrossPay.Size = New Size(100, 23)
        txtGrossPay.TabIndex = 4
        ' 
        ' txtNetPay
        ' 
        txtNetPay.Location = New Point(370, 130)
        txtNetPay.Name = "txtNetPay"
        txtNetPay.Size = New Size(100, 23)
        txtNetPay.TabIndex = 5
        ' 
        ' txtDeductions
        ' 
        txtDeductions.Location = New Point(370, 84)
        txtDeductions.Name = "txtDeductions"
        txtDeductions.Size = New Size(100, 23)
        txtDeductions.TabIndex = 6
        ' 
        ' btnComputePayroll
        ' 
        btnComputePayroll.Location = New Point(588, 15)
        btnComputePayroll.Name = "btnComputePayroll"
        btnComputePayroll.Size = New Size(75, 23)
        btnComputePayroll.TabIndex = 7
        btnComputePayroll.Text = "Compute"
        btnComputePayroll.UseVisualStyleBackColor = True
        ' 
        ' btnSavePayroll
        ' 
        btnSavePayroll.Location = New Point(588, 43)
        btnSavePayroll.Name = "btnSavePayroll"
        btnSavePayroll.Size = New Size(75, 23)
        btnSavePayroll.TabIndex = 8
        btnSavePayroll.Text = "Save"
        btnSavePayroll.UseVisualStyleBackColor = True
        ' 
        ' btnRefreshPayroll
        ' 
        btnRefreshPayroll.Location = New Point(588, 72)
        btnRefreshPayroll.Name = "btnRefreshPayroll"
        btnRefreshPayroll.Size = New Size(75, 23)
        btnRefreshPayroll.TabIndex = 9
        btnRefreshPayroll.Text = "Refresh"
        btnRefreshPayroll.UseVisualStyleBackColor = True
        ' 
        ' btnClearPayroll
        ' 
        btnClearPayroll.Location = New Point(588, 101)
        btnClearPayroll.Name = "btnClearPayroll"
        btnClearPayroll.Size = New Size(75, 23)
        btnClearPayroll.TabIndex = 10
        btnClearPayroll.Text = "Clear"
        btnClearPayroll.UseVisualStyleBackColor = True
        ' 
        ' btnDeletePayroll
        ' 
        btnDeletePayroll.Location = New Point(588, 130)
        btnDeletePayroll.Name = "btnDeletePayroll"
        btnDeletePayroll.Size = New Size(75, 23)
        btnDeletePayroll.TabIndex = 11
        btnDeletePayroll.Text = "Delete"
        btnDeletePayroll.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(290, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 12
        Label1.Text = "Gross Pay:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(290, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 13
        Label2.Text = "Deductions:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(290, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 14
        Label3.Text = "Net Pay:"
        ' 
        ' adminPayrollControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnDeletePayroll)
        Controls.Add(btnClearPayroll)
        Controls.Add(btnRefreshPayroll)
        Controls.Add(btnSavePayroll)
        Controls.Add(btnComputePayroll)
        Controls.Add(txtDeductions)
        Controls.Add(txtNetPay)
        Controls.Add(txtGrossPay)
        Controls.Add(dtpPayPeriodEnd)
        Controls.Add(dtpPayPeriodStart)
        Controls.Add(cmbEmployee)
        Controls.Add(dgvPayroll)
        Name = "adminPayrollControl"
        Size = New Size(793, 420)
        CType(dgvPayroll, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvPayroll As DataGridView
    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents dtpPayPeriodStart As DateTimePicker
    Friend WithEvents dtpPayPeriodEnd As DateTimePicker
    Friend WithEvents txtGrossPay As MaskedTextBox
    Friend WithEvents txtNetPay As MaskedTextBox
    Friend WithEvents txtDeductions As MaskedTextBox
    Friend WithEvents btnComputePayroll As Button
    Friend WithEvents btnSavePayroll As Button
    Friend WithEvents btnRefreshPayroll As Button
    Friend WithEvents btnClearPayroll As Button
    Friend WithEvents btnDeletePayroll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
