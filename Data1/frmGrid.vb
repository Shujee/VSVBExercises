Public Class frmGrid
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'MainDS.country' table. You can move, or remove it, as needed.
    Me.CountryTableAdapter.Fill(Me.MainDS.country)
  End Sub

  Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
    CountryTableAdapter.Update(MainDS.country)

    Dim x As Byte
  End Sub
End Class