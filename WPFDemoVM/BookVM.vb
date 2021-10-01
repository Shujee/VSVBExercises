Public Class BookVM
  Inherits GalaSoft.MvvmLight.ViewModelBase

  Private _name As String
  Public Property Name As String
    Get
      Return _name
    End Get
    Set(value As String)
      _name = value
      RaisePropertyChanged()
    End Set
  End Property

  Private _title As String
  Public Property Title As String
    Get
      Return _title
    End Get
    Set(value As String)
      _title = value
      RaisePropertyChanged()
    End Set
  End Property

  Public Property isbn As String
  Public Property author As String
  Public Property author_photo As String
  Public Property year_written As Integer
  Public Property edition As String
  Public Property price As Decimal
  Public Property sold_count As Integer
  Public Property votes As Integer
End Class