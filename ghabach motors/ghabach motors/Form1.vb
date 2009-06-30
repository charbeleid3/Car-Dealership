Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class Log_IN

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)












    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarDealershipDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.CarDealershipDataSet.users)

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Server=SAKR-PC; Database =CarDealership; Integrated Security = true")
        connection.Open()

        Dim dr As SqlClient.SqlDataReader

        Dim cmd As New SqlCommand("select * from [USERS] where Username = @username and password = @password", connection)

        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = UsernameTextBox.Text
        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = PasswordTextBox.Text
        dr = cmd.ExecuteReader


        If dr.Read Then
            client_select.Show()
            Me.Hide()


        Else
            MsgBox("Wrong Username or Password, Please Try again!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
