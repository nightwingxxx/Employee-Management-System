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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnLogOut = New Button()
        Button1 = New Button()
        btnUsersPanel = New Button()
        btnPayrollPanel = New Button()
        btnAttendancePanel = New Button()
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
        splitAdmin.Panel1.BackColor = Color.Blue
        splitAdmin.Panel1.Controls.Add(FlowLayoutPanel1)
        splitAdmin.Panel1.Controls.Add(btnLogOut)
        splitAdmin.Panel1.Controls.Add(Button1)
        splitAdmin.Panel1.Controls.Add(btnUsersPanel)
        splitAdmin.Panel1.Controls.Add(btnPayrollPanel)
        splitAdmin.Panel1.Controls.Add(btnAttendancePanel)
        splitAdmin.Panel1.Controls.Add(btnDepartmentsPanel)
        splitAdmin.Panel1.Controls.Add(btnEmployeesPanel)
        ' 
        ' splitAdmin.Panel2
        ' 
        splitAdmin.Size = New Size(1047, 448)
        splitAdmin.SplitterDistance = 261
        splitAdmin.TabIndex = 1
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), Image)
        FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(200, 128)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(3, 308)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(197, 23)
        btnLogOut.TabIndex = 6
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Location = New Point(3, 134)
        Button1.Name = "Button1"
        Button1.Size = New Size(197, 23)
        Button1.TabIndex = 5
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnUsersPanel
        ' 
        btnUsersPanel.Location = New Point(2, 279)
        btnUsersPanel.Name = "btnUsersPanel"
        btnUsersPanel.Size = New Size(197, 23)
        btnUsersPanel.TabIndex = 4
        btnUsersPanel.Text = "Users"
        btnUsersPanel.UseVisualStyleBackColor = True
        ' 
        ' btnPayrollPanel
        ' 
        btnPayrollPanel.Location = New Point(3, 250)
        btnPayrollPanel.Name = "btnPayrollPanel"
        btnPayrollPanel.Size = New Size(197, 23)
        btnPayrollPanel.TabIndex = 3
        btnPayrollPanel.Text = "Payroll"
        btnPayrollPanel.UseVisualStyleBackColor = True
        ' 
        ' btnAttendancePanel
        ' 
        btnAttendancePanel.Location = New Point(3, 221)
        btnAttendancePanel.Name = "btnAttendancePanel"
        btnAttendancePanel.Size = New Size(197, 23)
        btnAttendancePanel.TabIndex = 2
        btnAttendancePanel.Text = "Attendance"
        btnAttendancePanel.UseVisualStyleBackColor = True
        ' 
        ' btnDepartmentsPanel
        ' 
        btnDepartmentsPanel.Location = New Point(3, 192)
        btnDepartmentsPanel.Name = "btnDepartmentsPanel"
        btnDepartmentsPanel.Size = New Size(197, 23)
        btnDepartmentsPanel.TabIndex = 1
        btnDepartmentsPanel.Text = "Department"
        btnDepartmentsPanel.UseVisualStyleBackColor = True
        ' 
        ' btnEmployeesPanel
        ' 
        btnEmployeesPanel.BackColor = Color.Transparent
        btnEmployeesPanel.BackgroundImageLayout = ImageLayout.None
        btnEmployeesPanel.Location = New Point(3, 163)
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
        ClientSize = New Size(1047, 450)
        Controls.Add(splitAdmin)
        Name = "Form2"
        Text = "Form2"
        splitAdmin.Panel1.ResumeLayout(False)
        CType(splitAdmin, ComponentModel.ISupportInitialize).EndInit()
        splitAdmin.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents splitAdmin As SplitContainer
    Friend WithEvents btnUsersPanel As Button
    Friend WithEvents btnPayrollPanel As Button
    Friend WithEvents btnAttendancePanel As Button
    Friend WithEvents btnDepartmentsPanel As Button
    Friend WithEvents btnEmployeesPanel As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents pnlDept_Clear As Button
End Class
