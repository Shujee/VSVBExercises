Public Class frmDigital
  Private Sub frmDigital_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    lblTime.Text = System.DateTime.Now
  End Sub

  Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

  End Sub

  Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
    lblTime.Text = System.DateTime.Now
  End Sub
End Class