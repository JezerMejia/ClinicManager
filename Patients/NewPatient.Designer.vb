<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPatient
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
        Label1 = New Label()
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        txtFirstName = New TextBox()
        GroupBox2 = New GroupBox()
        txtLastName = New TextBox()
        GroupBox3 = New GroupBox()
        txtEmail = New TextBox()
        GroupBox4 = New GroupBox()
        txtPhone = New TextBox()
        GroupBox5 = New GroupBox()
        txtIdentifier = New TextBox()
        GroupBox6 = New GroupBox()
        dtpBirthday = New DateTimePicker()
        GroupBox7 = New GroupBox()
        cmbSex = New ComboBox()
        btnSave = New Button()
        btnClear = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox7.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.Location = New Point(21, 21)
        Label1.Margin = New Padding(12)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 30)
        Label1.TabIndex = 0
        Label1.Text = "Nuevo Paciente"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Honeydew
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(482, 69)
        Panel1.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtFirstName)
        GroupBox1.Location = New Point(21, 84)
        GroupBox1.Margin = New Padding(12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(6, 3, 7, 3)
        GroupBox1.Size = New Size(200, 53)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nombres"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Dock = DockStyle.Fill
        txtFirstName.Location = New Point(6, 19)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(187, 23)
        txtFirstName.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtLastName)
        GroupBox2.Location = New Point(21, 161)
        GroupBox2.Margin = New Padding(12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(6, 3, 7, 3)
        GroupBox2.Size = New Size(200, 53)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Apellidos"
        ' 
        ' txtLastName
        ' 
        txtLastName.Dock = DockStyle.Fill
        txtLastName.Location = New Point(6, 19)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(187, 23)
        txtLastName.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtEmail)
        GroupBox3.Location = New Point(21, 238)
        GroupBox3.Margin = New Padding(12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(6, 3, 7, 3)
        GroupBox3.Size = New Size(200, 53)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Correo Electrónico"
        ' 
        ' txtEmail
        ' 
        txtEmail.Dock = DockStyle.Fill
        txtEmail.Location = New Point(6, 19)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(187, 23)
        txtEmail.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(txtPhone)
        GroupBox4.Location = New Point(259, 84)
        GroupBox4.Margin = New Padding(12)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(6, 3, 7, 3)
        GroupBox4.Size = New Size(200, 53)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "Teléfono"
        ' 
        ' txtPhone
        ' 
        txtPhone.Dock = DockStyle.Fill
        txtPhone.Location = New Point(6, 19)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(187, 23)
        txtPhone.TabIndex = 0
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(txtIdentifier)
        GroupBox5.Location = New Point(259, 161)
        GroupBox5.Margin = New Padding(12)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(6, 3, 7, 3)
        GroupBox5.Size = New Size(200, 53)
        GroupBox5.TabIndex = 6
        GroupBox5.TabStop = False
        GroupBox5.Text = "Cédula"
        ' 
        ' txtIdentifier
        ' 
        txtIdentifier.Dock = DockStyle.Fill
        txtIdentifier.Location = New Point(6, 19)
        txtIdentifier.Name = "txtIdentifier"
        txtIdentifier.Size = New Size(187, 23)
        txtIdentifier.TabIndex = 0
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(dtpBirthday)
        GroupBox6.Location = New Point(259, 238)
        GroupBox6.Margin = New Padding(12)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(6, 3, 7, 3)
        GroupBox6.Size = New Size(200, 53)
        GroupBox6.TabIndex = 7
        GroupBox6.TabStop = False
        GroupBox6.Text = "Fecha de Nacimiento"
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.Dock = DockStyle.Fill
        dtpBirthday.Format = DateTimePickerFormat.Short
        dtpBirthday.Location = New Point(6, 19)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(187, 23)
        dtpBirthday.TabIndex = 1
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(cmbSex)
        GroupBox7.Location = New Point(21, 315)
        GroupBox7.Margin = New Padding(12)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Padding = New Padding(6, 3, 7, 3)
        GroupBox7.Size = New Size(200, 53)
        GroupBox7.TabIndex = 8
        GroupBox7.TabStop = False
        GroupBox7.Text = "Sexo"
        ' 
        ' cmbSex
        ' 
        cmbSex.Dock = DockStyle.Fill
        cmbSex.FormattingEnabled = True
        cmbSex.Items.AddRange(New Object() {"Hombre", "Mujer"})
        cmbSex.Location = New Point(6, 19)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(187, 23)
        cmbSex.TabIndex = 0
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSave.Location = New Point(392, 412)
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
        btnClear.Location = New Point(305, 412)
        btnClear.Margin = New Padding(6)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 10
        btnClear.Text = "Limpiar"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' NewPatient
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 450)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(GroupBox7)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "NewPatient"
        Text = "Nuevo Paciente"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox7.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtIdentifier As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
End Class
