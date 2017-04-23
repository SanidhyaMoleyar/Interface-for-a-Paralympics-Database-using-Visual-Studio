Imports System.Data.SqlClient

Public Class InsertFE

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = " " Or ComboBox2.Text = " " Or TextBox1.Text = " " Then
            MsgBox("Please Fill all Fields!")
        End If
        Dim Name As String = TextBox1.Text
        Dim Category As String = ComboBox1.ValueMember
        Dim Criteria As String = ComboBox2.ValueMember
        Dim Datee As Date = Format(DateTimePicker1.Value)
        Dim Query As String
        Query = "insert into FEvents values('" & Category & "','" & Criteria & "','" & Name & "','" & Datee & "')"

        Dim sqlcmd = New SqlCommand(Query, con)
        Try
            sqlcmd.ExecuteNonQuery()
            MsgBox("Employee Added")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub InsertFE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub
   End Class