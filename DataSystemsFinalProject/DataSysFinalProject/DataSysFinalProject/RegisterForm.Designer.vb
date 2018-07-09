<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.RegisterDataGrid = New System.Windows.Forms.DataGridView()
        Me.BillTab = New System.Windows.Forms.TabPage()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.BillButton = New System.Windows.Forms.Button()
        Me.bill_TableNoTextBox = New System.Windows.Forms.TextBox()
        Me.bill_TableNoLabel = New System.Windows.Forms.Label()
        Me.UpdateOrderTab = New System.Windows.Forms.TabPage()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.update_QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.update_OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.update_QuantityLabel = New System.Windows.Forms.Label()
        Me.update_OrderIDLabel = New System.Windows.Forms.Label()
        Me.RemoveOrderTab = New System.Windows.Forms.TabPage()
        Me.RemoveOrderButton = New System.Windows.Forms.Button()
        Me.remove_OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.OrderIDLabel = New System.Windows.Forms.Label()
        Me.AddOrderTab = New System.Windows.Forms.TabPage()
        Me.AddOrderButton = New System.Windows.Forms.Button()
        Me.add_CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.add_QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.add_ItemIDTextBox = New System.Windows.Forms.TextBox()
        Me.add_CustomerIDLabel = New System.Windows.Forms.Label()
        Me.add_QuantityLabel = New System.Windows.Forms.Label()
        Me.add_ItemIDLabel = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AddCustomerButton = New System.Windows.Forms.Button()
        Me.add_CustomerTableTextBox = New System.Windows.Forms.TextBox()
        Me.add_CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.add_CustomerTableLabel = New System.Windows.Forms.Label()
        Me.add_CustomerNameLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ItemDataGrid = New System.Windows.Forms.DataGridView()
        Me.CustomerDataGrid = New System.Windows.Forms.DataGridView()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.RegisterDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BillTab.SuspendLayout()
        Me.UpdateOrderTab.SuspendLayout()
        Me.RemoveOrderTab.SuspendLayout()
        Me.AddOrderTab.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ItemDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegisterDataGrid
        '
        Me.RegisterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegisterDataGrid.Location = New System.Drawing.Point(12, 12)
        Me.RegisterDataGrid.Name = "RegisterDataGrid"
        Me.RegisterDataGrid.Size = New System.Drawing.Size(408, 233)
        Me.RegisterDataGrid.TabIndex = 0
        '
        'BillTab
        '
        Me.BillTab.Controls.Add(Me.TotalLabel)
        Me.BillTab.Controls.Add(Me.BillButton)
        Me.BillTab.Controls.Add(Me.bill_TableNoTextBox)
        Me.BillTab.Controls.Add(Me.bill_TableNoLabel)
        Me.BillTab.Location = New System.Drawing.Point(4, 22)
        Me.BillTab.Name = "BillTab"
        Me.BillTab.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.BillTab.Size = New System.Drawing.Size(400, 122)
        Me.BillTab.TabIndex = 13
        Me.BillTab.Text = "Get Bill"
        Me.BillTab.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(11, 44)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(0, 13)
        Me.TotalLabel.TabIndex = 17
        '
        'BillButton
        '
        Me.BillButton.Location = New System.Drawing.Point(319, 93)
        Me.BillButton.Name = "BillButton"
        Me.BillButton.Size = New System.Drawing.Size(75, 23)
        Me.BillButton.TabIndex = 16
        Me.BillButton.Text = "Get Bill"
        Me.BillButton.UseVisualStyleBackColor = True
        '
        'bill_TableNoTextBox
        '
        Me.bill_TableNoTextBox.Location = New System.Drawing.Point(98, 9)
        Me.bill_TableNoTextBox.Name = "bill_TableNoTextBox"
        Me.bill_TableNoTextBox.Size = New System.Drawing.Size(296, 20)
        Me.bill_TableNoTextBox.TabIndex = 10
        '
        'bill_TableNoLabel
        '
        Me.bill_TableNoLabel.AutoSize = True
        Me.bill_TableNoLabel.Location = New System.Drawing.Point(11, 12)
        Me.bill_TableNoLabel.Name = "bill_TableNoLabel"
        Me.bill_TableNoLabel.Size = New System.Drawing.Size(74, 13)
        Me.bill_TableNoLabel.TabIndex = 8
        Me.bill_TableNoLabel.Text = "Table Number"
        '
        'UpdateOrderTab
        '
        Me.UpdateOrderTab.Controls.Add(Me.UpdateButton)
        Me.UpdateOrderTab.Controls.Add(Me.update_QuantityTextBox)
        Me.UpdateOrderTab.Controls.Add(Me.update_OrderIDTextBox)
        Me.UpdateOrderTab.Controls.Add(Me.update_QuantityLabel)
        Me.UpdateOrderTab.Controls.Add(Me.update_OrderIDLabel)
        Me.UpdateOrderTab.Location = New System.Drawing.Point(4, 22)
        Me.UpdateOrderTab.Name = "UpdateOrderTab"
        Me.UpdateOrderTab.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.UpdateOrderTab.Size = New System.Drawing.Size(400, 122)
        Me.UpdateOrderTab.TabIndex = 12
        Me.UpdateOrderTab.Text = "Update Quantity"
        Me.UpdateOrderTab.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(319, 93)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 16
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'update_QuantityTextBox
        '
        Me.update_QuantityTextBox.Location = New System.Drawing.Point(98, 35)
        Me.update_QuantityTextBox.Name = "update_QuantityTextBox"
        Me.update_QuantityTextBox.Size = New System.Drawing.Size(296, 20)
        Me.update_QuantityTextBox.TabIndex = 13
        '
        'update_OrderIDTextBox
        '
        Me.update_OrderIDTextBox.Location = New System.Drawing.Point(98, 9)
        Me.update_OrderIDTextBox.Name = "update_OrderIDTextBox"
        Me.update_OrderIDTextBox.Size = New System.Drawing.Size(296, 20)
        Me.update_OrderIDTextBox.TabIndex = 10
        '
        'update_QuantityLabel
        '
        Me.update_QuantityLabel.AutoSize = True
        Me.update_QuantityLabel.Location = New System.Drawing.Point(11, 38)
        Me.update_QuantityLabel.Name = "update_QuantityLabel"
        Me.update_QuantityLabel.Size = New System.Drawing.Size(46, 13)
        Me.update_QuantityLabel.TabIndex = 9
        Me.update_QuantityLabel.Text = "Quantity"
        '
        'update_OrderIDLabel
        '
        Me.update_OrderIDLabel.AutoSize = True
        Me.update_OrderIDLabel.Location = New System.Drawing.Point(11, 12)
        Me.update_OrderIDLabel.Name = "update_OrderIDLabel"
        Me.update_OrderIDLabel.Size = New System.Drawing.Size(47, 13)
        Me.update_OrderIDLabel.TabIndex = 8
        Me.update_OrderIDLabel.Text = "Order ID"
        '
        'RemoveOrderTab
        '
        Me.RemoveOrderTab.Controls.Add(Me.RemoveOrderButton)
        Me.RemoveOrderTab.Controls.Add(Me.remove_OrderIDTextBox)
        Me.RemoveOrderTab.Controls.Add(Me.OrderIDLabel)
        Me.RemoveOrderTab.Location = New System.Drawing.Point(4, 22)
        Me.RemoveOrderTab.Name = "RemoveOrderTab"
        Me.RemoveOrderTab.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.RemoveOrderTab.Size = New System.Drawing.Size(400, 122)
        Me.RemoveOrderTab.TabIndex = 11
        Me.RemoveOrderTab.Text = "Remove Order"
        Me.RemoveOrderTab.UseVisualStyleBackColor = True
        '
        'RemoveOrderButton
        '
        Me.RemoveOrderButton.Location = New System.Drawing.Point(319, 93)
        Me.RemoveOrderButton.Name = "RemoveOrderButton"
        Me.RemoveOrderButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveOrderButton.TabIndex = 16
        Me.RemoveOrderButton.Text = "Remove"
        Me.RemoveOrderButton.UseVisualStyleBackColor = True
        '
        'remove_OrderIDTextBox
        '
        Me.remove_OrderIDTextBox.Location = New System.Drawing.Point(98, 9)
        Me.remove_OrderIDTextBox.Name = "remove_OrderIDTextBox"
        Me.remove_OrderIDTextBox.Size = New System.Drawing.Size(296, 20)
        Me.remove_OrderIDTextBox.TabIndex = 10
        '
        'OrderIDLabel
        '
        Me.OrderIDLabel.AutoSize = True
        Me.OrderIDLabel.Location = New System.Drawing.Point(11, 12)
        Me.OrderIDLabel.Name = "OrderIDLabel"
        Me.OrderIDLabel.Size = New System.Drawing.Size(47, 13)
        Me.OrderIDLabel.TabIndex = 8
        Me.OrderIDLabel.Text = "Order ID"
        '
        'AddOrderTab
        '
        Me.AddOrderTab.Controls.Add(Me.AddOrderButton)
        Me.AddOrderTab.Controls.Add(Me.add_CustomerIDTextBox)
        Me.AddOrderTab.Controls.Add(Me.add_QuantityTextBox)
        Me.AddOrderTab.Controls.Add(Me.add_ItemIDTextBox)
        Me.AddOrderTab.Controls.Add(Me.add_CustomerIDLabel)
        Me.AddOrderTab.Controls.Add(Me.add_QuantityLabel)
        Me.AddOrderTab.Controls.Add(Me.add_ItemIDLabel)
        Me.AddOrderTab.Location = New System.Drawing.Point(4, 22)
        Me.AddOrderTab.Name = "AddOrderTab"
        Me.AddOrderTab.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.AddOrderTab.Size = New System.Drawing.Size(400, 122)
        Me.AddOrderTab.TabIndex = 8
        Me.AddOrderTab.Text = "Add Order"
        Me.AddOrderTab.UseVisualStyleBackColor = True
        '
        'AddOrderButton
        '
        Me.AddOrderButton.Location = New System.Drawing.Point(319, 93)
        Me.AddOrderButton.Name = "AddOrderButton"
        Me.AddOrderButton.Size = New System.Drawing.Size(75, 23)
        Me.AddOrderButton.TabIndex = 16
        Me.AddOrderButton.Text = "Add"
        Me.AddOrderButton.UseVisualStyleBackColor = True
        '
        'add_CustomerIDTextBox
        '
        Me.add_CustomerIDTextBox.Location = New System.Drawing.Point(98, 61)
        Me.add_CustomerIDTextBox.Name = "add_CustomerIDTextBox"
        Me.add_CustomerIDTextBox.Size = New System.Drawing.Size(296, 20)
        Me.add_CustomerIDTextBox.TabIndex = 14
        '
        'add_QuantityTextBox
        '
        Me.add_QuantityTextBox.Location = New System.Drawing.Point(98, 35)
        Me.add_QuantityTextBox.Name = "add_QuantityTextBox"
        Me.add_QuantityTextBox.Size = New System.Drawing.Size(296, 20)
        Me.add_QuantityTextBox.TabIndex = 13
        '
        'add_ItemIDTextBox
        '
        Me.add_ItemIDTextBox.Location = New System.Drawing.Point(98, 9)
        Me.add_ItemIDTextBox.Name = "add_ItemIDTextBox"
        Me.add_ItemIDTextBox.Size = New System.Drawing.Size(296, 20)
        Me.add_ItemIDTextBox.TabIndex = 10
        '
        'add_CustomerIDLabel
        '
        Me.add_CustomerIDLabel.AutoSize = True
        Me.add_CustomerIDLabel.Location = New System.Drawing.Point(11, 64)
        Me.add_CustomerIDLabel.Name = "add_CustomerIDLabel"
        Me.add_CustomerIDLabel.Size = New System.Drawing.Size(65, 13)
        Me.add_CustomerIDLabel.TabIndex = 11
        Me.add_CustomerIDLabel.Text = "Customer ID"
        '
        'add_QuantityLabel
        '
        Me.add_QuantityLabel.AutoSize = True
        Me.add_QuantityLabel.Location = New System.Drawing.Point(11, 38)
        Me.add_QuantityLabel.Name = "add_QuantityLabel"
        Me.add_QuantityLabel.Size = New System.Drawing.Size(46, 13)
        Me.add_QuantityLabel.TabIndex = 9
        Me.add_QuantityLabel.Text = "Quantity"
        '
        'add_ItemIDLabel
        '
        Me.add_ItemIDLabel.AutoSize = True
        Me.add_ItemIDLabel.Location = New System.Drawing.Point(11, 12)
        Me.add_ItemIDLabel.Name = "add_ItemIDLabel"
        Me.add_ItemIDLabel.Size = New System.Drawing.Size(41, 13)
        Me.add_ItemIDLabel.TabIndex = 8
        Me.add_ItemIDLabel.Text = "Item ID"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.AddOrderTab)
        Me.TabControl.Controls.Add(Me.RemoveOrderTab)
        Me.TabControl.Controls.Add(Me.UpdateOrderTab)
        Me.TabControl.Controls.Add(Me.BillTab)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Location = New System.Drawing.Point(12, 252)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(408, 148)
        Me.TabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AddCustomerButton)
        Me.TabPage1.Controls.Add(Me.add_CustomerTableTextBox)
        Me.TabPage1.Controls.Add(Me.add_CustomerNameTextBox)
        Me.TabPage1.Controls.Add(Me.add_CustomerTableLabel)
        Me.TabPage1.Controls.Add(Me.add_CustomerNameLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(400, 122)
        Me.TabPage1.TabIndex = 14
        Me.TabPage1.Text = "Add Customer"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'AddCustomerButton
        '
        Me.AddCustomerButton.Location = New System.Drawing.Point(319, 93)
        Me.AddCustomerButton.Name = "AddCustomerButton"
        Me.AddCustomerButton.Size = New System.Drawing.Size(75, 23)
        Me.AddCustomerButton.TabIndex = 16
        Me.AddCustomerButton.Text = "Add"
        Me.AddCustomerButton.UseVisualStyleBackColor = True
        '
        'add_CustomerTableTextBox
        '
        Me.add_CustomerTableTextBox.Location = New System.Drawing.Point(98, 35)
        Me.add_CustomerTableTextBox.Name = "add_CustomerTableTextBox"
        Me.add_CustomerTableTextBox.Size = New System.Drawing.Size(296, 20)
        Me.add_CustomerTableTextBox.TabIndex = 13
        '
        'add_CustomerNameTextBox
        '
        Me.add_CustomerNameTextBox.Location = New System.Drawing.Point(98, 9)
        Me.add_CustomerNameTextBox.Name = "add_CustomerNameTextBox"
        Me.add_CustomerNameTextBox.Size = New System.Drawing.Size(296, 20)
        Me.add_CustomerNameTextBox.TabIndex = 10
        '
        'add_CustomerTableLabel
        '
        Me.add_CustomerTableLabel.AutoSize = True
        Me.add_CustomerTableLabel.Location = New System.Drawing.Point(11, 38)
        Me.add_CustomerTableLabel.Name = "add_CustomerTableLabel"
        Me.add_CustomerTableLabel.Size = New System.Drawing.Size(81, 13)
        Me.add_CustomerTableLabel.TabIndex = 9
        Me.add_CustomerTableLabel.Text = "Customer Table"
        '
        'add_CustomerNameLabel
        '
        Me.add_CustomerNameLabel.AutoSize = True
        Me.add_CustomerNameLabel.Location = New System.Drawing.Point(11, 12)
        Me.add_CustomerNameLabel.Name = "add_CustomerNameLabel"
        Me.add_CustomerNameLabel.Size = New System.Drawing.Size(82, 13)
        Me.add_CustomerNameLabel.TabIndex = 8
        Me.add_CustomerNameLabel.Text = "Customer Name"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(734, 437)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "Logout"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ItemDataGrid
        '
        Me.ItemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemDataGrid.Location = New System.Drawing.Point(444, 12)
        Me.ItemDataGrid.Name = "ItemDataGrid"
        Me.ItemDataGrid.Size = New System.Drawing.Size(179, 355)
        Me.ItemDataGrid.TabIndex = 3
        '
        'CustomerDataGrid
        '
        Me.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGrid.Location = New System.Drawing.Point(630, 12)
        Me.CustomerDataGrid.Name = "CustomerDataGrid"
        Me.CustomerDataGrid.Size = New System.Drawing.Size(179, 355)
        Me.CustomerDataGrid.TabIndex = 4
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(595, 374)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 5
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.8!)
        Me.Label3.Location = New System.Drawing.Point(111, 453)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 9)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Farras Yamin  2101704584"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.8!)
        Me.Label6.Location = New System.Drawing.Point(256, 453)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 9)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = " Arkaan Nofarditya Ashadi  2101718425"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.8!)
        Me.Label5.Location = New System.Drawing.Point(429, 453)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 9)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Jason Christopher Chandra  2101725033"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 470)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.CustomerDataGrid)
        Me.Controls.Add(Me.ItemDataGrid)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.RegisterDataGrid)
        Me.Name = "RegisterForm"
        Me.Text = "Register"
        CType(Me.RegisterDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BillTab.ResumeLayout(False)
        Me.BillTab.PerformLayout()
        Me.UpdateOrderTab.ResumeLayout(False)
        Me.UpdateOrderTab.PerformLayout()
        Me.RemoveOrderTab.ResumeLayout(False)
        Me.RemoveOrderTab.PerformLayout()
        Me.AddOrderTab.ResumeLayout(False)
        Me.AddOrderTab.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ItemDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegisterDataGrid As DataGridView
    Friend WithEvents BillTab As TabPage
    Friend WithEvents TotalLabel As Label
    Friend WithEvents BillButton As Button
    Friend WithEvents bill_TableNoTextBox As TextBox
    Friend WithEvents bill_TableNoLabel As Label
    Friend WithEvents UpdateOrderTab As TabPage
    Friend WithEvents UpdateButton As Button
    Friend WithEvents update_QuantityTextBox As TextBox
    Friend WithEvents update_OrderIDTextBox As TextBox
    Friend WithEvents update_QuantityLabel As Label
    Friend WithEvents update_OrderIDLabel As Label
    Friend WithEvents RemoveOrderTab As TabPage
    Friend WithEvents RemoveOrderButton As Button
    Friend WithEvents remove_OrderIDTextBox As TextBox
    Friend WithEvents OrderIDLabel As Label
    Friend WithEvents AddOrderTab As TabPage
    Friend WithEvents AddOrderButton As Button
    Friend WithEvents add_CustomerIDTextBox As TextBox
    Friend WithEvents add_QuantityTextBox As TextBox
    Friend WithEvents add_ItemIDTextBox As TextBox
    Friend WithEvents add_CustomerIDLabel As Label
    Friend WithEvents add_QuantityLabel As Label
    Friend WithEvents add_ItemIDLabel As Label
    Friend WithEvents TabControl As TabControl
    Friend WithEvents BackButton As Button
    Friend WithEvents ItemDataGrid As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents AddCustomerButton As Button
    Friend WithEvents add_CustomerTableTextBox As TextBox
    Friend WithEvents add_CustomerNameTextBox As TextBox
    Friend WithEvents add_CustomerTableLabel As Label
    Friend WithEvents add_CustomerNameLabel As Label
    Friend WithEvents CustomerDataGrid As DataGridView
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
