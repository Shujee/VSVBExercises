<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.WorldDataset = New Data2.WorldDataset()
    Me.CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.CountryTableAdapter = New Data2.WorldDatasetTableAdapters.countryTableAdapter()
    Me.TableAdapterManager = New Data2.WorldDatasetTableAdapters.TableAdapterManager()
    Me.CountryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
    Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
    Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
    Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
    Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.CountryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
    Me.CodeTextBox = New System.Windows.Forms.TextBox()
    Me.NameTextBox = New System.Windows.Forms.TextBox()
    Me.PopulationTextBox = New System.Windows.Forms.TextBox()
    Me.ListBox1 = New System.Windows.Forms.ListBox()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.WorldDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CountryBindingNavigator.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WorldDataset
        '
        Me.WorldDataset.DataSetName = "WorldDataset"
        Me.WorldDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CountryBindingSource
        '
        Me.CountryBindingSource.DataMember = "country"
        Me.CountryBindingSource.DataSource = Me.WorldDataset
        '
        'CountryTableAdapter
        '
        Me.CountryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cityTableAdapter = Nothing
        Me.TableAdapterManager.countryTableAdapter = Me.CountryTableAdapter
        Me.TableAdapterManager.UpdateOrder = Data2.WorldDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CountryBindingNavigator
        '
        Me.CountryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CountryBindingNavigator.BindingSource = Me.CountryBindingSource
        Me.CountryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CountryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CountryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CountryBindingNavigatorSaveItem})
        Me.CountryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CountryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CountryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CountryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CountryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CountryBindingNavigator.Name = "CountryBindingNavigator"
        Me.CountryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CountryBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CountryBindingNavigator.TabIndex = 0
        Me.CountryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CountryBindingNavigatorSaveItem
        '
        Me.CountryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CountryBindingNavigatorSaveItem.Image = CType(resources.GetObject("CountryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CountryBindingNavigatorSaveItem.Name = "CountryBindingNavigatorSaveItem"
        Me.CountryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CountryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CodeTextBox
        '
        Me.CodeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CountryBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(203, 3)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(594, 20)
        Me.CodeTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CountryBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(203, 29)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(594, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'PopulationTextBox
        '
        Me.PopulationTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PopulationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CountryBindingSource, "Population", True))
        Me.PopulationTextBox.Location = New System.Drawing.Point(203, 55)
        Me.PopulationTextBox.Name = "PopulationTextBox"
        Me.PopulationTextBox.Size = New System.Drawing.Size(594, 20)
        Me.PopulationTextBox.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.DataSource = Me.CountryBindingSource
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.ListBox1, 4)
        Me.ListBox1.Size = New System.Drawing.Size(190, 407)
        Me.ListBox1.TabIndex = 7
        Me.ListBox1.ValueMember = "Code"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CodeTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PopulationTextBox, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 425)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CountryBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.WorldDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CountryBindingNavigator.ResumeLayout(False)
        Me.CountryBindingNavigator.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WorldDataset As WorldDataset
    Friend WithEvents CountryBindingSource As BindingSource
    Friend WithEvents CountryTableAdapter As WorldDatasetTableAdapters.countryTableAdapter
    Friend WithEvents TableAdapterManager As WorldDatasetTableAdapters.TableAdapterManager
    Friend WithEvents CountryBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CountryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodeTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PopulationTextBox As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
