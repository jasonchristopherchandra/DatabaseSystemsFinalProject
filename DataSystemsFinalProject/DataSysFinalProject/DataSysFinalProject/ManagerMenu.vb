Imports MySql.Data.MySqlClient

Public Class ManagerMenu
    Dim connection As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=resto2; SslMode=none")
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet

    Sub PopulateOrderGrid()
        Try
            dataSet = New DataSet()
            Dim column As String = ""
            Dim links As String = "o.item_id = i.item_id and o.customer_id = c.customer_id and"
            Dim tables As String = "orders o, item i, customer c"
            dataAdapter = New MySqlDataAdapter("SELECT c.customer_table, i.item_name, i.price, o.quantity, i.price*o.quantity FROM orders o, item i, customer c WHERE o.item_id = i.item_id and o.customer_id = c.customer_id and o.restaurant_id= " + LoginForm.restauraunt_id.ToString + ";", connection)
            dataAdapter.Fill(dataSet, "orders")
            OrderDataGrid.DataSource = dataSet
            OrderDataGrid.DataMember = "orders"
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Sub PopulateEmployeeGrid()
        Try
            dataSet = New DataSet()
            dataAdapter = New MySqlDataAdapter("SELECT employee_id, employee_name, username FROM employee WHERE restaurant_id=" + LoginForm.restauraunt_id.ToString + ";", connection)
            dataAdapter.Fill(dataSet, "employee")
            EmployeeDataGrid.DataSource = dataSet
            EmployeeDataGrid.DataMember = "employee"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PopulateStockGrid()
        Try
            dataSet = New DataSet()
            Dim column As String = "s. stock_id, s.stock, i.item_name"
            Dim links As String = "s.item_id = i.item_id and"
            Dim tables As String = "stock s, item i"
            dataAdapter = New MySqlDataAdapter("SELECT " + column + " FROM " + tables + " WHERE " + links + " s.restaurant_id= " + LoginForm.restauraunt_id.ToString + ";", connection)
            dataAdapter.Fill(dataSet, "stock")
            StockDataGrid.DataSource = dataSet
            StockDataGrid.DataMember = "stock"
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

    Sub PopulateItemGrid()
        Try
            dataSet = New DataSet()
            dataAdapter = New MySqlDataAdapter("SELECT item_id, item_name FROM item", connection)
            dataAdapter.Fill(dataSet, "items")
            ItemDataGrid.DataSource = dataSet
            ItemDataGrid.DataMember = "items"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateOrderGrid()
        PopulateEmployeeGrid()
        PopulateStockGrid()
        PopulateCustomerGrid()
        PopulateItemGrid()
    End Sub



    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        RegisterForm.Show()
        Me.Hide()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles OrdersTab.Click
        PopulateOrderGrid()
        RegisterButton.Show()
        OrderDataGrid.Show()
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        LoginForm.Show()
        Me.Dispose()
    End Sub

    Private Sub AddEmployeeButton_Click(sender As Object, e As EventArgs) Handles AddEmployeeButton.Click
        If String.Compare(add_EmployeeNameTextBox.Text, "") = 0 And String.Compare(add_UsernameTextBox.Text, "") = 0 And String.Compare(add_PasswordTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            Try
                connection.Open()
                Dim values As String = add_EmployeeNameTextBox.Text + "', 'employee', '" + add_UsernameTextBox.Text + "', '" + add_PasswordTextBox.Text + "', " + LoginForm.restauraunt_id.ToString
                command = New MySqlCommand("INSERT INTO employee(employee_name, role, username, password, restaurant_id) VALUES('" + values + ")", connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully added")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateEmployeeGrid()
    End Sub

    Private Sub RemoveEmployeeButton_Click(sender As Object, e As EventArgs) Handles RemoveEmployeeButton.Click
        If String.Compare(remove_EmployeeIDTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            Try
                connection.Open()
                command = New MySqlCommand("DELETE FROM employee WHERE employee_id =" + remove_EmployeeIDTextBox.Text + "AND restaurant_id=" + LoginForm.restauraunt_id.ToString, connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully removed")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateEmployeeGrid()
    End Sub

    Private Sub UpdateEmployeeButton_Click(sender As Object, e As EventArgs) Handles UpdateEmployeeButton.Click
        If String.Compare(update_EmployeeIDTextBox.Text, "") = 0 And String.Compare(update_EmployeeNameTextBox.Text, "") = 0 And String.Compare(update_EmployeeUsernameTextBox.Text, "") = 0 And String.Compare(update_EmployeePasswordTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            Try
                connection.Open()
                Dim values As String = "employee_name='" + update_EmployeeNameTextBox.Text + "', username='" + update_EmployeeUsernameTextBox.Text + "', password='" + update_EmployeePasswordTextBox.Text + "' "
                command = New MySqlCommand("UPDATE employee SET " + values + "WHERE employee_id=" + update_EmployeeIDTextBox.Text + " AND restaurant_id=" + LoginForm.restauraunt_id.ToString, connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully updated")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateEmployeeGrid()
    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddIStocktemButton.Click
        If String.Compare(add_Stock_ItemIDTextBox.Text, "") = 0 And String.Compare(add_StockTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            Try
                connection.Open()
                command = New MySqlCommand("INSERT INTO stock(item_id, stock, restaurant_id) VALUES(" + add_Stock_ItemIDTextBox.Text + ", " + add_StockTextBox.Text + ", " + LoginForm.restauraunt_id.ToString + ")", connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully added")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateStockGrid()
    End Sub

    Private Sub RemoveItemButton_Click(sender As Object, e As EventArgs) Handles RemoveStockButton.Click
        If String.Compare(remove_StockIDTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            Try
                connection.Open()
                command = New MySqlCommand("DELETE FROM stock WHERE stock_id =" + remove_StockIDTextBox.Text, connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully removed")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateStockGrid()
    End Sub

    Private Sub UpdateStockButton_Click(sender As Object, e As EventArgs) Handles UpdateStockButton.Click
        If String.Compare(update_StockIDTextBox.Text, "") = 0 And String.Compare(update_StockTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            Try
                connection.Open()
                command = New MySqlCommand("UPDATE stock SET stock=" + update_StockTextBox.Text + " WHERE stock_id =" + update_StockIDTextBox.Text, connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully updated")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateStockGrid()
    End Sub

    Private Sub AddCustomerButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddCustomerButton_Click_1(sender As Object, e As EventArgs) Handles AddCustomerButton.Click
        If String.Compare(add_CustomerNameTextBox.Text, "") = 0 And String.Compare(add_CustomerTableTextBox.Text, "") = 0 Then
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

    Private Sub RemoveCustomerButton_Click(sender As Object, e As EventArgs) Handles RemoveCustomerButton.Click
        If String.Compare(remove_CustomerIDTextBox.Text, "") = 0 Then
            MessageBox.Show("Please input table number")
        Else
            Try
                connection.Open()
                command = New MySqlCommand("DELETE FROM customer WHERE customer_id =" + remove_CustomerIDTextBox.Text, connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully removed")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateCustomerGrid()
    End Sub

    Private Sub UpdateCustomerButton_Click(sender As Object, e As EventArgs) Handles UpdateCustomerButton.Click
        If String.Compare(update_CustomerIDTextBox.Text, "") = 0 And String.Compare(update_CustomerNameTextBox.Text, "") = 0 And String.Compare(update_CustomerTableTextBox.Text, "") = 0 Then
            MessageBox.Show("Please properly input the data")
        Else
            Try
                connection.Open()
                command = New MySqlCommand("UPDATE customer SET customer_name = '" + update_CustomerNameTextBox.Text + "', customer_table=" + update_CustomerTableTextBox.Text + " WHERE customer_id =" + update_CustomerIDTextBox.Text, connection)
                reader = command.ExecuteReader()
                MessageBox.Show("Successfully updated")
                ResetText()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        connection.Close()
        PopulateCustomerGrid()
    End Sub

    Private Sub OrderDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderDataGrid.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class