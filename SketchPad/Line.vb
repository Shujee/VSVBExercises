Public Class Line
  Private _Start As Point
  Public Property Start() As Point
    Get
      Return _Start
    End Get
    Set(ByVal value As Point)
      _Start = value
    End Set
  End Property

  Private _Finish As Point
  Public Property Finish() As Point
    Get
      Return _Finish
    End Get
    Set(ByVal value As Point)
      _Finish = value
    End Set
  End Property
End Class