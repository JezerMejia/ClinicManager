Imports System.ComponentModel
Imports ClinicManager.Entities

Public Class PatientsTable
    Dim bindingList As BindingList(Of Patient)
    Dim selectedPatient As Patient = Nothing

    Private Sub PatientsTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime Then
            Return
        End If

        Me.UpdateData()

        AddHandler bindingList.ListChanged, AddressOf BindingList_ListChanged
    End Sub

    Private Sub UpdateData()
        Using db As New AppDbContext()
            Me.bindingList = New BindingList(Of Patient)(db.Patients.ToList())
            Me.PatientBindingSource.DataSource = Me.bindingList

            Me.lbCount.Text = $"Cantidad: {Me.bindingList.Count}"
        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim search = Me.TextBox1.Text.ToLower()

        If String.IsNullOrWhiteSpace(search) Then
            PatientBindingSource.DataSource = Me.bindingList
            Return
        End If

        Dim filtered = Me.bindingList.Where(Function(p) p.FullName IsNot Nothing AndAlso p.FullName.ToLower().Contains(search) OrElse p.Identifier IsNot Nothing AndAlso p.Identifier.ToLower().Contains(search) OrElse p.Email IsNot Nothing AndAlso p.Email.ToLower().Contains(search)).ToList()

        PatientBindingSource.DataSource = filtered
    End Sub

    Private Sub btnNewPatient_Click(sender As Object, e As EventArgs) Handles btnNewPatient.Click
        Dim newPatient As New NewPatient
        newPatient.bindingList = Me.bindingList

        newPatient.Show()
    End Sub

    Private Sub BindingList_ListChanged(sender As Object, e As ListChangedEventArgs)
        Me.lbCount.Text = $"Cantidad: {Me.bindingList.Count}"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show(
            $"¿Estás seguro/a de eliminar a este paciente? Se eliminará a {Me.selectedPatient.FullName}.",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result <> DialogResult.Yes Then
            Return
        End If

        Using db As New AppDbContext()
            db.Patients.Remove(Me.selectedPatient)
            db.SaveChanges()
        End Using
        Me.bindingList.Remove(Me.selectedPatient)
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim current = Me.PatientBindingSource.Current
        Me.selectedPatient = current

        Dim enabled = current IsNot Nothing
        Me.btnEdit.Enabled = enabled
        Me.btnDelete.Enabled = enabled
    End Sub

    Private Sub btnMedicRecords_Click(sender As Object, e As EventArgs) Handles btnMedicRecords.Click
        Dim medicalRecords As New MedicalRecords
        medicalRecords.patient = Me.selectedPatient

        medicalRecords.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editPatient As New EditPatient
        editPatient.patient = Me.selectedPatient

        editPatient.Show()
    End Sub
End Class
