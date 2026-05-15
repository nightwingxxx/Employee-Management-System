Imports System.Reflection.Emit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminEmployeeControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lvEmployees = New ListView()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnAddEmployee = New Button()
        SuspendLayout()
        ' 
        ' lvEmployees
        ' 
        lvEmployees.Location = New Point(3, 74)
        lvEmployees.Margin = New Padding(3, 2, 3, 2)
        lvEmployees.Name = "lvEmployees"
        lvEmployees.Size = New Size(1111, 390)
        lvEmployees.TabIndex = 0
        lvEmployees.UseCompatibleStateImageBehavior = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(31, 14)
        txtSearch.Margin = New Padding(3, 2, 3, 2)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(252, 23)
        txtSearch.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(287, 14)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(54, 22)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.Location = New Point(346, 13)
        btnAddEmployee.Margin = New Padding(3, 2, 3, 2)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(82, 22)
        btnAddEmployee.TabIndex = 3
        btnAddEmployee.Text = "Add"
        btnAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' adminEmployeeControl
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lvEmployees)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        Controls.Add(btnAddEmployee)
        Margin = New Padding(3, 2, 3, 2)
        Name = "adminEmployeeControl"
        Size = New Size(1111, 464)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lvEmployees As ListView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAddEmployee As Button
End Class