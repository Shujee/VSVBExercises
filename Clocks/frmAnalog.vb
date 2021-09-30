Public Class frmAnalog
  Dim pHour As New Pen(Brushes.Black, 12)
  Dim pMinute As New Pen(Brushes.Black, 6)
  Dim pSecond As New Pen(Brushes.Red, 2)

  Private Sub frmAnalog_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    Dim t As DateTime = DateTime.Now




    e.Graphics.FillEllipse(Brushes.Black, 300 - 10, 300 - 10, 20, 20)


    Dim hAngle = ((t.Hour Mod 12) + t.Minute / 60) * 30 - 90
    Dim mAngle = (t.Minute + t.Second / 60) * 6 - 90
    Dim sAngle = (t.Second + t.Millisecond / 1000) * 6 - 90

    Dim hx = 300 + 200 * System.Math.Cos(hAngle * 3.1415 / 180)
    Dim hy = 300 + 200 * System.Math.Sin(hAngle * 3.1415 / 180)
    e.Graphics.DrawLine(pHour, 300, 300, CInt(hx), CInt(hy))

    Dim mx = 300 + 300 * System.Math.Cos(mAngle * 3.1415 / 180)
    Dim my = 300 + 300 * System.Math.Sin(mAngle * 3.1415 / 180)
    e.Graphics.DrawLine(pMinute, 300, 300, CInt(mx), CInt(my))

    Dim sx = 300 + 225 * System.Math.Cos(sAngle * 3.1415 / 180)
    Dim sy = 300 + 225 * System.Math.Sin(sAngle * 3.1415 / 180)
    e.Graphics.DrawLine(pSecond, 300, 300, CInt(sx), CInt(sy))

    For i = 0 To 11
      e.Graphics.DrawString(i + 1, Me.Font, Brushes.Black, 300 + Math.Cos((i * 30 - 60) * 3.1415 / 180) * 270, 300 + Math.Sin((i * 30 - 60) * 3.1415 / 180) * 270)
    Next

  End Sub

  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    Me.Invalidate()
  End Sub
End Class