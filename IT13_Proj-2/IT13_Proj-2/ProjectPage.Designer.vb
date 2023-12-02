<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projectPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projectPage))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAddProj = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Projects"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(19, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(277, 30)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Search a Project"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 279)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(925, 430)
        Me.DataGridView1.TabIndex = 18
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Folder: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "---"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Items:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(287, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 21)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "---"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.BackgroundImage = Global.IT13_Proj_2.My.Resources.Resources.Frame_123__1_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(915, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 44)
        Me.Button1.TabIndex = 28
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAddProj
        '
        Me.btnAddProj.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddProj.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddProj.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProj.ForeColor = System.Drawing.Color.White
        Me.btnAddProj.Image = Global.IT13_Proj_2.My.Resources.Resources.Add_box__1_
        Me.btnAddProj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddProj.Location = New System.Drawing.Point(755, 121)
        Me.btnAddProj.Name = "btnAddProj"
        Me.btnAddProj.Size = New System.Drawing.Size(154, 44)
        Me.btnAddProj.TabIndex = 19
        Me.btnAddProj.Text = "Add Project"
        Me.btnAddProj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddProj.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button6.Image = Global.IT13_Proj_2.My.Resources.Resources.Filter_list_alt
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(313, 134)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 30)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Filter"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'projectPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 756)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAddProj)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "projectPage"
        Me.Text = "Project"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddProj As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
