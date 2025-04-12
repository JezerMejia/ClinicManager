Imports System.ComponentModel
Imports ClinicManager.Entities

Public Class NewMedicalRecord
    Public Property patient As Patient
    Public Property bindingList As BindingList(Of MedicalRecord)

    Private Sub NewMedicalRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime Then
            Return
        End If

        Me.lbPatientData.Text = $"Paciente {patient.FullName} - {patient.Identifier}"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtDescription.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim description = Me.txtDescription.Text

        If Validator.strings_are_empty(description) Then
            MsgBox("Ingresa una descripción", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        Dim medicalRecord As New MedicalRecord With {
            .Description = description,
            .PatientId = patient.Id
            }

        Using db As New AppDbContext()
            db.MedicalRecords.Add(medicalRecord)
            db.SaveChanges()
        End Using

        Me.bindingList.Add(medicalRecord)

        Me.Close()
    End Sub
End Class