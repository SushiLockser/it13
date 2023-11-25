<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomePage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.IT13_Proj_2.My.Resources.Resources.Untitled_design__1_
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(348, 73)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 206)
        Me.Panel1.TabIndex = 0
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnAdmin.ForeColor = System.Drawing.Color.Snow
        Me.btnAdmin.Location = New System.Drawing.Point(240, 479)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(181, 32)
        Me.btnAdmin.TabIndex = 7
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnStaff.ForeColor = System.Drawing.Color.Snow
        Me.btnStaff.Location = New System.Drawing.Point(478, 479)
        Me.btnStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(181, 32)
        Me.btnStaff.TabIndex = 8
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 32.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(262, 282)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(410, 51)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Welcom to GVAlias"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 32.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(145, 325)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(657, 51)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Construction Inventory System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(356, 448)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "What is your role in the copany?"
        '
        'WelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(891, 614)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "WelcomePage"
        Me.Text = "WelcomePage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
