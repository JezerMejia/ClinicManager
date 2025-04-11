Public Class Appointment
    Public Property Id As Integer
    Public Property Description As String
    Public Property CreatedAt As DateTime = DateTime.Now
    Public Property AttendAt As DateTime
    Public Property Prescription As String
    Public Property Diagnostic As String

    Public Overridable Property Patient As Patient
    Public Overridable Property Medic As Medic
End Class
