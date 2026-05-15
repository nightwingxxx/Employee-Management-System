<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDashboard
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
        lblTotalEmployees = New Label()
        lblActiveEmployees = New Label()
        lblInactiveEmployees = New Label()
        lblTotalDepartments = New Label()
        lblTotalUsers = New Label()
        lblActiveAppointments = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' lblTotalEmployees
        ' 
        lblTotalEmployees.AutoSize = True
        lblTotalEmployees.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalEmployees.Location = New Point(131, 113)
        lblTotalEmployees.Name = "lblTotalEmployees"
        lblTotalEmployees.Size = New Size(128, 47)
        lblTotalEmployees.TabIndex = 0
        lblTotalEmployees.Text = "Label1"
        ' 
        ' lblActiveEmployees
        ' 
        lblActiveEmployees.AutoSize = True
        lblActiveEmployees.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActiveEmployees.Location = New Point(131, 297)
        lblActiveEmployees.Name = "lblActiveEmployees"
        lblActiveEmployees.Size = New Size(128, 47)
        lblActiveEmployees.TabIndex = 1
        lblActiveEmployees.Text = "Label2"
        ' 
        ' lblInactiveEmployees
        ' 
        lblInactiveEmployees.AutoSize = True
        lblInactiveEmployees.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInactiveEmployees.Location = New Point(404, 113)
        lblInactiveEmployees.Name = "lblInactiveEmployees"
        lblInactiveEmployees.Size = New Size(128, 47)
        lblInactiveEmployees.TabIndex = 2
        lblInactiveEmployees.Text = "Label3"
        ' 
        ' lblTotalDepartments
        ' 
        lblTotalDepartments.AutoSize = True
        lblTotalDepartments.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalDepartments.Location = New Point(404, 297)
        lblTotalDepartments.Name = "lblTotalDepartments"
        lblTotalDepartments.Size = New Size(128, 47)
        lblTotalDepartments.TabIndex = 3
        lblTotalDepartments.Text = "Label4"
        ' 
        ' lblTotalUsers
        ' 
        lblTotalUsers.AutoSize = True
        lblTotalUsers.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalUsers.Location = New Point(645, 113)
        lblTotalUsers.Name = "lblTotalUsers"
        lblTotalUsers.Size = New Size(128, 47)
        lblTotalUsers.TabIndex = 4
        lblTotalUsers.Text = "Label5"
        ' 
        ' lblActiveAppointments
        ' 
        lblActiveAppointments.AutoSize = True
        lblActiveAppointments.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActiveAppointments.Location = New Point(645, 297)
        lblActiveAppointments.Name = "lblActiveAppointments"
        lblActiveAppointments.Size = New Size(128, 47)
        lblActiveAppointments.TabIndex = 5
        lblActiveAppointments.Text = "Label6"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(116, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 30)
        Label1.TabIndex = 6
        Label1.Text = "Total Employees:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(116, 267)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 30)
        Label2.TabIndex = 7
        Label2.Text = "Active Employees:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(375, 267)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 30)
        Label3.TabIndex = 8
        Label3.Text = "Total Departments:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(368, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(195, 30)
        Label4.TabIndex = 9
        Label4.Text = "Inactive Employees:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(602, 267)
        Label5.Name = "Label5"
        Label5.Size = New Size(212, 30)
        Label5.TabIndex = 10
        Label5.Text = "Active Appointments:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(645, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 30)
        Label6.TabIndex = 11
        Label6.Text = "Total Users:"
        ' 
        ' adminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblActiveAppointments)
        Controls.Add(lblTotalUsers)
        Controls.Add(lblTotalDepartments)
        Controls.Add(lblInactiveEmployees)
        Controls.Add(lblActiveEmployees)
        Controls.Add(lblTotalEmployees)
        Name = "adminDashboard"
        Size = New Size(936, 486)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTotalEmployees As Label
    Friend WithEvents lblActiveEmployees As Label
    Friend WithEvents lblInactiveEmployees As Label
    Friend WithEvents lblTotalDepartments As Label
    Friend WithEvents lblTotalUsers As Label
    Friend WithEvents lblActiveAppointments As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
