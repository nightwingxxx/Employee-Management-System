Module Module1
    Public CNN As New ADODB.Connection



    Public Sub DBconnect()

        CNN.ConnectionString = "Provider=SQLOLEDB.1;Data Source=LAPTOP-9VG92SDQ;Initial Catalog=EmployeeManagement;Integrated Security=SSPI;"

        CNN.Open()

    End Sub
End Module
