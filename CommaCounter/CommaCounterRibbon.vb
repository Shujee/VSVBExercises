Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Tools.Ribbon

Public Class CommaCounterRibbon

  Private Sub CommaCounterRibbon_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

  End Sub

  Private Sub btnCountCommas_Click(sender As Object, e As RibbonControlEventArgs) Handles btnCountCommas.Click
    Dim doc = Globals.ThisAddIn.Application.ActiveDocument

    Dim count = 0
    For Each ch As Range In doc.Characters
      If ch.Text = "," Then
        count += 1
      End If
    Next

    MsgBox($"There are {count} commas in this document.")
  End Sub

  Private Sub btnDetailed_Click(sender As Object, e As RibbonControlEventArgs) Handles btnDetailed.Click
    Dim pr As New PunctuationReport
    Dim doc = Globals.ThisAddIn.Application.ActiveDocument

    Dim register As New Dictionary(Of String, Integer)
    register.Add(".", 0)
    register.Add(",", 0)
    register.Add(":", 0)
    register.Add(";", 0)

    Dim count = 0
    For Each ch As Range In doc.Characters
      If ch.Text = "," Then
        register(",") += 1
      ElseIf ch.Text = "." Then
        register(".") += 1
      ElseIf ch.Text = ";" Then
        register(";") += 1
      ElseIf ch.Text = ":" Then
        register(":") += 1
      End If
    Next

    For Each entry In register
      pr.ReportText &= $"Character [{entry.Key}]: {entry.Value}{Environment.NewLine}"
    Next

    Dim NewTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(pr, "Punctuation Counter", doc.ActiveWindow)
    NewTaskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight
    NewTaskPane.Width = 500
    NewTaskPane.Visible = True
  End Sub
End Class
