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
        PatientsTab = New TabPage()
        PatientsTable1 = New PatientsTable()
        AppointmentsTab = New TabPage()
        AppointmentsTable1 = New AppointmentsTable()
        MedicsTab = New TabPage()
        AboutTab = New TabPage()
        AboutUser1 = New AboutUser()
        MedicsTable1 = New MedicsTable()
        TabControl1.SuspendLayout()
        PatientsTab.SuspendLayout()
        AppointmentsTab.SuspendLayout()
        MedicsTab.SuspendLayout()
        AboutTab.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(PatientsTab)
        TabControl1.Controls.Add(AppointmentsTab)
        TabControl1.Controls.Add(MedicsTab)
        TabControl1.Controls.Add(AboutTab)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 450)
        TabControl1.TabIndex = 0
        ' 
        ' PatientsTab
        ' 
        PatientsTab.Controls.Add(PatientsTable1)
        PatientsTab.Location = New Point(4, 24)
        PatientsTab.Name = "PatientsTab"
        PatientsTab.Padding = New Padding(3)
        PatientsTab.Size = New Size(792, 422)
        PatientsTab.TabIndex = 0
        PatientsTab.Text = "Pacientes"
        PatientsTab.UseVisualStyleBackColor = True
        ' 
        ' PatientsTable1
        ' 
        PatientsTable1.Dock = DockStyle.Fill
        PatientsTable1.Location = New Point(3, 3)
        PatientsTable1.Name = "PatientsTable1"
        PatientsTable1.Size = New Size(786, 416)
        PatientsTable1.TabIndex = 0
        ' 
        ' AppointmentsTab
        ' 
        AppointmentsTab.Controls.Add(AppointmentsTable1)
        AppointmentsTab.Location = New Point(4, 24)
        AppointmentsTab.Name = "AppointmentsTab"
        AppointmentsTab.Padding = New Padding(3)
        AppointmentsTab.Size = New Size(792, 422)
        AppointmentsTab.TabIndex = 1
        AppointmentsTab.Text = "Citas Médicas"
        AppointmentsTab.UseVisualStyleBackColor = True
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
        ' MedicsTab
        ' 
        MedicsTab.Controls.Add(MedicsTable1)
        MedicsTab.Location = New Point(4, 24)
        MedicsTab.Name = "MedicsTab"
        MedicsTab.Padding = New Padding(3)
        MedicsTab.Size = New Size(792, 422)
        MedicsTab.TabIndex = 3
        MedicsTab.Text = "Médicos"
        MedicsTab.UseVisualStyleBackColor = True
        ' 
        ' AboutTab
        ' 
        AboutTab.Controls.Add(AboutUser1)
        AboutTab.Location = New Point(4, 24)
        AboutTab.Name = "AboutTab"
        AboutTab.Padding = New Padding(3)
        AboutTab.Size = New Size(792, 422)
        AboutTab.TabIndex = 2
        AboutTab.Text = "Sobre mí"
        AboutTab.UseVisualStyleBackColor = True
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
        ' MedicsTable1
        ' 
        MedicsTable1.Dock = DockStyle.Fill
        MedicsTable1.Location = New Point(3, 3)
        MedicsTable1.Name = "MedicsTable1"
        MedicsTable1.Size = New Size(786, 416)
        MedicsTable1.TabIndex = 0
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
        PatientsTab.ResumeLayout(False)
        AppointmentsTab.ResumeLayout(False)
        MedicsTab.ResumeLayout(False)
        AboutTab.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PatientsTab As TabPage
    Friend WithEvents AppointmentsTab As TabPage
    Friend WithEvents PatientsTable1 As PatientsTable
    Friend WithEvents AppointmentsTable1 As AppointmentsTable
    Friend WithEvents AboutTab As TabPage
    Friend WithEvents AboutUser1 As AboutUser
    Friend WithEvents MedicsTab As TabPage
    Friend WithEvents MedicsTable1 As MedicsTable

End Class
