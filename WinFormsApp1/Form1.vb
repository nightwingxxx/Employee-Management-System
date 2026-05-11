Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub ClearLoginFields()
        username.Clear()
        password.Clear()
        username.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DBconnect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim isALLOk As Boolean = True

        Dim MSG As String = ""

        Dim RST As New ADODB.Recordset

        Dim STRSQL As String = ""

        If Trim(username.Text) = "" Then

            isALLOk = False

            MSG = MSG & vbCrLf & "Enter Username"

        End If

        If Trim(password.Text) = "" Then

            isALLOk = False

            MSG = MSG & vbCrLf & "Enter Password"

        End If

        If isALLOk Then

            STRSQL = "Select * From Users"

            STRSQL &= vbCrLf & " WHERE UserName ='" & Replace(username.Text, "'", "''") & "'"

            STRSQL &= vbCrLf & " AND Passcode = '" & Replace(password.Text, "'", "''") & "'"

            RST = CNN.Execute(STRSQL)

            If RST.EOF Then

                MsgBox("Invalid Credentials")

            Else
                LoginSession.LoggedInUserID = CInt(RST.Fields("UserID").Value)
                LoginSession.LoggedInUserName = RST.Fields("UserName").Value.ToString()
                LoginSession.LoggedInRole = RST.Fields("Roles").Value.ToString()

                If IsDBNull(RST.Fields("EmployeeID").Value) Then
                    LoginSession.LoggedInEmployeeID = 0
                Else
                    LoginSession.LoggedInEmployeeID = CInt(RST.Fields("EmployeeID").Value)
                End If

                If LoginSession.LoggedInRole = "Admin" Then
                    Form2.Show()
                    Me.Hide()

                ElseIf LoginSession.LoggedInRole = "Employee" Then
                    Form3.Show()
                    Me.Hide()

                Else
                    MsgBox("Unknown user role.")
                End If

            End If

        Else

            MsgBox(MSG)

        End If

    End Sub

End Class
