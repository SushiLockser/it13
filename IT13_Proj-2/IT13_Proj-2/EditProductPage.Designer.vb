<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditProductPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProductPage))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DomainUpDown2 = New System.Windows.Forms.DomainUpDown()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 40)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Product Name"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(468, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 430)
        Me.Panel1.TabIndex = 31
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 277)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(253, 22)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.Text = "Enter Product Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 334)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(253, 22)
        Me.TextBox2.TabIndex = 33
        Me.TextBox2.Text = "Enter Quantity"
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(18, 400)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(252, 22)
        Me.DomainUpDown1.TabIndex = 34
        Me.DomainUpDown1.Text = "Select Product Type"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(17, 463)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(253, 22)
        Me.TextBox3.TabIndex = 35
        Me.TextBox3.Text = "Enter Price"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(17, 531)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(253, 22)
        Me.TextBox4.TabIndex = 36
        Me.TextBox4.Text = "Enter Supplier"
        '
        'DomainUpDown2
        '
        Me.DomainUpDown2.Location = New System.Drawing.Point(19, 598)
        Me.DomainUpDown2.Name = "DomainUpDown2"
        Me.DomainUpDown2.Size = New System.Drawing.Size(252, 22)
        Me.DomainUpDown2.TabIndex = 37
        Me.DomainUpDown2.Text = "Quality"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(19, 220)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(251, 22)
        Me.TextBox5.TabIndex = 38
        Me.TextBox5.Text = "ID: "
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Firebrick
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Image = Global.IT13_Proj_2.My.Resources.Resources.Add_box__1_
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(891, 137)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(34, 30)
        Me.Button9.TabIndex = 40
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Helvetica", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = Global.IT13_Proj_2.My.Resources.Resources.Add_box__1_
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(755, 136)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(130, 30)
        Me.Button8.TabIndex = 39
        Me.Button8.Text = "Edit Item"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'EditProductPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 709)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DomainUpDown2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditProductPage"
        Me.Text = "987, 756"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DomainUpDown2 As DomainUpDown
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
End Class
