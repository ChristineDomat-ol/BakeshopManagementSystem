Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Admin credentials
        If username = "admin" And password = "123" Then
            MessageBox.Show("Welcome Admin!")
            Dim adminForm As New Admin()
            adminForm.Show()
            Me.Hide()

            ' Customer credentials
        ElseIf (username = "Croxy" And password = "rox") OrElse
               (username = "Tinepay" And password = "tin") OrElse
               (username = "Megatron" And password = "megs") OrElse
               (username = "HindiNaPeoplePleaser" And password = "marielle") Then

            MessageBox.Show("Welcome " & username & "!")
            Dim userForm As New User()
            userForm.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
