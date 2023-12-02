<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProject
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 352)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(943, 377)
        Me.DataGridView1.TabIndex = 32
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date Modified"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Items"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Status"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(14, 187)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(277, 30)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.Text = "Search a Project"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(413, 40)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Change to Product Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(348, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 21)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "---"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(208, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 21)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "No. of Products"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(135, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 21)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "---"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Total Value"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddProduct.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddProduct.Image = Global.IT13_Proj_2.My.Resources.Resources.Add_box__1_
        Me.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddProduct.Location = New System.Drawing.Point(808, 187)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(154, 44)
        Me.btnAddProduct.TabIndex = 33
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button6.Image = Global.IT13_Proj_2.My.Resources.Resources.Filter_list_alt
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(308, 187)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 30)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Filter"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 32)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "< back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ViewProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 756)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.Button6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewProject"
        Me.Text = "ViewProject"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
End Class
