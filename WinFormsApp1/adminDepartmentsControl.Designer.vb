<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDepartmentsControl
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        txtSearchDept = New TextBox()
        btnAddDept = New Button()
        BindingSource1 = New BindingSource(components)
        lvDepartments = New ListView()
        btnSearchDept = New Button()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 20)
        Label1.TabIndex = 0
        Label1.Text = "Department Name:"
        ' 
        ' txtSearchDept
        ' 
        txtSearchDept.Location = New Point(234, 40)
        txtSearchDept.Margin = New Padding(3, 4, 3, 4)
        txtSearchDept.Name = "txtSearchDept"
        txtSearchDept.Size = New Size(204, 27)
        txtSearchDept.TabIndex = 1
        ' 
        ' btnAddDept
        ' 
        btnAddDept.Location = New Point(536, 40)
        btnAddDept.Margin = New Padding(3, 4, 3, 4)
        btnAddDept.Name = "btnAddDept"
        btnAddDept.Size = New Size(86, 31)
        btnAddDept.TabIndex = 6
        btnAddDept.Text = "Add"
        btnAddDept.UseVisualStyleBackColor = True
        ' 
        ' lvDepartments
        ' 
        lvDepartments.Location = New Point(0, 175)
        lvDepartments.Name = "lvDepartments"
        lvDepartments.Size = New Size(1014, 354)
        lvDepartments.TabIndex = 8
        lvDepartments.UseCompatibleStateImageBehavior = False
        ' 
        ' btnSearchDept
        ' 
        btnSearchDept.Location = New Point(444, 40)
        btnSearchDept.Margin = New Padding(3, 4, 3, 4)
        btnSearchDept.Name = "btnSearchDept"
        btnSearchDept.Size = New Size(86, 31)
        btnSearchDept.TabIndex = 7
        btnSearchDept.Text = "Search"
        btnSearchDept.UseVisualStyleBackColor = True
        ' 
        ' adminDepartmentsControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lvDepartments)
        Controls.Add(btnSearchDept)
        Controls.Add(btnAddDept)
        Controls.Add(txtSearchDept)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "adminDepartmentsControl"
        Size = New Size(1014, 529)
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchDept As TextBox
    Friend WithEvents btnAddDept As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents lvDepartments As ListView
    Friend WithEvents btnSearchDept As Button

End Class
