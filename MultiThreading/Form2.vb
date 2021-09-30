Public Class Form2
  Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
    Dim n As Long

    Try
      n = CLng(txtNum.Text)
    Catch ex As Exception
      MsgBox("Please enter a valid positive integer")
      Return
    End Try

    lstFactors.Items.Clear()
    btnFind.Enabled = False
    btnCancel.Enabled = True

    bw.RunWorkerAsync(n)
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    bw.CancelAsync()
  End Sub

  Private Sub bw_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw.DoWork
    Dim i As Long = 2
    Dim n As Long = e.Argument

    While n > 1
      If n Mod i = 0 Then
        n = n / i
        bw.ReportProgress(Math.Min(100, (i / n) * 100), i)
      Else
        i += 1
      End If

      If i Mod 1000 = 0 Then
        bw.ReportProgress(Math.Min(100, (i / n) * 100))
        If bw.CancellationPending Then
          e.Cancel = True
          Exit While
        End If
      End If
    End While
  End Sub

  Private Sub bw_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bw.ProgressChanged
    pbr.Value = e.ProgressPercentage

    If e.UserState IsNot Nothing Then
      lstFactors.Items.Add(e.UserState)
    End If
  End Sub

  Private Sub bw_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bw.RunWorkerCompleted
    If e.Cancelled Then
      MsgBox("You cancelled the operation")
    Else
      MsgBox("Factorization completed")
    End If

    btnFind.Enabled = True
    btnCancel.Enabled = False
  End Sub
End Class
