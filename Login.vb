Imports ClinicManager.Entities

Public Class Login
    Public Property loggedInUser As RegisteredUser = Nothing
    Private Sub executeLogin()
        Dim email As String = Me.txtEmail.Text
        Dim password As String = Me.txtPassword.Text

        Dim foundUser As RegisteredUser

        Using db As New AppDbContext()
            ' No hay seguridad acá
            foundUser = db.RegisteredUsers.Where(Function(u) u.Email = email And u.Password = password).FirstOrDefault
        End Using

        If foundUser Is Nothing Then
            MsgBox("Credenciales incorrectas", MsgBoxStyle.OkOnly, "Error de inicio de sesión")
            Return
        End If

        Me.txtEmail.Clear()
        Me.txtPassword.Clear()

        Me.DialogResult = DialogResult.OK
        Me.loggedInUser = foundUser
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        executeLogin()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            executeLogin()
        End If
    End Sub
End Class
