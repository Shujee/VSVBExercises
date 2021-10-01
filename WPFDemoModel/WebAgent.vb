Imports RestSharp

Public Class WebAgent
  Dim R As New RestClient

  Sub New()
    R.BaseUrl = New Uri("http://127.0.0.1:8000/")
  End Sub

  Public Function GetAllBooks() As List(Of Book)
    Dim req As New RestRequest("api/books", Method.GET)
    Dim result = R.Execute(Of List(Of Book))(req)
    Return result.Data
  End Function
End Class
