<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMedicalRecord
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
        Panel1 = New Panel()
        lbPatientData = New Label()
        Label1 = New Label()
        txtDescription = New TextBox()
        btnSave = New Button()
        btnClear = New Button()
        Panel1.SuspendLayout()
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
        Panel1.Size = New Size(493, 97)
        Panel1.TabIndex = 3
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
        Label1.Size = New Size(294, 30)
        Label1.TabIndex = 0
        Label1.Text = "Nueva entrada del historial"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(21, 112)
        txtDescription.Margin = New Padding(12)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.PlaceholderText = "Descripción"
        txtDescription.Size = New Size(451, 132)
        txtDescription.TabIndex = 4
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(403, 266)
        btnSave.Margin = New Padding(6)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 5
        btnSave.Text = "Guardar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(316, 266)
        btnClear.Margin = New Padding(6)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 6
        btnClear.Text = "Limpiar"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' NewMedicalRecord
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(493, 304)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(txtDescription)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "NewMedicalRecord"
        Text = "Nueva entrada"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbPatientData As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
End Class
