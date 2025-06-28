Public Class Admin

    Dim ItemID As Integer = -1

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDataInGrid()
    End Sub

    'ShowDataInGrid'
    Private Sub ShowDataInGrid()
        tblMenu.Rows.Clear()
        tblMenu.Columns.Clear()

        tblMenu.Columns.Add("ID", "ID")
        tblMenu.Columns.Add("NAME", "NAME")
        tblMenu.Columns.Add("CATEGORY", "CATEGORY")
        tblMenu.Columns.Add("PRICE", "PRICE")

        For Each product In Login.ProductList
            Dim row As String() = New String() {
            product.Id,
            product.Name,
            product.Category,
            product.Price.ToString()
        }
            tblMenu.Rows.Add(row)
        Next

        tblMenu.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        tblMenu.Columns("CATEGORY").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        tblMenu.Columns("PRICE").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        tblMenu.Columns("NAME").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim orderForm As New Orders()
        orderForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtProductName.Text) OrElse String.IsNullOrEmpty(cmbCategory.Text) OrElse String.IsNullOrEmpty(txtPrice.Text) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearFields()
            Return
        ElseIf txtPrice.Text.Any(Function(c) Not Char.IsDigit(c)) Then
            MessageBox.Show("Price must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearFields()
            Return
        End If

        Dim newProduct As New Product With {
            .Name = txtProductName.Text,
            .Category = cmbCategory.Text,
            .Price = Convert.ToInt32(txtPrice.Text)
        }

        Login.ProductList.Add(newProduct)

        MessageBox.Show(txtProductName.Text + " added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ClearFields()
        ShowDataInGrid()
    End Sub

    Private Sub tblMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblMenu.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = tblMenu.Rows(e.RowIndex)

            ItemID = Convert.ToInt32(selectedRow.Cells(0).Value)
            txtProductName.Text = selectedRow.Cells(1).Value.ToString()
            cmbCategory.Text = selectedRow.Cells(2).Value.ToString()
            txtPrice.Text = selectedRow.Cells(3).Value.ToString()

        End If
    End Sub

    Private Sub ClearFields()
        txtProductName.Clear()
        cmbCategory.SelectedIndex = -1
        txtPrice.Clear()
        txtSearch.Clear()
        tblMenu.ClearSelection()
        ItemID = 0
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        ClearFields()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If String.IsNullOrEmpty(txtProductName.Text) Then
            MessageBox.Show("Please select Product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearFields()
            Return
        End If

        For i As Integer = Login.ProductList.Count - 1 To 0 Step -1
            Dim item = Login.ProductList(i)

            If String.Equals(item.Name, txtProductName.Text, StringComparison.OrdinalIgnoreCase) Then

                Login.ProductList.RemoveAt(i)
                MessageBox.Show(txtProductName.Text + " deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ShowDataInGrid()
                ClearFields()

                Exit Sub
            End If
        Next

        MessageBox.Show(txtProductName.Text + " is not in the List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ClearFields()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If String.IsNullOrEmpty(txtProductName.Text) OrElse cmbCategory.SelectedIndex = -1 OrElse String.IsNullOrEmpty(txtPrice.Text) Then
            MessageBox.Show("Please select Product to Update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearFields()

            Return
        End If

        For i As Integer = Login.ProductList.Count - 1 To 0 Step -1
            Dim item = Login.ProductList(i)

            If item.Id = ItemID Then

                item.Name = txtProductName.Text
                item.Category = cmbCategory.Text
                item.Price = Convert.ToDecimal(txtPrice.Text)

                MessageBox.Show(txtProductName.Text + " updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ShowDataInGrid()
                ClearFields()

                Exit Sub
            End If
        Next

        MessageBox.Show(txtProductName.Text + " is not in the List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ClearFields()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchItem As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(searchItem) Then
            MessageBox.Show("Please enter a product name to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearFields()
            Return
        End If

        For Each row As DataGridViewRow In tblMenu.Rows
            If row.Cells("NAME").Value.ToString().ToLower() = searchItem.ToLower() Then
                row.Selected = True
                tblMenu.FirstDisplayedScrollingRowIndex = row.Index

                txtProductName.Text = row.Cells("NAME").Value.ToString()
                cmbCategory.Text = row.Cells("CATEGORY").Value.ToString()
                txtPrice.Text = row.Cells("PRICE").Value.ToString()

                txtSearch.Clear()
                Return
            End If
        Next

        MessageBox.Show("Product not found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearFields()

    End Sub

    Private Sub tblMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblMenu.CellContentClick

    End Sub
End Class