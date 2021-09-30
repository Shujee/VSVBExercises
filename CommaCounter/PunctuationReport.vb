Public Class PunctuationReport
  Public Property ReportText() As String
    Get
      Return txtReport.Text
    End Get
    Set(ByVal value As String)
      txtReport.Text = value
    End Set
  End Property

  Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

  End Sub
End Class
