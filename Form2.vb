Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ParalympicsDataSet.FEvents' table. You can move, or remove it, as needed.
        Me.FEventsTableAdapter.Fill(Me.ParalympicsDataSet.FEvents)
        Call Connect()

    End Sub
End Class