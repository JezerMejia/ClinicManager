Imports System.ComponentModel
Imports ClinicManager.Entities
Imports Microsoft.EntityFrameworkCore

Public Class AppointmentsTable
    Public Property currentMedic As Medic

    Dim bindingList As BindingList(Of Appointment)
    Dim selectedAppointment As Appointment = Nothing

    Private Sub PatientsTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime Then
            Return
        End If

        Me.UpdateData()

        AddHandler bindingList.ListChanged, AddressOf BindingList_ListChanged
    End Sub

    Private Sub UpdateData()
        Using db As New AppDbContext()
            Me.bindingList = New BindingList(Of Appointment)(
                db.Appointments.
                Include(Function(a) a.Medic).
                Include(Function(a) a.Patient).
                ToList())
            Me.AppointmentBindingSource.DataSource = Me.bindingList

            Me.lbCount.Text = $"Cantidad: {Me.bindingList.Count}"
        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim search = Me.TextBox1.Text.ToLower()

        If String.IsNullOrWhiteSpace(search) Then
            AppointmentBindingSource.DataSource = Me.bindingList
            Return
        End If

        Dim filtered = Me.bindingList.Where(Function(p) p.Description IsNot Nothing AndAlso p.Description.ToLower().Contains(search) OrElse p.MedicName IsNot Nothing AndAlso p.MedicName.ToLower().Contains(search) OrElse p.PatientName IsNot Nothing AndAlso p.PatientName.ToLower().Contains(search)).ToList()

        AppointmentBindingSource.DataSource = filtered
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim current = Me.AppointmentBindingSource.Current
        Me.selectedAppointment = current

        Dim enabled = current IsNot Nothing
        Me.btnEdit.Enabled = enabled
        Me.btnDelete.Enabled = enabled
    End Sub

    Private Sub BindingList_ListChanged(sender As Object, e As ListChangedEventArgs)
        Me.lbCount.Text = $"Cantidad: {Me.bindingList.Count}"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show(
            $"¿Estás seguro/a de eliminar esta cita médica? (ID: {Me.selectedAppointment.Id})",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result <> DialogResult.Yes Then
            Return
        End If

        Using db As New AppDbContext()
            db.Appointments.Remove(Me.selectedAppointment)
            db.SaveChanges()
        End Using
        Me.bindingList.Remove(Me.selectedAppointment)
    End Sub

    Private Sub btnNewAppointment_Click(sender As Object, e As EventArgs) Handles btnNewAppointment.Click
        Dim newAppointment As New NewAppointment
        newAppointment.bindingList = Me.bindingList
        newAppointment.selectedMedic = Me.currentMedic

        newAppointment.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editAppointment As New EditAppointment
        editAppointment.appointment = Me.selectedAppointment

        editAppointment.Show()
    End Sub
End Class
