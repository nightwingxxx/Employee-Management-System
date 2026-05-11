<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeAttendanceControl
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
        btnTimeIn = New Button()
        btnRefreshAttendance = New Button()
        btnTimeOut = New Button()
        todayStatus = New Label()
        dgvMyAttendance = New DataGridView()
        CType(dgvMyAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTimeIn
        ' 
        btnTimeIn.Location = New Point(88, 48)
        btnTimeIn.Name = "btnTimeIn"
        btnTimeIn.Size = New Size(75, 23)
        btnTimeIn.TabIndex = 0
        btnTimeIn.Text = "Time In"
        btnTimeIn.UseVisualStyleBackColor = True
        ' 
        ' btnRefreshAttendance
        ' 
        btnRefreshAttendance.Location = New Point(88, 156)
        btnRefreshAttendance.Name = "btnRefreshAttendance"
        btnRefreshAttendance.Size = New Size(75, 23)
        btnRefreshAttendance.TabIndex = 1
        btnRefreshAttendance.Text = "Rrefresh"
        btnRefreshAttendance.UseVisualStyleBackColor = True
        ' 
        ' btnTimeOut
        ' 
        btnTimeOut.Location = New Point(88, 102)
        btnTimeOut.Name = "btnTimeOut"
        btnTimeOut.Size = New Size(75, 23)
        btnTimeOut.TabIndex = 2
        btnTimeOut.Text = "Time Out"
        btnTimeOut.UseVisualStyleBackColor = True
        ' 
        ' todayStatus
        ' 
        todayStatus.AutoSize = True
        todayStatus.Location = New Point(319, 56)
        todayStatus.Name = "todayStatus"
        todayStatus.Size = New Size(41, 15)
        todayStatus.TabIndex = 3
        todayStatus.Text = "Label1"
        ' 
        ' dgvMyAttendance
        ' 
        dgvMyAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMyAttendance.Location = New Point(0, 198)
        dgvMyAttendance.Name = "dgvMyAttendance"
        dgvMyAttendance.Size = New Size(712, 193)
        dgvMyAttendance.TabIndex = 4
        ' 
        ' EmployeeAttendanceControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(dgvMyAttendance)
        Controls.Add(todayStatus)
        Controls.Add(btnTimeOut)
        Controls.Add(btnRefreshAttendance)
        Controls.Add(btnTimeIn)
        Name = "EmployeeAttendanceControl"
        Size = New Size(712, 391)
        CType(dgvMyAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTimeIn As Button
    Friend WithEvents btnRefreshAttendance As Button
    Friend WithEvents btnTimeOut As Button
    Friend WithEvents todayStatus As Label
    Friend WithEvents dgvMyAttendance As DataGridView

End Class
