<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffSideBar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffSideBar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnDashboardPage = New System.Windows.Forms.Button()
        Me.btnProjectPage = New System.Windows.Forms.Button()
        Me.btnSearchPage = New System.Windows.Forms.Button()
        Me.btnAccountPage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pagePlaceholder = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pagePlaceholder.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.IT13_Proj_2.My.Resources.Resources.Frame_123
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnDashboardPage)
        Me.Panel1.Controls.Add(Me.btnProjectPage)
        Me.Panel1.Controls.Add(Me.btnSearchPage)
        Me.Panel1.Controls.Add(Me.btnAccountPage)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(195, 614)
        Me.Panel1.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Image = Global.IT13_Proj_2.My.Resources.Resources.Logout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 569)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(195, 47)
        Me.btnLogout.TabIndex = 16
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnDashboardPage
        '
        Me.btnDashboardPage.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboardPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDashboardPage.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnDashboardPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDashboardPage.Image = Global.IT13_Proj_2.My.Resources.Resources.Home_filled
        Me.btnDashboardPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboardPage.Location = New System.Drawing.Point(0, 93)
        Me.btnDashboardPage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDashboardPage.Name = "btnDashboardPage"
        Me.btnDashboardPage.Size = New System.Drawing.Size(195, 42)
        Me.btnDashboardPage.TabIndex = 15
        Me.btnDashboardPage.Text = "Dashboard"
        Me.btnDashboardPage.UseVisualStyleBackColor = False
        '
        'btnProjectPage
        '
        Me.btnProjectPage.BackColor = System.Drawing.Color.Transparent
        Me.btnProjectPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProjectPage.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnProjectPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProjectPage.Image = Global.IT13_Proj_2.My.Resources.Resources.Folder_open
        Me.btnProjectPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProjectPage.Location = New System.Drawing.Point(0, 133)
        Me.btnProjectPage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnProjectPage.Name = "btnProjectPage"
        Me.btnProjectPage.Size = New System.Drawing.Size(195, 42)
        Me.btnProjectPage.TabIndex = 14
        Me.btnProjectPage.Text = "Project"
        Me.btnProjectPage.UseVisualStyleBackColor = False
        '
        'btnSearchPage
        '
        Me.btnSearchPage.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchPage.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnSearchPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchPage.Image = Global.IT13_Proj_2.My.Resources.Resources.Search
        Me.btnSearchPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchPage.Location = New System.Drawing.Point(0, 174)
        Me.btnSearchPage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearchPage.Name = "btnSearchPage"
        Me.btnSearchPage.Size = New System.Drawing.Size(195, 42)
        Me.btnSearchPage.TabIndex = 13
        Me.btnSearchPage.Text = "Search"
        Me.btnSearchPage.UseVisualStyleBackColor = False
        '
        'btnAccountPage
        '
        Me.btnAccountPage.BackColor = System.Drawing.Color.Transparent
        Me.btnAccountPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAccountPage.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnAccountPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAccountPage.Image = Global.IT13_Proj_2.My.Resources.Resources.Account_circle
        Me.btnAccountPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccountPage.Location = New System.Drawing.Point(0, 522)
        Me.btnAccountPage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAccountPage.Name = "btnAccountPage"
        Me.btnAccountPage.Size = New System.Drawing.Size(195, 47)
        Me.btnAccountPage.TabIndex = 11
        Me.btnAccountPage.Text = "Account"
        Me.btnAccountPage.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(74, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "GVAlias"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.IT13_Proj_2.My.Resources.Resources.Untitled_design__1_
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(39, 17)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(30, 32)
        Me.Panel2.TabIndex = 3
        '
        'pagePlaceholder
        '
        Me.pagePlaceholder.BackColor = System.Drawing.Color.Transparent
        Me.pagePlaceholder.Controls.Add(Me.Panel3)
        Me.pagePlaceholder.Controls.Add(Me.Label3)
        Me.pagePlaceholder.Controls.Add(Me.Label2)
        Me.pagePlaceholder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pagePlaceholder.Location = New System.Drawing.Point(195, 0)
        Me.pagePlaceholder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pagePlaceholder.Name = "pagePlaceholder"
        Me.pagePlaceholder.Size = New System.Drawing.Size(740, 614)
        Me.pagePlaceholder.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.IT13_Proj_2.My.Resources.Resources.Untitled_design__1_
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(282, 228)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(130, 142)
        Me.Panel3.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(207, 382)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 36)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Click a button to start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(249, 161)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 46)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "WELCOME"
        '
        'StaffSideBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 614)
        Me.Controls.Add(Me.pagePlaceholder)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "StaffSideBar"
        Me.Text = "StaffSideBar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pagePlaceholder.ResumeLayout(False)
        Me.pagePlaceholder.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDashboardPage As Button
    Friend WithEvents btnProjectPage As Button
    Friend WithEvents btnSearchPage As Button
    Friend WithEvents btnAccountPage As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pagePlaceholder As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
