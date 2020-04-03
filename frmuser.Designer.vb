' ++++++++++++++++++++++++++++++++++++++++++++++++++
' This code is generated by a tool and is provided "as is", without warranty of any kind,
' express or implied, including but not limited to the warranties of merchantability,
' fitness for a particular purpose and non-infringement.
' In no event shall the authors or copyright holders be liable for any claim, damages or
' other liability, whether in an action of contract, tort or otherwise, arising from,
' out of or in connection with the software or the use or other dealings in the software.
' ++++++++++++++++++++++++++++++++++++++++++++++++++
' 

Namespace DatabaseTestApplication2
	
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
	Partial Class frmuser
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmuser))
            Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
            Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
            Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
            Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
            Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
            Me.userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.usernameLabel = New System.Windows.Forms.Label()
            Me.usernameTextBox = New System.Windows.Forms.TextBox()
            Me.passwordLabel = New System.Windows.Forms.Label()
            Me.passwordTextBox = New System.Windows.Forms.TextBox()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.panel5 = New System.Windows.Forms.Panel()
            Me.panel6 = New System.Windows.Forms.Panel()
            CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.BindingNavigator1.SuspendLayout()
            CType(Me.userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'BindingNavigator1
            '
            Me.BindingNavigator1.AddNewItem = Nothing
            Me.BindingNavigator1.BindingSource = Me.userBindingSource
            Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
            Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
            Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
            Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
            Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
            Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
            Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
            Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
            Me.BindingNavigator1.Name = "BindingNavigator1"
            Me.BindingNavigator1.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
            Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
            Me.BindingNavigator1.Size = New System.Drawing.Size(898, 27)
            Me.BindingNavigator1.TabIndex = 0
            Me.BindingNavigator1.Text = "BindingNavigator1"
            '
            'BindingNavigatorCountItem
            '
            Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
            Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
            Me.BindingNavigatorCountItem.Text = "of {0}"
            Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
            '
            'BindingNavigatorDeleteItem
            '
            Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
            Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
            Me.BindingNavigatorDeleteItem.Text = "Delete"
            '
            'BindingNavigatorMoveFirstItem
            '
            Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
            Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
            Me.BindingNavigatorMoveFirstItem.Text = "Move first"
            '
            'BindingNavigatorMovePreviousItem
            '
            Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
            Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
            Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
            '
            'BindingNavigatorSeparator
            '
            Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
            Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
            '
            'BindingNavigatorPositionItem
            '
            Me.BindingNavigatorPositionItem.AccessibleName = "Position"
            Me.BindingNavigatorPositionItem.AutoSize = False
            Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
            Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
            Me.BindingNavigatorPositionItem.Text = "0"
            Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
            '
            'BindingNavigatorSeparator1
            '
            Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
            Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
            '
            'BindingNavigatorMoveNextItem
            '
            Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
            Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
            Me.BindingNavigatorMoveNextItem.Text = "Move next"
            '
            'BindingNavigatorMoveLastItem
            '
            Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
            Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
            Me.BindingNavigatorMoveLastItem.Text = "Move last"
            '
            'BindingNavigatorSeparator2
            '
            Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
            Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
            '
            'BindingNavigatorAddNewItem
            '
            Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
            Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
            Me.BindingNavigatorAddNewItem.Text = "Add new"
            '
            'ToolStripButton1
            '
            Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
            Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton1.Name = "ToolStripButton1"
            Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
            Me.ToolStripButton1.Text = "Save"
            '
            'ErrorProvider1
            '
            Me.ErrorProvider1.ContainerControl = Me
            '
            'Panel1
            '
            Me.Panel1.AutoScroll = True
            Me.Panel1.AutoSize = True
            Me.Panel1.Controls.Add(Me.usernameLabel)
            Me.Panel1.Controls.Add(Me.usernameTextBox)
            Me.Panel1.Controls.Add(Me.passwordLabel)
            Me.Panel1.Controls.Add(Me.passwordTextBox)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(13, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(13, 4, 13, 4)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(872, 403)
            Me.Panel1.TabIndex = 1
            '
            'usernameLabel
            '
            Me.usernameLabel.AutoSize = True
            Me.usernameLabel.Location = New System.Drawing.Point(81, 62)
            Me.usernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.usernameLabel.Name = "usernameLabel"
            Me.usernameLabel.Size = New System.Drawing.Size(71, 17)
            Me.usernameLabel.TabIndex = 1
            Me.usernameLabel.Text = "username"
            '
            'usernameTextBox
            '
            Me.usernameTextBox.Location = New System.Drawing.Point(189, 62)
            Me.usernameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.usernameTextBox.Name = "usernameTextBox"
            Me.usernameTextBox.Size = New System.Drawing.Size(132, 22)
            Me.usernameTextBox.TabIndex = 2
            '
            'passwordLabel
            '
            Me.passwordLabel.AutoSize = True
            Me.passwordLabel.Location = New System.Drawing.Point(488, 62)
            Me.passwordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.passwordLabel.Name = "passwordLabel"
            Me.passwordLabel.Size = New System.Drawing.Size(68, 17)
            Me.passwordLabel.TabIndex = 3
            Me.passwordLabel.Text = "password"
            '
            'passwordTextBox
            '
            Me.passwordTextBox.Location = New System.Drawing.Point(592, 62)
            Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.passwordTextBox.Name = "passwordTextBox"
            Me.passwordTextBox.Size = New System.Drawing.Size(132, 22)
            Me.passwordTextBox.TabIndex = 4
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.Panel1)
            Me.panel3.Controls.Add(Me.panel4)
            Me.panel3.Controls.Add(Me.panel5)
            Me.panel3.Controls.Add(Me.panel6)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(0, 27)
            Me.panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(898, 415)
            Me.panel3.TabIndex = 19
            '
            'panel4
            '
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel4.Location = New System.Drawing.Point(885, 0)
            Me.panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(13, 403)
            Me.panel4.TabIndex = 3
            '
            'panel5
            '
            Me.panel5.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel5.Location = New System.Drawing.Point(0, 0)
            Me.panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(13, 403)
            Me.panel5.TabIndex = 5
            '
            'panel6
            '
            Me.panel6.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel6.Location = New System.Drawing.Point(0, 403)
            Me.panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel6.Name = "panel6"
            Me.panel6.Size = New System.Drawing.Size(898, 12)
            Me.panel6.TabIndex = 6
            '
            'frmuser
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(898, 442)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.BindingNavigator1)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "frmuser"
            Me.Text = "User"
            CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.BindingNavigator1.ResumeLayout(False)
            Me.BindingNavigator1.PerformLayout()
            CType(Me.userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
		Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
		Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
		Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
		Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
		Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
		Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
		Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
		Friend WithEvents Panel1 As System.Windows.Forms.Panel
		Friend WithEvents userBindingSource As System.Windows.Forms.BindingSource
		Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
		Friend WithEvents usernameLabel As System.Windows.Forms.Label
		Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
		Friend WithEvents passwordLabel As System.Windows.Forms.Label
		Friend WithEvents panel3 As System.Windows.Forms.Panel
		Friend WithEvents panel4 As System.Windows.Forms.Panel
		Friend WithEvents panel5 As System.Windows.Forms.Panel
		Friend WithEvents panel6 As System.Windows.Forms.Panel
		
	End Class
	
End Namespace