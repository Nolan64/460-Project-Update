'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace DatabaseTestApplication2

    Partial Public Class general
        Public Property UID As Integer
        Public Property firstName As String
        Public Property lastName As String
        Public Property inquiryDate As Nullable(Of Date)
        Public Property streetAddress As String
        Public Property cityAddress As String
        Public Property zipAddress As String
        Public Property stateAddress As String
        Public Property countryAddress As String
        Public Property phoneNumber As String
        Public Property email As String
        Public Property gender As String
        Public Property birthdate As Nullable(Of Date)
        Public Property householdSize As Nullable(Of Integer)
        Public Property householdAMI As Nullable(Of Double)
        Public Property race As String
        Public Property maritalStatus As Nullable(Of SByte)
        Public Property notes As String
    
        Public Overridable Property homeownership As homeownership
        Public Overridable Property repair As repair
        Public Overridable Property tracking As tracking
    
    End Class

End Namespace
