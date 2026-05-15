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
        lvEmployees.Location = New Point(0, 153)
        lvEmployees.Name = "lvEmployees"
        lvEmployees.Size = New Size(1126, 518)
        lvEmployees.TabIndex = 0
        lvEmployees.UseCompatibleStateImageBehavior = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(35, 18)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(287, 27)
        txtSearch.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(328, 18)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(62, 29)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.Location = New Point(396, 17)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(94, 29)
        btnAddEmployee.TabIndex = 3
        btnAddEmployee.Text = "Add"
        btnAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' adminEmployeeControl
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnDeleteEmployee)
        Controls.Add(btnUpdateEmployee)
        Controls.Add(btnClearFields)
        Controls.Add(btnAddEmployee)
        Controls.Add(Label8)
        Controls.Add(cmbDepartment)
        Controls.Add(txtSalaryRate)
        Controls.Add(Label6)
        Controls.Add(txtEmail)
        Controls.Add(Label5)
        Controls.Add(txtContactNo)
        Controls.Add(Label4)
        Controls.Add(txtPosition)
        Controls.Add(Label3)
        Controls.Add(txtLastName)
        Controls.Add(Label2)
        Controls.Add(dgvEmployees)
        Controls.Add(txtFirstName)
        Controls.Add(Label1)
        Name = "EmployeeControl"
        Size = New Size(776, 394)
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lvEmployees As ListView
        Controls.Add(btnDeleteEmployee)
        Controls.Add(btnUpdateEmployee)
        Controls.Add(btnClearFields)


