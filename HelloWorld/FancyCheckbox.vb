Public Class FancyCheckbox
  Private _IsChecked As Boolean
  Public Property IsChecked() As Boolean
    Get
      Return _IsChecked
    End Get
    Set(ByVal value As Boolean)
      _IsChecked = value

      If _IsChecked = True Then
        Me.BackgroundImage = My.Resources._ON
      Else
        Me.BackgroundImage = My.Resources.OFF
      End If
    End Set
  End Property

  Private Sub FancyCheckbox_Click(sender As Object, e As EventArgs) Handles MyBase.Click
    _IsChecked = Not _IsChecked

    If _IsChecked = True Then
      Me.BackgroundImage = My.Resources._ON
    Else
      Me.BackgroundImage = My.Resources.OFF



    End If
  End Sub
End Class
