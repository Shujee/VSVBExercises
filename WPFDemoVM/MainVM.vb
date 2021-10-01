Imports System.ComponentModel

Public Class MainVM
  Inherits GalaSoft.MvvmLight.ViewModelBase

  Private _Books As New List(Of BookVM)

  Public Property Books() As List(Of BookVM)
    Get
      Return _Books
    End Get
    Set(ByVal value As List(Of BookVM))
      _Books = value
    End Set
  End Property

  Private _SelectedBook As BookVM
  Public Property SelectedBook() As BookVM
    Get
      Return _SelectedBook
    End Get
    Set(ByVal value As BookVM)
      _SelectedBook = value
      RaisePropertyChanged()
    End Set
  End Property

  Public ReadOnly Property GetAllBooksCommand As GalaSoft.MvvmLight.Command.RelayCommand
    Get
      Dim m As New MainVM
      m.GetAllBooksCommand.Execute(Nothing)

      Return New GalaSoft.MvvmLight.Command.RelayCommand(Sub()
                                                           Dim agent As New WPFDemoModel.WebAgent
                                                           Dim bks = agent.GetAllBooks()

                                                           _Books.Clear()

                                                           For Each b In bks
                                                             _Books.Add(New BookVM With {
                                                                        .Name = b.name,
                                                                        .Title = b.title,
                                                                        .author = b.author,
                                                                        .author_photo = b.author_photo,
                                                                        .edition = b.edition,
                                                                        .isbn = b.isbn,
                                                                        .price = b.price,
                                                                        .sold_count = b.sold_count,
                                                                        .votes = b.votes,
                                                                        .year_written = b.year_written
                                                                        })
                                                           Next

                                                           RaisePropertyChanged(NameOf(Books))
                                                         End Sub)
    End Get
  End Property
End Class