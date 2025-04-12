<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MedicsTable
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
        IdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        FirstNameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        LastNameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        EmailDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        IdentifierDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        PhoneDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        SexName = New DataGridViewTextBoxColumn()
        MedicBindingSource = New BindingSource(components)
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        btnNewMedic = New Button()
        Panel2 = New Panel()
        lbCount = New Label()
        btnDelete = New Button()
        btnEdit = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(MedicBindingSource, ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {IdDataGridViewTextBoxColumn, FirstNameDataGridViewTextBoxColumn, LastNameDataGridViewTextBoxColumn, EmailDataGridViewTextBoxColumn, IdentifierDataGridViewTextBoxColumn, PhoneDataGridViewTextBoxColumn, SexName})
        DataGridView1.DataSource = MedicBindingSource
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 48)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(684, 299)
        DataGridView1.TabIndex = 0
        ' 
        ' IdDataGridViewTextBoxColumn
        ' 
        IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        IdDataGridViewTextBoxColumn.HeaderText = "ID"
        IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        IdDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' FirstNameDataGridViewTextBoxColumn
        ' 
        FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        FirstNameDataGridViewTextBoxColumn.HeaderText = "Nombres"
        FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' LastNameDataGridViewTextBoxColumn
        ' 
        LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        LastNameDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        LastNameDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' EmailDataGridViewTextBoxColumn
        ' 
        EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        EmailDataGridViewTextBoxColumn.HeaderText = "Correo"
        EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        EmailDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' IdentifierDataGridViewTextBoxColumn
        ' 
        IdentifierDataGridViewTextBoxColumn.DataPropertyName = "Identifier"
        IdentifierDataGridViewTextBoxColumn.HeaderText = "Cédula"
        IdentifierDataGridViewTextBoxColumn.Name = "IdentifierDataGridViewTextBoxColumn"
        IdentifierDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' PhoneDataGridViewTextBoxColumn
        ' 
        PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        PhoneDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        PhoneDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' SexName
        ' 
        SexName.DataPropertyName = "SexName"
        SexName.HeaderText = "Sexo"
        SexName.Name = "SexName"
        SexName.ReadOnly = True
        ' 
        ' MedicBindingSource
        ' 
        MedicBindingSource.DataSource = GetType(Entities.Medic)
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(btnNewMedic)
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
        ' btnNewMedic
        ' 
        btnNewMedic.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNewMedic.Location = New Point(560, 12)
        btnNewMedic.Margin = New Padding(12)
        btnNewMedic.Name = "btnNewMedic"
        btnNewMedic.Size = New Size(112, 23)
        btnNewMedic.TabIndex = 0
        btnNewMedic.Text = "Nuevo Médico"
        btnNewMedic.UseVisualStyleBackColor = True
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
        Panel2.TabIndex = 3
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
        btnDelete.Location = New Point(597, 17)
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
        btnEdit.Location = New Point(498, 17)
        btnEdit.Margin = New Padding(12)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 0
        btnEdit.Text = "Editar"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' MedicsTable
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "MedicsTable"
        Size = New Size(684, 347)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(MedicBindingSource, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNewMedic As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbCount As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdentifierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexName As DataGridViewTextBoxColumn
    Friend WithEvents MedicBindingSource As BindingSource

End Class
