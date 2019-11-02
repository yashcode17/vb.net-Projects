<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registerPage
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
        Me.components = New System.ComponentModel.Container()
        Dim Cu_nameLabel As System.Windows.Forms.Label
        Dim Cu_phone1Label As System.Windows.Forms.Label
        Dim Cu_phone2Label As System.Windows.Forms.Label
        Dim Cu_addressLabel As System.Windows.Forms.Label
        Dim Cu_commentsLabel As System.Windows.Forms.Label
        Dim Cu_due_amountLabel As System.Windows.Forms.Label
        Dim Cu_total_amountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerPage))
        Me.CustomerDataSet = New coldstore2.CustomerDataSet()
        Me.CustomerDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataTableTableAdapter = New coldstore2.CustomerDataSetTableAdapters.customerDataTableTableAdapter()
        Me.TableAdapterManager = New coldstore2.CustomerDataSetTableAdapters.TableAdapterManager()
        Me.CustomerDataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CustomerDataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cu_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Cu_phone1TextBox = New System.Windows.Forms.TextBox()
        Me.Cu_phone2TextBox = New System.Windows.Forms.TextBox()
        Me.Cu_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Cu_due_amountTextBox = New System.Windows.Forms.TextBox()
        Me.Cu_commentsTextBox = New System.Windows.Forms.TextBox()
        Me.Cu_total_amountTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Cu_nameLabel = New System.Windows.Forms.Label()
        Cu_phone1Label = New System.Windows.Forms.Label()
        Cu_phone2Label = New System.Windows.Forms.Label()
        Cu_addressLabel = New System.Windows.Forms.Label()
        Cu_commentsLabel = New System.Windows.Forms.Label()
        Cu_due_amountLabel = New System.Windows.Forms.Label()
        Cu_total_amountLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerDataTableBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cu_nameLabel
        '
        Cu_nameLabel.AutoSize = True
        Cu_nameLabel.Font = New System.Drawing.Font("Montserrat", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_nameLabel.Location = New System.Drawing.Point(39, 23)
        Cu_nameLabel.Name = "Cu_nameLabel"
        Cu_nameLabel.Size = New System.Drawing.Size(300, 40)
        Cu_nameLabel.TabIndex = 6
        Cu_nameLabel.Text = "Customer Name:"
        '
        'Cu_phone1Label
        '
        Cu_phone1Label.AutoSize = True
        Cu_phone1Label.Font = New System.Drawing.Font("Montserrat", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_phone1Label.Location = New System.Drawing.Point(39, 175)
        Cu_phone1Label.Name = "Cu_phone1Label"
        Cu_phone1Label.Size = New System.Drawing.Size(307, 40)
        Cu_phone1Label.TabIndex = 8
        Cu_phone1Label.Text = "Phone Number-1:"
        '
        'Cu_phone2Label
        '
        Cu_phone2Label.AutoSize = True
        Cu_phone2Label.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_phone2Label.Location = New System.Drawing.Point(81, 34)
        Cu_phone2Label.Name = "Cu_phone2Label"
        Cu_phone2Label.Size = New System.Drawing.Size(246, 29)
        Cu_phone2Label.TabIndex = 10
        Cu_phone2Label.Text = "Phone Number-2:"
        '
        'Cu_addressLabel
        '
        Cu_addressLabel.AutoSize = True
        Cu_addressLabel.Font = New System.Drawing.Font("Montserrat", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_addressLabel.Location = New System.Drawing.Point(39, 323)
        Cu_addressLabel.Name = "Cu_addressLabel"
        Cu_addressLabel.Size = New System.Drawing.Size(162, 40)
        Cu_addressLabel.TabIndex = 12
        Cu_addressLabel.Text = "Adderss:"
        '
        'Cu_commentsLabel
        '
        Cu_commentsLabel.AutoSize = True
        Cu_commentsLabel.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_commentsLabel.Location = New System.Drawing.Point(81, 377)
        Cu_commentsLabel.Name = "Cu_commentsLabel"
        Cu_commentsLabel.Size = New System.Drawing.Size(309, 29)
        Cu_commentsLabel.TabIndex = 20
        Cu_commentsLabel.Text = "Additional Comments:"
        '
        'Cu_due_amountLabel
        '
        Cu_due_amountLabel.AutoSize = True
        Cu_due_amountLabel.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_due_amountLabel.Location = New System.Drawing.Point(81, 145)
        Cu_due_amountLabel.Name = "Cu_due_amountLabel"
        Cu_due_amountLabel.Size = New System.Drawing.Size(272, 29)
        Cu_due_amountLabel.TabIndex = 18
        Cu_due_amountLabel.Text = "Any Due Ammount:"
        '
        'Cu_total_amountLabel
        '
        Cu_total_amountLabel.AutoSize = True
        Cu_total_amountLabel.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_total_amountLabel.Location = New System.Drawing.Point(81, 254)
        Cu_total_amountLabel.Name = "Cu_total_amountLabel"
        Cu_total_amountLabel.Size = New System.Drawing.Size(336, 29)
        Cu_total_amountLabel.TabIndex = 16
        Cu_total_amountLabel.Text = "Customer Total Amount:"
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDataTableBindingSource
        '
        Me.CustomerDataTableBindingSource.DataMember = "customerDataTable"
        Me.CustomerDataTableBindingSource.DataSource = Me.CustomerDataSet
        '
        'CustomerDataTableTableAdapter
        '
        Me.CustomerDataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adLodinTableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerDataTableTableAdapter = Me.CustomerDataTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = coldstore2.CustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerDataTableBindingNavigator
        '
        Me.CustomerDataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerDataTableBindingNavigator.BindingSource = Me.CustomerDataTableBindingSource
        Me.CustomerDataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerDataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerDataTableBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomerDataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerDataTableBindingNavigatorSaveItem})
        Me.CustomerDataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerDataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerDataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerDataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerDataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerDataTableBindingNavigator.Name = "CustomerDataTableBindingNavigator"
        Me.CustomerDataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerDataTableBindingNavigator.Size = New System.Drawing.Size(1902, 31)
        Me.CustomerDataTableBindingNavigator.TabIndex = 2
        Me.CustomerDataTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CustomerDataTableBindingNavigatorSaveItem
        '
        Me.CustomerDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerDataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerDataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerDataTableBindingNavigatorSaveItem.Name = "CustomerDataTableBindingNavigatorSaveItem"
        Me.CustomerDataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.CustomerDataTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Cu_nameTextBox
        '
        Me.Cu_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataTableBindingSource, "cu_name", True))
        Me.Cu_nameTextBox.Font = New System.Drawing.Font("Montserrat", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cu_nameTextBox.Location = New System.Drawing.Point(111, 76)
        Me.Cu_nameTextBox.Name = "Cu_nameTextBox"
        Me.Cu_nameTextBox.Size = New System.Drawing.Size(559, 48)
        Me.Cu_nameTextBox.TabIndex = 7
        '
        'Cu_phone1TextBox
        '
        Me.Cu_phone1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataTableBindingSource, "cu_phone1", True))
        Me.Cu_phone1TextBox.Font = New System.Drawing.Font("Montserrat", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cu_phone1TextBox.Location = New System.Drawing.Point(111, 234)
        Me.Cu_phone1TextBox.Name = "Cu_phone1TextBox"
        Me.Cu_phone1TextBox.Size = New System.Drawing.Size(559, 48)
        Me.Cu_phone1TextBox.TabIndex = 9
        '
        'Cu_phone2TextBox
        '
        Me.Cu_phone2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataTableBindingSource, "cu_phone2", True))
        Me.Cu_phone2TextBox.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cu_phone2TextBox.Location = New System.Drawing.Point(166, 76)
        Me.Cu_phone2TextBox.Name = "Cu_phone2TextBox"
        Me.Cu_phone2TextBox.Size = New System.Drawing.Size(504, 36)
        Me.Cu_phone2TextBox.TabIndex = 11
        '
        'Cu_addressTextBox
        '
        Me.Cu_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataTableBindingSource, "cu_address", True))
        Me.Cu_addressTextBox.Font = New System.Drawing.Font("Montserrat", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cu_addressTextBox.Location = New System.Drawing.Point(111, 389)
        Me.Cu_addressTextBox.Multiline = True
        Me.Cu_addressTextBox.Name = "Cu_addressTextBox"
        Me.Cu_addressTextBox.Size = New System.Drawing.Size(559, 222)
        Me.Cu_addressTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(538, 832)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 161)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button2.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(852, 830)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 165)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button3.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1156, 830)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(209, 161)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Cu_due_amountTextBox
        '
        Me.Cu_due_amountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataTableBindingSource, "cu_due_amount", True))
        Me.Cu_due_amountTextBox.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cu_due_amountTextBox.Location = New System.Drawing.Point(175, 303)
        Me.Cu_due_amountTextBox.Name = "Cu_due_amountTextBox"
        Me.Cu_due_amountTextBox.ReadOnly = True
        Me.Cu_due_amountTextBox.Size = New System.Drawing.Size(504, 36)
        Me.Cu_due_amountTextBox.TabIndex = 19
        '
        'Cu_commentsTextBox
        '
        Me.Cu_commentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataTableBindingSource, "cu_comments", True))
        Me.Cu_commentsTextBox.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cu_commentsTextBox.Location = New System.Drawing.Point(175, 426)
        Me.Cu_commentsTextBox.Multiline = True
        Me.Cu_commentsTextBox.Name = "Cu_commentsTextBox"
        Me.Cu_commentsTextBox.Size = New System.Drawing.Size(504, 185)
        Me.Cu_commentsTextBox.TabIndex = 21
        '
        'Cu_total_amountTextBox
        '
        Me.Cu_total_amountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataTableBindingSource, "cu_total_amount", True))
        Me.Cu_total_amountTextBox.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cu_total_amountTextBox.Location = New System.Drawing.Point(166, 195)
        Me.Cu_total_amountTextBox.Name = "Cu_total_amountTextBox"
        Me.Cu_total_amountTextBox.Size = New System.Drawing.Size(504, 36)
        Me.Cu_total_amountTextBox.TabIndex = 17
        Me.Cu_total_amountTextBox.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 748)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel2.Controls.Add(Me.Cu_phone1TextBox)
        Me.Panel2.Controls.Add(Cu_addressLabel)
        Me.Panel2.Controls.Add(Cu_nameLabel)
        Me.Panel2.Controls.Add(Me.Cu_addressTextBox)
        Me.Panel2.Controls.Add(Me.Cu_nameTextBox)
        Me.Panel2.Controls.Add(Cu_phone1Label)
        Me.Panel2.Location = New System.Drawing.Point(51, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(816, 649)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel3.Controls.Add(Me.Cu_due_amountTextBox)
        Me.Panel3.Controls.Add(Me.Cu_total_amountTextBox)
        Me.Panel3.Controls.Add(Me.Cu_phone2TextBox)
        Me.Panel3.Controls.Add(Cu_commentsLabel)
        Me.Panel3.Controls.Add(Cu_due_amountLabel)
        Me.Panel3.Controls.Add(Me.Cu_commentsTextBox)
        Me.Panel3.Controls.Add(Cu_total_amountLabel)
        Me.Panel3.Controls.Add(Cu_phone2Label)
        Me.Panel3.Location = New System.Drawing.Point(59, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(779, 649)
        Me.Panel3.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Location = New System.Drawing.Point(982, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(889, 748)
        Me.Panel4.TabIndex = 28
        '
        'Timer1
        '
        '
        'registerPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CustomerDataTableBindingNavigator)
        Me.Name = "registerPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registerPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerDataTableBindingNavigator.ResumeLayout(False)
        Me.CustomerDataTableBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents CustomerDataTableBindingSource As BindingSource
    Friend WithEvents CustomerDataTableTableAdapter As CustomerDataSetTableAdapters.customerDataTableTableAdapter
    Friend WithEvents TableAdapterManager As CustomerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerDataTableBindingNavigator As BindingNavigator
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
    Friend WithEvents CustomerDataTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Cu_nameTextBox As TextBox
    Friend WithEvents Cu_phone1TextBox As TextBox
    Friend WithEvents Cu_phone2TextBox As TextBox
    Friend WithEvents Cu_addressTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Cu_due_amountTextBox As TextBox
    Friend WithEvents Cu_commentsTextBox As TextBox
    Friend WithEvents Cu_total_amountTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Timer1 As Timer
End Class
