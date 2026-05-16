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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboard))
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
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' lblTotalEmployees
        ' 
        lblTotalEmployees.AutoSize = True
        lblTotalEmployees.BackColor = Color.Transparent
        lblTotalEmployees.Font = New Font("Segoe UI", 48F, FontStyle.Bold)
        lblTotalEmployees.ForeColor = Color.WhiteSmoke
        lblTotalEmployees.Location = New Point(80, 164)
        lblTotalEmployees.Name = "lblTotalEmployees"
        lblTotalEmployees.Size = New Size(291, 106)
        lblTotalEmployees.TabIndex = 0
        lblTotalEmployees.Text = "Label1"
        ' 
        ' lblActiveEmployees
        ' 
        lblActiveEmployees.AutoSize = True
        lblActiveEmployees.BackColor = Color.Transparent
        lblActiveEmployees.Font = New Font("Segoe UI", 48F, FontStyle.Bold)
        lblActiveEmployees.ForeColor = Color.WhiteSmoke
        lblActiveEmployees.Location = New Point(80, 382)
        lblActiveEmployees.Name = "lblActiveEmployees"
        lblActiveEmployees.Size = New Size(291, 106)
        lblActiveEmployees.TabIndex = 1
        lblActiveEmployees.Text = "Label2"
        ' 
        ' lblInactiveEmployees
        ' 
        lblInactiveEmployees.AutoSize = True
        lblInactiveEmployees.BackColor = Color.Transparent
        lblInactiveEmployees.Font = New Font("Segoe UI", 48F, FontStyle.Bold)
        lblInactiveEmployees.ForeColor = Color.WhiteSmoke
        lblInactiveEmployees.Location = New Point(377, 164)
        lblInactiveEmployees.Name = "lblInactiveEmployees"
        lblInactiveEmployees.Size = New Size(291, 106)
        lblInactiveEmployees.TabIndex = 2
        lblInactiveEmployees.Text = "Label3"
        ' 
        ' lblTotalDepartments
        ' 
        lblTotalDepartments.AutoSize = True
        lblTotalDepartments.BackColor = Color.Transparent
        lblTotalDepartments.Font = New Font("Segoe UI", 48F, FontStyle.Bold)
        lblTotalDepartments.ForeColor = Color.WhiteSmoke
        lblTotalDepartments.Location = New Point(377, 382)
        lblTotalDepartments.Name = "lblTotalDepartments"
        lblTotalDepartments.Size = New Size(291, 106)
        lblTotalDepartments.TabIndex = 3
        lblTotalDepartments.Text = "Label4"
        ' 
        ' lblTotalUsers
        ' 
        lblTotalUsers.AutoSize = True
        lblTotalUsers.BackColor = Color.Transparent
        lblTotalUsers.Font = New Font("Segoe UI", 48F, FontStyle.Bold)
        lblTotalUsers.ForeColor = Color.WhiteSmoke
        lblTotalUsers.Location = New Point(679, 164)
        lblTotalUsers.Name = "lblTotalUsers"
        lblTotalUsers.Size = New Size(291, 106)
        lblTotalUsers.TabIndex = 4
        lblTotalUsers.Text = "Label5"
        ' 
        ' lblActiveAppointments
        ' 
        lblActiveAppointments.AutoSize = True
        lblActiveAppointments.BackColor = Color.Transparent
        lblActiveAppointments.Font = New Font("Segoe UI", 48F, FontStyle.Bold)
        lblActiveAppointments.ForeColor = Color.WhiteSmoke
        lblActiveAppointments.Location = New Point(679, 382)
        lblActiveAppointments.Name = "lblActiveAppointments"
        lblActiveAppointments.Size = New Size(291, 106)
        lblActiveAppointments.TabIndex = 5
        lblActiveAppointments.Text = "Label6"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(94, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 37)
        Label1.TabIndex = 6
        Label1.Text = "Total Employees:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(94, 345)
        Label2.Name = "Label2"
        Label2.Size = New Size(230, 37)
        Label2.TabIndex = 7
        Label2.Text = "Active Employees:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(376, 345)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 37)
        Label3.TabIndex = 8
        Label3.Text = "Total Departments:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(376, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(249, 37)
        Label4.TabIndex = 9
        Label4.Text = "Inactive Employees:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(664, 345)
        Label5.Name = "Label5"
        Label5.Size = New Size(270, 37)
        Label5.TabIndex = 10
        Label5.Text = "Active Appointments:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.WhiteSmoke
        Label6.Location = New Point(679, 127)
        Label6.Name = "Label6"
        Label6.Size = New Size(151, 37)
        Label6.TabIndex = 11
        Label6.Text = "Total Users:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(130, 26)
        Label7.Name = "Label7"
        Label7.Size = New Size(298, 60)
        Label7.TabIndex = 12
        Label7.Text = "DASHBOARD"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.FlatStyle = FlatStyle.Flat
        Label8.ForeColor = Color.Silver
        Label8.Location = New Point(139, 81)
        Label8.Name = "Label8"
        Label8.Size = New Size(170, 20)
        Label8.TabIndex = 13
        Label8.Text = "Data summary for today"
        ' 
        ' adminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(Label8)
        Controls.Add(Label7)
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
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "adminDashboard"
        Size = New Size(1070, 648)
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
