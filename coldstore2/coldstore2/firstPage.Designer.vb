<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class firstPage
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CunameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuphone1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuphone2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CudobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CutotalamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CudueamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CucommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New coldstore2.CustomerDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.CustomerDataTableTableAdapter = New coldstore2.CustomerDataSetTableAdapters.customerDataTableTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1541, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(228, 114)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "SHOW ALL RECORD"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CunameDataGridViewTextBoxColumn, Me.Cuphone1DataGridViewTextBoxColumn, Me.Cuphone2DataGridViewTextBoxColumn, Me.CuaddressDataGridViewTextBoxColumn, Me.CudobDataGridViewTextBoxColumn, Me.CutotalamountDataGridViewTextBoxColumn, Me.CudueamountDataGridViewTextBoxColumn, Me.CucommentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerDataTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 157)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1745, 321)
        Me.DataGridView1.TabIndex = 11
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'CunameDataGridViewTextBoxColumn
        '
        Me.CunameDataGridViewTextBoxColumn.DataPropertyName = "cu_name"
        Me.CunameDataGridViewTextBoxColumn.HeaderText = "cu_name"
        Me.CunameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CunameDataGridViewTextBoxColumn.Name = "CunameDataGridViewTextBoxColumn"
        Me.CunameDataGridViewTextBoxColumn.Width = 125
        '
        'Cuphone1DataGridViewTextBoxColumn
        '
        Me.Cuphone1DataGridViewTextBoxColumn.DataPropertyName = "cu_phone1"
        Me.Cuphone1DataGridViewTextBoxColumn.HeaderText = "cu_phone1"
        Me.Cuphone1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Cuphone1DataGridViewTextBoxColumn.Name = "Cuphone1DataGridViewTextBoxColumn"
        Me.Cuphone1DataGridViewTextBoxColumn.Width = 125
        '
        'Cuphone2DataGridViewTextBoxColumn
        '
        Me.Cuphone2DataGridViewTextBoxColumn.DataPropertyName = "cu_phone2"
        Me.Cuphone2DataGridViewTextBoxColumn.HeaderText = "cu_phone2"
        Me.Cuphone2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Cuphone2DataGridViewTextBoxColumn.Name = "Cuphone2DataGridViewTextBoxColumn"
        Me.Cuphone2DataGridViewTextBoxColumn.Width = 125
        '
        'CuaddressDataGridViewTextBoxColumn
        '
        Me.CuaddressDataGridViewTextBoxColumn.DataPropertyName = "cu_address"
        Me.CuaddressDataGridViewTextBoxColumn.HeaderText = "cu_address"
        Me.CuaddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CuaddressDataGridViewTextBoxColumn.Name = "CuaddressDataGridViewTextBoxColumn"
        Me.CuaddressDataGridViewTextBoxColumn.Width = 125
        '
        'CudobDataGridViewTextBoxColumn
        '
        Me.CudobDataGridViewTextBoxColumn.DataPropertyName = "cu_dob"
        Me.CudobDataGridViewTextBoxColumn.HeaderText = "cu_dob"
        Me.CudobDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CudobDataGridViewTextBoxColumn.Name = "CudobDataGridViewTextBoxColumn"
        Me.CudobDataGridViewTextBoxColumn.Width = 125
        '
        'CutotalamountDataGridViewTextBoxColumn
        '
        Me.CutotalamountDataGridViewTextBoxColumn.DataPropertyName = "cu_total_amount"
        Me.CutotalamountDataGridViewTextBoxColumn.HeaderText = "cu_total_amount"
        Me.CutotalamountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CutotalamountDataGridViewTextBoxColumn.Name = "CutotalamountDataGridViewTextBoxColumn"
        Me.CutotalamountDataGridViewTextBoxColumn.Width = 125
        '
        'CudueamountDataGridViewTextBoxColumn
        '
        Me.CudueamountDataGridViewTextBoxColumn.DataPropertyName = "cu_due_amount"
        Me.CudueamountDataGridViewTextBoxColumn.HeaderText = "cu_due_amount"
        Me.CudueamountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CudueamountDataGridViewTextBoxColumn.Name = "CudueamountDataGridViewTextBoxColumn"
        Me.CudueamountDataGridViewTextBoxColumn.Width = 125
        '
        'CucommentsDataGridViewTextBoxColumn
        '
        Me.CucommentsDataGridViewTextBoxColumn.DataPropertyName = "cu_comments"
        Me.CucommentsDataGridViewTextBoxColumn.HeaderText = "cu_comments"
        Me.CucommentsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CucommentsDataGridViewTextBoxColumn.Name = "CucommentsDataGridViewTextBoxColumn"
        Me.CucommentsDataGridViewTextBoxColumn.Width = 125
        '
        'CustomerDataTableBindingSource
        '
        Me.CustomerDataTableBindingSource.DataMember = "customerDataTable"
        Me.CustomerDataTableBindingSource.DataSource = Me.CustomerDataSet
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(365, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(309, 63)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "FIND BY PHONE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataTableBindingSource, "cu_phone1", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(365, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(309, 45)
        Me.TextBox2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(25, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 63)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "FIND BY NAME"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataTableBindingSource, "cu_name", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(25, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(309, 45)
        Me.TextBox1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(638, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(228, 246)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "ADD NEW MEMBER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(1632, 40)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(137, 246)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "EXIT"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(25, 40)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(358, 113)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Customer Operations"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1878, 590)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(33, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1809, 503)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 625)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1878, 396)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Location = New System.Drawing.Point(33, 38)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1809, 324)
        Me.Panel4.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(965, 40)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(246, 246)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "DELETE CUSTOMER"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1454, 40)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 246)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "BACK"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(25, 173)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(358, 113)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Customer Past Data"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'CustomerDataTableTableAdapter
        '
        Me.CustomerDataTableTableAdapter.ClearBeforeFill = True
        '
        'firstPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "firstPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "firstPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents CustomerDataTableBindingSource As BindingSource
    Friend WithEvents CustomerDataTableTableAdapter As CustomerDataSetTableAdapters.customerDataTableTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CunameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cuphone1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cuphone2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CudobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CutotalamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CudueamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CucommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button9 As Button
End Class
