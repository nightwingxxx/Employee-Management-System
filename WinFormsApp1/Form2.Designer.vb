<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        splitAdmin = New SplitContainer()
        btnAppointmentsPanel = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnLogOut = New Button()
        btnDashboardPanel = New Button()
        btnUsersPanel = New Button()
        btnDepartmentsPanel = New Button()
        btnEmployeesPanel = New Button()
        CType(splitAdmin, ComponentModel.ISupportInitialize).BeginInit()
        splitAdmin.Panel1.SuspendLayout()
        splitAdmin.SuspendLayout()
        SuspendLayout()
        ' 
        ' splitAdmin
        ' 
        splitAdmin.Dock = DockStyle.Top
        splitAdmin.IsSplitterFixed = True
        splitAdmin.Location = New Point(0, 0)
        splitAdmin.Name = "splitAdmin"
        ' 
        ' splitAdmin.Panel1
        ' 
        splitAdmin.Panel1.BackColor = Color.AliceBlue
        splitAdmin.Panel1.BackgroundImage = My.Resources.Resources.Untitled__171_x_229_px___2_
        splitAdmin.Panel1.BackgroundImageLayout = ImageLayout.Stretch
        splitAdmin.Panel1.Controls.Add(btnAppointmentsPanel)
        splitAdmin.Panel1.Controls.Add(FlowLayoutPanel1)
        splitAdmin.Panel1.Controls.Add(btnLogOut)
        splitAdmin.Panel1.Controls.Add(btnDashboardPanel)
        splitAdmin.Panel1.Controls.Add(btnUsersPanel)
        splitAdmin.Panel1.Controls.Add(btnDepartmentsPanel)
        splitAdmin.Panel1.Controls.Add(btnEmployeesPanel)
        splitAdmin.Size = New Size(1120, 448)
        splitAdmin.SplitterDistance = 277
        splitAdmin.TabIndex = 1
        ' 
        ' btnAppointmentsPanel
        ' 
        btnAppointmentsPanel.BackColor = Color.Transparent
        btnAppointmentsPanel.FlatStyle = FlatStyle.Flat
        btnAppointmentsPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAppointmentsPanel.ForeColor = Color.White
        btnAppointmentsPanel.Location = New Point(40, 244)
        btnAppointmentsPanel.Name = "btnAppointmentsPanel"
        btnAppointmentsPanel.Size = New Size(197, 23)
        btnAppointmentsPanel.TabIndex = 8
        btnAppointmentsPanel.Text = "Appointment"
        btnAppointmentsPanel.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), Image)
        FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
        FlowLayoutPanel1.Location = New Point(67, 28)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(136, 96)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(39, 395)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(197, 23)
        btnLogOut.TabIndex = 6
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnDashboardPanel
        ' 
        btnDashboardPanel.BackColor = Color.Transparent
        btnDashboardPanel.FlatStyle = FlatStyle.Flat
        btnDashboardPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDashboardPanel.ForeColor = Color.White
        btnDashboardPanel.Location = New Point(40, 157)
        btnDashboardPanel.Name = "btnDashboardPanel"
        btnDashboardPanel.Size = New Size(197, 23)
        btnDashboardPanel.TabIndex = 5
        btnDashboardPanel.Text = "Dashboard"
        btnDashboardPanel.UseVisualStyleBackColor = False
        ' 
        ' btnUsersPanel
        ' 
        btnUsersPanel.BackColor = Color.Transparent
        btnUsersPanel.FlatStyle = FlatStyle.Flat
        btnUsersPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUsersPanel.ForeColor = Color.White
        btnUsersPanel.Location = New Point(40, 273)
        btnUsersPanel.Name = "btnUsersPanel"
        btnUsersPanel.Size = New Size(197, 23)
        btnUsersPanel.TabIndex = 4
        btnUsersPanel.Text = "Users"
        btnUsersPanel.UseVisualStyleBackColor = False
        ' 
        ' btnDepartmentsPanel
        ' 
        btnDepartmentsPanel.BackColor = Color.Transparent
        btnDepartmentsPanel.FlatStyle = FlatStyle.Flat
        btnDepartmentsPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDepartmentsPanel.ForeColor = Color.White
        btnDepartmentsPanel.Location = New Point(40, 214)
        btnDepartmentsPanel.Name = "btnDepartmentsPanel"
        btnDepartmentsPanel.Size = New Size(197, 23)
        btnDepartmentsPanel.TabIndex = 1
        btnDepartmentsPanel.Text = "Department"
        btnDepartmentsPanel.UseVisualStyleBackColor = False
        ' 
        ' btnEmployeesPanel
        ' 
        btnEmployeesPanel.BackColor = Color.Transparent
        btnEmployeesPanel.BackgroundImageLayout = ImageLayout.None
        btnEmployeesPanel.FlatStyle = FlatStyle.Flat
        btnEmployeesPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEmployeesPanel.ForeColor = Color.White
        btnEmployeesPanel.Location = New Point(40, 185)
        btnEmployeesPanel.Name = "btnEmployeesPanel"
        btnEmployeesPanel.Size = New Size(197, 23)
        btnEmployeesPanel.TabIndex = 0
        btnEmployeesPanel.Text = "Employees"
        btnEmployeesPanel.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1120, 450)
        Controls.Add(splitAdmin)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form2"
        Text = "Employee Management System"
        splitAdmin.Panel1.ResumeLayout(False)
        CType(splitAdmin, ComponentModel.ISupportInitialize).EndInit()
        splitAdmin.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents splitAdmin As SplitContainer
    Friend WithEvents btnUsersPanel As Button
    Friend WithEvents btnDepartmentsPanel As Button
    Friend WithEvents btnEmployeesPanel As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnDashboardPanel As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents pnlDept_Clear As Button
    Friend WithEvents btnAppointmentsPanel As Button
End Class
