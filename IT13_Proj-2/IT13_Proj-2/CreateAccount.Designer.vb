﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
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
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(343, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(620, 575)
        Me.DataGridView1.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Password"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Position"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Employee since:"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Firebrick
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Image = Global.IT13_Proj_2.My.Resources.Resources.Add_box__1_
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(925, 68)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(34, 30)
        Me.Button9.TabIndex = 27
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddItem.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Image = Global.IT13_Proj_2.My.Resources.Resources.Add_box__1_
        Me.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddItem.Location = New System.Drawing.Point(789, 67)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(130, 30)
        Me.btnAddItem.TabIndex = 26
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(13, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(277, 30)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.Text = "Search Item"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button6.Image = Global.IT13_Proj_2.My.Resources.Resources.Filter_list_alt
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(307, 67)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 30)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "Filter"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 756)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateAccount"
        Me.Text = "CreateAccount"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Button9 As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
End Class