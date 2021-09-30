Public Class Form1
  Private CancelFlag As Boolean = False

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
    CancelFlag = False

    Dim i As Long = 2

    While n > 1
      If CancelFlag Then Exit While

      If n Mod i = 0 Then
        n = n / i
        lstFactors.Items.Add(i)
      Else
        i += 1
      End If

      pbr.Value = Math.Min(100, (i / n) * 100)
    End While

    btnFind.Enabled = True
    btnCancel.Enabled = False
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    CancelFlag = True
  End Sub
End Class
