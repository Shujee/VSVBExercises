Public Class Point
  Private _X As Integer
  Public Property X() As Integer
    Get
      Return _X
    End Get
    Set(ByVal value As Integer)
      _X = value
    End Set
  End Property

  Private _Y As Integer
  Public Property Y() As Integer
    Get
      Return _Y
    End Get
    Set(ByVal value As Integer)
      _Y = value
    End Set
  End Property
End Class