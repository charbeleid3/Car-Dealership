Public Class new_client

    Private Sub new_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarDealershipDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.CarDealershipDataSet.Client)

    End Sub

    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarDealershipDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        client_select.Show()
        Me.Hide()
    End Sub
End Class