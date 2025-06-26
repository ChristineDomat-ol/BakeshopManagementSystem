<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tblMenu = New System.Windows.Forms.DataGridView()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddtoCart = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeleteCart = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblOrders = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.tblMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserName.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(565, 9)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(220, 31)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "👤 USER NAME"
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnReload.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.load
        Me.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReload.FlatAppearance.BorderSize = 0
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Location = New System.Drawing.Point(266, 89)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(31, 23)
        Me.btnReload.TabIndex = 19
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSearch.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.search
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(230, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(31, 23)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(28, 89)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(233, 23)
        Me.txtSearch.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tblMenu)
        Me.Panel1.Location = New System.Drawing.Point(27, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 271)
        Me.Panel1.TabIndex = 16
        '
        'tblMenu
        '
        Me.tblMenu.AllowUserToOrderColumns = True
        Me.tblMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.tblMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductName, Me.ProductCategory, Me.ProductPrice, Me.txtQty, Me.btnAddtoCart})
        Me.tblMenu.Location = New System.Drawing.Point(0, 0)
        Me.tblMenu.Name = "tblMenu"
        Me.tblMenu.Size = New System.Drawing.Size(414, 271)
        Me.tblMenu.TabIndex = 0
        '
        'ProductName
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductName.DefaultCellStyle = DataGridViewCellStyle9
        Me.ProductName.FillWeight = 99.49239!
        Me.ProductName.HeaderText = "NAME"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ProductCategory
        '
        Me.ProductCategory.FillWeight = 99.49239!
        Me.ProductCategory.HeaderText = "CATEGORY"
        Me.ProductCategory.Name = "ProductCategory"
        Me.ProductCategory.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ProductPrice
        '
        Me.ProductPrice.FillWeight = 99.49239!
        Me.ProductPrice.HeaderText = "PRICE"
        Me.ProductPrice.Name = "ProductPrice"
        Me.ProductPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txtQty
        '
        Me.txtQty.HeaderText = "QUANTITY"
        Me.txtQty.Name = "txtQty"
        '
        'btnAddtoCart
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAddtoCart.DefaultCellStyle = DataGridViewCellStyle10
        Me.btnAddtoCart.FillWeight = 101.5228!
        Me.btnAddtoCart.HeaderText = ""
        Me.btnAddtoCart.Name = "btnAddtoCart"
        Me.btnAddtoCart.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnAddtoCart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnAddtoCart.Text = "Add to Cart"
        Me.btnAddtoCart.UseColumnTextForButtonValue = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnDeleteCart)
        Me.Panel2.Controls.Add(Me.btnCheckout)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(504, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(270, 312)
        Me.Panel2.TabIndex = 20
        '
        'btnDeleteCart
        '
        Me.btnDeleteCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnDeleteCart.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.delete__2_
        Me.btnDeleteCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteCart.FlatAppearance.BorderSize = 0
        Me.btnDeleteCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteCart.Location = New System.Drawing.Point(223, 20)
        Me.btnDeleteCart.Name = "btnDeleteCart"
        Me.btnDeleteCart.Size = New System.Drawing.Size(23, 20)
        Me.btnDeleteCart.TabIndex = 21
        Me.btnDeleteCart.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCheckout.FlatAppearance.BorderSize = 0
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCheckout.Location = New System.Drawing.Point(66, 270)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(144, 27)
        Me.btnCheckout.TabIndex = 26
        Me.btnCheckout.Text = "CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(204, 237)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(36, 18)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(34, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "TOTAL"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblOrders)
        Me.Panel3.Location = New System.Drawing.Point(18, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(230, 160)
        Me.Panel3.TabIndex = 23
        '
        'lblOrders
        '
        Me.lblOrders.AutoSize = True
        Me.lblOrders.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrders.Location = New System.Drawing.Point(7, 9)
        Me.lblOrders.Name = "lblOrders"
        Me.lblOrders.Size = New System.Drawing.Size(215, 51)
        Me.lblOrders.TabIndex = 0
        Me.lblOrders.Text = "1 X Chocolate Cake                 123.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 X Chocolate Cake                 123" &
    ".00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "-----------------------------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "CART"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnLogout.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.Brown_and_Black_Cute_Illustrative_Coffee_Presentation__3_
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(12, 415)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(44, 27)
        Me.btnLogout.TabIndex = 17
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblUserName)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "User"
        Me.Text = "User"
        Me.Panel1.ResumeLayout(False)
        CType(Me.tblMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents btnReload As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tblMenu As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblOrders As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnDeleteCart As Button
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents ProductCategory As DataGridViewTextBoxColumn
    Friend WithEvents ProductPrice As DataGridViewTextBoxColumn
    Friend WithEvents txtQty As DataGridViewTextBoxColumn
    Friend WithEvents btnAddtoCart As DataGridViewButtonColumn
    Friend WithEvents btnLogout As Button
End Class
