﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tblMenu = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.tblMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(824, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "👤 ADMIN"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tblMenu)
        Me.Panel1.Location = New System.Drawing.Point(443, 140)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 334)
        Me.Panel1.TabIndex = 2
        '
        'tblMenu
        '
        Me.tblMenu.AllowUserToAddRows = False
        Me.tblMenu.AllowUserToDeleteRows = False
        Me.tblMenu.AllowUserToResizeColumns = False
        Me.tblMenu.AllowUserToResizeRows = False
        Me.tblMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.tblMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.ProductName, Me.ProductCategory, Me.ProductPrice})
        Me.tblMenu.Location = New System.Drawing.Point(0, 0)
        Me.tblMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tblMenu.Name = "tblMenu"
        Me.tblMenu.ReadOnly = True
        Me.tblMenu.RowHeadersWidth = 51
        Me.tblMenu.Size = New System.Drawing.Size(552, 334)
        Me.tblMenu.TabIndex = 0
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "ID"
        Me.ProductID.MinimumWidth = 6
        Me.ProductID.Name = "ProductID"
        Me.ProductID.ReadOnly = True
        Me.ProductID.Width = 125
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "NAME"
        Me.ProductName.MinimumWidth = 6
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        Me.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductName.Width = 125
        '
        'ProductCategory
        '
        Me.ProductCategory.HeaderText = "CATEGORY"
        Me.ProductCategory.MinimumWidth = 6
        Me.ProductCategory.Name = "ProductCategory"
        Me.ProductCategory.ReadOnly = True
        Me.ProductCategory.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductCategory.Width = 124
        '
        'ProductPrice
        '
        Me.ProductPrice.HeaderText = "PRICE"
        Me.ProductPrice.MinimumWidth = 6
        Me.ProductPrice.Name = "ProductPrice"
        Me.ProductPrice.ReadOnly = True
        Me.ProductPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductPrice.Width = 125
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProductName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtProductName.ForeColor = System.Drawing.Color.Gray
        Me.txtProductName.Location = New System.Drawing.Point(53, 217)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Multiline = True
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(311, 28)
        Me.txtProductName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 191)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPrice.ForeColor = System.Drawing.Color.Gray
        Me.txtPrice.Location = New System.Drawing.Point(241, 288)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(123, 32)
        Me.txtPrice.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(240, 268)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(96, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ADD PRODUCT"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"🍰 Cake", "🍞 Bread", "🥧 Pastry", "🍪 Cookie", "🥤 Coffee"})
        Me.cmbCategory.Location = New System.Drawing.Point(53, 287)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(141, 33)
        Me.cmbCategory.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(51, 266)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Category"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(54, 363)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 33)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(259, 363)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 33)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(156, 422)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 33)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(635, 92)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(311, 28)
        Me.txtSearch.TabIndex = 13
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSearch.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.search
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(904, 92)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(41, 28)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnReload.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.load
        Me.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReload.FlatAppearance.BorderSize = 0
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Location = New System.Drawing.Point(952, 92)
        Me.btnReload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(41, 28)
        Me.btnReload.TabIndex = 15
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnLogout.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.Brown_and_Black_Cute_Illustrative_Coffee_Presentation__3_
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(16, 471)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(59, 33)
        Me.btnLogout.TabIndex = 16
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(205, 64)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 26)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "📄 ORDERS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(32, 64)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 26)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "☰  MENU"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeshopManagementSystem.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1049, 519)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COZY CRUST - Admin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.tblMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tblMenu As DataGridView
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents ProductCategory As DataGridViewTextBoxColumn
    Friend WithEvents ProductPrice As DataGridViewTextBoxColumn
    Friend WithEvents btnReload As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
