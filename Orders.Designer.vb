﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.tblMenu = New System.Windows.Forms.DataGridView()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddtoCart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        CType(Me.tblMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserName.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(815, 8)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(189, 39)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "👤 ADMIN"
        '
        'tblMenu
        '
        Me.tblMenu.AllowUserToOrderColumns = True
        Me.tblMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.tblMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductName, Me.ProductCategory, Me.ProductPrice, Me.txtQty, Me.btnAddtoCart, Me.STATUS})
        Me.tblMenu.Location = New System.Drawing.Point(0, 0)
        Me.tblMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tblMenu.Name = "tblMenu"
        Me.tblMenu.RowHeadersWidth = 51
        Me.tblMenu.Size = New System.Drawing.Size(931, 319)
        Me.tblMenu.TabIndex = 4
        '
        'ProductName
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductName.DefaultCellStyle = DataGridViewCellStyle1
        Me.ProductName.FillWeight = 99.49239!
        Me.ProductName.HeaderText = "ID"
        Me.ProductName.MinimumWidth = 6
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ProductCategory
        '
        Me.ProductCategory.FillWeight = 99.49239!
        Me.ProductCategory.HeaderText = "ITEM"
        Me.ProductCategory.MinimumWidth = 6
        Me.ProductCategory.Name = "ProductCategory"
        Me.ProductCategory.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ProductPrice
        '
        Me.ProductPrice.FillWeight = 99.49239!
        Me.ProductPrice.HeaderText = "PRICE"
        Me.ProductPrice.MinimumWidth = 6
        Me.ProductPrice.Name = "ProductPrice"
        Me.ProductPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txtQty
        '
        Me.txtQty.HeaderText = "QUANTITY"
        Me.txtQty.MinimumWidth = 6
        Me.txtQty.Name = "txtQty"
        '
        'btnAddtoCart
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAddtoCart.DefaultCellStyle = DataGridViewCellStyle2
        Me.btnAddtoCart.FillWeight = 101.5228!
        Me.btnAddtoCart.HeaderText = "TOTAL"
        Me.btnAddtoCart.MinimumWidth = 6
        Me.btnAddtoCart.Name = "btnAddtoCart"
        Me.btnAddtoCart.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.MinimumWidth = 6
        Me.STATUS.Name = "STATUS"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.tblMenu)
        Me.Panel1.Location = New System.Drawing.Point(64, 148)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 320)
        Me.Panel1.TabIndex = 5
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnReload.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.load
        Me.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReload.FlatAppearance.BorderSize = 0
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Location = New System.Drawing.Point(953, 86)
        Me.btnReload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(41, 28)
        Me.btnReload.TabIndex = 18
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSearch.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.search
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(905, 86)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(41, 28)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(636, 86)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(311, 28)
        Me.txtSearch.TabIndex = 16
        '
        'btnComplete
        '
        Me.btnComplete.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnComplete.FlatAppearance.BorderSize = 0
        Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComplete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnComplete.Location = New System.Drawing.Point(741, 490)
        Me.btnComplete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(119, 33)
        Me.btnComplete.TabIndex = 19
        Me.btnComplete.Text = "COMPLETE"
        Me.btnComplete.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(876, 490)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 33)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnLogout.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.Brown_and_Black_Cute_Illustrative_Coffee_Presentation__3_
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(16, 506)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(59, 33)
        Me.btnLogout.TabIndex = 21
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnMenu.Location = New System.Drawing.Point(32, 64)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(119, 26)
        Me.btnMenu.TabIndex = 22
        Me.btnMenu.Text = "☰  MENU"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnOrders
        '
        Me.btnOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnOrders.Location = New System.Drawing.Point(205, 64)
        Me.btnOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(119, 26)
        Me.btnOrders.TabIndex = 23
        Me.btnOrders.Text = "📄 ORDERS"
        Me.btnOrders.UseVisualStyleBackColor = False
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnOrders)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblUserName)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COZY CRUST - Orders"
        CType(Me.tblMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents tblMenu As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents ProductCategory As DataGridViewTextBoxColumn
    Friend WithEvents ProductPrice As DataGridViewTextBoxColumn
    Friend WithEvents txtQty As DataGridViewTextBoxColumn
    Friend WithEvents btnAddtoCart As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents btnReload As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnComplete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnOrders As Button
End Class
