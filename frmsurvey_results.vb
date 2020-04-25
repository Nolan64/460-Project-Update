' ++++++++++++++++++++++++++++++++++++++++++++++++++
' This code is generated by a tool and is provided "as is", without warranty of any kind,
' express or implied, including but not limited to the warranties of merchantability,
' fitness for a particular purpose and non-infringement.
' In no event shall the authors or copyright holders be liable for any claim, damages or
' other liability, whether in an action of contract, tort or otherwise, arising from,
' out of or in connection with the software or the use or other dealings in the software.
' ++++++++++++++++++++++++++++++++++++++++++++++++++
'

Imports System.ComponentModel
Imports System.Data.Entity.Core.Objects
Imports System.Data.Entity

Namespace DatabaseTestApplication2
	
	Public Class frmsurvey_results

		Private ctx As mydbEntities1

		Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
			ctx = New mydbEntities1()
			ctx.survey_results.Load()
			Dim _entities As BindingList(Of survey_results) = ctx.survey_results.Local.ToBindingList()
			survey_resultsBindingSource.DataSource = _entities
			Me.Question1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question1", True))
			Me.Question10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question10", True))
			Me.Question11TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question11", True))
			Me.Question12TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question12", True))
			Me.Question13TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question13", True))
			Me.Question14TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question14", True))
			Me.Question15TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question15", True))
			Me.Question16TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question16", True))
			Me.Question17TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question17", True))
			Me.Question18TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question18", True))
			Me.Question19TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question19", True))
			Me.Question2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question2", True))
			Me.Question20TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question20", True))
			Me.Question21TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question21", True))
			Me.Question22TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question22", True))
			Me.Question23TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question23", True))
			Me.Question24TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question24", True))
			Me.Question25TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question25", True))
			Me.Question26TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question26", True))
			Me.Question27TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question27", True))
			Me.Question28TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question28", True))
			Me.Question29TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question29", True))
			Me.Question3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question3", True))
			Me.Question30TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question30", True))
			Me.Question31TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question31", True))
			Me.Question32TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question32", True))
			Me.Question33TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question33", True))
			Me.Question34TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question34", True))
			Me.Question35TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question35", True))
			Me.Question36TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question36", True))
			Me.Question37TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question37", True))
			Me.Question38TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question38", True))
			Me.Question39TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question39", True))
			Me.Question4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question4", True))
			Me.Question40TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question40", True))
			Me.Question41TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question41", True))
			Me.Question42TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question42", True))
			Me.Question43TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question43", True))
			Me.Question44TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question44", True))
			Me.Question45TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question45", True))
			Me.Question46TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question46", True))
			Me.Question47TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question47", True))
			Me.Question48TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question48", True))
			Me.Question49TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question49", True))
			Me.Question5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question5", True))
			Me.Question50TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question50", True))
			Me.Question6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question6", True))
			Me.Question7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question7", True))
			Me.Question8TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question8", True))
			Me.Question9TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "Question9", True))
			Me.QuestionNum1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "QuestionNum1", True ))
			Me.QuestionNum2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "QuestionNum2", True ))
			Me.QuestionNum3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "QuestionNum3", True ))
			Me.QuestionNum4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "QuestionNum4", True ))
			Me.QuestionNum5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.survey_resultsBindingSource, "QuestionNum5", True ))
			Me.survey_SurveyID_comboBox.DataSource = ctx.surveys.ToList()
			Me.survey_SurveyID_comboBox.DisplayMember = "SurveyID"
			Me.survey_SurveyID_comboBox.ValueMember = "SurveyID"
			Me.survey_SurveyID_comboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.survey_resultsBindingSource, "survey_SurveyID", True))
		End Sub
		
		Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
			If Not Me.Validate() Then
				Return
			End If
			survey_resultsBindingSource.EndEdit()
			ctx.SaveChanges()
		End Sub
		
		Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = False
		End Sub

		Private Sub QuestionNum1TextBox_Validating(sender As Object, e As CancelEventArgs) Handles QuestionNum1TextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(QuestionNum1TextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(QuestionNum1TextBox, "The field QuestionNum1 is required")
			End If
			Dim v As Double
			Dim s As String = QuestionNum1TextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(QuestionNum1TextBox, "The field QuestionNum1 must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(QuestionNum1TextBox, "")
			End If
		End Sub

		Private Sub QuestionNum2TextBox_Validating(sender As Object, e As CancelEventArgs) Handles QuestionNum2TextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(QuestionNum2TextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(QuestionNum2TextBox, "The field QuestionNum2 is required")
			End If
			Dim v As Double
			Dim s As String = QuestionNum2TextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(QuestionNum2TextBox, "The field QuestionNum2 must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(QuestionNum2TextBox, "")
			End If
		End Sub

		Private Sub QuestionNum3TextBox_Validating(sender As Object, e As CancelEventArgs) Handles QuestionNum3TextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(QuestionNum3TextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(QuestionNum3TextBox, "The field QuestionNum3 is required")
			End If
			Dim v As Double
			Dim s As String = QuestionNum3TextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(QuestionNum3TextBox, "The field QuestionNum3 must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(QuestionNum3TextBox, "")
			End If
		End Sub

		Private Sub QuestionNum4TextBox_Validating(sender As Object, e As CancelEventArgs) Handles QuestionNum4TextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(QuestionNum4TextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(QuestionNum4TextBox, "The field QuestionNum4 is required")
			End If
			Dim v As Double
			Dim s As String = QuestionNum4TextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(QuestionNum4TextBox, "The field QuestionNum4 must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(QuestionNum4TextBox, "")
			End If
		End Sub

		Private Sub QuestionNum5TextBox_Validating(sender As Object, e As CancelEventArgs) Handles QuestionNum5TextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(QuestionNum5TextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(QuestionNum5TextBox, "The field QuestionNum5 is required")
			End If
			Dim v As Double
			Dim s As String = QuestionNum5TextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(QuestionNum5TextBox, "The field QuestionNum5 must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(QuestionNum5TextBox, "")
			End If
		End Sub

		Private Sub survey_SurveyID_comboBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles survey_SurveyID_comboBox.Validating
			Dim i As Integer = survey_SurveyID_comboBox.SelectedIndex
			e.Cancel = False
			If i = -1 Then
				e.Cancel = True
				ErrorProvider1.SetError(survey_SurveyID_comboBox, "Must select a survey_SurveyID")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(survey_SurveyID_comboBox, "")
			End If
		End Sub

		Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
			survey_resultsBindingSource.AddNew()
		End Sub

		Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

		End Sub



		Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
			Me.Close()
		End Sub

		Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click
			DatabaseTestApplication2.frmgeneral.Show()
			Me.Close()
		End Sub

		Private Sub RepairsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairsToolStripMenuItem.Click
			DatabaseTestApplication2.frmrepairs.Show()
			Me.Close()
		End Sub

		Private Sub TrackingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrackingToolStripMenuItem.Click
			DatabaseTestApplication2.frmtracking.Show()
			Me.Close()
		End Sub

		Private Sub SurveyEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SurveyEditorToolStripMenuItem.Click
			DatabaseTestApplication2.frmsurvey.Show()
			Me.Close()
		End Sub

		Private Sub HomeownershipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeownershipToolStripMenuItem.Click
			DatabaseTestApplication2.frmhomeownership.Show()
			Me.Close()
		End Sub
	End Class

End Namespace
