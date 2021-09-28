Class Dog
  Private _Name As String
  Public Property Name() As String
    Get
      Return _Name
    End Get
    Set(ByVal value As String)
      _Name = value
    End Set
  End Property

  Private _Height As Integer

  Public ReadOnly Property Height As String
    Get
      Return _Height
    End Get
  End Property

  Public Overridable Function Run()
    Return "A poor simple dog is running"
  End Function

  Public Overrides Function ToString() As String
    Return Name & ": " & Height & " inches high"
  End Function
End Class

MustInherit Class WorkingDog
  Inherits Dog

  Public Sub PullCart()

  End Sub

  Public Overrides Function Run()
    Console.WriteLine("A working dog running")
  End Function
End Class

Class GreatDane
  Inherits WorkingDog

  Public Sub EatPizza()
    Dim x As Object
  End Sub

  Public Overrides Function Run() As Object
    Return "GreatDane is running"
  End Function
End Class

Class BloodHound
  Inherits Dog

  Public Overrides Function Run() As Object
    Return "Bloodhound is running"
  End Function
End Class