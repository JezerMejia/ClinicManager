Imports System.ComponentModel
Imports ClinicManager.Entities
Imports Microsoft.EntityFrameworkCore

Public Class EditAppointment
    Public Property appointment As Appointment
    Public Property selectedPatient As Patient
    Public Property selectedMedic As Medic

    Public Property enableMedicSelection As Boolean = False

    Private Sub NewPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpAttendDate.MinDate = Date.Now

        Me.GroupBox2.Enabled = Me.enableMedicSelection

        Me.ResetData()
        Me.SetupData()
    End Sub

    Private Sub ResetData()
        Me.selectedMedic = Me.appointment.Medic
        Me.selectedPatient = Me.appointment.Patient

        Me.txtDescription.Text = Me.appointment.Description
        Me.txtDiagnostic.Text = Me.appointment.Diagnostic
        Me.txtPrescription.Text = Me.appointment.Prescription
    End Sub

    Private Sub SetupData()
        If Me.selectedPatient IsNot Nothing Then
            Me.lbPatientData.Text = Me.selectedPatient.FullName
        Else
            Me.lbPatientData.Text = "Selecciona..."
        End If

        If Me.selectedMedic IsNot Nothing Then
            Me.lbMedicData.Text = Me.selectedMedic.FullName
        Else
            Me.lbMedicData.Text = "Selecciona..."
        End If
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Me.ResetData()
        Me.SetupData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim description = Me.txtDescription.Text
        Dim attendAt = Me.dtpAttendDate.Value

        If Me.selectedPatient Is Nothing Then
            MsgBox("Selecciona un paciente", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Return
        End If
        If Me.selectedMedic Is Nothing Then
            MsgBox("Selecciona un médico", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        Dim diagnostic = Me.txtDiagnostic.Text
        Dim prescription = Me.txtPrescription.Text

        If Validator.strings_are_empty(diagnostic, prescription) Then
            MsgBox("Añade un diagnóstico y prescripción", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        Me.appointment.Description = description
        Me.appointment.AttendAt = attendAt
        Me.appointment.PatientId = Me.selectedPatient.Id
        Me.appointment.MedicId = Me.selectedMedic.Id

        Me.appointment.Diagnostic = diagnostic
        Me.appointment.Prescription = prescription

        Using db As New AppDbContext()
            db.Attach(Me.appointment)
            db.Entry(Me.appointment).State = EntityState.Modified
            db.SaveChanges()
        End Using

        Me.Close()
    End Sub

    Private Sub btnPatientSearch_Click(sender As Object, e As EventArgs) Handles btnPatientSearch.Click
        Dim identifier = InputBox("Ingresa la cédula del paciente:", "Buscar paciente")

        If String.IsNullOrWhiteSpace(identifier) Then
            Return
        End If

        Using db As New AppDbContext()
            Dim patient = db.Patients.Where(Function(p) p.Identifier = identifier).SingleOrDefault()
            If patient Is Nothing Then
                MsgBox($"No se encontró al paciente con la cédula {identifier}", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Else
                Me.selectedPatient = patient
            End If
        End Using

        Me.SetupData()
    End Sub

    Private Sub btnMedicSearch_Click(sender As Object, e As EventArgs) Handles btnMedicSearch.Click
        Dim identifier = InputBox("Ingresa la cédula del médico:", "Buscar médico")

        If String.IsNullOrWhiteSpace(identifier) Then
            Return
        End If

        Using db As New AppDbContext()
            Dim medic = db.Medics.Where(Function(p) p.Identifier = identifier).SingleOrDefault()
            If medic IsNot Nothing Then
                Me.selectedMedic = medic
            End If
        End Using

        Me.SetupData()
    End Sub
End Class