Public Class Medic
    Inherits RegisteredUser

    Public Overridable Property Appointments As List(Of Appointment)
    Public Overridable Property Specialties As List(Of Specialty)
End Class
