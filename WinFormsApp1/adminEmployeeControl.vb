Imports System.Drawing.Drawing2D

Public Class adminEmployeeControl

    Private Sub MakeTextBoxRounded(txt As TextBox, radius As Integer, borderColor As Color)
        txt.BorderStyle = BorderStyle.None

        Dim fillColor As Color = Color.FromArgb(245, 245, 245)
        Dim oldParent As Control = txt.Parent

        Dim panel As New Panel()
        panel.Size = New Size(txt.Width + 16, txt.Height + 12)
        panel.Location = txt.Location
        panel.BackColor = fillColor
        panel.Padding = New Padding(8, 6, 8, 6)

        Using regionPath As GraphicsPath = GetRoundedPath(panel.ClientRectangle, radius)
            panel.Region = New Region(regionPath)
        End Using

        AddHandler panel.Paint,
        Sub(sender As Object, e As PaintEventArgs)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

            Using path As GraphicsPath = GetRoundedPath(panel.ClientRectangle, radius)
                Using brush As New SolidBrush(fillColor)
                    e.Graphics.FillPath(brush, path)
                End Using

                Using pen As New Pen(borderColor, 2)
                    e.Graphics.DrawPath(pen, path)
                End Using
            End Using
        End Sub

        txt.BackColor = fillColor

        oldParent.Controls.Add(panel)
        panel.BringToFront()

        txt.Parent = panel
        txt.Location = New Point(8, 6)
        txt.Width = panel.Width - 16
        txt.BringToFront()
    End Sub
    Private Sub MakeButtonRounded(btn As Button, radius As Integer)
        Using path As GraphicsPath = GetRoundedPath(btn.ClientRectangle, radius)
            btn.Region = New Region(path)
        End Using

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.UseVisualStyleBackColor = False
    End Sub

    Private Function GetRoundedPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim diameter As Integer = radius * 2

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter - 1, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter - 1, rect.Bottom - diameter - 1, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter - 1, diameter, diameter, 90, 90)
        path.CloseFigure()

        Return path
    End Function

    Private Sub EmployeeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView()
        LoadEmployees()

        MakeTextBoxRounded(txtSearch, 8, Color.WhiteSmoke)

        PictureBox1.BringToFront()

        MakeButtonRounded(btnSearch, 8)
        MakeButtonRounded(btnAddEmployee, 12)
    End Sub

    Private Sub ListView()
        lvEmployees.View = View.Details
        lvEmployees.FullRowSelect = True
        lvEmployees.GridLines = True
        lvEmployees.MultiSelect = False

        lvEmployees.Columns.Clear()
        lvEmployees.Columns.Add("ID", 80)
        lvEmployees.Columns.Add("Full Name", 200)
        lvEmployees.Columns.Add("Contact No", 140)
        lvEmployees.Columns.Add("Email", 200)
        lvEmployees.Columns.Add("Salary Rate", 120)
        lvEmployees.Columns.Add("Latest Position", 160)
        lvEmployees.Columns.Add("Latest Department", 160)
        lvEmployees.Columns.Add("Status", 100)


    End Sub

    Private Sub LoadEmployees(Optional searchText As String = "")
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT E.EmployeeID, E.FirstName, E.LastName, "
        STRSQL &= "E.ContactNo, E.Email, E.SalaryRate, "
        STRSQL &= "E.Position, D.DepartmentName, "
        STRSQL &= "CASE WHEN EXISTS ("
        STRSQL &= "SELECT 1 FROM EmployeeAppointments A "
        STRSQL &= "WHERE A.EmployeeID = E.EmployeeID "
        STRSQL &= "AND A.EndDate IS NULL "
        STRSQL &= "AND A.Status IN ('Active', 'Renewed')"
        STRSQL &= ") THEN 'Active' ELSE 'Inactive' END AS EmployeeStatus "
        STRSQL &= "FROM Employees E "
        STRSQL &= "LEFT JOIN Department D ON E.DepartmentID = D.DepartmentID "



        If searchText.Trim() <> "" Then
            STRSQL &= "WHERE E.FirstName LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR E.LastName LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR E.ContactNo LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR E.Email LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR E.Position LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR D.DepartmentName LIKE '%" & Replace(searchText, "'", "''") & "%' "
        End If




        STRSQL &= "ORDER BY E.EmployeeID DESC"

        RST = CNN.Execute(STRSQL)

        lvEmployees.Items.Clear()

        Do While Not RST.EOF
            Dim firstName As String = RST.Fields("FirstName").Value.ToString()
            Dim lastName As String = RST.Fields("LastName").Value.ToString()
            Dim fullName As String = firstName & " " & lastName

            Dim item As New ListViewItem(RST.Fields("EmployeeID").Value.ToString())
            item.SubItems.Add(fullName)
            item.SubItems.Add(RST.Fields("ContactNo").Value.ToString())
            item.SubItems.Add(RST.Fields("Email").Value.ToString())
            item.SubItems.Add(RST.Fields("SalaryRate").Value.ToString())
            item.SubItems.Add(RST.Fields("Position").Value.ToString())
            item.SubItems.Add(RST.Fields("DepartmentName").Value.ToString())
            item.SubItems.Add(RST.Fields("EmployeeStatus").Value.ToString())

            lvEmployees.Items.Add(item)

            RST.MoveNext()
        Loop
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadEmployees(txtSearch.Text)
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadEmployees(txtSearch.Text)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadEmployees(txtSearch.Text)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim frm As New EmployeeDetailsForm(0)
        frm.ShowDialog()

        LoadEmployees(txtSearch.Text)
    End Sub

    Private Sub lvEmployees_DoubleClick(sender As Object, e As EventArgs) Handles lvEmployees.DoubleClick
        If lvEmployees.SelectedItems.Count = 0 Then Exit Sub

        Dim employeeID As Integer = CInt(lvEmployees.SelectedItems(0).Text)

        Dim frm As New EmployeeDetailsForm(employeeID)
        frm.ShowDialog()

        LoadEmployees(txtSearch.Text)
    End Sub

    Private Sub lvEmployees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvEmployees.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class