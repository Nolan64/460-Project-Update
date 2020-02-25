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
	
	Public Class frmgeneral

		Private ctx As mydbEntities1

		Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
			ctx = New mydbEntities1()
			ctx.generals.Load()
			Dim _entities As BindingList(Of general) = ctx.generals.Local.ToBindingList()
			generalBindingSource.DataSource = _entities
			Me.UIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "UID", True))
			Me.firstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "firstName", True))
			Me.lastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "lastName", True))
			Me.inquiryDate_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "inquiryDate", True))
			Me.streetAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "streetAddress", True))
			Me.cityAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "cityAddress", True))
			Me.zipAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "zipAddress", True))
			Me.stateAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "stateAddress", True))
			Me.countryAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "countryAddress", True))
			Me.phoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "phoneNumber", True))
			Me.emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "email", True))
			Me.genderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "gender", True))
			Me.birthdate_dateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "birthdate", True))
			Me.householdSizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "householdSize", True))
			Me.householdAMITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "householdAMI", True))
			Me.raceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "race", True))
			Me.maritalStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "maritalStatus", True))
			Me.notesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.generalBindingSource, "notes", True))
		End Sub

		Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
			If Not Me.Validate() Then
				Return
			End If
			generalBindingSource.EndEdit()
			Try
				ctx.SaveChanges()

			Catch
				MessageBox.Show("Please enter valid data")

			End Try
		End Sub

		Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = False
		End Sub

		Private Sub UIDTextBox_Validating(sender As Object, e As CancelEventArgs) Handles UIDTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(UIDTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(UIDTextBox, "The field UID is required")
			End If
			Dim v As Integer
			Dim s As String = UIDTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(UIDTextBox, "The field UID must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(UIDTextBox, "")
			End If
		End Sub

		Private Sub firstNameTextBox_Validating(sender As Object, e As CancelEventArgs) Handles firstNameTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(firstNameTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(firstNameTextBox, "The field firstName is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(firstNameTextBox, "")
			End If
		End Sub

		Private Sub lastNameTextBox_Validating(sender As Object, e As CancelEventArgs) Handles lastNameTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(lastNameTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(lastNameTextBox, "The field lastName is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(lastNameTextBox, "")
			End If
		End Sub

		Private Sub streetAddressTextBox_Validating(sender As Object, e As CancelEventArgs) Handles streetAddressTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(streetAddressTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(streetAddressTextBox, "The field streetAddress is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(streetAddressTextBox, "")
			End If
		End Sub

		Private Sub cityAddressTextBox_Validating(sender As Object, e As CancelEventArgs) Handles cityAddressTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(cityAddressTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(cityAddressTextBox, "The field cityAddress is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(cityAddressTextBox, "")
			End If
		End Sub

		Private Sub zipAddressTextBox_Validating(sender As Object, e As CancelEventArgs) Handles zipAddressTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(zipAddressTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(zipAddressTextBox, "The field zipAddress is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(zipAddressTextBox, "")
			End If
		End Sub

		Private Sub stateAddressTextBox_Validating(sender As Object, e As CancelEventArgs) Handles stateAddressTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(stateAddressTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(stateAddressTextBox, "The field stateAddress is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(stateAddressTextBox, "")
			End If
		End Sub

		Private Sub countryAddressTextBox_Validating(sender As Object, e As CancelEventArgs) Handles countryAddressTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(countryAddressTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(countryAddressTextBox, "The field countryAddress is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(countryAddressTextBox, "")
			End If
		End Sub

		Private Sub phoneNumberTextBox_Validating(sender As Object, e As CancelEventArgs) Handles phoneNumberTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(phoneNumberTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(phoneNumberTextBox, "The field phoneNumber is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(phoneNumberTextBox, "")
			End If
		End Sub

		Private Sub emailTextBox_Validating(sender As Object, e As CancelEventArgs) Handles emailTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(emailTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(emailTextBox, "The field email is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(emailTextBox, "")
			End If
		End Sub

		Private Sub genderTextBox_Validating(sender As Object, e As CancelEventArgs) Handles genderTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(genderTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(genderTextBox, "The field gender is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(genderTextBox, "")
			End If
		End Sub

		Private Sub householdSizeTextBox_Validating(sender As Object, e As CancelEventArgs) Handles householdSizeTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(householdSizeTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(householdSizeTextBox, "The field householdSize is required")
			End If
			Dim v As Integer
			Dim s As String = householdSizeTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(householdSizeTextBox, "The field householdSize must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(householdSizeTextBox, "")
			End If
		End Sub

		Private Sub householdAMITextBox_Validating(sender As Object, e As CancelEventArgs) Handles householdAMITextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(householdAMITextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(householdAMITextBox, "The field householdAMI is required")
			End If
			Dim v As Double
			Dim s As String = householdAMITextBox.Text
			If Not Double.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(householdAMITextBox, "The field householdAMI must be Double.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(householdAMITextBox, "")
			End If
		End Sub

		Private Sub raceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles raceTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(raceTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(raceTextBox, "The field race is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(raceTextBox, "")
			End If
		End Sub

		Private Sub maritalStatusTextBox_Validating(sender As Object, e As CancelEventArgs) Handles maritalStatusTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(maritalStatusTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(maritalStatusTextBox, "The field maritalStatus is required")
			End If
			Dim v As Integer
			Dim s As String = maritalStatusTextBox.Text
			If Not Integer.TryParse(s, v) Then
				e.Cancel = True
				ErrorProvider1.SetError(maritalStatusTextBox, "The field maritalStatus must be Integer.")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(maritalStatusTextBox, "")
			End If
		End Sub

		Private Sub notesTextBox_Validating(sender As Object, e As CancelEventArgs) Handles notesTextBox.Validating

			e.Cancel = False
			If String.IsNullOrEmpty(notesTextBox.Text) Then
				e.Cancel = True
				ErrorProvider1.SetError(notesTextBox, "The field notes is required")
			End If
			If Not e.Cancel Then
				ErrorProvider1.SetError(notesTextBox, "")
			End If
		End Sub


		Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
			generalBindingSource.AddNew()
		End Sub

	End Class
	
End Namespace