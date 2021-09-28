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
        Me.btnDigital = New System.Windows.Forms.Button()
        Me.btnAnalog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDigital
        '
        Me.btnDigital.Location = New System.Drawing.Point(292, 59)
        Me.btnDigital.Name = "btnDigital"
        Me.btnDigital.Size = New System.Drawing.Size(193, 71)
        Me.btnDigital.TabIndex = 0
        Me.btnDigital.Text = "Digital Clock"
        Me.btnDigital.UseVisualStyleBackColor = True
        '
        'btnAnalog
        '
        Me.btnAnalog.Location = New System.Drawing.Point(292, 202)
        Me.btnAnalog.Name = "btnAnalog"
        Me.btnAnalog.Size = New System.Drawing.Size(193, 71)
        Me.btnAnalog.TabIndex = 1
        Me.btnAnalog.Text = "Analog Clock"
        Me.btnAnalog.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAnalog)
        Me.Controls.Add(Me.btnDigital)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDigital As Button
    Friend WithEvents btnAnalog As Button
End Class
