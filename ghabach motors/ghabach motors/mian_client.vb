Public Class client_select

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarDealershipDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.CarDealershipDataSet.Client)
        'TODO: This line of code loads data into the 'CarDealershipDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.CarDealershipDataSet.Client)
        'TODO: This line of code loads data into the 'CarDealershipDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.CarDealershipDataSet.Client)

    End Sub

    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarDealershipDataSet)

    End Sub

    Private Sub ClientBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarDealershipDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ClientBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ClientBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        new_client.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        choose_car.Show()

    End Sub

    Private Sub ChooseCarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChooseCarToolStripMenuItem.Click
        choose_car.Show()
        Me.Hide()
    End Sub

    Private Sub ViewPurchasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPurchasesToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class