<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        UsernameTxt = New TextBox()
        PasswordTxt = New TextBox()
        LOGINBtn = New Button()
        HomeBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' UsernameTxt
        ' 
        UsernameTxt.Location = New Point(283, 166)
        UsernameTxt.Name = "UsernameTxt"
        UsernameTxt.Size = New Size(217, 23)
        UsernameTxt.TabIndex = 0
        ' 
        ' PasswordTxt
        ' 
        PasswordTxt.Location = New Point(283, 209)
        PasswordTxt.Name = "PasswordTxt"
        PasswordTxt.Size = New Size(217, 23)
        PasswordTxt.TabIndex = 1
        ' 
        ' LOGINBtn
        ' 
        LOGINBtn.Location = New Point(325, 261)
        LOGINBtn.Name = "LOGINBtn"
        LOGINBtn.Size = New Size(125, 23)
        LOGINBtn.TabIndex = 2
        LOGINBtn.Text = "LOG IN "
        LOGINBtn.UseVisualStyleBackColor = True
        ' 
        ' HomeBtn
        ' 
        HomeBtn.Location = New Point(563, 39)
        HomeBtn.Name = "HomeBtn"
        HomeBtn.Size = New Size(125, 23)
        HomeBtn.TabIndex = 3
        HomeBtn.Text = "Home"
        HomeBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(206, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 4
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(206, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(364, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 6
        Label3.Text = "LOG IN "
        ' 
        ' LogIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(HomeBtn)
        Controls.Add(LOGINBtn)
        Controls.Add(PasswordTxt)
        Controls.Add(UsernameTxt)
        Name = "LogIn"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents LOGINBtn As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
