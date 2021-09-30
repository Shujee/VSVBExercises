<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.txtNum = New System.Windows.Forms.TextBox()
    Me.lblMessage = New System.Windows.Forms.Label()
    Me.lstFactors = New System.Windows.Forms.ListBox()
    Me.llblFactors = New System.Windows.Forms.Label()
    Me.btnFind = New System.Windows.Forms.Button()
    Me.pbr = New System.Windows.Forms.ProgressBar()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'txtNum
    '
    Me.txtNum.Location = New System.Drawing.Point(12, 25)
    Me.txtNum.MaxLength = 30
    Me.txtNum.Name = "txtNum"
    Me.txtNum.Size = New System.Drawing.Size(241, 20)
    Me.txtNum.TabIndex = 0
    '
    'lblMessage
    '
    Me.lblMessage.AutoSize = True
    Me.lblMessage.Location = New System.Drawing.Point(12, 9)
    Me.lblMessage.Name = "lblMessage"
    Me.lblMessage.Size = New System.Drawing.Size(79, 13)
    Me.lblMessage.TabIndex = 1
    Me.lblMessage.Text = "Enter a number"
    '
    'lstFactors
    '
    Me.lstFactors.FormattingEnabled = True
    Me.lstFactors.Location = New System.Drawing.Point(12, 113)
    Me.lstFactors.Name = "lstFactors"
    Me.lstFactors.Size = New System.Drawing.Size(238, 329)
    Me.lstFactors.TabIndex = 2
    '
    'llblFactors
    '
    Me.llblFactors.AutoSize = True
    Me.llblFactors.Location = New System.Drawing.Point(9, 97)
    Me.llblFactors.Name = "llblFactors"
    Me.llblFactors.Size = New System.Drawing.Size(42, 13)
    Me.llblFactors.TabIndex = 3
    Me.llblFactors.Text = "Factors"
    '
    'btnFind
    '
    Me.btnFind.Location = New System.Drawing.Point(93, 71)
    Me.btnFind.Name = "btnFind"
    Me.btnFind.Size = New System.Drawing.Size(77, 28)
    Me.btnFind.TabIndex = 1
    Me.btnFind.Text = "Find Factors"
    Me.btnFind.UseVisualStyleBackColor = True
    '
    'pbr
    '
    Me.pbr.Location = New System.Drawing.Point(12, 51)
    Me.pbr.Name = "pbr"
    Me.pbr.Size = New System.Drawing.Size(241, 14)
    Me.pbr.TabIndex = 4
    '
    'btnCancel
    '
    Me.btnCancel.Enabled = False
    Me.btnCancel.Location = New System.Drawing.Point(176, 71)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(77, 28)
    Me.btnCancel.TabIndex = 5
    Me.btnCancel.Text = "Cancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'Form3
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(265, 450)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.pbr)
    Me.Controls.Add(Me.btnFind)
    Me.Controls.Add(Me.llblFactors)
    Me.Controls.Add(Me.lstFactors)
    Me.Controls.Add(Me.lblMessage)
    Me.Controls.Add(Me.txtNum)
    Me.Name = "Form3"
    Me.Text = "Factors Finder (BW)"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtNum As TextBox
  Friend WithEvents lblMessage As Label
  Friend WithEvents lstFactors As ListBox
  Friend WithEvents llblFactors As Label
  Friend WithEvents btnFind As Button
  Friend WithEvents pbr As ProgressBar
  Friend WithEvents btnCancel As Button
End Class
