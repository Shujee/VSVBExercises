Public Class Person
  Private _name As String
  Public Property Name() As String
    Get
      Return _name
    End Get
    Set(ByVal value As String)
      _name = value
    End Set
  End Property

  Private _age As Integer
  Public Property Age() As Integer
    Get
      Return _age
    End Get
    Set(ByVal value As Integer)
      _age = value
    End Set
  End Property

  Private _address As String
  Public Property Address() As String
    Get
      Return _address
    End Get
    Set(ByVal value As String)
      _address = value
    End Set
  End Property

  Public Sub IncrementAge()
    Age += 1
  End Sub

  Public Sub PrintInformation()
    Console.WriteLine("My name is: " & Name)
    Console.WriteLine("My age is: " & Age)
  End Sub
End Class