﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        TextBox1 = New TextBox()
        HomeBtn = New Button()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SignUpBtn = New Button()
        SignupTxt = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(285, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(194, 23)
        TextBox1.TabIndex = 0
        ' 
        ' HomeBtn
        ' 
        HomeBtn.Location = New Point(588, 29)
        HomeBtn.Name = "HomeBtn"
        HomeBtn.Size = New Size(102, 34)
        HomeBtn.TabIndex = 1
        HomeBtn.Text = "Home"
        HomeBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(220, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(285, 138)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(194, 23)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(285, 190)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(194, 23)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(285, 239)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(194, 23)
        TextBox4.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(220, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 6
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(220, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 7
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(220, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 8
        Label4.Text = "Label4"
        ' 
        ' SignUpBtn
        ' 
        SignUpBtn.Location = New Point(323, 306)
        SignUpBtn.Name = "SignUpBtn"
        SignUpBtn.Size = New Size(102, 34)
        SignUpBtn.TabIndex = 9
        SignUpBtn.Text = "SIGN UP"
        SignUpBtn.UseVisualStyleBackColor = True
        ' 
        ' SignupTxt
        ' 
        SignupTxt.AutoSize = True
        SignupTxt.Location = New Point(355, 48)
        SignupTxt.Name = "SignupTxt"
        SignupTxt.Size = New Size(48, 15)
        SignupTxt.TabIndex = 10
        SignupTxt.Text = "Sign Up"
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SignupTxt)
        Controls.Add(SignUpBtn)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(HomeBtn)
        Controls.Add(TextBox1)
        Name = "SignUp"
        Text = "SignUp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents HomeBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SignUpBtn As Button
    Friend WithEvents SignupTxt As Label
End Class
