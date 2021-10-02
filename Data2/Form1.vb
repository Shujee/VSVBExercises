Imports System.Linq
Imports Data2.WorldDataset

Public Class Form1
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.CountryTableAdapter.Fill(Me.WorldDataset.country)
  End Sub

  Private Sub CountryBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CountryBindingNavigatorSaveItem.Click
    Me.Validate()
    Me.CountryBindingSource.EndEdit()
    Me.TableAdapterManager.UpdateAll(Me.WorldDataset)

  End Sub

  Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBox1.DrawItem
    Dim r = WorldDataset.country.Rows(e.Index)
    e.Graphics.DrawString(r("Name") & " (" & r("Code") & ")", Me.Font, Brushes.Black, e.Bounds)
  End Sub
End Class