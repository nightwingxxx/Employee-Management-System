Module Module1
    Public CNN As New ADODB.Connection
    Public Sub DBconnect()

        CNN.ConnectionString = "Provider=SQLOLEDB.1;Data Source=LAPTOP-5VNB83I5;Initial Catalog=GENETIA;Integrated Security=SSPI;"

        CNN.Open()

    End Sub
End Module
