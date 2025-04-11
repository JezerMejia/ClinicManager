Public Class Login
    Public Property loggedInUser = Nothing
    Private Sub executeLogin()
        Dim user As String = Me.txtUser.Text
        Dim password As String = Me.txtPassword.Text

        If user <> "admin" Or password <> "Usuario123." Then
            MsgBox("Credenciales incorrectas", MsgBoxStyle.OkOnly, "Error de inicio de sesión")
            Return
        End If

        Me.txtUser.Clear()
        Me.txtPassword.Clear()

        Me.DialogResult = DialogResult.OK
        Me.loggedInUser = user
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
