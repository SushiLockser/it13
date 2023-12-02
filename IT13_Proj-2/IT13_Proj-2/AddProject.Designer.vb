<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProject))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 38)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Product Name"
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtProductName.Location = New System.Drawing.Point(19, 110)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(513, 38)
        Me.txtProductName.TabIndex = 56
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(195, 238)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(165, 54)
        Me.btnSave.TabIndex = 57
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(367, 238)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 54)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AddProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 313)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AddProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddProject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Button2 As Button
End Class
