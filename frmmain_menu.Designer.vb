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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain_menu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.addApplicant = New System.Windows.Forms.Button()
        Me.editSurvey = New System.Windows.Forms.Button()
        Me.tracking = New System.Windows.Forms.Button()
        Me.repairs = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.Button()
        Me.userName = New System.Windows.Forms.Label()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.All_table_vwBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Refreshbtn = New System.Windows.Forms.Button()
        Me.Reportsbtn = New System.Windows.Forms.Button()
        Me.All_table_vwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.All_table_vwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.DatabaseTestApplication2.My.Resources.Resources.CV_HB_Logo_White_400px
        Me.PictureBox1.Location = New System.Drawing.Point(13, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(353, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'addApplicant
        '
        Me.addApplicant.Location = New System.Drawing.Point(20, 183)
        Me.addApplicant.Margin = New System.Windows.Forms.Padding(4)
        Me.addApplicant.Name = "addApplicant"
        Me.addApplicant.Size = New System.Drawing.Size(165, 30)
        Me.addApplicant.TabIndex = 2
        Me.addApplicant.Text = "Add Applicant"
        Me.addApplicant.UseVisualStyleBackColor = True
        '
        'editSurvey
        '
        Me.editSurvey.Location = New System.Drawing.Point(20, 220)
        Me.editSurvey.Margin = New System.Windows.Forms.Padding(4)
        Me.editSurvey.Name = "editSurvey"
        Me.editSurvey.Size = New System.Drawing.Size(165, 30)
        Me.editSurvey.TabIndex = 3
        Me.editSurvey.Text = "Edit Survey"
        Me.editSurvey.UseVisualStyleBackColor = True
        '
        'tracking
        '
        Me.tracking.Location = New System.Drawing.Point(20, 257)
        Me.tracking.Margin = New System.Windows.Forms.Padding(4)
        Me.tracking.Name = "tracking"
        Me.tracking.Size = New System.Drawing.Size(165, 30)
        Me.tracking.TabIndex = 5
        Me.tracking.Text = "Tracking"
        Me.tracking.UseVisualStyleBackColor = True
        '
        'repairs
        '
        Me.repairs.BackColor = System.Drawing.Color.Transparent
        Me.repairs.Location = New System.Drawing.Point(20, 294)
        Me.repairs.Margin = New System.Windows.Forms.Padding(4)
        Me.repairs.Name = "repairs"
        Me.repairs.Size = New System.Drawing.Size(165, 30)
        Me.repairs.TabIndex = 6
        Me.repairs.Text = "Repairs"
        Me.repairs.UseVisualStyleBackColor = False
        '
        'settings
        '
        Me.settings.Location = New System.Drawing.Point(13, 879)
        Me.settings.Margin = New System.Windows.Forms.Padding(4)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(165, 30)
        Me.settings.TabIndex = 9
        Me.settings.Text = "Settings"
        Me.settings.UseVisualStyleBackColor = True
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.BackColor = System.Drawing.Color.Transparent
        Me.userName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.userName.Location = New System.Drawing.Point(13, 858)
        Me.userName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(79, 17)
        Me.userName.TabIndex = 10
        Me.userName.Text = "GET USER"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Enabled = False
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 26)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Enabled = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 26)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 26)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'All_table_vwBindingNavigatorSaveItem
        '
        Me.All_table_vwBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.All_table_vwBindingNavigatorSaveItem.Enabled = False
        Me.All_table_vwBindingNavigatorSaveItem.Image = CType(resources.GetObject("All_table_vwBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.All_table_vwBindingNavigatorSaveItem.Name = "All_table_vwBindingNavigatorSaveItem"
        Me.All_table_vwBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 26)
        Me.All_table_vwBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(373, 14)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1517, 896)
        Me.DataGridView1.TabIndex = 11
        '
        'Refreshbtn
        '
        Me.Refreshbtn.Location = New System.Drawing.Point(291, 146)
        Me.Refreshbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Refreshbtn.Name = "Refreshbtn"
        Me.Refreshbtn.Size = New System.Drawing.Size(75, 23)
        Me.Refreshbtn.TabIndex = 12
        Me.Refreshbtn.Text = "Refresh"
        Me.Refreshbtn.UseVisualStyleBackColor = True
        '
        'Reportsbtn
        '
        Me.Reportsbtn.BackColor = System.Drawing.Color.Transparent
        Me.Reportsbtn.Location = New System.Drawing.Point(20, 332)
        Me.Reportsbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Reportsbtn.Name = "Reportsbtn"
        Me.Reportsbtn.Size = New System.Drawing.Size(165, 30)
        Me.Reportsbtn.TabIndex = 13
        Me.Reportsbtn.Text = "Reports"
        Me.Reportsbtn.UseVisualStyleBackColor = False
        '
        'frmmain_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1901, 1033)
        Me.Controls.Add(Me.Reportsbtn)
        Me.Controls.Add(Me.Refreshbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.repairs)
        Me.Controls.Add(Me.tracking)
        Me.Controls.Add(Me.editSurvey)
        Me.Controls.Add(Me.addApplicant)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmmain_menu"
        Me.Text = "MainMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.All_table_vwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents All_table_vwBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents All_table_vwBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Refreshbtn As Button
    Friend WithEvents Reportsbtn As Button
End Class
