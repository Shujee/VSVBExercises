Imports System.Threading

Public Class Form3
  Dim cts As CancellationTokenSource
  Dim lst As New List(Of Long)

  Private Async Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
    Dim n As Long

    Try
      n = CLng(txtNum.Text)
    Catch ex As Exception
      MsgBox("Please enter a valid positive integer")
      Return
    End Try

    lst.Clear()
    lstFactors.Items.Clear()
    btnFind.Enabled = False
    btnCancel.Enabled = True

    cts = New CancellationTokenSource()
    Dim Prog As New Progress(Of Long)(AddressOf ShowProgress)

    Await Task.Run(Sub() FindFactors(n, cts.Token, Prog), cts.Token)

    If cts.IsCancellationRequested Then
      MsgBox("You cancelled the operation")
    Else
      For i = 0 To lst.Count - 1
        lstFactors.Items.Add(lst(i))
      Next

      MsgBox("Factorization completed")
    End If

    btnFind.Enabled = True
    btnCancel.Enabled = False
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    cts.Cancel()
  End Sub

  Private Sub ShowProgress(percent As Long)
    pbr.Value = percent

    For i = 0 To lst.Count - 1
      lstFactors.Items.Add(lst(i))
    Next

    lst.Clear()
  End Sub

  Private Sub FindFactors(number As Long, token As CancellationToken, progress As IProgress(Of Long))
    Dim i As Long = 2
    Dim n As Long = number

    While n > 1
      If n Mod i = 0 Then
        n = n / i
        progress.Report(Math.Min(100, (i / n) * 100))
        lst.Add(i)
      Else
        i += 1
      End If

      If i Mod 1000 = 0 Then
        progress.Report(Math.Min(100, (i / n) * 100))
        If token.IsCancellationRequested Then Exit While
      End If
    End While
  End Sub
End Class
