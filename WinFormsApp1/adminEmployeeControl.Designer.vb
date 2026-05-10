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
        Label1.Location = New Point(19, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(87, 14)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(134, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(0, 150)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.Size = New Size(776, 244)
        dgvEmployees.TabIndex = 2
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(87, 54)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(134, 23)
        txtLastName.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 3
        Label2.Text = "Last Name:"
        ' 
        ' txtPosition
        ' 
        txtPosition.Location = New Point(87, 99)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(134, 23)
        txtPosition.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 5
        Label3.Text = "Position:"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(314, 14)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(129, 23)
        txtContactNo.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(246, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 7
        Label4.Text = "Contact No:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(314, 57)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(129, 23)
        txtEmail.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(246, 60)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 9
        Label5.Text = "Email:"
        ' 
        ' txtSalaryRate
        ' 
        txtSalaryRate.Location = New Point(314, 102)
        txtSalaryRate.Name = "txtSalaryRate"
        txtSalaryRate.Size = New Size(129, 23)
        txtSalaryRate.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(246, 105)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 11
        Label6.Text = "Salary Rate:"
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(541, 14)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(100, 23)
        cmbDepartment.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(459, 17)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 15)
        Label8.TabIndex = 16
        Label8.Text = "Department:"
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.Location = New Point(672, 14)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(75, 23)
        btnAddEmployee.TabIndex = 17
        btnAddEmployee.Text = "Add"
        btnAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnClearFields
        ' 
        btnClearFields.Location = New Point(672, 43)
        btnClearFields.Name = "btnClearFields"
        btnClearFields.Size = New Size(75, 23)
        btnClearFields.TabIndex = 18
        btnClearFields.Text = "Clear"
        btnClearFields.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateEmployee
        ' 
        btnUpdateEmployee.Location = New Point(672, 72)
        btnUpdateEmployee.Name = "btnUpdateEmployee"
        btnUpdateEmployee.Size = New Size(75, 23)
        btnUpdateEmployee.TabIndex = 19
        btnUpdateEmployee.Text = "Update"
        btnUpdateEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteEmployee
        ' 
        btnDeleteEmployee.Location = New Point(672, 102)
        btnDeleteEmployee.Name = "btnDeleteEmployee"
        btnDeleteEmployee.Size = New Size(75, 23)
        btnDeleteEmployee.TabIndex = 20
        btnDeleteEmployee.Text = "Delete"
        btnDeleteEmployee.UseVisualStyleBackColor = True
        ' 
        ' EmployeeControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
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
        Name = "EmployeeControl"
        Size = New Size(776, 394)
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
