Public Class Medic
    Inherits RegisteredUser

    Public Overridable Property Appointments As List(Of Appointment)
    Public Overridable Property Specialties As List(Of Specialty)

    Public ReadOnly Property SpecialtiesString As String
        Get
            If Me.Specialties Is Nothing Then
                Return ""
            End If

            Return String.Join(", ", Me.Specialties.Select(Function(s) s.Description))
        End Get
    End Property
End Class
