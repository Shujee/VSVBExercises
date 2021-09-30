<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnSimple = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAsync = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSimple
        '
        Me.btnSimple.Location = New System.Drawing.Point(12, 12)
        Me.btnSimple.Name = "btnSimple"
        Me.btnSimple.Size = New System.Drawing.Size(225, 56)
        Me.btnSimple.TabIndex = 0
        Me.btnSimple.Text = "Simple"
        Me.btnSimple.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Multi-Threaded"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAsync
        '
        Me.btnAsync.Location = New System.Drawing.Point(13, 136)
        Me.btnAsync.Name = "btnAsync"
        Me.btnAsync.Size = New System.Drawing.Size(225, 56)
        Me.btnAsync.TabIndex = 2
        Me.btnAsync.Text = "Async/Await"
        Me.btnAsync.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAsync)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSimple)
        Me.Name = "frmMain"
        Me.Text = "With and Without BackgroundWorker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSimple As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAsync As Button
End Class
