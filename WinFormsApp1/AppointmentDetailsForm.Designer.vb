<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentDetailsForm
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
        cmbEmployee = New ComboBox()
        txtPosition = New TextBox()
        cmbDepartment = New ComboBox()
        dtpStartDate = New DateTimePicker()
        dtpEndDate = New DateTimePicker()
        chkNoEndDate = New CheckBox()
        btnSave = New Button()
        btnDelete = New Button()
        cmbStatus = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' cmbEmployee
        ' 
        cmbEmployee.FormattingEnabled = True
        cmbEmployee.Location = New Point(126, 39)
        cmbEmployee.Name = "cmbEmployee"
        cmbEmployee.Size = New Size(228, 28)
        cmbEmployee.TabIndex = 0
        ' 
        ' txtPosition
        ' 
        txtPosition.Location = New Point(126, 134)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(228, 27)
        txtPosition.TabIndex = 1
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(126, 87)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(228, 28)
        cmbDepartment.TabIndex = 2
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Location = New Point(126, 186)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(250, 27)
        dtpStartDate.TabIndex = 3
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Location = New Point(126, 222)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(250, 27)
        dtpEndDate.TabIndex = 4
        ' 
        ' chkNoEndDate
        ' 
        chkNoEndDate.AutoSize = True
        chkNoEndDate.Location = New Point(382, 226)
        chkNoEndDate.Name = "chkNoEndDate"
        chkNoEndDate.Size = New Size(103, 24)
        chkNoEndDate.TabIndex = 5
        chkNoEndDate.Text = "CheckBox1"
        chkNoEndDate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(570, 54)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 7
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(570, 98)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(126, 269)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(151, 28)
        cmbStatus.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 10
        Label1.Text = "Employe:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 11
        Label2.Text = "Department:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 12
        Label3.Text = "Position:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 13
        Label4.Text = "Start Date:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(28, 227)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 20)
        Label5.TabIndex = 14
        Label5.Text = "End Date:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(28, 269)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 20)
        Label7.TabIndex = 16
        Label7.Text = "Status:"
        ' 
        ' AppointmentDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(879, 492)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbStatus)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(chkNoEndDate)
        Controls.Add(dtpEndDate)
        Controls.Add(dtpStartDate)
        Controls.Add(cmbDepartment)
        Controls.Add(txtPosition)
        Controls.Add(cmbEmployee)
        Name = "AppointmentDetailsForm"
        Text = "AppointmentDetailsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents chkNoEndDate As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
