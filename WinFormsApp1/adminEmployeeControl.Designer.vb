<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminEmployeeControl
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
        Label1 = New Label()
        txtFirstName = New MaskedTextBox()
        dgvEmployees = New DataGridView()
        txtLastName = New MaskedTextBox()
        Label2 = New Label()
        txtPosition = New MaskedTextBox()
        Label3 = New Label()
        txtContactNo = New MaskedTextBox()
        Label4 = New Label()
        txtEmail = New MaskedTextBox()
        Label5 = New Label()
        txtSalaryRate = New MaskedTextBox()
        Label6 = New Label()
        cmbDepartment = New ComboBox()
        Label8 = New Label()
        btnAddEmployee = New Button()
        btnClearFields = New Button()
        btnUpdateEmployee = New Button()
        btnDeleteEmployee = New Button()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 0
        Label1.Text = "First Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(99, 19)
        txtFirstName.Margin = New Padding(3, 4, 3, 4)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(153, 27)
        txtFirstName.TabIndex = 1
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(0, 200)
        dgvEmployees.Margin = New Padding(3, 4, 3, 4)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.RowHeadersWidth = 51
        dgvEmployees.Size = New Size(887, 325)
        dgvEmployees.TabIndex = 2
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(99, 72)
        txtLastName.Margin = New Padding(3, 4, 3, 4)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(153, 27)
        txtLastName.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 3
        Label2.Text = "Last Name:"
        ' 
        ' txtPosition
        ' 
        txtPosition.Margin = New Padding(3, 4, 3, 4)
        txtPosition.Name = "txtPosition"
        txtPosition.Location = New Point(99, 132)
        txtPosition.Size = New Size(153, 27)
        txtPosition.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 5
        Label3.Text = "Position:"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(359, 19)
        txtContactNo.Margin = New Padding(3, 4, 3, 4)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(147, 27)
        txtContactNo.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(266, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 7
        Label4.Text = "Contact No:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(359, 76)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(147, 27)
        txtEmail.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(266, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 9
        Label5.Text = "Email:"
        ' 
        ' txtSalaryRate
        ' 
        txtSalaryRate.Location = New Point(359, 136)
        txtSalaryRate.Margin = New Padding(3, 4, 3, 4)
        txtSalaryRate.Name = "txtSalaryRate"
        txtSalaryRate.Size = New Size(147, 27)
        txtSalaryRate.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(266, 141)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 11
        Label6.Text = "Salary Rate:"
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(618, 19)
        cmbDepartment.Margin = New Padding(3, 4, 3, 4)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(114, 28)
        cmbDepartment.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(525, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(92, 20)
        Label8.TabIndex = 16
        Label8.Text = "Department:"
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.Location = New Point(748, 19)
        btnAddEmployee.Margin = New Padding(3, 4, 3, 4)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(116, 30)
        btnAddEmployee.TabIndex = 17
        btnAddEmployee.Text = "Add"
        btnAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnClearFields
        ' 
        btnClearFields.Location = New Point(748, 57)
        btnClearFields.Margin = New Padding(3, 4, 3, 4)
        btnClearFields.Name = "btnClearFields"
        btnClearFields.Size = New Size(116, 31)
        btnClearFields.TabIndex = 18
        btnClearFields.Text = "Clear"
        btnClearFields.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateEmployee
        ' 
        btnUpdateEmployee.Location = New Point(748, 96)
        btnUpdateEmployee.Margin = New Padding(3, 4, 3, 4)
        btnUpdateEmployee.Name = "btnUpdateEmployee"
        btnUpdateEmployee.Size = New Size(116, 31)
        btnUpdateEmployee.TabIndex = 19
        btnUpdateEmployee.Text = "Update"
        btnUpdateEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteEmployee
        ' 
        btnDeleteEmployee.Location = New Point(748, 136)
        btnDeleteEmployee.Margin = New Padding(3, 4, 3, 4)
        btnDeleteEmployee.Name = "btnDeleteEmployee"
        btnDeleteEmployee.Size = New Size(116, 31)
        btnDeleteEmployee.TabIndex = 20
        btnDeleteEmployee.Text = "Delete"
        btnDeleteEmployee.UseVisualStyleBackColor = True
        ' 
        ' adminEmployeeControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        Controls.Add(btnDeleteEmployee)
        Controls.Add(btnUpdateEmployee)
        Controls.Add(btnClearFields)
        Controls.Add(btnAddEmployee)
        Controls.Add(Label8)
        Controls.Add(cmbDepartment)
        Controls.Add(txtSalaryRate)
        Controls.Add(Label6)
        Controls.Add(txtEmail)
        Controls.Add(Label5)
        Controls.Add(txtContactNo)
        Controls.Add(Label4)
        Controls.Add(txtPosition)
        Controls.Add(Label3)
        Controls.Add(txtLastName)
        Controls.Add(Label2)
        Controls.Add(dgvEmployees)
        Controls.Add(txtFirstName)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "adminEmployeeControl"
        Size = New Size(887, 525)
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As MaskedTextBox
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents txtLastName As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPosition As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContactNo As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSalaryRate As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnClearFields As Button
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents btnDeleteEmployee As Button

End Class
