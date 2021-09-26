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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnCheckEven = New System.Windows.Forms.Button()
        Me.btnCheckPrime = New System.Windows.Forms.Button()
        Me.btnCheckEvenSafe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(12, 12)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(419, 44)
        Me.txtNumber.TabIndex = 0
        Me.txtNumber.Text = "236"
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCheckEven
        '
        Me.btnCheckEven.Location = New System.Drawing.Point(169, 117)
        Me.btnCheckEven.Name = "btnCheckEven"
        Me.btnCheckEven.Size = New System.Drawing.Size(114, 45)
        Me.btnCheckEven.TabIndex = 1
        Me.btnCheckEven.Text = "Check Even"
        Me.btnCheckEven.UseVisualStyleBackColor = True
        '
        'btnCheckPrime
        '
        Me.btnCheckPrime.Location = New System.Drawing.Point(169, 219)
        Me.btnCheckPrime.Name = "btnCheckPrime"
        Me.btnCheckPrime.Size = New System.Drawing.Size(114, 45)
        Me.btnCheckPrime.TabIndex = 2
        Me.btnCheckPrime.Text = "Check Prime"
        Me.btnCheckPrime.UseVisualStyleBackColor = True
        '
        'btnCheckEvenSafe
        '
        Me.btnCheckEvenSafe.Location = New System.Drawing.Point(169, 168)
        Me.btnCheckEvenSafe.Name = "btnCheckEvenSafe"
        Me.btnCheckEvenSafe.Size = New System.Drawing.Size(114, 45)
        Me.btnCheckEvenSafe.TabIndex = 3
        Me.btnCheckEvenSafe.Text = "Check Even (Safe)"
        Me.btnCheckEvenSafe.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 450)
        Me.Controls.Add(Me.btnCheckEvenSafe)
        Me.Controls.Add(Me.btnCheckPrime)
        Me.Controls.Add(Me.btnCheckEven)
        Me.Controls.Add(Me.txtNumber)
        Me.Name = "frmMain"
        Me.Text = "VSVB: Basic Input and Output"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnCheckEven As Button
    Friend WithEvents btnCheckPrime As Button
    Friend WithEvents btnCheckEvenSafe As Button
End Class
