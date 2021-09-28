
Public Class frmMain
  Private Sub btnSayHello_Click(sender As Object, e As EventArgs) Handles btnSayHello.Click

    Dim d As Dog

    Dim answer = MsgBox("Do you want to create a Great Dane? Press Yes for Great Dane. Press No for Bloodhound.", MsgBoxStyle.YesNo)

    If answer = vbYes Then
      d = New GreatDane
    Else
      d = New BloodHound
    End If

    MsgBox(d.Run())
  End Sub
End Class