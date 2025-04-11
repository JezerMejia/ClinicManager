Public Class MedicalRecord
    Public Property Id As Integer
    Public Property PatientId As Integer

    Public Property Description As String
    Public Property CreatedAt As DateTime = DateTime.Now

    Public Overridable Property Patient As Patient
End Class
