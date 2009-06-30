Imports System.Data.SqlClient

Public Class Form2

    Private Sub RECEIPTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RECEIPTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarDealershipDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarDealershipDataSet.RECEIPT' table. You can move, or remove it, as needed.
        Me.RECEIPTTableAdapter.Fill(Me.CarDealershipDataSet.RECEIPT)

    End Sub
    Private Function GetDataSource() As DataTable
        Dim str As String = "Server=SAKR-PC; Database =CarDealership; Integrated Security = true"


        Const sqlSelect As String = "SELECT dbo.C_brand.brand_name, dbo.Client.client_id_show, dbo.Client.client_fname, dbo.MODEL.model_name, dbo.MODEL.car_year, dbo.RECEIPT.receipt_id FROM dbo.C_brand INNER JOIN dbo.MODEL ON dbo.C_brand.brand_id = dbo.MODEL.brand_id INNER JOIN dbo.RECEIPT ON dbo.MODEL.model_id = dbo.RECEIPT.model_id INNER JOIN dbo.Client ON dbo.RECEIPT.client_id = dbo.Client.Client_ID"
        Try
            Dim table = New DataTable()
            Using con As New SqlConnection(str)
                con.Open()
                Using da = New SqlDataAdapter(sqlSelect, con)
                    da.Fill(table)
                    Return table
                End Using
            End Using
        Catch ex As Exception
            ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles View.Click
        'Dim str As String = "Server=SAKR-PC; Database =CarDealership; Integrated Security = true"

        'Dim con As New SqlConnection(str)

        'Dim com As String = "SELECT dbo.C_brand.brand_name, dbo.Client.client_id_show,FROM dbo.C_brand INNER JOIN dbo.MODEL ON dbo.C_brand.brand_id = dbo.MODEL.brand_id INNER JOIN dbo.RECEIPT ON dbo.MODEL.model_id = dbo.RECEIPT.model_id INNER JOIN dbo.Client ON dbo.RECEIPT.client_id = dbo.Client.Client_ID"

        'Dim Adpt As New SqlDataAdapter(com, con)

        'Dim ds As New DataSet()

        'Adpt.Fill(ds, "Emp")

        'DataGridView1.DataSource = ds.Tables(0)
        Me.DataGridView1.DataSource = GetDataSource()
    End Sub

    Private Sub ChooseClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChooseClientToolStripMenuItem.Click
        client_select.Show()
        Me.Hide()
    End Sub

    Private Sub ChooseCarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChooseCarToolStripMenuItem.Click
        choose_car.Show()
        Me.Hide()
    End Sub
End Class