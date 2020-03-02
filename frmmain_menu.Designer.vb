<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmmain_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain_menu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.addApplicant = New System.Windows.Forms.Button()
        Me.editSurvey = New System.Windows.Forms.Button()
        Me.tracking = New System.Windows.Forms.Button()
        Me.repairs = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.Button()
        Me.userName = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.THIS_WILL_BE_A_SEARCH_BAR = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.DatabaseTestApplication2.My.Resources.Resources.CV_HB_Logo_White_400px
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'addApplicant
        '
        Me.addApplicant.Location = New System.Drawing.Point(15, 149)
        Me.addApplicant.Name = "addApplicant"
        Me.addApplicant.Size = New System.Drawing.Size(124, 24)
        Me.addApplicant.TabIndex = 2
        Me.addApplicant.Text = "Add Applicant"
        Me.addApplicant.UseVisualStyleBackColor = True
        '
        'editSurvey
        '
        Me.editSurvey.Location = New System.Drawing.Point(15, 179)
        Me.editSurvey.Name = "editSurvey"
        Me.editSurvey.Size = New System.Drawing.Size(124, 24)
        Me.editSurvey.TabIndex = 3
        Me.editSurvey.Text = "Edit Survey"
        Me.editSurvey.UseVisualStyleBackColor = True
        '
        'tracking
        '
        Me.tracking.Location = New System.Drawing.Point(15, 209)
        Me.tracking.Name = "tracking"
        Me.tracking.Size = New System.Drawing.Size(124, 24)
        Me.tracking.TabIndex = 5
        Me.tracking.Text = "Tracking"
        Me.tracking.UseVisualStyleBackColor = True
        '
        'repairs
        '
        Me.repairs.BackColor = System.Drawing.Color.Transparent
        Me.repairs.Location = New System.Drawing.Point(15, 239)
        Me.repairs.Name = "repairs"
        Me.repairs.Size = New System.Drawing.Size(124, 24)
        Me.repairs.TabIndex = 6
        Me.repairs.Text = "Repairs"
        Me.repairs.UseVisualStyleBackColor = False
        '
        'settings
        '
        Me.settings.Location = New System.Drawing.Point(15, 568)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(124, 24)
        Me.settings.TabIndex = 9
        Me.settings.Text = "Settings"
        Me.settings.UseVisualStyleBackColor = True
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.BackColor = System.Drawing.Color.Transparent
        Me.userName.Location = New System.Drawing.Point(12, 552)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(62, 13)
        Me.userName.TabIndex = 10
        Me.userName.Text = "GET USER"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(283, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(885, 580)
        Me.DataGridView1.TabIndex = 11
        '
        'THIS_WILL_BE_A_SEARCH_BAR
        '
        Me.THIS_WILL_BE_A_SEARCH_BAR.Location = New System.Drawing.Point(283, -1)
        Me.THIS_WILL_BE_A_SEARCH_BAR.Name = "THIS_WILL_BE_A_SEARCH_BAR"
        Me.THIS_WILL_BE_A_SEARCH_BAR.Size = New System.Drawing.Size(885, 20)
        Me.THIS_WILL_BE_A_SEARCH_BAR.TabIndex = 12
        '
        'frmmain_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1170, 600)
        Me.Controls.Add(Me.THIS_WILL_BE_A_SEARCH_BAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.repairs)
        Me.Controls.Add(Me.tracking)
        Me.Controls.Add(Me.editSurvey)
        Me.Controls.Add(Me.addApplicant)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "frmmain_menu"
        Me.Text = "MainMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents addApplicant As Button
    Friend WithEvents editSurvey As Button
    Friend WithEvents tracking As Button
    Friend WithEvents repairs As Button
    Friend WithEvents settings As Button
    Friend WithEvents userName As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents THIS_WILL_BE_A_SEARCH_BAR As TextBox
End Class
