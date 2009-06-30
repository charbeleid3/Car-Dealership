Public Class choose_car
    Dim taxval As String
    Dim tax As String
    Dim total As String
    Private Sub RECEIPTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RECEIPTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RECEIPTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarDealershipDataSet)

    End Sub

    Private Sub choose_car_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'CarDealershipDataSet.MODEL' table. You can move, or remove it, as needed.
        Me.MODELTableAdapter.Fill(Me.CarDealershipDataSet.MODEL)
        'TODO: This line of code loads data into the 'CarDealershipDataSet.C_brand' table. You can move, or remove it, as needed.
        Me.C_brandTableAdapter.Fill(Me.CarDealershipDataSet.C_brand)
        'TODO: This line of code loads data into the 'CarDealershipDataSet.CAR' table. You can move, or remove it, as needed.
        Me.MODELTableAdapter.Fill(Me.CarDealershipDataSet.MODEL)
        'TODO: This line of code loads data into the 'CarDealershipDataSet.CAR' table. You can move, or remove it, as needed.
        Me.MODELTableAdapter.Fill(Me.CarDealershipDataSet.MODEL)
        'TODO: This line of code loads data into the 'CarDealershipDataSet.CAR' table. You can move, or remove it, as needed.
        Me.MODELTableAdapter.Fill(Me.CarDealershipDataSet.MODEL)
        'TODO: This line of code loads data into the 'CarDealershipDataSet.RECEIPT' table. You can move, or remove it, as needed.
        Me.RECEIPTTableAdapter.Fill(Me.CarDealershipDataSet.RECEIPT)

    End Sub

    Private Sub Brand_nameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Brand_nameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Brand_nameComboBox.SelectedIndexChanged

    End Sub

    Private Sub Model_nameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        taxval = 0.1
        tax = PriceTextBox.Text * taxval
        total = PriceTextBox.Text + PriceTextBox.Text * taxval

        TxtReciept.AppendText(vbTab & vbTab & "Car Dealer System:" & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "================================" & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "First Name:" & vbTab & client_select.Client_fnameTextBox.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Last Name:" & vbTab & client_select.Client_lnameTextBox.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Phone Nb:" & vbTab & client_select.Client_telTextBox.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Chosen brand:" & vbTab & Brand_nameComboBox.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Car Model:" & vbTab & Model_nameComboBox.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Sub Total:" & vbTab & PriceTextBox.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Tax Paid:" & vbTab & vbTab & tax & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Total:" & vbTab & vbTab & total & vbNewLine)


    End Sub

    Private Sub RECEIPTBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles RECEIPTBindingNavigator.RefreshItems

    End Sub
End Class