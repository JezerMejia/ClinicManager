<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        PatientsTable1 = New PatientsTable()
        TabPage2 = New TabPage()
        AppointmentsTable1 = New AppointmentsTable()
        TabPage3 = New TabPage()
        AboutUser1 = New AboutUser()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 450)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(PatientsTable1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(792, 422)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Pacientes"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' PatientsTable1
        ' 
        PatientsTable1.Dock = DockStyle.Fill
        PatientsTable1.Location = New Point(3, 3)
        PatientsTable1.Name = "PatientsTable1"
        PatientsTable1.Size = New Size(786, 416)
        PatientsTable1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(AppointmentsTable1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(792, 422)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Citas Médicas"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' AppointmentsTable1
        ' 
        AppointmentsTable1.currentMedic = Nothing
        AppointmentsTable1.Dock = DockStyle.Fill
        AppointmentsTable1.Location = New Point(3, 3)
        AppointmentsTable1.Name = "AppointmentsTable1"
        AppointmentsTable1.Size = New Size(786, 416)
        AppointmentsTable1.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(AboutUser1)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(792, 422)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Sobre mí"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' AboutUser1
        ' 
        AboutUser1.Dock = DockStyle.Fill
        AboutUser1.Location = New Point(3, 3)
        AboutUser1.Name = "AboutUser1"
        AboutUser1.Size = New Size(786, 416)
        AboutUser1.TabIndex = 0
        AboutUser1.user = Nothing
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "ClinicManager"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PatientsTable1 As PatientsTable
    Friend WithEvents AppointmentsTable1 As AppointmentsTable
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents AboutUser1 As AboutUser

End Class
