﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.btnSayHello = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSayHello
        '
        Me.btnSayHello.Location = New System.Drawing.Point(325, 175)
        Me.btnSayHello.Name = "btnSayHello"
        Me.btnSayHello.Size = New System.Drawing.Size(159, 53)
        Me.btnSayHello.TabIndex = 0
        Me.btnSayHello.Text = "Say Hello!"
        Me.btnSayHello.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(374, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 53)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(539, 291)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 53)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSayHello)
        Me.Name = "frmMain"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSayHello As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
