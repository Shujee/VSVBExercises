Public Class frmMain
  Dim IsMouseDown As Boolean
  Dim Points As New List(Of Point)
  Dim p As New Pen(Brushes.Black, 2)
  Dim LastPoint As Integer

  Private Sub frmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
    IsMouseDown = True
  End Sub

  Private Sub frmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
    If IsMouseDown Then
      Points.Add(New Point() With {.X = e.Location.X, .Y = e.Location.Y})
      Me.Invalidate()
    End If
  End Sub

  Private Sub frmMain_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
    IsMouseDown = False
  End Sub

  Private Sub frmMain_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    For i As Integer = 0 To Points.Count - 2
      e.Graphics.DrawLine(p, Points(i).X, Points(i).Y, Points(i + 1).X, Points(i + 1).Y)
    Next
  End Sub

  Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    Points.Clear()
    Me.Invalidate()
  End Sub
End Class
