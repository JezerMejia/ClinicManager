Imports ClinicManager.Entities

Public Class Form1
    Private loggedInUser As RegisteredUser = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim result = False
        If Me.loggedInUser Is Nothing Then
            result = Me.validateLogin()
        End If

        If result = True Then
            Me.InitStuff()
            Me.Show()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub InitStuff()
        Me.AboutUser1.user = Me.loggedInUser

        If TypeOf Me.loggedInUser Is Medic Then
            Me.AppointmentsTable1.currentMedic = loggedInUser
        End If
    End Sub

    Private Function validateLogin()
        Dim loginForm As New Login
        Dim result As DialogResult = loginForm.ShowDialog()
        Dim user = loginForm.loggedInUser

        If result = DialogResult.OK And user IsNot Nothing Then
            Me.loggedInUser = user
            MsgBox($"Iniciaste sesión como {user.FullName}", MsgBoxStyle.OkOnly, "Inicio de sesión exitoso")
            Return True
        End If

        MsgBox("Ocurrió un error inesperado", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error de inicio de sesión")
        Return False
    End Function
End Class
