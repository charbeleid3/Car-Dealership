Public Class new_client


    Private Sub new_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'CarDealershipDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.CarDealershipDataSet.Client)
        Client_id_showTextBox.Clear()
        Client_fnameTextBox.Clear()
        Client_lnameTextBox.Clear()
        Client_telTextBox.Clear()
        Client_emailTextBox.Clear()

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

    Private Sub ClientBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles ClientBindingNavigator.RefreshItems

    End Sub

    Private Sub ChooseCarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChooseCarToolStripMenuItem.Click
        choose_car.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class