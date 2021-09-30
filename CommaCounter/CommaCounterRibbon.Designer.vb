Partial Class CommaCounterRibbon
  Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New(ByVal container As System.ComponentModel.IContainer)
    MyClass.New()

    'Required for Windows.Forms Class Composition Designer support
    If (container IsNot Nothing) Then
      container.Add(Me)
    End If

  End Sub

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New()
    MyBase.New(Globals.Factory.GetRibbonFactory())

    'This call is required by the Component Designer.
    InitializeComponent()

  End Sub

  'Component overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Component Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Component Designer
  'It can be modified using the Component Designer.
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.grpCC = Me.Factory.CreateRibbonGroup
        Me.btnCountCommas = Me.Factory.CreateRibbonButton
        Me.btnDetailed = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.grpCC.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.ControlId.OfficeId = "TabHome"
        Me.Tab1.Groups.Add(Me.grpCC)
        Me.Tab1.Label = "TabHome"
        Me.Tab1.Name = "Tab1"
        '
        'grpCC
        '
        Me.grpCC.Items.Add(Me.btnCountCommas)
        Me.grpCC.Items.Add(Me.btnDetailed)
        Me.grpCC.Label = "Comma Counter"
        Me.grpCC.Name = "grpCC"
        '
        'btnCountCommas
        '
        Me.btnCountCommas.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnCountCommas.Label = "Count Commas"
        Me.btnCountCommas.Name = "btnCountCommas"
        Me.btnCountCommas.OfficeImageId = "MailMergeAddressBlockInsert"
        Me.btnCountCommas.ShowImage = True
        '
        'btnDetailed
        '
        Me.btnDetailed.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnDetailed.Label = "Detailed Report"
        Me.btnDetailed.Name = "btnDetailed"
        Me.btnDetailed.OfficeImageId = "MailMergeAddressBlockInsert"
        Me.btnDetailed.ShowImage = True
        '
        'CommaCounterRibbon
        '
        Me.Name = "CommaCounterRibbon"
        Me.RibbonType = "Microsoft.Word.Document"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.grpCC.ResumeLayout(False)
        Me.grpCC.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
  Friend WithEvents grpCC As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnCountCommas As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnDetailed As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

  <System.Diagnostics.DebuggerNonUserCode()> _
  Friend ReadOnly Property CommaCounterRibbon() As CommaCounterRibbon
    Get
      Return Me.GetRibbon(Of CommaCounterRibbon)()
    End Get
  End Property
End Class
