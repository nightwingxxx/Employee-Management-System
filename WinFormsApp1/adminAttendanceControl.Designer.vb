<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminAttendanceControl
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
        dgvAttendance = New DataGridView()
        cmbEmployeeFilter = New ComboBox()
        cmbDepartmentFilter = New ComboBox()
        dtpFrom = New DateTimePicker()
        dtpTo = New DateTimePicker()
        btnSearch = New Button()
        btnRefresh = New Button()
        btnClearFilter = New Button()
        totalTimedIn = New Label()
        totalTimedOut = New Label()
        totalNotTimedOut = New Label()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendance.Location = New Point(0, 285)
        dgvAttendance.Margin = New Padding(3, 4, 3, 4)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.RowHeadersWidth = 51
        dgvAttendance.Size = New Size(878, 300)
        dgvAttendance.TabIndex = 0
        ' 
        ' cmbEmployeeFilter
        ' 
        cmbEmployeeFilter.FormattingEnabled = True
        cmbEmployeeFilter.Location = New Point(109, 31)
        cmbEmployeeFilter.Margin = New Padding(3, 4, 3, 4)
        cmbEmployeeFilter.Name = "cmbEmployeeFilter"
        cmbEmployeeFilter.Size = New Size(138, 28)
        cmbEmployeeFilter.TabIndex = 1
        ' 
        ' cmbDepartmentFilter
        ' 
        cmbDepartmentFilter.FormattingEnabled = True
        cmbDepartmentFilter.Location = New Point(109, 83)
        cmbDepartmentFilter.Margin = New Padding(3, 4, 3, 4)
        cmbDepartmentFilter.Name = "cmbDepartmentFilter"
        cmbDepartmentFilter.Size = New Size(138, 28)
        cmbDepartmentFilter.TabIndex = 2
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Location = New Point(297, 31)
        dtpFrom.Margin = New Padding(3, 4, 3, 4)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(228, 27)
        dtpFrom.TabIndex = 3
        ' 
        ' dtpTo
        ' 
        dtpTo.Location = New Point(297, 83)
        dtpTo.Margin = New Padding(3, 4, 3, 4)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(228, 27)
        dtpTo.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(135, 181)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(86, 31)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(227, 181)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(86, 31)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.Location = New Point(320, 181)
        btnClearFilter.Margin = New Padding(3, 4, 3, 4)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(86, 31)
        btnClearFilter.TabIndex = 7
        btnClearFilter.Text = "Clear"
        btnClearFilter.UseVisualStyleBackColor = True
        ' 
        ' totalTimedIn
        ' 
        totalTimedIn.AutoSize = True
        totalTimedIn.Location = New Point(584, 39)
        totalTimedIn.Name = "totalTimedIn"
        totalTimedIn.Size = New Size(70, 20)
        totalTimedIn.TabIndex = 8
        totalTimedIn.Text = "Timed In:"
        ' 
        ' totalTimedOut
        ' 
        totalTimedOut.AutoSize = True
        totalTimedOut.Location = New Point(584, 93)
        totalTimedOut.Name = "totalTimedOut"
        totalTimedOut.Size = New Size(82, 20)
        totalTimedOut.TabIndex = 9
        totalTimedOut.Text = "Timed Out:"
        ' 
        ' totalNotTimedOut
        ' 
        totalNotTimedOut.AutoSize = True
        totalNotTimedOut.Location = New Point(584, 144)
        totalNotTimedOut.Name = "totalNotTimedOut"
        totalNotTimedOut.Size = New Size(111, 20)
        totalNotTimedOut.TabIndex = 10
        totalNotTimedOut.Text = "Not Timed Out:"
        ' 
        ' adminAttendanceControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(totalNotTimedOut)
        Controls.Add(totalTimedOut)
        Controls.Add(totalTimedIn)
        Controls.Add(btnClearFilter)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(dtpTo)
        Controls.Add(dtpFrom)
        Controls.Add(cmbDepartmentFilter)
        Controls.Add(cmbEmployeeFilter)
        Controls.Add(dgvAttendance)
        Margin = New Padding(3, 4, 3, 4)
        Name = "adminAttendanceControl"
        Size = New Size(878, 585)
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents cmbEmployeeFilter As ComboBox
    Friend WithEvents cmbDepartmentFilter As ComboBox
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents totalTimedIn As Label
    Friend WithEvents totalTimedOut As Label
    Friend WithEvents totalNotTimedOut As Label

End Class
