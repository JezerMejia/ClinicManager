<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewAppointment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label1 = New Label()
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        btnPatientSearch = New Button()
        lbPatientData = New Label()
        btnSave = New Button()
        btnClear = New Button()
        GroupBox2 = New GroupBox()
        btnMedicSearch = New Button()
        lbMedicData = New Label()
        GroupBox3 = New GroupBox()
        dtpAttendDate = New DateTimePicker()
        GroupBox4 = New GroupBox()
        txtDescription = New TextBox()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        Label1.Location = New Point(21, 21)
        Label1.Margin = New Padding(12)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 30)
        Label1.TabIndex = 0
        Label1.Text = "Nueva Cita Médica"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Honeydew
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(691, 69)
        Panel1.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnPatientSearch)
        GroupBox1.Controls.Add(lbPatientData)
        GroupBox1.Location = New Point(21, 84)
        GroupBox1.Margin = New Padding(12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(6, 3, 7, 3)
        GroupBox1.Size = New Size(200, 53)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Paciente"
        ' 
        ' btnPatientSearch
        ' 
        btnPatientSearch.Location = New Point(115, 18)
        btnPatientSearch.Name = "btnPatientSearch"
        btnPatientSearch.Size = New Size(75, 23)
        btnPatientSearch.TabIndex = 1
        btnPatientSearch.Text = "Buscar..."
        btnPatientSearch.UseVisualStyleBackColor = True
        ' 
        ' lbPatientData
        ' 
        lbPatientData.AutoEllipsis = True
        lbPatientData.AutoSize = True
        lbPatientData.Location = New Point(9, 22)
        lbPatientData.MaximumSize = New Size(120, 0)
        lbPatientData.Name = "lbPatientData"
        lbPatientData.Size = New Size(44, 15)
        lbPatientData.TabIndex = 0
        lbPatientData.Text = "Patient"
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSave.Location = New Point(601, 344)
        btnSave.Margin = New Padding(6)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 9
        btnSave.Text = "Añadir"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClear.Location = New Point(514, 344)
        btnClear.Margin = New Padding(6)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 10
        btnClear.Text = "Limpiar"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnMedicSearch)
        GroupBox2.Controls.Add(lbMedicData)
        GroupBox2.Location = New Point(245, 84)
        GroupBox2.Margin = New Padding(12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(6, 3, 7, 3)
        GroupBox2.Size = New Size(200, 53)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Médico"
        ' 
        ' btnMedicSearch
        ' 
        btnMedicSearch.Location = New Point(115, 18)
        btnMedicSearch.Name = "btnMedicSearch"
        btnMedicSearch.Size = New Size(75, 23)
        btnMedicSearch.TabIndex = 1
        btnMedicSearch.Text = "Buscar..."
        btnMedicSearch.UseVisualStyleBackColor = True
        ' 
        ' lbMedicData
        ' 
        lbMedicData.AutoEllipsis = True
        lbMedicData.AutoSize = True
        lbMedicData.Location = New Point(12, 22)
        lbMedicData.MaximumSize = New Size(120, 0)
        lbMedicData.Name = "lbMedicData"
        lbMedicData.Size = New Size(47, 15)
        lbMedicData.TabIndex = 0
        lbMedicData.Text = "Médico"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(dtpAttendDate)
        GroupBox3.Location = New Point(469, 84)
        GroupBox3.Margin = New Padding(12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(6, 3, 7, 3)
        GroupBox3.Size = New Size(200, 53)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Fecha"
        ' 
        ' dtpAttendDate
        ' 
        dtpAttendDate.Dock = DockStyle.Fill
        dtpAttendDate.Format = DateTimePickerFormat.Short
        dtpAttendDate.Location = New Point(6, 19)
        dtpAttendDate.Name = "dtpAttendDate"
        dtpAttendDate.Size = New Size(187, 23)
        dtpAttendDate.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(txtDescription)
        GroupBox4.Location = New Point(21, 161)
        GroupBox4.Margin = New Padding(12)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(6, 3, 7, 3)
        GroupBox4.Size = New Size(648, 156)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "Descripción"
        ' 
        ' txtDescription
        ' 
        txtDescription.Dock = DockStyle.Fill
        txtDescription.Location = New Point(6, 19)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(635, 134)
        txtDescription.TabIndex = 0
        ' 
        ' NewAppointment
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(691, 382)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "NewAppointment"
        Text = "Nueva Cita Médica"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lbPatientData As Label
    Friend WithEvents btnPatientSearch As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnMedicSearch As Button
    Friend WithEvents lbMedicData As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpAttendDate As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtDescription As TextBox
End Class
