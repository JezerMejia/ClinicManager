<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        GroupBox1 = New GroupBox()
        txtUser = New TextBox()
        GroupBox2 = New GroupBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtUser)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(245, 47)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Usuario"
        ' 
        ' txtUser
        ' 
        txtUser.Dock = DockStyle.Fill
        txtUser.Location = New Point(3, 19)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(239, 23)
        txtUser.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtPassword)
        GroupBox2.Location = New Point(12, 75)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(245, 47)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Contraseña"
        ' 
        ' txtPassword
        ' 
        txtPassword.Dock = DockStyle.Fill
        txtPassword.Location = New Point(3, 19)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(239, 23)
        txtPassword.TabIndex = 0
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLogin.Location = New Point(182, 147)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Ingresar"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(269, 182)
        Controls.Add(btnLogin)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Login"
        Text = "Inicio de Sesión"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button

End Class
