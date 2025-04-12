<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicalRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        lbPatientData = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        IdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CreatedAtDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        DescriptionDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        MedicalRecordBindingSource = New BindingSource(components)
        btnNewRecord = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        lbCount = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(MedicalRecordBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Honeydew
        Panel1.Controls.Add(lbPatientData)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(488, 97)
        Panel1.TabIndex = 2
        ' 
        ' lbPatientData
        ' 
        lbPatientData.AutoSize = True
        lbPatientData.Location = New Point(21, 63)
        lbPatientData.Name = "lbPatientData"
        lbPatientData.Size = New Size(71, 15)
        lbPatientData.TabIndex = 1
        lbPatientData.Text = "Patient Data"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.Location = New Point(21, 21)
        Label1.Margin = New Padding(12)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 30)
        Label1.TabIndex = 0
        Label1.Text = "Historial Médico"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {IdDataGridViewTextBoxColumn, CreatedAtDataGridViewTextBoxColumn, DescriptionDataGridViewTextBoxColumn})
        DataGridView1.DataSource = MedicalRecordBindingSource
        DataGridView1.Location = New Point(21, 112)
        DataGridView1.Margin = New Padding(12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(446, 288)
        DataGridView1.TabIndex = 3
        ' 
        ' IdDataGridViewTextBoxColumn
        ' 
        IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        IdDataGridViewTextBoxColumn.HeaderText = "ID"
        IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        IdDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' CreatedAtDataGridViewTextBoxColumn
        ' 
        CreatedAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt"
        CreatedAtDataGridViewTextBoxColumn.HeaderText = "Fecha de creación"
        CreatedAtDataGridViewTextBoxColumn.Name = "CreatedAtDataGridViewTextBoxColumn"
        CreatedAtDataGridViewTextBoxColumn.ReadOnly = True
        CreatedAtDataGridViewTextBoxColumn.Width = 150
        ' 
        ' DescriptionDataGridViewTextBoxColumn
        ' 
        DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        DescriptionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        DescriptionDataGridViewTextBoxColumn.Width = 150
        ' 
        ' MedicalRecordBindingSource
        ' 
        MedicalRecordBindingSource.DataSource = GetType(Entities.MedicalRecord)
        ' 
        ' btnNewRecord
        ' 
        btnNewRecord.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNewRecord.Location = New Point(362, 412)
        btnNewRecord.Margin = New Padding(6)
        btnNewRecord.Name = "btnNewRecord"
        btnNewRecord.Size = New Size(111, 23)
        btnNewRecord.TabIndex = 4
        btnNewRecord.Text = "Nuevo Registro"
        btnNewRecord.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEdit.Location = New Point(271, 412)
        btnEdit.Margin = New Padding(6)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(79, 23)
        btnEdit.TabIndex = 5
        btnEdit.Text = "Editar"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnDelete.Location = New Point(180, 412)
        btnDelete.Margin = New Padding(6)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(79, 23)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' lbCount
        ' 
        lbCount.AutoSize = True
        lbCount.Location = New Point(21, 416)
        lbCount.Margin = New Padding(12)
        lbCount.Name = "lbCount"
        lbCount.Size = New Size(43, 15)
        lbCount.TabIndex = 7
        lbCount.Text = "Count:"
        ' 
        ' MedicalRecords
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(488, 450)
        Controls.Add(lbCount)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnNewRecord)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "MedicalRecords"
        Text = "MedicalRecords"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(MedicalRecordBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbPatientData As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicalRecordBindingSource As BindingSource
    Friend WithEvents btnNewRecord As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lbCount As Label
End Class
