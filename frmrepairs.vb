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
	
	Public Class frmrepairs

		Private ctx As mydbEntities1

		Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
			ctx = New mydbEntities1()
			ctx.repairs.Load()
			Dim _entities As BindingList(Of repair) = ctx.repairs.Local.ToBindingList()
			repairsBindingSource.DataSource = _entities
			Me.ApplicationSubmission_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "ApplicationSubmission", True ))
			Me.AdditionalDocuments_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "AdditionalDocuments", True ))
			Me.ApprovalSiteVisit_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "ApprovalSiteVisit", True ))
			Me.SiteVisitComplete_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "SiteVisitComplete", True ))
			Me.ScopeOfWork_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "ScopeOfWork", True ))
			Me.ContractComplete_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "ContractComplete", True ))
			Me.WorkComplete_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "WorkComplete", True))
			Me.IDDocumentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "IDDocuments", True))
			Me.IncomeVerifiedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "IncomeVerified", True))
			Me.DeedOfTrustTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "DeedOfTrust", True))
			Me.TaxBillTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "TaxBill", True))
			Me.SatisfactionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "Satisfaction", True))
			Me.CompletedApplicationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "CompletedApplication", True))
			Me.ParcelReportTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "ParcelReport", True))
			Me.GISAssessmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "GISAssessment", True))
			Me.FundingSourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.repairsBindingSource, "FundingSource", True))
			Me.General_Info_UID_comboBox.DataSource = ctx.generals.ToList()
			Me.General_Info_UID_comboBox.DisplayMember = "UID"
			Me.General_Info_UID_comboBox.ValueMember = "UID"
			Me.General_Info_UID_comboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.repairsBindingSource, "General_Info_UID", True))
		End Sub

		Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
			If chkCompletedApp.Checked = True Then
				CompletedApplicationTextBox.Text = "1"
			ElseIf chkCompletedApp.Checked = False Then
				CompletedApplicationTextBox.Text = "0"
			End If

			If chkDeed.Checked = True Then
				DeedOfTrustTextBox.Text = "1"
			ElseIf chkDeed.Checked = False Then
				DeedOfTrustTextBox.Text = "0"
			End If

			If chkFundSource.Checked = True Then
				FundingSourceTextBox.Text = "1"
			ElseIf chkFundSource.Checked = False Then
				FundingSourceTextBox.Text = "0"
			End If

			If chkGISAssessment.Checked = True Then
				GISAssessmentTextBox.Text = "1"
			ElseIf chkGISAssessment.Checked = False Then
				GISAssessmentTextBox.Text = "0"
			End If

			If chkIDDocs.Checked = True Then
				IDDocumentsTextBox.Text = "1"
			ElseIf chkIDDocs.Checked = False Then
				IDDocumentsTextBox.Text = "0"
			End If

			If chkIncomeVerified.Checked = True Then
				IncomeVerifiedTextBox.Text = "1"
			ElseIf chkIncomeVerified.Checked = False Then
				IncomeVerifiedTextBox.Text = "0"
			End If

			If chkParcelReport.Checked = True Then
				ParcelReportTextBox.Text = "1"
			ElseIf chkParcelReport.Checked = False Then
				ParcelReportTextBox.Text = "0"
			End If

			If chkSatisfaction.Checked = True Then
				SatisfactionTextBox.Text = "1"
			ElseIf chkSatisfaction.Checked = False Then
				SatisfactionTextBox.Text = "0"
			End If

			If chkTaxBill.Checked = True Then
				TaxBillTextBox.Text = "1"
			ElseIf chkTaxBill.Checked = False Then
				TaxBillTextBox.Text = "0"
			End If
			ctx.SaveChanges()
			repairsBindingSource.EndEdit()
			If Not Me.Validate() Then
				Return
			End If
		End Sub

		Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = False
		End Sub

		Private Sub IDDocumentsTextBox_Validating(sender As Object, e As CancelEventArgs) Handles IDDocumentsTextBox.Validating

            Call CheckToTextValidation()

            e.Cancel = False
			If String.IsNullOrEmpty(IDDocumentsTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(IDDocumentsTextBox, "The field IDDocuments is required")
			End If
			Dim v As Integer
			Dim s As String = IDDocumentsTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(IDDocumentsTextBox, "The field IDDocuments must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(IDDocumentsTextBox, "")
			End If
		End Sub

		Private Sub IncomeVerifiedTextBox_Validating(sender As Object, e As CancelEventArgs) Handles IncomeVerifiedTextBox.Validating

            Call CheckToTextValidation()

            e.Cancel = False
			If String.IsNullOrEmpty(IncomeVerifiedTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(IncomeVerifiedTextBox, "The field IncomeVerified is required")
			End If
			Dim v As Integer
			Dim s As String = IncomeVerifiedTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(IncomeVerifiedTextBox, "The field IncomeVerified must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(IncomeVerifiedTextBox, "")
			End If
		End Sub

		Private Sub DeedOfTrustTextBox_Validating(sender As Object, e As CancelEventArgs) Handles DeedOfTrustTextBox.Validating

            Call CheckToTextValidation()

            e.Cancel = False
			If String.IsNullOrEmpty(DeedOfTrustTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(DeedOfTrustTextBox, "The field DeedOfTrust is required")
			End If
			Dim v As Integer
			Dim s As String = DeedOfTrustTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(DeedOfTrustTextBox, "The field DeedOfTrust must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(DeedOfTrustTextBox, "")
			End If
		End Sub

		Private Sub TaxBillTextBox_Validating(sender As Object, e As CancelEventArgs) Handles TaxBillTextBox.Validating

            Call CheckToTextValidation()

            e.Cancel = False
			If String.IsNullOrEmpty(TaxBillTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(TaxBillTextBox, "The field TaxBill is required")
			End If
			Dim v As Integer
			Dim s As String = TaxBillTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(TaxBillTextBox, "The field TaxBill must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(TaxBillTextBox, "")
			End If
		End Sub

		Private Sub SatisfactionTextBox_Validating(sender As Object, e As CancelEventArgs) Handles SatisfactionTextBox.Validating

            Call CheckToTextValidation()

            e.Cancel = False
			If String.IsNullOrEmpty(SatisfactionTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(SatisfactionTextBox, "The field Satisfaction is required")
			End If
			Dim v As Integer
			Dim s As String = SatisfactionTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(SatisfactionTextBox, "The field Satisfaction must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(SatisfactionTextBox, "")
			End If
		End Sub

		Private Sub CompletedApplicationTextBox_Validating(sender As Object, e As CancelEventArgs) Handles CompletedApplicationTextBox.Validating

            Call CheckToTextValidation()

            e.Cancel = False
			If String.IsNullOrEmpty(CompletedApplicationTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(CompletedApplicationTextBox, "The field CompletedApplication is required")
			End If
			Dim v As Integer
			Dim s As String = CompletedApplicationTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(CompletedApplicationTextBox, "The field CompletedApplication must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(CompletedApplicationTextBox, "")
			End If
		End Sub

		Private Sub ParcelReportTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ParcelReportTextBox.Validating

            Call CheckToTextValidation()

            e.Cancel = False
			If String.IsNullOrEmpty(ParcelReportTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(ParcelReportTextBox, "The field ParcelReport is required")
			End If
			Dim v As Integer
			Dim s As String = ParcelReportTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(ParcelReportTextBox, "The field ParcelReport must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(ParcelReportTextBox, "")
			End If
		End Sub

		Private Sub GISAssessmentTextBox_Validating(sender As Object, e As CancelEventArgs) Handles GISAssessmentTextBox.Validating

            Call CheckToTextValidation()

            e.Cancel = False
			If String.IsNullOrEmpty(GISAssessmentTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(GISAssessmentTextBox, "The field GISAssessment is required")
			End If
			Dim v As Integer
			Dim s As String = GISAssessmentTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(GISAssessmentTextBox, "The field GISAssessment must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(GISAssessmentTextBox, "")
			End If
		End Sub

		Private Sub FundingSourceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles FundingSourceTextBox.Validating

            Call CheckToTextValidation()

            e.Cancel = False
			If String.IsNullOrEmpty(FundingSourceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(FundingSourceTextBox, "The field FundingSource is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(FundingSourceTextBox, "")
			End If
		End Sub

		Private Sub General_Info_UID_comboBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles General_Info_UID_comboBox.Validating
			Dim i As Integer = General_Info_UID_comboBox.SelectedIndex
			e.Cancel = False
			If i = -1 Then
				e.Cancel = True
				ErrorProvider1.SetError(General_Info_UID_comboBox, "Must select a General_Info_UID")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(General_Info_UID_comboBox, "")
			End If
		End Sub

		Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
			repairsBindingSource.AddNew()
		End Sub

        Private Sub tstripMainMenu_Click(sender As Object, e As EventArgs) Handles tstripMainMenu.Click
            frmmain_menu.Show()
            Me.Close()
        End Sub

        Private Sub tstripGeneral_Click(sender As Object, e As EventArgs) Handles tstripGeneral.Click
            frmgeneral.Show()
            Me.Close()
        End Sub

        Private Sub tstripHomeownership_Click(sender As Object, e As EventArgs) Handles tstripHomeownership.Click
            frmhomeownership.Show()
            Me.Close()
        End Sub

        Private Sub CheckToTextValidation()
            If chkCompletedApp.Checked = True Then
                CompletedApplicationTextBox.Text = "1"
            ElseIf chkCompletedApp.Checked = False Then
                CompletedApplicationTextBox.Text = "0"
            End If

            If chkDeed.Checked = True Then
                DeedOfTrustTextBox.Text = "1"
            ElseIf chkDeed.Checked = False Then
                DeedOfTrustTextBox.Text = "0"
            End If

            If chkFundSource.Checked = True Then
                FundingSourceTextBox.Text = "1"
            ElseIf chkFundSource.Checked = False Then
                FundingSourceTextBox.Text = "0"
            End If

            If chkGISAssessment.Checked = True Then
                GISAssessmentTextBox.Text = "1"
            ElseIf chkGISAssessment.Checked = False Then
                GISAssessmentTextBox.Text = "0"
            End If

            If chkIDDocs.Checked = True Then
                IDDocumentsTextBox.Text = "1"
            ElseIf chkIDDocs.Checked = False Then
                IDDocumentsTextBox.Text = "0"
            End If

            If chkIncomeVerified.Checked = True Then
                IncomeVerifiedTextBox.Text = "1"
            ElseIf chkIncomeVerified.Checked = False Then
                IncomeVerifiedTextBox.Text = "0"
            End If

            If chkParcelReport.Checked = True Then
                ParcelReportTextBox.Text = "1"
            ElseIf chkParcelReport.Checked = False Then
                ParcelReportTextBox.Text = "0"
            End If

            If chkSatisfaction.Checked = True Then
                SatisfactionTextBox.Text = "1"
            ElseIf chkSatisfaction.Checked = False Then
                SatisfactionTextBox.Text = "0"
            End If

            If chkTaxBill.Checked = True Then
                TaxBillTextBox.Text = "1"
            ElseIf chkTaxBill.Checked = False Then
                TaxBillTextBox.Text = "0"
            End If
        End Sub

		Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

		End Sub

		Private Sub General_Info_UIDLabel_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

		End Sub
	End Class

End Namespace
