Public Class frmMain
  Dim xyz As Integer

  Private Sub btnCheckEven_Click(sender As Object, e As EventArgs) Handles btnCheckEven.Click
    Dim n As Integer
    n = Integer.Parse(txtNumber.Text)

    If n Mod 2 = 0 Then
      MessageBox.Show("This number is even")
    Else
      MessageBox.Show("This number is odd")
    End If
  End Sub

  Private Sub btnCheckEvenSafe_Click(sender As Object, e As EventArgs) Handles btnCheckEvenSafe.Click
    Dim n As Integer

    Try
      n = Integer.Parse(txtNumber.Text)
    Catch ex As Exception
      MessageBox.Show("Please provide an integer value.")
    End Try

    If n Mod 2 = 0 Then
      MessageBox.Show("This number is even")
    Else
      MessageBox.Show("This number is odd")
    End If
  End Sub

  Private Sub btnCheckPrime_Click(sender As Object, e As EventArgs) Handles btnCheckPrime.Click
    Dim n As Integer
    n = Integer.Parse(txtNumber.Text)

    If n = 0 OrElse n = 1 Then
      MessageBox.Show("Neither prime nor composite")
    Else
      If IsPrime(n) = True Then
        MessageBox.Show("Prime number")
      Else
        MessageBox.Show("Composite number")
      End If
    End If
  End Sub

  Private Function IsPrime(n As Integer) As Boolean
    If n = 2 Then
      Return True
    Else
      If n Mod 2 = 0 Then
        Return False
      Else
        For i = 3 To n - 1 Step 2
          If n Mod i = 0 Then
            Return False
          End If
        Next

        Return True
      End If
    End If
  End Function
End Class
