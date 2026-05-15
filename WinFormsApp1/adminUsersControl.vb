Public Class adminUsersControl

    Private Sub UsersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadUsers()
    End Sub

    Private Sub SetupListView()
        lvUsers.View = View.Details
        lvUsers.FullRowSelect = True
        lvUsers.GridLines = True
        lvUsers.MultiSelect = False

        lvUsers.Columns.Clear()
        lvUsers.Columns.Add("ID", 80)
        lvUsers.Columns.Add("Username", 160)
        lvUsers.Columns.Add("Role", 120)
        lvUsers.Columns.Add("Linked Employee", 220)
    End Sub

    Private Sub LoadUsers(Optional searchText As String = "")
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String = ""

        STRSQL = "SELECT U.UserID, U.UserName, U.Roles, "
        STRSQL &= "E.FirstName + ' ' + E.LastName AS EmployeeName "
        STRSQL &= "FROM Users U "
        STRSQL &= "LEFT JOIN Employees E ON U.EmployeeID = E.EmployeeID "

        If searchText.Trim() <> "" Then
            STRSQL &= "WHERE U.UserName LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR U.Roles LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR E.FirstName LIKE '%" & Replace(searchText, "'", "''") & "%' "
            STRSQL &= "OR E.LastName LIKE '%" & Replace(searchText, "'", "''") & "%' "
        End If

        STRSQL &= "ORDER BY U.UserID DESC"

        RST = CNN.Execute(STRSQL)

        lvUsers.Items.Clear()

        Do While Not RST.EOF
            Dim item As New ListViewItem(RST.Fields("UserID").Value.ToString())
            item.SubItems.Add(RST.Fields("UserName").Value.ToString())
            item.SubItems.Add(RST.Fields("Roles").Value.ToString())
            item.SubItems.Add(If(IsDBNull(RST.Fields("EmployeeName").Value), "No Linked Employee", RST.Fields("EmployeeName").Value.ToString()))

            lvUsers.Items.Add(item)
            RST.MoveNext()
        Loop
    End Sub

    Private Sub txtSearchUser_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUser.TextChanged
        LoadUsers(txtSearchUser.Text)
    End Sub

    Private Sub btnSearchUser_Click(sender As Object, e As EventArgs) Handles btnSearchUser.Click
        LoadUsers(txtSearchUser.Text)
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim frm As New UserDetailsForm(0)
        frm.ShowDialog()
        LoadUsers(txtSearchUser.Text)
    End Sub

    Private Sub lvUsers_DoubleClick(sender As Object, e As EventArgs) Handles lvUsers.DoubleClick
        If lvUsers.SelectedItems.Count = 0 Then Exit Sub

        Dim userID As Integer = CInt(lvUsers.SelectedItems(0).Text)

        Dim frm As New UserDetailsForm(userID)
        frm.ShowDialog()
        LoadUsers(txtSearchUser.Text)
    End Sub

End Class
