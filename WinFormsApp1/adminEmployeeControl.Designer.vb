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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminEmployeeControl))
        lvEmployees = New ListView()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnAddEmployee = New Button()
        Label7 = New System.Windows.Forms.Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lvEmployees
        ' 
        lvEmployees.Location = New Point(3, 184)
        lvEmployees.Name = "lvEmployees"
        lvEmployees.Size = New Size(1267, 434)
        lvEmployees.TabIndex = 0
        lvEmployees.UseCompatibleStateImageBehavior = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.ControlLightLight
        txtSearch.Cursor = Cursors.IBeam
        txtSearch.ForeColor = Color.DimGray
        txtSearch.Location = New Point(407, 81)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(238, 27)
        txtSearch.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.DeepSkyBlue
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(672, 81)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(86, 33)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.BackColor = Color.ForestGreen
        btnAddEmployee.FlatStyle = FlatStyle.Flat
        btnAddEmployee.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddEmployee.ForeColor = Color.White
        btnAddEmployee.ImageAlign = ContentAlignment.TopCenter
        btnAddEmployee.Location = New Point(869, 38)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(113, 108)
        btnAddEmployee.TabIndex = 3
        btnAddEmployee.Text = "+"
        btnAddEmployee.TextAlign = ContentAlignment.TopCenter
        btnAddEmployee.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(112, 61)
        Label7.Name = "Label7"
        Label7.Size = New Size(269, 60)
        Label7.TabIndex = 13
        Label7.Text = "EMPLOYEES"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlLightLight
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(634, 87)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(21, 22)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' adminEmployeeControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImage = My.Resources.Resources.ADAMSON__12_
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(lvEmployees)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        Controls.Add(btnAddEmployee)
        DoubleBuffered = True
        Name = "adminEmployeeControl"
        Size = New Size(1064, 619)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lvEmployees As ListView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
End Class