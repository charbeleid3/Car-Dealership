Public Class Form1
    Dim Ford As Double
    Dim SubT As Decimal
    Dim BMW As Double
    Dim Mercedes_Benz As Double
    Dim Audi As Double
    Dim Porshe As Double
    Dim Fiesta As Double
    Dim Mustang As Double
    Dim SL As Double
    Dim CLK As Double
    Dim TT As Double
    Dim R8 As Double
    Dim Cayenne As Double
    Dim GT3 As Double
    Dim M3 As Double
    Dim M5 As Double
    Dim kilo As Decimal
    Dim val As Decimal
    Dim tax As Decimal
    Dim total As Decimal



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarDealershipDataSet.CLIENT' table. You can move, or remove it, as needed.
        Me.CLIENTTableAdapter.Fill(Me.CarDealershipDataSet.CLIENT)
        'TODO: This line of code loads data into the 'CarDealershipDataSet.MODEL' table. You can move, or remove it, as needed.
        Me.MODELTableAdapter.Fill(Me.CarDealershipDataSet.MODEL)
        'TODO: This line of code loads data into the 'CarDealershipDataSet.CAR' table. You can move, or remove it, as needed.
        Me.CARTableAdapter.Fill(Me.CarDealershipDataSet.CAR)
        CmbChosenCar.Items.Add("Ford")
        CmbChosenCar.Items.Add("porshe")
        CmbChosenCar.Items.Add("Mercedes Benz")
        CmbChosenCar.Items.Add("Audi")
        CmbChosenCar.Items.Add("BMW")




        CmbKilo.Items.Add("Kilometer")
        CmbKilo.Items.Add("Mile")




    End Sub

    Private Sub BtnReset2_Click(sender As Object, e As EventArgs) Handles BtnReset2.Click
        Client_addressTextBox.Text = ""
        TxtBrand.Text = ""
        Client_nameTextBox.Text = ""
        Client_telTextBox.Text = ""

        TxtTax.Text = ""
        TxtSub.Text = ""
        TxtTotal.Text = ""
        TxtReciept.Text = ""
        CmbChosenCar.Text = "Choose A Brand..."
        CmbKilo.Text = "Choose A Unit Of Mesure..."
        CmbModel.Text = "Choose A Model..."

    End Sub
    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click

        If CmbKilo.Text = "Mile" Then
            val = TxtKilo.Text * 1.60934
        Else : CmbKilo.Text = "kilometer"
            val = TxtKilo.Text / 1.60934


        End If
        If CmbKilo.Text = "Mile" Then
            TxtMile.Text = val.ToString + " Kilometers"
        ElseIf CmbKilo.Text = "kilometer" Then
            TxtMile.Text = val.ToString + " Miles"
        End If

    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()

    End Sub
    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title1.Click

    End Sub
    Private Sub TxtBrand_TextChanged(sender As Object, e As EventArgs) Handles TxtBrand.TextChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)



        If (CmbChosenCar.Text = "Ford") Then
            CmbModel.Items.Clear()
            CmbModel.Items.Add("Fiesta")
            CmbModel.Items.Add("Mustang")



        ElseIf (CmbChosenCar.Text = "Mercedes Benz") Then
            CmbModel.Items.Clear()
            CmbModel.Items.Add("SL")
            CmbModel.Items.Add("CLK")


        ElseIf (CmbChosenCar.Text = "Audi") Then
            CmbModel.Items.Clear()
            CmbModel.Items.Add("TT")
            CmbModel.Items.Add("R8")


        ElseIf (CmbChosenCar.Text = "porshe") Then
            CmbModel.Items.Clear()
            CmbModel.Items.Add("cayenne")
            CmbModel.Items.Add("GT3")

        ElseIf (CmbChosenCar.Text = "BMW") Then
            CmbModel.Items.Clear()
            CmbModel.Items.Add("M3")
            CmbModel.Items.Add("M5")

        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles LblSubTotal.Click

    End Sub

    Private Sub LblAdress_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtKilo.TextChanged

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub LblBrand_Click(sender As Object, e As EventArgs) Handles LblBrand.Click, Label1.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub


    Private Sub BtnTotal_Click(sender As Object, e As EventArgs) Handles BtnTotal.Click
        Ford = 0
        BMW = 0
        Mercedes_Benz = 0
        Audi = 0
        Porshe = 0
        Fiesta = 7000
        Mustang = 20000
        SL = 20000
        CLK = 15000
        R8 = 150000
        Cayenne = 50000
        GT3 = 70000
        M3 = 20000
        M5 = 40000

        TxtBrand.Text = 0
        If (CmbModel.Text = "Fiesta") Then
            TxtBrand.Clear()
            TxtBrand.Text = Fiesta.ToString + " $"
            tax = (TxtBrand.Text * 10 / 100)
            TxtTax.Text = tax.ToString + " $"

            SubT = (TxtBrand.Text) + (TxtBrand.Text * 10 / 100)
            TxtSub.Text = SubT.ToString + " $"

            Dim AddOn(5) As Double
            AddOn(0) = 200
            AddOn(1) = 150
            AddOn(2) = 500
            AddOn(3) = 700
            AddOn(4) = 180

            TxtTotal.Text = TxtSub.Text


            If ChModified.Checked = True Then
                total = TxtSub.Text + AddOn(0)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChSterio.Checked = True Then
                total = TxtSub.Text + AddOn(1)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChCostum.Checked = True Then
                total = TxtSub.Text + AddOn(2)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChLeather.Checked = True Then
                total = TxtSub.Text + AddOn(3)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChGPS.Checked = True Then
                total = TxtSub.Text + AddOn(4)
                TxtTotal.Text = total.ToString + " $"

            End If



        ElseIf (CmbModel.Text = "TT") Then
            TxtBrand.Clear()
            TxtBrand.Text = Fiesta.ToString + " $"
            tax = (TxtBrand.Text * 10 / 100)
            TxtTax.Text = tax.ToString + " $"

            SubT = (TxtBrand.Text) + (TxtBrand.Text * 10 / 100)
            TxtSub.Text = SubT.ToString + " $"

            Dim AddOn(5) As Double
            AddOn(0) = 200
            AddOn(1) = 150
            AddOn(2) = 500
            AddOn(3) = 700
            AddOn(4) = 180

            TxtTotal.Text = TxtSub.Text


            If ChModified.Checked = True Then
                total = TxtSub.Text + AddOn(0)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChSterio.Checked = True Then
                total = TxtSub.Text + AddOn(1)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChCostum.Checked = True Then
                total = TxtSub.Text + AddOn(2)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChLeather.Checked = True Then
                total = TxtSub.Text + AddOn(3)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChGPS.Checked = True Then
                total = TxtSub.Text + AddOn(4)
                TxtTotal.Text = total.ToString + " $"

            End If




        ElseIf (CmbModel.Text = "Mustang") Then
            TxtBrand.Clear()
            TxtBrand.Text = Mustang.ToString + " $"
            tax = (TxtBrand.Text * 10 / 100)
            TxtTax.Text = tax.ToString + " $"

            SubT = (TxtBrand.Text) + (TxtBrand.Text * 10 / 100)
            TxtSub.Text = SubT.ToString + " $"

            Dim AddOn(5) As Double
            AddOn(0) = 200
            AddOn(1) = 150
            AddOn(2) = 500
            AddOn(3) = 700
            AddOn(4) = 180

            TxtTotal.Text = TxtSub.Text


            If ChModified.Checked = True Then
                total = TxtSub.Text + AddOn(0)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChSterio.Checked = True Then
                total = TxtSub.Text + AddOn(1)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChCostum.Checked = True Then
                total = TxtSub.Text + AddOn(2)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChLeather.Checked = True Then
                total = TxtSub.Text + AddOn(3)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChGPS.Checked = True Then
                total = TxtSub.Text + AddOn(4)
                TxtTotal.Text = total.ToString + " $"

            End If




        ElseIf (CmbModel.Text = "SL") Then
            TxtBrand.Clear()
            TxtBrand.Text = SL.ToString + " $"
            tax = (TxtBrand.Text * 10 / 100)
            TxtTax.Text = tax.ToString + " $"

            SubT = (TxtBrand.Text) + (TxtBrand.Text * 10 / 100)
            TxtSub.Text = SubT.ToString + " $"

            Dim AddOn(5) As Double
            AddOn(0) = 200
            AddOn(1) = 150
            AddOn(2) = 500
            AddOn(3) = 700
            AddOn(4) = 180

            TxtTotal.Text = TxtSub.Text


            If ChModified.Checked = True Then
                total = TxtSub.Text + AddOn(0)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChSterio.Checked = True Then
                total = TxtSub.Text + AddOn(1)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChCostum.Checked = True Then
                total = TxtSub.Text + AddOn(2)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChLeather.Checked = True Then
                total = TxtSub.Text + AddOn(3)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChGPS.Checked = True Then
                total = TxtSub.Text + AddOn(4)
                TxtTotal.Text = total.ToString + " $"

            End If




        ElseIf (CmbModel.Text = "CLK") Then
            TxtBrand.Clear()
            TxtBrand.Text = CLK.ToString + " $"
            tax = (TxtBrand.Text * 10 / 100)
            TxtTax.Text = tax.ToString + " $"

            SubT = (TxtBrand.Text) + (TxtBrand.Text * 10 / 100)
            TxtSub.Text = SubT.ToString + " $"

            Dim AddOn(5) As Double
            AddOn(0) = 200
            AddOn(1) = 150
            AddOn(2) = 500
            AddOn(3) = 700
            AddOn(4) = 180

            TxtTotal.Text = TxtSub.Text


            If ChModified.Checked = True Then
                total = TxtSub.Text + AddOn(0)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChSterio.Checked = True Then
                total = TxtSub.Text + AddOn(1)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChCostum.Checked = True Then
                total = TxtSub.Text + AddOn(2)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChLeather.Checked = True Then
                total = TxtSub.Text + AddOn(3)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChGPS.Checked = True Then
                total = TxtSub.Text + AddOn(4)
                TxtTotal.Text = total.ToString + " $"

            End If




        ElseIf (CmbModel.Text = "R8") Then
            TxtBrand.Clear()
            TxtBrand.Text = R8.ToString + " $"
            tax = (TxtBrand.Text * 10 / 100)
            TxtTax.Text = tax.ToString + " $"

            SubT = (TxtBrand.Text) + (TxtBrand.Text * 10 / 100)
            TxtSub.Text = SubT.ToString + " $"

            Dim AddOn(5) As Double
            AddOn(0) = 200
            AddOn(1) = 150
            AddOn(2) = 500
            AddOn(3) = 700
            AddOn(4) = 180

            TxtTotal.Text = TxtSub.Text


            If ChModified.Checked = True Then
                total = TxtSub.Text + AddOn(0)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChSterio.Checked = True Then
                total = TxtSub.Text + AddOn(1)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChCostum.Checked = True Then
                total = TxtSub.Text + AddOn(2)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChLeather.Checked = True Then
                total = TxtSub.Text + AddOn(3)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChGPS.Checked = True Then
                total = TxtSub.Text + AddOn(4)
                TxtTotal.Text = total.ToString + " $"

            End If




        ElseIf (CmbModel.Text = "GT3") Then
            TxtBrand.Clear()
            TxtBrand.Text = GT3.ToString + " $"
            tax = (TxtBrand.Text * 10 / 100)
            TxtTax.Text = tax.ToString + " $"

            SubT = (TxtBrand.Text) + (TxtBrand.Text * 10 / 100)
            TxtSub.Text = SubT.ToString + " $"

            Dim AddOn(5) As Double
            AddOn(0) = 200
            AddOn(1) = 150
            AddOn(2) = 500
            AddOn(3) = 700
            AddOn(4) = 180

            TxtTotal.Text = TxtSub.Text


            If ChModified.Checked = True Then
                total = TxtSub.Text + AddOn(0)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChSterio.Checked = True Then
                total = TxtSub.Text + AddOn(1)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChCostum.Checked = True Then
                total = TxtSub.Text + AddOn(2)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChLeather.Checked = True Then
                total = TxtSub.Text + AddOn(3)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChGPS.Checked = True Then
                total = TxtSub.Text + AddOn(4)
                TxtTotal.Text = total.ToString + " $"

            End If




        ElseIf (CmbModel.Text = "M3") Then
            TxtBrand.Clear()
            TxtBrand.Text = M3.ToString + " $"
            tax = (TxtBrand.Text * 10 / 100)
            TxtTax.Text = tax.ToString + " $"

            SubT = (TxtBrand.Text) + (TxtBrand.Text * 10 / 100)
            TxtSub.Text = SubT.ToString + " $"

            Dim AddOn(5) As Double
            AddOn(0) = 200
            AddOn(1) = 150
            AddOn(2) = 500
            AddOn(3) = 700
            AddOn(4) = 180

            TxtTotal.Text = TxtSub.Text


            If ChModified.Checked = True Then
                total = TxtSub.Text + AddOn(0)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChSterio.Checked = True Then
                total = TxtSub.Text + AddOn(1)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChCostum.Checked = True Then
                total = TxtSub.Text + AddOn(2)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChLeather.Checked = True Then
                total = TxtSub.Text + AddOn(3)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChGPS.Checked = True Then
                total = TxtSub.Text + AddOn(4)
                TxtTotal.Text = total.ToString + " $"

            End If




        ElseIf (CmbModel.Text = "M5") Then
            TxtBrand.Clear()
            TxtBrand.Text = M5.ToString + " $"
            tax = (TxtBrand.Text * 10 / 100)
            TxtTax.Text = tax.ToString + " $"

            SubT = (TxtBrand.Text) + (TxtBrand.Text * 10 / 100)
            TxtSub.Text = SubT.ToString + " $"

            Dim AddOn(5) As Double
            AddOn(0) = 200
            AddOn(1) = 150
            AddOn(2) = 500
            AddOn(3) = 700
            AddOn(4) = 180

            TxtTotal.Text = TxtSub.Text


            If ChModified.Checked = True Then
                total = TxtSub.Text + AddOn(0)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChSterio.Checked = True Then
                total = TxtSub.Text + AddOn(1)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChCostum.Checked = True Then
                total = TxtSub.Text + AddOn(2)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChLeather.Checked = True Then
                total = TxtSub.Text + AddOn(3)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChGPS.Checked = True Then
                total = TxtSub.Text + AddOn(4)
                TxtTotal.Text = total.ToString + " $"

            End If




        ElseIf (CmbModel.Text = "cayenne") Then
            TxtBrand.Clear()
            TxtBrand.Text = Cayenne.ToString + " $"
            tax = (TxtBrand.Text * 10 / 100)
            TxtTax.Text = tax.ToString + " $"

            SubT = (TxtBrand.Text) + (TxtBrand.Text * 10 / 100)
            TxtSub.Text = SubT.ToString + " $"

            Dim AddOn(5) As Double
            AddOn(0) = 200
            AddOn(1) = 150
            AddOn(2) = 500
            AddOn(3) = 700
            AddOn(4) = 180

            TxtTotal.Text = TxtSub.Text


            If ChModified.Checked = True Then
                total = TxtSub.Text + AddOn(0)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChSterio.Checked = True Then
                total = TxtSub.Text + AddOn(1)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChCostum.Checked = True Then
                total = TxtSub.Text + AddOn(2)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChLeather.Checked = True Then
                total = TxtSub.Text + AddOn(3)
                TxtTotal.Text = total.ToString + " $"

            End If

            If ChGPS.Checked = True Then
                total = TxtSub.Text + AddOn(4)
                TxtTotal.Text = total.ToString + " $"

            End If




        Else
            TxtBrand.Clear()
            TxtBrand.Text = "please choose a car"
        End If





        ' If ChModified.Checked = True And ChSterio.Checked = True Then
        'total = TxtSub.Text + AddOn(0) + AddOn(1)
        'TxtTotal.Text = total.ToString + " $"
        'End If

        'If ChModified.Checked = True Then
        '    If ChSterio.Checked Then
        '        If ChCostum.Checked = True Then
        '            If ChLeather.Checked = True Then
        '                If ChGPS.Checked = True Then
        '                    total = TxtSub.Text + AddOn(0) + AddOn(1) + AddOn(2) + AddOn(3) + AddOn(4)
        '                    TxtTotal.Text = total.ToString + " $"
        '                Else
        '                End If
        '            End If
        '        End If
        '    End If
        'End If
        'If ChModified.Checked = True Then
        '    If ChSterio.Checked Then
        '        If ChCostum.Checked = True Then
        '            If ChLeather.Checked = True Then
        '                total = TxtSub.Text + AddOn(0) + AddOn(1) + AddOn(2) + AddOn(3)
        '                TxtTotal.Text = total.ToString + " $"
        '            End If
        '        End If
        '    End If
        'End If

        'If ChModified.Checked = True Then
        '    If ChSterio.Checked Then
        '        If ChCostum.Checked = True Then
        '            total = TxtSub.Text + AddOn(0) + AddOn(1) + AddOn(2)
        '            TxtTotal.Text = total.ToString + " $"
        '        End If
        '    End If
        'End If

        'If ChModified.Checked = True Then
        '    If ChSterio.Checked Then
        '        total = TxtSub.Text + AddOn(0) + AddOn(1)
        '        TxtTotal.Text = total.ToString + " $"
        '    End If
        'End If

        'If ChModified.Checked = True Then
        '    total = TxtSub.Text + AddOn(0)
        '    TxtTotal.Text = total.ToString + " $"
        'End If



        '    total = TxtSub.Text + AddOn(0) + AddOn(1)
        '    TxtTotal.Text = total.ToString + " $"
        '    elseIf
        '    total = TxtSub.Text + AddOn(0)
        '    TxtTotal.Text = total.ToString + " $"
        'End If

        'If ChSterio.Checked = True Then
        '    total = TxtSub.Text + AddOn(1)
        '    TxtTotal.Text = total.ToString + " $"
        'End If

        'If ChCostum.Checked = True Then
        '    total = TxtSub.Text + AddOn(2)
        '    TxtTotal.Text = total.ToString + " $"
        'End If

        'If ChLeather.Checked = True Then
        '    total = TxtSub.Text + AddOn(3)
        '    TxtTotal.Text = total.ToString + " $"
        'End If

        'If ChGPS.Checked = True Then
        '    total = TxtSub.Text + AddOn(4)
        '    TxtTotal.Text = total.ToString + " $"
        'End If


    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtKilo.Text = ""
        TxtMile.Text = ""
        CmbKilo.Text = "Choose A Unit Of Mesure..."
    End Sub


    Private Sub CmbModel_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtTax_TextChanged(sender As Object, e As EventArgs) Handles TxtTax.TextChanged

    End Sub


    Private Sub ChModified_CheckedChanged(sender As Object, e As EventArgs) Handles ChModified.CheckedChanged

    End Sub

    Private Sub BtnReceipt_Click(sender As Object, e As EventArgs) Handles BtnReceipt.Click
        TxtReciept.AppendText(vbTab & vbTab & "Car Dealer System:" & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "================================" & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Name:" & vbTab & vbTab & Client_nameTextBox.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Address:" & vbTab & Client_addressTextBox.Text & vbNewLine)

        TxtReciept.AppendText(vbTab & vbTab & "Phone Nb:" & vbTab & Client_telTextBox.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Chosen Car:" & CmbChosenCar.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Car Model:" & CmbModel.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Tax Paid:" & vbTab & vbTab & TxtTax.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Tax Paid:" & vbTab & vbTab & TxtTax.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Sub Total:" & vbTab & TxtSub.Text & vbNewLine)
        TxtReciept.AppendText(vbTab & vbTab & "Total:" & vbTab & vbTab & TxtTotal.Text & vbNewLine)
    End Sub

    Private Sub TxtTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtTotal.TextChanged

    End Sub

    Private Sub TxtAdress_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CARBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CARBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarDealershipDataSet)

    End Sub

    Private Sub Client_addressLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Client_addressTextBox_TextChanged(sender As Object, e As EventArgs) Handles Client_addressTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CLIENTBindingSource.MovePrevious()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.CLIENTBindingSource.MoveNext()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            Me.CLIENTBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CarDealershipDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.CLIENTBindingSource.AddNew()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
