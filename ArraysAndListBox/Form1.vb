Public Class frmMain
  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    If txtName.Text = "" Then
      MessageBox.Show("Please provide a name to add to list.")
    Else
      lstNames.Items.Add(txtName.Text)
      txtName.Clear()
      txtName.Select()
    End If
  End Sub
End Class
