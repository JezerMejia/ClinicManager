Imports System.ComponentModel.DataAnnotations

Public Class Specialty
    <Key>
    Public Property Name As String
    Public Property Description As String

    Public Overridable Property Medics As List(Of Medic)
End Class
