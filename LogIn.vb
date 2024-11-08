Public Class LogIn
    ' Define the usernames and passwords for simplicity
    Private validUsername As String = "admin"
    Private validPassword As String = "renny"

    Private Sub LOGINBtn_Click(sender As Object, e As EventArgs) Handles LOGINBtn.Click
        ' Get the input values from the text boxes
        Dim username As String = UsernameTxt.Text
        Dim password As String = PasswordTxt.Text

        ' Check if the input matches the valid credentials
        If username = validUsername And password = validPassword Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim home As New Home()
            home.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Event handler for the CheckBox to toggle password visibility
    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        ' Toggle PasswordTxt's UseSystemPasswordChar property
        PasswordTxt.UseSystemPasswordChar = Not ShowPasswordCheckBox.Checked
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        ' Open the Home form and close the login form
        Dim home As New Home()
        home.Show()
        Me.Hide()
    End Sub
End Class
