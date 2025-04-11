Public Class Form1
    Private loggedInUser = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        If Me.loggedInUser Is Nothing Then
            Me.validateLogin()
        End If

        Me.Show()
    End Sub

    Private Sub validateLogin()
        Dim loginForm As New Login
        Dim result As DialogResult = loginForm.ShowDialog()
        Dim user = loginForm.loggedInUser

        If result = DialogResult.OK And user IsNot Nothing Then
            Me.loggedInUser = user
            Return
        End If

        MsgBox("Ocurrió un error inesperado", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error de inicio de sesión")
    End Sub
End Class
