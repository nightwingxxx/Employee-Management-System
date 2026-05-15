<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminAppointment
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
        lvAppointments = New ListView()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnAddAppointment = New Button()
        SuspendLayout()
        ' 
        ' lvAppointments
        ' 
        lvAppointments.Location = New Point(0, 199)
        lvAppointments.Name = "lvAppointments"
        lvAppointments.Size = New Size(971, 364)
        lvAppointments.TabIndex = 0
        lvAppointments.UseCompatibleStateImageBehavior = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(62, 52)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(244, 27)
        txtSearch.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(352, 52)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnAddAppointment
        ' 
        btnAddAppointment.Location = New Point(352, 101)
        btnAddAppointment.Name = "btnAddAppointment"
        btnAddAppointment.Size = New Size(94, 29)
        btnAddAppointment.TabIndex = 3
        btnAddAppointment.Text = "Add"
        btnAddAppointment.UseVisualStyleBackColor = True
        ' 
        ' adminAppointment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnAddAppointment)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lvAppointments)
        Name = "adminAppointment"
        Size = New Size(971, 563)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lvAppointments As ListView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAddAppointment As Button

End Class
