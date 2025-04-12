Public Class Appointment
    Public Property Id As Integer
    Public Property Description As String
    Public Property CreatedAt As DateTime = DateTime.Now
    Public Property AttendAt As DateTime
    Public Property Prescription As String
    Public Property Diagnostic As String

    Public Property PatientId As Integer
    Public Property MedicId As Integer

    Public Overridable Property Patient As Patient
    Public Overridable Property Medic As Medic

    Public ReadOnly Property PatientName As String
        Get
            Return Patient.FullName
        End Get
    End Property
    Public ReadOnly Property MedicName As String
        Get
            Return Medic.FullName
        End Get
    End Property
End Class
