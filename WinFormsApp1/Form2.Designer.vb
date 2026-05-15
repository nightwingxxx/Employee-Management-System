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
        Button1 = New Button()
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
        splitAdmin.Margin = New Padding(3, 4, 3, 4)
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
        splitAdmin.Panel1.Controls.Add(Button1)
        splitAdmin.Panel1.Controls.Add(btnUsersPanel)
        splitAdmin.Panel1.Controls.Add(btnDepartmentsPanel)
        splitAdmin.Panel1.Controls.Add(btnEmployeesPanel)
        splitAdmin.Size = New Size(1280, 597)
        splitAdmin.SplitterDistance = 317
        splitAdmin.SplitterWidth = 5
        splitAdmin.TabIndex = 1
        ' 
        ' btnAppointmentsPanel
        ' 
        btnAppointmentsPanel.BackColor = Color.Transparent
        btnAppointmentsPanel.FlatStyle = FlatStyle.Flat
        btnAppointmentsPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAppointmentsPanel.ForeColor = Color.White
        btnAppointmentsPanel.Location = New Point(46, 325)
        btnAppointmentsPanel.Margin = New Padding(3, 4, 3, 4)
        btnAppointmentsPanel.Name = "btnAppointmentsPanel"
        btnAppointmentsPanel.Size = New Size(225, 31)
        btnAppointmentsPanel.TabIndex = 8
        btnAppointmentsPanel.Text = "Appointment"
        btnAppointmentsPanel.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), Image)
        FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
        FlowLayoutPanel1.Location = New Point(77, 37)
        FlowLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(155, 128)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(45, 527)
        btnLogOut.Margin = New Padding(3, 4, 3, 4)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(225, 31)
        btnLogOut.TabIndex = 6
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(46, 209)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(225, 31)
        Button1.TabIndex = 5
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnUsersPanel
        ' 
        btnUsersPanel.BackColor = Color.Transparent
        btnUsersPanel.FlatStyle = FlatStyle.Flat
        btnUsersPanel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUsersPanel.ForeColor = Color.White
        btnUsersPanel.Location = New Point(46, 364)
        btnUsersPanel.Margin = New Padding(3, 4, 3, 4)
        btnUsersPanel.Name = "btnUsersPanel"
        btnUsersPanel.Size = New Size(225, 31)
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
        btnDepartmentsPanel.Location = New Point(46, 286)
        btnDepartmentsPanel.Margin = New Padding(3, 4, 3, 4)
        btnDepartmentsPanel.Name = "btnDepartmentsPanel"
        btnDepartmentsPanel.Size = New Size(225, 31)
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
        btnEmployeesPanel.Location = New Point(46, 247)
        btnEmployeesPanel.Margin = New Padding(3, 4, 3, 4)
        btnEmployeesPanel.Name = "btnEmployeesPanel"
        btnEmployeesPanel.Size = New Size(225, 31)
        btnEmployeesPanel.TabIndex = 0
        btnEmployeesPanel.Text = "Employees"
        btnEmployeesPanel.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 600)
        Controls.Add(splitAdmin)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents pnlDept_Clear As Button
    Friend WithEvents btnAppointmentsPanel As Button
End Class
