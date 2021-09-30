Public Class frmMain
  Dim p As New Person With {.Name = "William"}

  Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    AddHandler p.Overweight, AddressOf abc
  End Sub

  Private Sub btnSayHello_Click(sender As Object, e As EventArgs) Handles btnSayHello.Click
    p.IncrementWeight()
  End Sub

  Sub abc()
    MsgBox("Person has got overweight")
  End Sub
End Class


Class Person
  Public Event Overweight As Action

  Private _Name As String
  Public Property Name() As String
    Get
      Return _Name
    End Get
    Set(ByVal value As String)
      _Name = value
    End Set
  End Property

  Private _Weight As Integer

  Public Sub IncrementWeight()
    _Weight = _Weight + 1

    If _Weight > 10 Then
      RaiseEvent Overweight()
    End If
  End Sub
End Class