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
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
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
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' splitAdmin
        ' 
        splitAdmin.Dock = DockStyle.Top
        splitAdmin.IsSplitterFixed = True
        splitAdmin.Location = New Point(0, 0)
        splitAdmin.Margin = New Padding(3, 4, 3, 4)
        splitAdmin.Name = "splitAdmin"
        ' 
        ' splitAdmin.Panel1
        ' 
        splitAdmin.Panel1.BackColor = Color.AliceBlue
        splitAdmin.Panel1.BackgroundImage = My.Resources.Resources.Untitled__171_x_229_px___2_
        splitAdmin.Panel1.BackgroundImageLayout = ImageLayout.Stretch
        splitAdmin.Panel1.Controls.Add(PictureBox5)
        splitAdmin.Panel1.Controls.Add(PictureBox4)
        splitAdmin.Panel1.Controls.Add(PictureBox3)
        splitAdmin.Panel1.Controls.Add(PictureBox2)
        splitAdmin.Panel1.Controls.Add(PictureBox1)
        splitAdmin.Panel1.Controls.Add(btnAppointmentsPanel)
        splitAdmin.Panel1.Controls.Add(FlowLayoutPanel1)
        splitAdmin.Panel1.Controls.Add(btnLogOut)
        splitAdmin.Panel1.Controls.Add(btnDashboardPanel)
        splitAdmin.Panel1.Controls.Add(btnUsersPanel)
        splitAdmin.Panel1.Controls.Add(btnDepartmentsPanel)
        splitAdmin.Panel1.Controls.Add(btnEmployeesPanel)
        ' 
        ' splitAdmin.Panel2
        ' 
        splitAdmin.Panel2.BackColor = Color.Gainsboro
        splitAdmin.Size = New Size(1345, 597)
        splitAdmin.SplitterDistance = 329
        splitAdmin.SplitterWidth = 5
        splitAdmin.TabIndex = 1
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(69, 369)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(26, 24)
        PictureBox5.TabIndex = 13
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(69, 329)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(26, 24)
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(68, 288)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(26, 24)
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.employees
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(68, 248)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(26, 24)
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.dashboard
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(69, 211)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(26, 24)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' btnAppointmentsPanel
        ' 
        btnAppointmentsPanel.BackColor = Color.Transparent
        btnAppointmentsPanel.FlatStyle = FlatStyle.Flat
        btnAppointmentsPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAppointmentsPanel.ForeColor = Color.White
        btnAppointmentsPanel.Location = New Point(100, 326)
        btnAppointmentsPanel.Margin = New Padding(3, 4, 3, 4)
        btnAppointmentsPanel.Name = "btnAppointmentsPanel"
        btnAppointmentsPanel.Size = New Size(173, 31)
        btnAppointmentsPanel.TabIndex = 8
        btnAppointmentsPanel.Text = "Appointment"
        btnAppointmentsPanel.TextAlign = ContentAlignment.MiddleLeft
        btnAppointmentsPanel.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), Image)
        FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
        FlowLayoutPanel1.Location = New Point(88, 34)
        FlowLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(155, 128)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.Navy
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogOut.ForeColor = Color.White
        btnLogOut.Location = New Point(40, 524)
        btnLogOut.Margin = New Padding(3, 4, 3, 4)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(242, 43)
        btnLogOut.TabIndex = 6
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' btnDashboardPanel
        ' 
        btnDashboardPanel.BackColor = Color.Transparent
        btnDashboardPanel.FlatStyle = FlatStyle.Flat
        btnDashboardPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDashboardPanel.ForeColor = Color.White
        btnDashboardPanel.Location = New Point(100, 209)
        btnDashboardPanel.Margin = New Padding(3, 4, 3, 4)
        btnDashboardPanel.Name = "btnDashboardPanel"
        btnDashboardPanel.Size = New Size(173, 31)
        btnDashboardPanel.TabIndex = 5
        btnDashboardPanel.Text = "Dashboard"
        btnDashboardPanel.TextAlign = ContentAlignment.MiddleLeft
        btnDashboardPanel.UseVisualStyleBackColor = False
        ' 
        ' btnUsersPanel
        ' 
        btnUsersPanel.BackColor = Color.Transparent
        btnUsersPanel.FlatStyle = FlatStyle.Flat
        btnUsersPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUsersPanel.ForeColor = Color.White
        btnUsersPanel.Location = New Point(100, 365)
        btnUsersPanel.Margin = New Padding(3, 4, 3, 4)
        btnUsersPanel.Name = "btnUsersPanel"
        btnUsersPanel.Size = New Size(173, 31)
        btnUsersPanel.TabIndex = 4
        btnUsersPanel.Text = "Users"
        btnUsersPanel.TextAlign = ContentAlignment.MiddleLeft
        btnUsersPanel.UseVisualStyleBackColor = False
        ' 
        ' btnDepartmentsPanel
        ' 
        btnDepartmentsPanel.BackColor = Color.Transparent
        btnDepartmentsPanel.FlatStyle = FlatStyle.Flat
        btnDepartmentsPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDepartmentsPanel.ForeColor = Color.White
        btnDepartmentsPanel.Location = New Point(100, 286)
        btnDepartmentsPanel.Margin = New Padding(3, 4, 3, 4)
        btnDepartmentsPanel.Name = "btnDepartmentsPanel"
        btnDepartmentsPanel.Size = New Size(173, 31)
        btnDepartmentsPanel.TabIndex = 1
        btnDepartmentsPanel.Text = "Department"
        btnDepartmentsPanel.TextAlign = ContentAlignment.MiddleLeft
        btnDepartmentsPanel.UseVisualStyleBackColor = False
        ' 
        ' btnEmployeesPanel
        ' 
        btnEmployeesPanel.BackColor = Color.Transparent
        btnEmployeesPanel.BackgroundImageLayout = ImageLayout.None
        btnEmployeesPanel.FlatStyle = FlatStyle.Flat
        btnEmployeesPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEmployeesPanel.ForeColor = Color.White
        btnEmployeesPanel.Location = New Point(100, 248)
        btnEmployeesPanel.Margin = New Padding(3, 4, 3, 4)
        btnEmployeesPanel.Name = "btnEmployeesPanel"
        btnEmployeesPanel.Size = New Size(173, 31)
        btnEmployeesPanel.TabIndex = 0
        btnEmployeesPanel.Text = "Employees"
        btnEmployeesPanel.TextAlign = ContentAlignment.MiddleLeft
        btnEmployeesPanel.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1345, 600)
        Controls.Add(splitAdmin)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Employee Management System"
        splitAdmin.Panel1.ResumeLayout(False)
        CType(splitAdmin, ComponentModel.ISupportInitialize).EndInit()
        splitAdmin.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
End Class
