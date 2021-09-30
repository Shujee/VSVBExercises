Public Class ThisAddIn

  Private Sub ThisAddIn_Startup() Handles Me.Startup
    Dim dt = DateTime.Now
    Me.Application.ActiveDocument.Range().InsertAfter(dt.ToString())
  End Sub

  Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

  End Sub
End Class
