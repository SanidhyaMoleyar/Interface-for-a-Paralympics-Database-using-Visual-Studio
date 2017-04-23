Imports System.Data.SqlClient

Module Module1
    Public con As SqlConnection
    Public Function Connect()
        con = New SqlConnection("server=LENOVO;database=Paralympics;")
        Try
            con.Open()
            MsgBox("Connected To the Database.")


        Catch ex As Exception
            MsgBox(ex.Message)



        End Try
        Return Nothing
    End Function
End Module
