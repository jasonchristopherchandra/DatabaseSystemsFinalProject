Imports MySql.Data.MySqlClient
Public Class RegisterForm

    Dim connection As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=resto2; SslMode=none")
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet

    Sub PopulateGrid(column As String, tables As String, condition As String)
        Try
            dataSet = New DataSet()
            dataAdapter = New MySqlDataAdapter("SELECT " + column + " FROM " + tables + " WHERE " + condition + " and o.restaurant_id=" + LoginForm.restauraunt_id.ToString, connection)
            dataAdapter.Fill(dataSet, "orders")
            RegisterDataGrid.DataSource = dataSet
            RegisterDataGrid.DataMember = "orders"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PopulateCustomerGrid()
        Try
            dataSet = New DataSet()
            dataAdapter = New MySqlDataAdapter("SELECT customer_id, customer_name, customer_table FROM customer;", connection)
            dataAdapter.Fill(dataSet, "customer")
            CustomerDataGrid.DataSource = dataSet
            CustomerDataGrid.DataMember = "customer"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub ResetText()
        add_ItemIDTextBox.Text = ""
        add_QuantityTextBox.Text = ""
        add_CustomerIDTextBox.Text = ""
        remove_OrderIDTextBox.Text = ""
        update_OrderIDTextBox.Text = ""
        update_QuantityTextBox.Text = ""
        bill_TableNoTextBox.Text = ""
        add_CustomerNameTextBox.Text = ""
        add_CustomerTableTextBox.Text = ""
    End Sub

    Sub Refresh()
        PopulateGrid("o.order_id, i.item_name, i.price, o.quantity, c.customer_table", "orders o, item i, customer c", "o.item_id = i.item_id and o.customer_id = c.customer_id")
        If String.Compare(LoginForm.role, "manager") = 0 Then
            BackButton.Text = "Back"
        End If

        Try
            dataSet = New DataSet()
            dataAdapter = New MySqlDataAdapter("SELECT item_id, item_name FROM item", connection)
            dataAdapter.Fill(dataSet, "items")
            ItemDataGrid.DataSource = dataSet
            ItemDataGrid.DataMember = "items"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            dataSet = New DataSet()
            dataAdapter = New MySqlDataAdapter("SELECT * FROM customer", connection)
            dataAdapter.Fill(dataSet, "customers")
            CustomerDataGrid.DataSource = dataSet
            CustomerDataGrid.DataMember = "customers"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh()
    End Sub

    Private Sub AddOrderButton_Click(sender As Object, e As EventArgs) Handles AddOrderButton.Click
        If String.Compare(add_ItemIDTextBox.Text, "") = 0 Or String.Compare(add_QuantityTextBox.Text, "") = 0 Or String.Compare(add_CustomerIDTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            Try
                connection.Open()
                command = New MySqlCommand("INSERT INTO orders(item_id, quantity, customer_id, restaurant_id) VALUES(" + add_ItemIDTextBox.Text + "," + add_QuantityTextBox.Text + "," + add_CustomerIDTextBox.Text + "," + LoginForm.restauraunt_id.ToString + ");", connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully added")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateGrid("o.order_id, i.item_name, i.price, o.quantity, c.customer_table", "orders o, item i, customer c", "o.item_id = i.item_id and o.customer_id = c.customer_id")
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If String.Compare(update_OrderIDTextBox.Text, "") = 0 Or String.Compare(update_QuantityTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            Try
                connection.Open()
                command = New MySqlCommand("UPDATE orders SET quantity=" + update_QuantityTextBox.Text + " WHERE order_id=" + update_OrderIDTextBox.Text + ";", connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully updated")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateGrid("o.order_id, i.item_name, i.price, o.quantity, c.customer_table", "orders o, item i, customer c", "o.item_id = i.item_id and o.customer_id = c.customer_id")
    End Sub

    Private Sub RemoveOrderButton_Click(sender As Object, e As EventArgs) Handles RemoveOrderButton.Click
        If String.Compare(remove_OrderIDTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            Try
                connection.Open()
                command = New MySqlCommand("DELETE FROM orders WHERE order_id=" + remove_OrderIDTextBox.Text + ";", connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully removed")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateGrid("o.order_id, i.item_name, i.price, o.quantity, c.customer_table", "orders o, item i, customer c", "o.item_id = i.item_id and o.customer_id = c.customer_id")
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If String.Compare(LoginForm.role, "manager") = 0 Then
            ManagerMenu.Show()
        Else
            LoginForm.Show()
        End If
        Me.Dispose()
    End Sub

    Private Sub BillButton_Click(sender As Object, e As EventArgs) Handles BillButton.Click
        If String.Compare(bill_TableNoTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            PopulateGrid("o.order_id, i.item_name, i.price, o.quantity, c.customer_table", "orders o, item i, customer c", "o.item_id = i.item_id AND o.customer_id = c.customer_id AND c.customer_table=" + bill_TableNoTextBox.Text)
            Try
                connection.Open()
                Dim tables As String = "orders o, item i, customer c"
                Dim condition As String = "o.item_id = i.item_id AND o.customer_id = c.customer_id AND c.customer_table=" + bill_TableNoTextBox.Text + " AND restaurant_id=" + LoginForm.restauraunt_id.ToString
                command = New MySqlCommand("SELECT SUM(i.price*o.quantity) FROM " + tables + " WHERE " + condition + ";", connection)
                reader = command.ExecuteReader
                reader.Read()
                TotalLabel.Text = "Total: " + reader("SUM(i.price*o.quantity)").ToString
                connection.Close()

                connection.Open()
                command = New MySqlCommand("DELETE FROM orders WHERE customer_id = (SELECT customer_id from customer WHERE customer_table=" + bill_TableNoTextBox.Text + " );", connection)
                reader = command.ExecuteReader
                connection.Close()

                connection.Open()
                command = New MySqlCommand("DELETE FROM customer WHERE customer_table= " + bill_TableNoTextBox.Text, connection)
                reader = command.ExecuteReader
                connection.Close()
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            PopulateGrid("o.order_id, i.item_name, i.price, o.quantity, c.customer_table", "orders o, item i, customer c", "o.item_id = i.item_id and o.customer_id = c.customer_id")
            PopulateCustomerGrid()
        End If
    End Sub

    Private Sub AddCustomerButton_Click(sender As Object, e As EventArgs) Handles AddCustomerButton.Click
        If String.Compare(add_CustomerTableTextBox.Text, "") = 0 Then
            MessageBox.Show("Please input table number")
        Else
            Try
                connection.Open()
                command = New MySqlCommand("INSERT INTO customer(customer_name, customer_table) VALUES('" + add_CustomerNameTextBox.Text + "'," + add_CustomerTableTextBox.Text + ");", connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully added")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateCustomerGrid()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Refresh()
    End Sub
End Class