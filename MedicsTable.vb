Imports System.ComponentModel
Imports ClinicManager.Entities

Public Class MedicsTable
    Dim bindingList As BindingList(Of Medic)
    Dim selectedMedic As Medic = Nothing

    Private Sub MedicsTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime Then
            Return
        End If

        Me.UpdateData()

        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False
        Me.btnNewMedic.Enabled = False

        AddHandler bindingList.ListChanged, AddressOf BindingList_ListChanged
    End Sub

    Private Sub UpdateData()
        Using db As New AppDbContext()
            Me.bindingList = New BindingList(Of Medic)(db.Medics.ToList())
            Me.MedicBindingSource.DataSource = Me.bindingList

            Me.lbCount.Text = $"Cantidad: {Me.bindingList.Count}"
        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim search = Me.TextBox1.Text.ToLower()

        If String.IsNullOrWhiteSpace(search) Then
            MedicBindingSource.DataSource = Me.bindingList
            Return
        End If

        Dim filtered = Me.bindingList.Where(Function(p) p.FullName IsNot Nothing AndAlso p.FullName.ToLower().Contains(search) OrElse p.Identifier IsNot Nothing AndAlso p.Identifier.ToLower().Contains(search) OrElse p.Email IsNot Nothing AndAlso p.Email.ToLower().Contains(search)).ToList()

        MedicBindingSource.DataSource = filtered
    End Sub

    Private Sub BindingList_ListChanged(sender As Object, e As ListChangedEventArgs)
        Me.lbCount.Text = $"Cantidad: {Me.bindingList.Count}"
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim current = Me.MedicBindingSource.Current
        Me.selectedMedic = current

        ' Dim enabled = current IsNot Nothing
        ' Me.btnEdit.Enabled = enabled
        ' Me.btnDelete.Enabled = enabled
    End Sub
End Class
