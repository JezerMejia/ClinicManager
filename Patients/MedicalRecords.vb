Imports System.ComponentModel
Imports ClinicManager.Entities

Public Class MedicalRecords
    Public Property patient As Patient

    Dim bindingList As BindingList(Of MedicalRecord)
    Dim selectedRecord As MedicalRecord = Nothing

    Private Sub MedicalRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime Then
            Return
        End If

        Me.lbPatientData.Text = $"Paciente {patient.FullName} - {patient.Identifier}"

        Me.UpdateData()

        AddHandler bindingList.ListChanged, AddressOf BindingList_ListChanged
    End Sub

    Private Sub UpdateData()
        Using db As New AppDbContext()
            Me.bindingList = New BindingList(Of MedicalRecord)(db.MedicalRecords.Where(Function(m) m.PatientId = Me.patient.Id).ToList())
            Me.MedicalRecordBindingSource.DataSource = bindingList

            Me.lbCount.Text = $"Cantidad: {bindingList.Count}"
        End Using
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim current = Me.MedicalRecordBindingSource.Current
        Me.selectedRecord = current

        Dim enabled = current IsNot Nothing
        Me.btnEdit.Enabled = enabled
        Me.btnDelete.Enabled = enabled
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show(
            $"¿Estás seguro/a de eliminar este registro? (ID: {Me.selectedRecord.Id})",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result <> DialogResult.Yes Then
            Return
        End If

        Using db As New AppDbContext()
            db.MedicalRecords.Remove(Me.selectedRecord)
            db.SaveChanges()
        End Using
        Me.bindingList.Remove(Me.selectedRecord)
    End Sub
    Private Sub BindingList_ListChanged(sender As Object, e As ListChangedEventArgs)
        Me.lbCount.Text = $"Cantidad: {Me.bindingList.Count}"
    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        Dim newMedicalRecord As New NewMedicalRecord
        newMedicalRecord.patient = Me.patient
        newMedicalRecord.bindingList = Me.bindingList

        newMedicalRecord.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editMedicalRecord As New EditMedicalRecord
        editMedicalRecord.patient = Me.patient
        editMedicalRecord.record = Me.selectedRecord

        editMedicalRecord.Show()
    End Sub
End Class