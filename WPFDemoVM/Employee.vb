Imports System.ComponentModel

Public Class Employee
  Implements INotifyPropertyChanged

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Private _Name As String
  Public Property Name() As String
    Get
      Return _Name
    End Get
    Set(ByVal value As String)
      _Name = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Name)))
    End Set
  End Property

  Private _Age As Integer
  Public Property Age() As Integer
    Get
      Return _Age
    End Get
    Set(ByVal value As Integer)
      _Age = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Age)))
    End Set
  End Property

  Private _Address As String
  Public Property Address() As String
    Get
      Return _Address
    End Get
    Set(ByVal value As String)
      _Address = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Address)))
    End Set
  End Property

  Private _Photo As String
  Public Property Photo() As String
    Get
      Return _Photo
    End Get
    Set(ByVal value As String)
      _Photo = value
    End Set
  End Property
End Class
