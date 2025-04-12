Imports System.ComponentModel
Imports ClinicManager.Entities

Public Class AboutUser
    Public Property user As User

    Private Sub AboutUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime Then
            Return
        End If

        Dim information = $"
Nombre: {user.FullName}
Cédula: {user.Identifier}
Email: {user.Email}
Teléfono: {user.Phone}
Sexo: {user.SexName}
         "

        If TypeOf user Is Medic Then

            Dim medic As Medic = Me.user
            Using db As New AppDbContext()
                db.Attach(medic)
                db.Entry(medic).Collection(Function(m) m.Specialties).Load()
            End Using

            information += $"
Tipo: Médico
Especialidades: {medic.SpecialtiesString}
"
        End If

        Me.lbInfo.Text = information
    End Sub

End Class
