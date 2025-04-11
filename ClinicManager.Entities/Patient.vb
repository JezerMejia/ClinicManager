Public Class Patient
    Inherits User

    Public Property Birthday As Date

    Public Overridable Property MedicalRecords As List(Of MedicalRecord)
    Public Overridable Property Appointments As List(Of Appointment)
End Class
