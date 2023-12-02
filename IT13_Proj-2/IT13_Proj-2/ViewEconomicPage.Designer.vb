<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewEconomicPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewEconomicPage))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.btnBack.Location = New System.Drawing.Point(19, 22)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 32)
        Me.btnBack.TabIndex = 53
        Me.btnBack.Text = "< back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 40)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Supplier:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 21)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Maxx Hardware"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(19, 199)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 349)
        Me.Panel1.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(301, 40)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "This is the picture"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(393, 199)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(564, 205)
        Me.Panel2.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 40)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "This is the graph"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(393, 421)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(564, 276)
        Me.DataGridView1.TabIndex = 59
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Item Description"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Price"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Supplier"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Change"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'ViewEconomicPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 709)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewEconomicPage"
        Me.Text = "ViewEconomicPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
