Imports System.ComponentModel
Imports ClinicManager.Entities

Public Class NewPatient
    Public Property bindingList As BindingList(Of Patient)

    Private Sub NewPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpBirthday.MaxDate = Date.Now
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtFirstName.Clear()
        Me.txtLastName.Clear()
        Me.txtEmail.Clear()
        Me.txtPhone.Clear()
        Me.txtIdentifier.Clear()
        Me.dtpBirthday.Value = Nothing
        Me.cmbSex.SelectedIndex = -1
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

        Dim Sex = 0
        If SexText = "Hombre" Then
            Sex = 1
        End If

        Dim patient As New Patient With {
            .FirstName = FirstName,
            .LastName = LastName,
            .Email = Email,
            .Phone = Phone,
            .Identifier = Identifier,
            .Birthday = Birthday,
            .Sex = Sex
            }

        Using db As New AppDbContext()
            db.Patients.Add(patient)
            db.SaveChanges()
        End Using
        Me.bindingList.Add(patient)

        Me.Close()
    End Sub
End Class