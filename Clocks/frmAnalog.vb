Public Class frmAnalog
  Dim pHour As New Pen(Brushes.Black, 12)
  Dim pMinute As New Pen(Brushes.Black, 6)
  Dim pSecond As New Pen(Brushes.Red, 2)

  Private Sub frmAnalog_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    Dim t As DateTime = DateTime.Now

    'Dim hAngle = (t.Hour Mod 12) * 30
    Dim sAngle = t.Second * 6 - 90

    Dim hx = 300 + 300 * System.Math.Cos(sAngle * 3.1415 / 180)
    Dim hy = 300 + 300 * System.Math.Sin(sAngle * 3.1415 / 180)

    e.Graphics.DrawLine(pSecond, 300, 300, CInt(hx), CInt(hy))
    'e.Graphics.DrawLine(pMinute, 200, 200, 100, 50)
    'e.Graphics.DrawLine(pSecond, 400, 100, 300, 150)
  End Sub

  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    Me.Invalidate()
  End Sub
End Class