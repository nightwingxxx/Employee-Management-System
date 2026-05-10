Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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

            STRSQL &= vbCrLf & " WHERE username ='" & Replace(username.Text, "'", "''") & "'"

            STRSQL &= vbCrLf & " AND passcode = '" & Replace(password.Text, "'", "''") & "'"

            RST = CNN.Execute(STRSQL)

            If RST.EOF Then

                MsgBox("Invalid Credentials")

            Else

                Form2.Show()
                Me.Hide()

            End If

        Else

            MsgBox(MSG)

        End If
    End Sub
End Class
