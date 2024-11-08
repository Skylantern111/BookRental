<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        LogIN = New Button()
        SignUp = New Button()
        Homelb = New Label()
        SuspendLayout()
        ' 
        ' LogIN
        ' 
        LogIN.Location = New Point(518, 22)
        LogIN.Name = "LogIN"
        LogIN.Size = New Size(75, 23)
        LogIN.TabIndex = 0
        LogIN.Text = "LogIn"
        LogIN.UseVisualStyleBackColor = True
        ' 
        ' SignUp
        ' 
        SignUp.Location = New Point(661, 22)
        SignUp.Name = "SignUp"
        SignUp.Size = New Size(75, 23)
        SignUp.TabIndex = 1
        SignUp.Text = "Signup"
        SignUp.UseVisualStyleBackColor = True
        ' 
        ' Homelb
        ' 
        Homelb.AutoSize = True
        Homelb.Location = New Point(214, 15)
        Homelb.Name = "Homelb"
        Homelb.Size = New Size(40, 15)
        Homelb.TabIndex = 2
        Homelb.Text = "Home"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Homelb)
        Controls.Add(SignUp)
        Controls.Add(LogIN)
        Name = "Home"
        Text = "Home"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LogIN As Button
    Friend WithEvents SignUp As Button
    Friend WithEvents Homelb As Label
End Class
