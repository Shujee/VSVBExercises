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
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(12, 9)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(174, 13)
        Me.lblMsg.TabIndex = 0
        Me.lblMsg.Text = "Enter a name and press Add button"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(388, 20)
        Me.txtName.TabIndex = 1
        '
        'lstNames
        '
        Me.lstNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 37
        Me.lstNames.Location = New System.Drawing.Point(15, 80)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(388, 337)
        Me.lstNames.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(328, 51)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 450)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblMsg)
        Me.Name = "frmMain"
        Me.Text = "Arrays and ListBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMsg As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lstNames As ListBox
    Friend WithEvents btnAdd As Button
End Class
