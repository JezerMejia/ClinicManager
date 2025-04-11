Public Class User
    Public Property Id As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property Identifier As String
    Public Property Phone As String
    Public Property Sex As Integer

    Public ReadOnly Property FullName As String
        Get
            Return (FirstName & " " & LastName).Trim()
        End Get
    End Property
End Class
