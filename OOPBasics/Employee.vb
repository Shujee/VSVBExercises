Public Class Employee
  Inherits Person

  Private _Salary As Integer
  Public Property Salary() As Integer
    Get
      Return _Salary
    End Get
    Set(ByVal value As Integer)
      _Salary = value
    End Set
  End Property

  Private _JoiningDate As Date
  Public Property JoiningDate() As Date
    Get
      Return _JoiningDate
    End Get
    Set(ByVal value As DateTime)
      _JoiningDate = value
    End Set
  End Property
End Class