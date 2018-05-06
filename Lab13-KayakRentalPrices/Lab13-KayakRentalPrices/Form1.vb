Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KayaksDataSet.RentalPrices' table. You can move, or remove it, as needed.
        Me.RentalPricesTableAdapter.Fill(Me.KayaksDataSet.RentalPrices)
        DataGridView1.Columns(1).DefaultCellStyle.Format = "n2"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "n2"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "n2"

    End Sub
End Class
