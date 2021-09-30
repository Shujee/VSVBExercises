Public Class frmMain
  Private Sub btnSimple_Click(sender As Object, e As EventArgs) Handles btnSimple.Click
    Dim frm As New Form1
    frm.Show()
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Dim frm As New Form2
    frm.Show()
  End Sub

  Private Sub btnAsync_Click(sender As Object, e As EventArgs) Handles btnAsync.Click
    Dim frm As New Form3
    frm.Show()
  End Sub
End Class