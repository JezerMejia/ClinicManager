Imports System.ComponentModel.DataAnnotations

Public Class Specialty
    <Key>
    Public Property Name As String
    Public Property Description As String

    Public Overridable Property Medic As Medic
End Class
