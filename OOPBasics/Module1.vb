Module Module1
  Sub Main()
    Dim p1 As New Person

    p1.Name = "Nicholas"
    p1.Age = 35

    p1.IncrementAge()
    p1.PrintInformation()

    Console.ReadLine()
  End Sub
End Module
