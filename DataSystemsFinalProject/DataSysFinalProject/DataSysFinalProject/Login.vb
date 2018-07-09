Imports MySql.Data.MySqlClient

Public Class LoginForm

    Public Shared role As String
    Public Shared restauraunt_id As Integer = 1

    Dim connection As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=resto2; SslMode=none")
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader



    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ClearTextBox()
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        connection.Open()
        command = New MySqlCommand("SELECT username, password, role, restaurant_id from employee", connection)
        reader = command.ExecuteReader
        While reader.Read
            If String.Compare(reader("username"), UsernameTextBox.Text) = 0 Then
                If String.Compare(reader("password"), PasswordTextBox.Text) = 0 Then
                    restauraunt_id = reader("restaurant_id")
                    If String.Compare(reader("role"), "manager") = 0 Then
                        role = "manager"
                        connection.Close()
                        ManagerMenu.Show()
                    ElseIf String.Compare(reader("role"), "employee") = 0 Then
                        role = "employee"
                        connection.Close()
                        RegisterForm.Show()
                    End If
                    ClearTextBox()
                    Me.Hide()
                    Return
                Else
                    PasswordTextBox.Text = ""
                End If
            End If
        End While
        ClearTextBox()
        connection.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class