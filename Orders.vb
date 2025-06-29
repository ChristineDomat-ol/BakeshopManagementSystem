Imports BakeshopManagementSystem.Product

Public Class Orders

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rekta "Admin" na po to - tin lblUserName.Text = Login.CurrentUsername
        InitializeTable()
        LoadCartData()
    End Sub

    Private Sub InitializeTable()
        tblMenu.Rows.Clear()
        tblMenu.Columns.Clear()
        tblMenu.AllowUserToAddRows = False
        tblMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        tblMenu.MultiSelect = True

        tblMenu.Columns.Add("ID", "ID")
        tblMenu.Columns.Add("ITEM", "ITEM")
        tblMenu.Columns.Add("PRICE", "PRICE")
        tblMenu.Columns.Add("QUANTITY", "QUANTITY")
        tblMenu.Columns.Add("TOTAL", "TOTAL")
        tblMenu.Columns.Add("STATUS", "STATUS")

        For Each col As DataGridViewColumn In tblMenu.Columns
            col.ReadOnly = True
        Next
    End Sub

    Private Sub LoadCartData(Optional filter As String = "")
        tblMenu.Rows.Clear()

        For Each order As ProductOrder In Login.CartList
            If String.IsNullOrWhiteSpace(filter) OrElse order.Name.ToLower().Contains(filter) Then
                tblMenu.Rows.Add(
                    order.Id,
                    order.Name,
                    order.Price.ToString("0.00"),
                    order.Quantity,
                    order.Subtotal.ToString("0.00"),
                    If(String.IsNullOrWhiteSpace(order.Status), "Pending", order.Status)
                )
            End If
        Next
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        If tblMenu.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one row to mark as completed.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        For Each row As DataGridViewRow In tblMenu.SelectedRows
            Dim index As Integer = row.Index

            row.Cells("STATUS").Value = "Completed"

            If index >= 0 AndAlso index < Login.CartList.Count Then
                Login.CartList(index).Status = "Completed"
            End If
        Next

        tblMenu.ClearSelection()
        tblMenu.Refresh()
        MessageBox.Show("Selected order(s) marked as Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub tblMenu_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles tblMenu.CellFormatting
        If tblMenu.Columns(e.ColumnIndex).Name = "STATUS" Then
            If e.Value IsNot Nothing AndAlso e.Value.ToString() = "Completed" Then
                e.CellStyle.ForeColor = Color.Green
                e.CellStyle.Font = New Font(tblMenu.Font, FontStyle.Bold)
            End If
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim adminForm As New Admin()
        adminForm.Show()
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If tblMenu.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one row to mark as pending.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        For Each row As DataGridViewRow In tblMenu.SelectedRows
            Dim index As Integer = row.Index

            row.Cells("STATUS").Value = "Pending"

            If index >= 0 AndAlso index < Login.CartList.Count Then
                Login.CartList(index).Status = "Pending"
            End If
        Next

        tblMenu.ClearSelection()
        tblMenu.Refresh()
        MessageBox.Show("Selected order(s) marked as Pending.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim filter As String = txtSearch.Text.Trim().ToLower()
        LoadCartData(filter)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim filter As String = txtSearch.Text.Trim().ToLower()
        If String.IsNullOrWhiteSpace(filter) Then
            MessageBox.Show("Please enter a keyword to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        LoadCartData(filter)
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        txtSearch.Clear()
        LoadCartData()
    End Sub

End Class
