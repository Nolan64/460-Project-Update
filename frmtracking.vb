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
	
	Public Class frmtracking

		Private ctx As mydbEntities1

		Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
			ctx = New mydbEntities1()
			ctx.trackings.Load()
			Dim _entities As BindingList(Of tracking) = ctx.trackings.Local.ToBindingList()
			trackingBindingSource.DataSource = _entities
			Me.general_UID_comboBox.DataSource = ctx.generals.ToList()
			Me.general_UID_comboBox.DisplayMember = "UID"
			Me.general_UID_comboBox.ValueMember = "UID"
			Me.general_UID_comboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.trackingBindingSource, "general_UID", True))
			Me.sweatEquityDate_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "sweatEquityDate", True))
			Me.sweatEquityAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "sweatEquityAmount", True))
			Me.monthlyDepositDate_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "monthlyDepositDate", True))
			Me.monthlyDepositAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "monthlyDepositAmount", True))
			Me.HUDHoursDate_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "HUDHoursDate", True))
			Me.HUDHoursCompleteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "HUDHoursComplete", True))
			Me.financeClassesDate_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "financeClassesDate", True))
			Me.financeClassesCompleteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "financeClassesComplete", True))
			Me.homebuyerEducationDate_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "homebuyerEducationDate", True))
			Me.homebuyerEducationAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "homebuyerEducationAmount", True))
			Me.mortgage1PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage1Price", True))
			Me.mortgage1BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage1Bank", True))
			Me.mortgage1ForgivableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage1Forgivable", True))
			Me.mortgage1OriginalBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage1OriginalBalance", True))
			Me.mortgage1NumberOfYearsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage1NumberOfYears", True))
			Me.mortgage2PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage2Price", True))
			Me.mortgage2BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage2Bank", True))
			Me.mortgage2ForgivableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage2Forgivable", True))
			Me.mortgage2OriginalBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage2OriginalBalance", True))
			Me.morgage2NumberOfYearsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "morgage2NumberOfYears", True))
			Me.mortgage3PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage3Price", True))
			Me.mortgage3BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage3Bank", True))
			Me.mortgage3ForgivableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage3Forgivable", True))
			Me.mortgage3OriginalBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage3OriginalBalance", True))
			Me.mortgage3NumberOfYearsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage3NumberOfYears", True))
			Me.mortgage4PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage4Price", True))
			Me.mortgage4BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage4Bank", True))
			Me.mortgage4ForgivableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage4Forgivable", True))
			Me.mortgage4OriginalBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage4OriginalBalance", True))
			Me.mortgage4NumberOfYearsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage4NumberOfYears", True))
			Me.mortgage5PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage5Price", True))
			Me.mortgage5BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage5Bank", True))
			Me.mortgage5ForgivableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage5Forgivable", True))
			Me.mortgage5OriginalBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage5OriginalBalance", True))
			Me.mortgage5NumberOfYearsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage5NumberOfYears", True))
			Me.mortgage6PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage6Price", True))
			Me.mortgage6BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage6Bank", True))
			Me.mortgage6ForgivableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage6Forgivable", True))
			Me.mortgage6OriginalBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage6OriginalBalance", True))
			Me.mortgage6NumberOfYearsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.trackingBindingSource, "mortgage6NumberOfYears", True))
		End Sub

		Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
			If Not Me.Validate() Then
				Return
			End If
			trackingBindingSource.EndEdit()
			ctx.SaveChanges()
		End Sub

		Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = False
		End Sub

		Private Sub general_UID_comboBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles general_UID_comboBox.Validating
			Dim i As Integer = general_UID_comboBox.SelectedIndex
			e.Cancel = False
			If i = -1 Then
				e.Cancel = True
				ErrorProvider1.SetError(general_UID_comboBox, "Must select a general_UID")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(general_UID_comboBox, "")
			End If
		End Sub
		Private Sub sweatEquityAmountTextBox_Validating(sender As Object, e As CancelEventArgs) Handles sweatEquityAmountTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(sweatEquityAmountTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(sweatEquityAmountTextBox, "The field sweatEquityAmount is required")
			End If
			Dim v As Integer
			Dim s As String = sweatEquityAmountTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(sweatEquityAmountTextBox, "The field sweatEquityAmount must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(sweatEquityAmountTextBox, "")
			End If
		End Sub

		Private Sub monthlyDepositAmountTextBox_Validating(sender As Object, e As CancelEventArgs) Handles monthlyDepositAmountTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(monthlyDepositAmountTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(monthlyDepositAmountTextBox, "The field monthlyDepositAmount is required")
			End If
			Dim v As Double
			Dim s As String = monthlyDepositAmountTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(monthlyDepositAmountTextBox, "The field monthlyDepositAmount must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(monthlyDepositAmountTextBox, "")
			End If
		End Sub

		Private Sub HUDHoursCompleteTextBox_Validating(sender As Object, e As CancelEventArgs) Handles HUDHoursCompleteTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(HUDHoursCompleteTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(HUDHoursCompleteTextBox, "The field HUDHoursComplete is required")
			End If
			Dim v As Integer
			Dim s As String = HUDHoursCompleteTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(HUDHoursCompleteTextBox, "The field HUDHoursComplete must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(HUDHoursCompleteTextBox, "")
			End If
		End Sub

		Private Sub financeClassesCompleteTextBox_Validating(sender As Object, e As CancelEventArgs) Handles financeClassesCompleteTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(financeClassesCompleteTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(financeClassesCompleteTextBox, "The field financeClassesComplete is required")
			End If
			Dim v As Integer
			Dim s As String = financeClassesCompleteTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(financeClassesCompleteTextBox, "The field financeClassesComplete must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(financeClassesCompleteTextBox, "")
			End If
		End Sub

		Private Sub homebuyerEducationAmountTextBox_Validating(sender As Object, e As CancelEventArgs) Handles homebuyerEducationAmountTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(homebuyerEducationAmountTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(homebuyerEducationAmountTextBox, "The field homebuyerEducationAmount is required")
			End If
			Dim v As Integer
			Dim s As String = homebuyerEducationAmountTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(homebuyerEducationAmountTextBox, "The field homebuyerEducationAmount must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(homebuyerEducationAmountTextBox, "")
			End If
		End Sub

		Private Sub mortgage1PriceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage1PriceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage1PriceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage1PriceTextBox, "The field mortgage1Price is required")
			End If
			Dim v As Double
			Dim s As String = mortgage1PriceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage1PriceTextBox, "The field mortgage1Price must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage1PriceTextBox, "")
			End If
		End Sub

		Private Sub mortgage1BankTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage1BankTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage1BankTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage1BankTextBox, "The field mortgage1Bank is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage1BankTextBox, "")
			End If
		End Sub

		Private Sub mortgage1ForgivableTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage1ForgivableTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage1ForgivableTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage1ForgivableTextBox, "The field mortgage1Forgivable is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage1ForgivableTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage1ForgivableTextBox, "The field mortgage1Forgivable must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage1ForgivableTextBox, "")
			End If
		End Sub

		Private Sub mortgage1OriginalBalanceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage1OriginalBalanceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage1OriginalBalanceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage1OriginalBalanceTextBox, "The field mortgage1OriginalBalance is required")
			End If
			Dim v As Double
			Dim s As String = mortgage1OriginalBalanceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage1OriginalBalanceTextBox, "The field mortgage1OriginalBalance must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage1OriginalBalanceTextBox, "")
			End If
		End Sub

		Private Sub mortgage1NumberOfYearsTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage1NumberOfYearsTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage1NumberOfYearsTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage1NumberOfYearsTextBox, "The field mortgage1NumberOfYears is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage1NumberOfYearsTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage1NumberOfYearsTextBox, "The field mortgage1NumberOfYears must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage1NumberOfYearsTextBox, "")
			End If
		End Sub

		Private Sub mortgage2PriceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage2PriceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage2PriceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage2PriceTextBox, "The field mortgage2Price is required")
			End If
			Dim v As Double
			Dim s As String = mortgage2PriceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage2PriceTextBox, "The field mortgage2Price must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage2PriceTextBox, "")
			End If
		End Sub

		Private Sub mortgage2BankTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage2BankTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage2BankTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage2BankTextBox, "The field mortgage2Bank is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage2BankTextBox, "")
			End If
		End Sub

		Private Sub mortgage2ForgivableTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage2ForgivableTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage2ForgivableTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage2ForgivableTextBox, "The field mortgage2Forgivable is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage2ForgivableTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage2ForgivableTextBox, "The field mortgage2Forgivable must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage2ForgivableTextBox, "")
			End If
		End Sub

		Private Sub mortgage2OriginalBalanceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage2OriginalBalanceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage2OriginalBalanceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage2OriginalBalanceTextBox, "The field mortgage2OriginalBalance is required")
			End If
			Dim v As Double
			Dim s As String = mortgage2OriginalBalanceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage2OriginalBalanceTextBox, "The field mortgage2OriginalBalance must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage2OriginalBalanceTextBox, "")
			End If
		End Sub

		Private Sub morgage2NumberOfYearsTextBox_Validating(sender As Object, e As CancelEventArgs) Handles morgage2NumberOfYearsTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(morgage2NumberOfYearsTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(morgage2NumberOfYearsTextBox, "The field morgage2NumberOfYears is required")
			End If
			Dim v As Integer
			Dim s As String = morgage2NumberOfYearsTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(morgage2NumberOfYearsTextBox, "The field morgage2NumberOfYears must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(morgage2NumberOfYearsTextBox, "")
			End If
		End Sub

		Private Sub mortgage3PriceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage3PriceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage3PriceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage3PriceTextBox, "The field mortgage3Price is required")
			End If
			Dim v As Double
			Dim s As String = mortgage3PriceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage3PriceTextBox, "The field mortgage3Price must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage3PriceTextBox, "")
			End If
		End Sub

		Private Sub mortgage3BankTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage3BankTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage3BankTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage3BankTextBox, "The field mortgage3Bank is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage3BankTextBox, "")
			End If
		End Sub

		Private Sub mortgage3ForgivableTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage3ForgivableTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage3ForgivableTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage3ForgivableTextBox, "The field mortgage3Forgivable is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage3ForgivableTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage3ForgivableTextBox, "The field mortgage3Forgivable must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage3ForgivableTextBox, "")
			End If
		End Sub

		Private Sub mortgage3OriginalBalanceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage3OriginalBalanceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage3OriginalBalanceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage3OriginalBalanceTextBox, "The field mortgage3OriginalBalance is required")
			End If
			Dim v As Double
			Dim s As String = mortgage3OriginalBalanceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage3OriginalBalanceTextBox, "The field mortgage3OriginalBalance must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage3OriginalBalanceTextBox, "")
			End If
		End Sub

		Private Sub mortgage3NumberOfYearsTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage3NumberOfYearsTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage3NumberOfYearsTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage3NumberOfYearsTextBox, "The field mortgage3NumberOfYears is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage3NumberOfYearsTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage3NumberOfYearsTextBox, "The field mortgage3NumberOfYears must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage3NumberOfYearsTextBox, "")
			End If
		End Sub

		Private Sub mortgage4PriceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage4PriceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage4PriceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage4PriceTextBox, "The field mortgage4Price is required")
			End If
			Dim v As Double
			Dim s As String = mortgage4PriceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage4PriceTextBox, "The field mortgage4Price must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage4PriceTextBox, "")
			End If
		End Sub

		Private Sub mortgage4BankTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage4BankTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage4BankTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage4BankTextBox, "The field mortgage4Bank is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage4BankTextBox, "")
			End If
		End Sub

		Private Sub mortgage4ForgivableTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage4ForgivableTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage4ForgivableTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage4ForgivableTextBox, "The field mortgage4Forgivable is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage4ForgivableTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage4ForgivableTextBox, "The field mortgage4Forgivable must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage4ForgivableTextBox, "")
			End If
		End Sub

		Private Sub mortgage4OriginalBalanceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage4OriginalBalanceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage4OriginalBalanceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage4OriginalBalanceTextBox, "The field mortgage4OriginalBalance is required")
			End If
			Dim v As Double
			Dim s As String = mortgage4OriginalBalanceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage4OriginalBalanceTextBox, "The field mortgage4OriginalBalance must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage4OriginalBalanceTextBox, "")
			End If
		End Sub

		Private Sub mortgage4NumberOfYearsTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage4NumberOfYearsTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage4NumberOfYearsTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage4NumberOfYearsTextBox, "The field mortgage4NumberOfYears is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage4NumberOfYearsTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage4NumberOfYearsTextBox, "The field mortgage4NumberOfYears must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage4NumberOfYearsTextBox, "")
			End If
		End Sub

		Private Sub mortgage5PriceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage5PriceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage5PriceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage5PriceTextBox, "The field mortgage5Price is required")
			End If
			Dim v As Double
			Dim s As String = mortgage5PriceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage5PriceTextBox, "The field mortgage5Price must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage5PriceTextBox, "")
			End If
		End Sub

		Private Sub mortgage5BankTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage5BankTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage5BankTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage5BankTextBox, "The field mortgage5Bank is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage5BankTextBox, "")
			End If
		End Sub

		Private Sub mortgage5ForgivableTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage5ForgivableTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage5ForgivableTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage5ForgivableTextBox, "The field mortgage5Forgivable is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage5ForgivableTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage5ForgivableTextBox, "The field mortgage5Forgivable must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage5ForgivableTextBox, "")
			End If
		End Sub

		Private Sub mortgage5OriginalBalanceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage5OriginalBalanceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage5OriginalBalanceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage5OriginalBalanceTextBox, "The field mortgage5OriginalBalance is required")
			End If
			Dim v As Double
			Dim s As String = mortgage5OriginalBalanceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage5OriginalBalanceTextBox, "The field mortgage5OriginalBalance must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage5OriginalBalanceTextBox, "")
			End If
		End Sub

		Private Sub mortgage5NumberOfYearsTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage5NumberOfYearsTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage5NumberOfYearsTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage5NumberOfYearsTextBox, "The field mortgage5NumberOfYears is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage5NumberOfYearsTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage5NumberOfYearsTextBox, "The field mortgage5NumberOfYears must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage5NumberOfYearsTextBox, "")
			End If
		End Sub

		Private Sub mortgage6PriceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage6PriceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage6PriceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage6PriceTextBox, "The field mortgage6Price is required")
			End If
			Dim v As Double
			Dim s As String = mortgage6PriceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage6PriceTextBox, "The field mortgage6Price must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage6PriceTextBox, "")
			End If
		End Sub

		Private Sub mortgage6BankTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage6BankTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage6BankTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage6BankTextBox, "The field mortgage6Bank is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage6BankTextBox, "")
			End If
		End Sub

		Private Sub mortgage6ForgivableTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage6ForgivableTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage6ForgivableTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage6ForgivableTextBox, "The field mortgage6Forgivable is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage6ForgivableTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage6ForgivableTextBox, "The field mortgage6Forgivable must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage6ForgivableTextBox, "")
			End If
		End Sub

		Private Sub mortgage6OriginalBalanceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage6OriginalBalanceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage6OriginalBalanceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage6OriginalBalanceTextBox, "The field mortgage6OriginalBalance is required")
			End If
			Dim v As Double
			Dim s As String = mortgage6OriginalBalanceTextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage6OriginalBalanceTextBox, "The field mortgage6OriginalBalance must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage6OriginalBalanceTextBox, "")
			End If
		End Sub

		Private Sub mortgage6NumberOfYearsTextBox_Validating(sender As Object, e As CancelEventArgs) Handles mortgage6NumberOfYearsTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(mortgage6NumberOfYearsTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage6NumberOfYearsTextBox, "The field mortgage6NumberOfYears is required")
			End If
			Dim v As Integer
			Dim s As String = mortgage6NumberOfYearsTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(mortgage6NumberOfYearsTextBox, "The field mortgage6NumberOfYears must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(mortgage6NumberOfYearsTextBox, "")
			End If
		End Sub


		Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
			trackingBindingSource.AddNew()
		End Sub

	End Class
	
End Namespace