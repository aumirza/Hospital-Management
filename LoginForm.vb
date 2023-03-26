Public Class LoginForm

    Private Sub LoginButton_Click(sender As Object, e As EventArgs)
        ' Authenticate user with username and password
        If ValidateCredentials(UserNameTextBox.Text, PasswordTextBox.Text) Then
            ' Open main form if credentials are correct
            MessageBox.Show("Login Successful")
            MainForm.Show()
            Me.Hide()
        Else
            ' Show error message if credentials are incorrect
            MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Function ValidateCredentials(username As String, password As String) As Boolean
        ' Perform authentication logic here
        ' For example, check credentials against a database or a file
        ' Return True if credentials are correct, False otherwise
        If username = "admin" AndAlso password = "password" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
