Public Class Home
    Private Sub LogIN_Click(sender As Object, e As EventArgs) Handles LogIN.Click
        ' Create an instance of the LogIn form and show it
        Dim logInForm As New LogIn()
        logInForm.Show()
        Me.Hide() ' 
    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        ' Create an instance of the SignUp form and show it
        Dim signUpForm As New SignUp()
        signUpForm.Show()
        Me.Hide()
    End Sub
End Class
