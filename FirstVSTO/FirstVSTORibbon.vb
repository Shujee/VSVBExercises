Imports Microsoft.Office.Tools.Ribbon

Public Class FirstVSTORibbon

  Private Sub FirstVSTORibbon_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

  End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click
    Dim dt = DateTime.Now
    Globals.ThisAddIn.Application.ActiveDocument.Range().InsertAfter(dt.ToString())
  End Sub
End Class
