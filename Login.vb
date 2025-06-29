Imports BakeshopManagementSystem.Product

Public Class Login

    'Login source frame natin since to unang nagrurun
    Public ProductList As New List(Of Product)() 'Product/Menu list

    'list for checkout
    Public Shared CartList As New List(Of ProductOrder)()
    'to display username
    Public Shared CurrentUsername As String

    Private passwordVisible As Boolean = False


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim sampleProduct1 As New Product With {
            .Name = "Strawberry Cake",
            .Category = "🍰 Cake",
            .Price = 345
        }
        ProductList.Add(sampleProduct1)

        Dim sampleProduct2 As New Product With {
            .Name = "Garlic Bread",
            .Category = "🍞 Bread",
            .Price = 100
        }
        ProductList.Add(sampleProduct2)

        Dim sampleProduct3 As New Product With {
            .Name = "Macaron",
            .Category = "🥧 Pastry",
            .Price = 30
        }
        ProductList.Add(sampleProduct3)

        Dim sampleProduct4 As New Product With {
            .Name = "Chocolate Chips Cookie",
            .Category = "🍪 Cookie",
            .Price = 30
        }
        ProductList.Add(sampleProduct4)

        Dim sampleProduct5 As New Product With {
            .Name = "Iced Caramel Machiato",
            .Category = "🥤 Coffee",
            .Price = 30
        }
        ProductList.Add(sampleProduct5)

        txtPassword.UseSystemPasswordChar = True
        passwordVisible = False
        btnEyeOpened.BackgroundImage = My.Resources._20
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
            CurrentUsername = username

            Dim userForm As New User()
            userForm.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Clear()
            txtPassword.Clear()
        End If
    End Sub

    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnEyeOpened_Click(sender As Object, e As EventArgs) Handles btnEyeOpened.Click
        passwordVisible = Not passwordVisible

        If passwordVisible Then
            txtPassword.UseSystemPasswordChar = False
            btnEyeOpened.BackgroundImage = My.Resources._191
        Else
            txtPassword.UseSystemPasswordChar = True
            btnEyeOpened.BackgroundImage = My.Resources._20
        End If
    End Sub


End Class
