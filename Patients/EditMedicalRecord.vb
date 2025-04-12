Imports System.ComponentModel
Imports ClinicManager.Entities
Imports Microsoft.EntityFrameworkCore

Public Class EditMedicalRecord
    Public Property patient As Patient
    Public Property record As MedicalRecord

    Private Sub NewMedicalRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime Then
            Return
        End If

        Me.lbPatientData.Text = $"Paciente {patient.FullName} - {patient.Identifier}"

        Me.ResetData()
    End Sub

    Private Sub ResetData()
        Me.txtDescription.Text = record.Description
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.ResetData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim description = Me.txtDescription.Text

        If Validator.strings_are_empty(description) Then
            MsgBox("Ingresa una descripción", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        Me.record.Description = description

        Using db As New AppDbContext()
            db.Attach(Me.record)
            db.Entry(Me.record).Property(Function(p) p.Description).IsModified = True
            db.SaveChanges()
        End Using

        Me.Close()
    End Sub
End Class