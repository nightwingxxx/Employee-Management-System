<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminEmployeeControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminEmployeeControl))
        Label1 = New Label()
        dgvEmployees = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        cmbDepartment = New ComboBox()
        Label8 = New Label()
        btnAddEmployee = New Button()
        btnClearFields = New Button()
        btnUpdateEmployee = New Button()
        btnDeleteEmployee = New Button()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtPosition = New TextBox()
        txtContactNo = New TextBox()
        txtEmail = New TextBox()
        txtSalaryRate = New TextBox()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 10.2F)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(26, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 0
        Label1.Text = "First Name:"
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(13, 227)
        dgvEmployees.Margin = New Padding(3, 4, 3, 4)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.RowHeadersWidth = 51
        dgvEmployees.Size = New Size(923, 312)
        dgvEmployees.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 10.2F)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(26, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 3
        Label2.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Rounded MT Bold", 10.2F)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(26, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 5
        Label3.Text = "Position:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 10.2F)
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(303, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 20)
        Label4.TabIndex = 7
        Label4.Text = "Contact No:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Rounded MT Bold", 10.2F)
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(303, 92)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 20)
        Label5.TabIndex = 9
        Label5.Text = "Email:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial Rounded MT Bold", 10.2F)
        Label6.ForeColor = Color.WhiteSmoke
        Label6.Location = New Point(303, 154)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 20)
        Label6.TabIndex = 11
        Label6.Text = "Salary Rate:"
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.BackColor = Color.White
        cmbDepartment.ForeColor = Color.Black
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(694, 33)
        cmbDepartment.Margin = New Padding(3, 4, 3, 4)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(100, 23)
        cmbDepartment.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial Rounded MT Bold", 10.2F)
        Label8.ForeColor = Color.WhiteSmoke
        Label8.Location = New Point(576, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 20)
        Label8.TabIndex = 16
        Label8.Text = "Department:"
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.BackColor = Color.LightGreen
        btnAddEmployee.BackgroundImageLayout = ImageLayout.Stretch
        btnAddEmployee.FlatStyle = FlatStyle.Flat
        btnAddEmployee.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddEmployee.Location = New Point(814, 34)
        btnAddEmployee.Margin = New Padding(3, 4, 3, 4)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(75, 23)
        btnAddEmployee.TabIndex = 17
        btnAddEmployee.Text = "Add"
        btnAddEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnClearFields
        ' 
        btnClearFields.BackColor = SystemColors.ControlLight
        btnClearFields.FlatStyle = FlatStyle.Flat
        btnClearFields.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnClearFields.Location = New Point(814, 72)
        btnClearFields.Margin = New Padding(3, 4, 3, 4)
        btnClearFields.Name = "btnClearFields"
        btnClearFields.Size = New Size(75, 23)
        btnClearFields.TabIndex = 18
        btnClearFields.Text = "Clear"
        btnClearFields.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateEmployee
        ' 
        btnUpdateEmployee.BackColor = Color.Khaki
        btnUpdateEmployee.FlatStyle = FlatStyle.Flat
        btnUpdateEmployee.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnUpdateEmployee.Location = New Point(814, 111)
        btnUpdateEmployee.Margin = New Padding(3, 4, 3, 4)
        btnUpdateEmployee.Name = "btnUpdateEmployee"
        btnUpdateEmployee.Size = New Size(75, 23)
        btnUpdateEmployee.TabIndex = 19
        btnUpdateEmployee.Text = "Update"
        btnUpdateEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteEmployee
        ' 
        btnDeleteEmployee.BackColor = Color.Salmon
        btnDeleteEmployee.FlatStyle = FlatStyle.Flat
        btnDeleteEmployee.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnDeleteEmployee.Location = New Point(814, 151)
        btnDeleteEmployee.Margin = New Padding(3, 4, 3, 4)
        btnDeleteEmployee.Name = "btnDeleteEmployee"
        btnDeleteEmployee.Size = New Size(75, 23)
        btnDeleteEmployee.TabIndex = 20
        btnDeleteEmployee.Text = "Delete"
        btnDeleteEmployee.UseVisualStyleBackColor = False
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(135, 31)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(135, 27)
        txtFirstName.TabIndex = 21
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(135, 85)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(135, 27)
        txtLastName.TabIndex = 22
        ' 
        ' txtPosition
        ' 
        txtPosition.Location = New Point(135, 144)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(135, 27)
        txtPosition.TabIndex = 23
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(417, 31)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(135, 27)
        txtContactNo.TabIndex = 24
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(417, 85)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(135, 27)
        txtEmail.TabIndex = 25
        ' 
        ' txtSalaryRate
        ' 
        txtSalaryRate.Location = New Point(417, 144)
        txtSalaryRate.Name = "txtSalaryRate"
        txtSalaryRate.Size = New Size(135, 27)
        txtSalaryRate.TabIndex = 26
        ' 
        ' EmployeeControl
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(txtSalaryRate)
        Controls.Add(txtEmail)
        Controls.Add(txtContactNo)
        Controls.Add(txtPosition)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(btnDeleteEmployee)
        Controls.Add(btnUpdateEmployee)
        Controls.Add(btnClearFields)
        Controls.Add(btnAddEmployee)
        Controls.Add(Label8)
        Controls.Add(cmbDepartment)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dgvEmployees)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "adminEmployeeControl"
        Size = New Size(965, 525)
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnClearFields As Button
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSalaryRate As TextBox

End Class
