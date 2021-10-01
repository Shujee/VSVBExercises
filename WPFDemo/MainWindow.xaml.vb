Imports WPFDemoVM

Class MainWindow
  Dim mvm As New MainVM

  Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.DataContext = mvm

  End Sub
End Class
