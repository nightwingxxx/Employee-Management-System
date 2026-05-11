<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        splitEmployee = New SplitContainer()
        btnLogOut = New Button()
        btnMyPayroll = New Button()
        btnMyAttendance = New Button()
        CType(splitEmployee, ComponentModel.ISupportInitialize).BeginInit()
        splitEmployee.Panel1.SuspendLayout()
        splitEmployee.SuspendLayout()
        SuspendLayout()
        ' 
        ' splitEmployee
        ' 
        splitEmployee.Dock = DockStyle.Fill
        splitEmployee.Location = New Point(0, 0)
        splitEmployee.Name = "splitEmployee"
        ' 
        ' splitEmployee.Panel1
        ' 
        splitEmployee.Panel1.Controls.Add(btnLogOut)
        splitEmployee.Panel1.Controls.Add(btnMyPayroll)
        splitEmployee.Panel1.Controls.Add(btnMyAttendance)
        splitEmployee.Size = New Size(800, 450)
        splitEmployee.SplitterDistance = 165
        splitEmployee.TabIndex = 0
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(0, 232)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(162, 23)
        btnLogOut.TabIndex = 2
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnMyPayroll
        ' 
        btnMyPayroll.Location = New Point(0, 191)
        btnMyPayroll.Name = "btnMyPayroll"
        btnMyPayroll.Size = New Size(162, 23)
        btnMyPayroll.TabIndex = 1
        btnMyPayroll.Text = "My Payroll"
        btnMyPayroll.UseVisualStyleBackColor = True
        ' 
        ' btnMyAttendance
        ' 
        btnMyAttendance.Location = New Point(0, 152)
        btnMyAttendance.Name = "btnMyAttendance"
        btnMyAttendance.Size = New Size(162, 23)
        btnMyAttendance.TabIndex = 0
        btnMyAttendance.Text = "My Attendance"
        btnMyAttendance.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(splitEmployee)
        Name = "Form3"
        Text = "Form3"
        splitEmployee.Panel1.ResumeLayout(False)
        CType(splitEmployee, ComponentModel.ISupportInitialize).EndInit()
        splitEmployee.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents splitEmployee As SplitContainer
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnMyPayroll As Button
    Friend WithEvents btnMyAttendance As Button
End Class
