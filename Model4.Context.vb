﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Namespace DatabaseTestApplication2

    Partial Public Class mydbEntities4
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=mydbEntities4")
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Overridable Property generals() As DbSet(Of general)
        Public Overridable Property homeownerships() As DbSet(Of homeownership)
        Public Overridable Property repairs() As DbSet(Of repair)
        Public Overridable Property surveys() As DbSet(Of survey)
        Public Overridable Property survey_results() As DbSet(Of survey_results)
        Public Overridable Property trackings() As DbSet(Of tracking)
        Public Overridable Property users() As DbSet(Of user)
        Public Overridable Property all_table_vw() As DbSet(Of all_table_vw)
    
    End Class

End Namespace
