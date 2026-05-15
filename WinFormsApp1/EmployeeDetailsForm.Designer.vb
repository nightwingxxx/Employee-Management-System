<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetailsForm
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
        txtFirstName = New TextBox()
        cmbDepartment = New ComboBox()
        btnSave = New Button()
        btnDelete = New Button()
        txtContactNo = New TextBox()
        txtSalaryRate = New TextBox()
        txtEmail = New TextBox()
        txtPosition = New TextBox()
        txtLastName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(213, 35)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(202, 27)
        txtFirstName.TabIndex = 0
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(213, 394)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(202, 28)
        cmbDepartment.TabIndex = 6
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(642, 35)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 7
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(642, 90)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(213, 213)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(202, 27)
        txtContactNo.TabIndex = 9
        ' 
        ' txtSalaryRate
        ' 
        txtSalaryRate.Location = New Point(213, 333)
        txtSalaryRate.Name = "txtSalaryRate"
        txtSalaryRate.Size = New Size(202, 27)
        txtSalaryRate.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(213, 274)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(202, 27)
        txtEmail.TabIndex = 11
        ' 
        ' txtPosition
        ' 
        txtPosition.Location = New Point(213, 152)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(202, 27)
        txtPosition.TabIndex = 12
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(213, 92)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(202, 27)
        txtLastName.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 14
        Label1.Text = "First Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 15
        Label2.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 16
        Label3.Text = "Position:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(62, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 20)
        Label4.TabIndex = 17
        Label4.Text = "Contact No.:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(62, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 18
        Label5.Text = "Email:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(62, 336)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 19
        Label6.Text = "Salary Rate:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(62, 402)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 20)
        Label7.TabIndex = 20
        Label7.Text = "Department:"
        ' 
        ' EmployeeDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtLastName)
        Controls.Add(txtPosition)
        Controls.Add(txtEmail)
        Controls.Add(txtSalaryRate)
        Controls.Add(txtContactNo)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(cmbDepartment)
        Controls.Add(txtFirstName)
        Name = "EmployeeDetailsForm"
        Text = "EmployeeDetailsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtSalaryRate As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
