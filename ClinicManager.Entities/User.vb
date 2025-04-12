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

    Public ReadOnly Property SexName As String
        Get
            If Sex = 0 Then
                Return "Mujer"
            ElseIf Sex = 1 Then
                Return "Hombre"
            End If
            Return "No definido"
        End Get
    End Property
End Class
