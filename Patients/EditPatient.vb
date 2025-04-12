Imports System.ComponentModel
Imports ClinicManager.Entities
Imports Microsoft.EntityFrameworkCore

Public Class EditPatient
    Public Property patient As Patient

    Private Sub NewPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpBirthday.MaxDate = Date.Now

        AddHandler Me.txtIdentifier.KeyPress, Validator.limit_length_with(14)
        AddHandler Me.txtPhone.KeyPress, Validator.limit_length_with(8)
        AddHandler Me.txtPhone.KeyPress, AddressOf Validator.only_integer

        Me.ResetData()
    End Sub

    Private Sub ResetData()
        Me.txtFirstName.Text = Me.patient.FirstName
        Me.txtLastName.Text = Me.patient.LastName
        Me.txtEmail.Text = Me.patient.Email
        Me.txtPhone.Text = Me.patient.Phone
        Me.txtIdentifier.Text = Me.patient.Identifier
        Me.dtpBirthday.Value = Me.patient.Birthday

        If Me.patient.Sex = 0 Then
            Me.cmbSex.SelectedItem = "Mujer"
        Else
            Me.cmbSex.SelectedItem = "Hombre"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Me.ResetData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim FirstName = Me.txtFirstName.Text
        Dim LastName = Me.txtLastName.Text
        Dim Email = Me.txtEmail.Text
        Dim Phone = Me.txtPhone.Text
        Dim Identifier = Me.txtIdentifier.Text
        Dim Birthday = Me.dtpBirthday.Value.Date
        Dim SexText = Me.cmbSex.SelectedItem

        If Validator.strings_are_empty(FirstName, LastName, Email, Phone, Identifier, SexText) Then
            MsgBox("Ingresa los campos del formulario", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        If Not Validator.is_email(Email) Then
            MsgBox("El correo ingresado no es válido", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        Dim Sex = 0
        If SexText = "Hombre" Then
            Sex = 1
        End If

        Me.patient.FirstName = FirstName
        Me.patient.LastName = LastName
        Me.patient.Email = Email
        Me.patient.Phone = Phone
        Me.patient.Identifier = Identifier
        Me.patient.Birthday = Birthday
        Me.patient.Sex = Sex

        Using db As New AppDbContext()
            db.Attach(Me.patient)
            db.Entry(Me.patient).State = EntityState.Modified
            db.SaveChanges()
        End Using

        Me.Close()
    End Sub
End Class