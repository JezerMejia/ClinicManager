<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutUser
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Label1 = New Label()
        lbInfo = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Honeydew
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(325, 69)
        Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.Location = New Point(21, 21)
        Label1.Margin = New Padding(12)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 30)
        Label1.TabIndex = 0
        Label1.Text = "Información del usuario"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbInfo
        ' 
        lbInfo.AutoSize = True
        lbInfo.Location = New Point(21, 93)
        lbInfo.MaximumSize = New Size(260, 0)
        lbInfo.Name = "lbInfo"
        lbInfo.Size = New Size(72, 15)
        lbInfo.TabIndex = 3
        lbInfo.Text = "Información"
        ' 
        ' AboutUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lbInfo)
        Controls.Add(Panel1)
        Name = "AboutUser"
        Size = New Size(325, 254)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbInfo As Label

End Class
