Public Class frmMain
  Private Sub btnDigital_Click(sender As Object, e As EventArgs) Handles btnDigital.Click
    Dim f As New frmDigital
    f.Show()
  End Sub

  Private Sub btnAnalog_Click(sender As Object, e As EventArgs) Handles btnAnalog.Click
    Dim f As New frmAnalog
    f.Show()
  End Sub
End Class
