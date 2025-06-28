Imports BakeshopManagementSystem.Product

Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDataInGrid()
        lblUserName.Text = Login.CurrentUsername
    End Sub

    Private Sub ShowDataInGrid()
        tblMenu.Rows.Clear()
        tblMenu.Columns.Clear()
        tblMenu.AllowUserToAddRows = False

        tblMenu.Columns.Add("ID", "ID")
        tblMenu.Columns.Add("NAME", "NAME")
        tblMenu.Columns.Add("CATEGORY", "CATEGORY")
        tblMenu.Columns.Add("PRICE", "PRICE")
        tblMenu.Columns.Add("QUANTITY", "QUANTITY")

        Dim btnCol As New DataGridViewButtonColumn()
        btnCol.HeaderText = "ACTION"
        btnCol.Name = "btnAddToCart"
        btnCol.Text = "Add to Cart"
        btnCol.UseColumnTextForButtonValue = True
        tblMenu.Columns.Add(btnCol)

        For Each product In Login.ProductList
            tblMenu.Rows.Add(product.Id, product.Name, product.Category, product.Price.ToString(), "")
        Next

        tblMenu.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        tblMenu.Columns("CATEGORY").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        tblMenu.Columns("PRICE").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        tblMenu.Columns("NAME").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tblMenu.Columns("QUANTITY").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        tblMenu.Columns("btnAddToCart").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        tblMenu.Columns("ID").Visible = False
    End Sub
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If Login.CartList.Count = 0 Then
            MessageBox.Show("Your cart is empty. Please add items to cart before checkout.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim receiptText As New Text.StringBuilder()
        Dim totalPrice As Decimal = 0

        receiptText.AppendLine("----- Receipt -----")

        For Each item In Login.CartList
            receiptText.AppendLine($"{item.Quantity} x {item.Name,-25} {item.Subtotal,10:0.00}")
            totalPrice += item.Subtotal
        Next

        lblOrders.Text = receiptText.ToString()
        lblTotal.Text = totalPrice.ToString("0.00")

        MessageBox.Show("Checkout complete! Thank you for your order.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Login.CartList.Clear()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()

        If String.IsNullOrWhiteSpace(searchTerm) Then
            MessageBox.Show("Please enter a product name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        tblMenu.Rows.Clear()
        Dim found As Boolean = False
        For Each product In Login.ProductList
            If product.Name.ToLower().Contains(searchTerm) Then
                tblMenu.Rows.Add(product.Id, product.Name, product.Category, product.Price.ToString(), "")
                found = True
            End If
        Next

        If Not found Then
            MessageBox.Show("Product not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtSearch.Clear()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        txtSearch.Clear()
        tblMenu.ClearSelection()
        ShowDataInGrid()
    End Sub

    Private Sub btnDeleteCart_Click(sender As Object, e As EventArgs) Handles btnDeleteCart.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the cart?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            For Each row As DataGridViewRow In tblMenu.Rows
                Dim qtyCell = row.Cells("QUANTITY").Value
                If qtyCell IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(qtyCell.ToString()) Then
                    Dim qty As Integer
                    If Integer.TryParse(qtyCell.ToString(), qty) AndAlso qty > 0 Then
                        row.Cells("QUANTITY").Value = ""
                    End If
                End If
            Next

            lblOrders.Text = ""
            lblTotal.Text = "0.00"

            MessageBox.Show("Cart has been cleared.", "Cart Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tblMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblMenu.CellContentClick
        If e.RowIndex >= 0 AndAlso tblMenu.Columns(e.ColumnIndex).Name = "btnAddToCart" Then
            Dim row As DataGridViewRow = tblMenu.Rows(e.RowIndex)
            Dim name As String = row.Cells("NAME").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(row.Cells("PRICE").Value)
            Dim qtyCell = row.Cells("QUANTITY").Value

            If qtyCell Is Nothing OrElse String.IsNullOrWhiteSpace(qtyCell.ToString()) Then
                MessageBox.Show("Please enter a quantity before adding to cart.", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim qty As Integer
            If Integer.TryParse(qtyCell.ToString(), qty) AndAlso qty > 0 Then
                Dim subtotal As Decimal = qty * price

                Login.CartList.Add(New ProductOrder With {
                    .Name = name,
                    .Price = price,
                    .Quantity = qty,
                    .Subtotal = subtotal
                })

                Dim sb As New Text.StringBuilder()
                Dim total As Decimal = 0

                For Each item In Login.CartList
                    sb.AppendLine($"{item.Quantity,4}  {item.Name.PadRight(20)} {item.Subtotal,10:0.00}")
                    total += item.Subtotal
                Next

                lblOrders.Text = sb.ToString()
                lblTotal.Text = total.ToString("0.00")

                row.Cells("QUANTITY").Value = ""
            Else
                MessageBox.Show("Invalid quantity. Please enter a positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class
