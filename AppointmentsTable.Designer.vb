<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppointmentsTable
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        DataGridView1 = New DataGridView()
        AppointmentBindingSource = New BindingSource(components)
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        btnNewAppointment = New Button()
        Panel2 = New Panel()
        lbCount = New Label()
        btnDelete = New Button()
        btnEdit = New Button()
        IdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Description = New DataGridViewTextBoxColumn()
        AttendAt = New DataGridViewTextBoxColumn()
        PatientName = New DataGridViewTextBoxColumn()
        MedicName = New DataGridViewTextBoxColumn()
        CreatedAt = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(AppointmentBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {IdDataGridViewTextBoxColumn, Description, AttendAt, PatientName, MedicName, CreatedAt})
        DataGridView1.DataSource = AppointmentBindingSource
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 48)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(684, 251)
        DataGridView1.TabIndex = 0
        ' 
        ' AppointmentBindingSource
        ' 
        AppointmentBindingSource.DataSource = GetType(Entities.Appointment)
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(btnNewAppointment)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(684, 48)
        Panel1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 12)
        TextBox1.Margin = New Padding(12)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Buscar..."
        TextBox1.Size = New Size(148, 23)
        TextBox1.TabIndex = 1
        ' 
        ' btnNewAppointment
        ' 
        btnNewAppointment.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNewAppointment.Location = New Point(537, 12)
        btnNewAppointment.Margin = New Padding(12)
        btnNewAppointment.Name = "btnNewAppointment"
        btnNewAppointment.Size = New Size(135, 23)
        btnNewAppointment.TabIndex = 0
        btnNewAppointment.Text = "Nueva cita médica"
        btnNewAppointment.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lbCount)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnEdit)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 299)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(684, 48)
        Panel2.TabIndex = 2
        ' 
        ' lbCount
        ' 
        lbCount.AutoSize = True
        lbCount.Location = New Point(12, 21)
        lbCount.Margin = New Padding(12)
        lbCount.Name = "lbCount"
        lbCount.Size = New Size(43, 15)
        lbCount.TabIndex = 2
        lbCount.Text = "Count:"
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnDelete.Location = New Point(597, 13)
        btnDelete.Margin = New Padding(12)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEdit.Location = New Point(498, 13)
        btnEdit.Margin = New Padding(12)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 0
        btnEdit.Text = "Editar"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' IdDataGridViewTextBoxColumn
        ' 
        IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        IdDataGridViewTextBoxColumn.HeaderText = "ID"
        IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        IdDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' Description
        ' 
        Description.DataPropertyName = "Description"
        Description.HeaderText = "Descripción"
        Description.Name = "Description"
        Description.ReadOnly = True
        ' 
        ' AttendAt
        ' 
        AttendAt.DataPropertyName = "AttendAt"
        AttendAt.HeaderText = "Fecha"
        AttendAt.Name = "AttendAt"
        AttendAt.ReadOnly = True
        ' 
        ' PatientName
        ' 
        PatientName.DataPropertyName = "PatientName"
        PatientName.HeaderText = "Paciente"
        PatientName.Name = "PatientName"
        PatientName.ReadOnly = True
        ' 
        ' MedicName
        ' 
        MedicName.DataPropertyName = "MedicName"
        MedicName.HeaderText = "Médico"
        MedicName.Name = "MedicName"
        MedicName.ReadOnly = True
        ' 
        ' CreatedAt
        ' 
        CreatedAt.DataPropertyName = "CreatedAt"
        CreatedAt.HeaderText = "Fecha de Creación"
        CreatedAt.Name = "CreatedAt"
        CreatedAt.ReadOnly = True
        CreatedAt.Width = 150
        ' 
        ' AppointmentsTable
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "AppointmentsTable"
        Size = New Size(684, 347)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(AppointmentBindingSource, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNewAppointment As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lbCount As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents AttendAt As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents MedicName As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAt As DataGridViewTextBoxColumn

End Class
