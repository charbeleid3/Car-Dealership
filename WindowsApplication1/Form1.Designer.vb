<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Client_nameLabel As System.Windows.Forms.Label
        Dim Client_telLabel As System.Windows.Forms.Label
        Dim Client_addressLabel As System.Windows.Forms.Label
        Dim Client_idLabel As System.Windows.Forms.Label
        Dim Client_idLabel1 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtReciept = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChGPS = New System.Windows.Forms.CheckBox()
        Me.ChLeather = New System.Windows.Forms.CheckBox()
        Me.ChCostum = New System.Windows.Forms.CheckBox()
        Me.ChSterio = New System.Windows.Forms.CheckBox()
        Me.ChModified = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtMile = New System.Windows.Forms.TextBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.TxtKilo = New System.Windows.Forms.TextBox()
        Me.CmbKilo = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtSub = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblSubTotal = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TxtTax = New System.Windows.Forms.TextBox()
        Me.LblTax = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BtnReceipt = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnReset2 = New System.Windows.Forms.Button()
        Me.BtnTotal = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TxtBrand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblBrand = New System.Windows.Forms.Label()
        Me.CarDealershipDataSet = New WindowsApplication1.CarDealershipDataSet()
        Me.CARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CARTableAdapter = New WindowsApplication1.CarDealershipDataSetTableAdapters.CARTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.CarDealershipDataSetTableAdapters.TableAdapterManager()
        Me.CmbChosenCar = New System.Windows.Forms.ComboBox()
        Me.MODELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MODELTableAdapter = New WindowsApplication1.CarDealershipDataSetTableAdapters.MODELTableAdapter()
        Me.CmbModel = New System.Windows.Forms.ComboBox()
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTTableAdapter = New WindowsApplication1.CarDealershipDataSetTableAdapters.CLIENTTableAdapter()
        Me.Client_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Client_telTextBox = New System.Windows.Forms.TextBox()
        Me.Client_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CLIENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Client_idComboBox = New System.Windows.Forms.ComboBox()
        Me.Client_idTextBox = New System.Windows.Forms.TextBox()
        Client_nameLabel = New System.Windows.Forms.Label()
        Client_telLabel = New System.Windows.Forms.Label()
        Client_addressLabel = New System.Windows.Forms.Label()
        Client_idLabel = New System.Windows.Forms.Label()
        Client_idLabel1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Title1)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(22, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1311, 100)
        Me.Panel1.TabIndex = 0
        '
        'Title1
        '
        Me.Title1.AutoSize = True
        Me.Title1.Font = New System.Drawing.Font("Times New Roman", 66.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1.Location = New System.Drawing.Point(0, 0)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(1222, 99)
        Me.Title1.TabIndex = 0
        Me.Title1.Text = "Car Dealer Managemnet System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Client_idTextBox)
        Me.Panel2.Controls.Add(Client_idLabel1)
        Me.Panel2.Controls.Add(Me.Client_idComboBox)
        Me.Panel2.Controls.Add(Client_idLabel)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Client_addressLabel)
        Me.Panel2.Controls.Add(Me.Client_addressTextBox)
        Me.Panel2.Controls.Add(Client_telLabel)
        Me.Panel2.Controls.Add(Me.Client_telTextBox)
        Me.Panel2.Controls.Add(Client_nameLabel)
        Me.Panel2.Controls.Add(Me.Client_nameTextBox)
        Me.Panel2.Controls.Add(Me.TxtReciept)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(1011, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 534)
        Me.Panel2.TabIndex = 1
        '
        'TxtReciept
        '
        Me.TxtReciept.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReciept.Location = New System.Drawing.Point(15, 352)
        Me.TxtReciept.Multiline = True
        Me.TxtReciept.Name = "TxtReciept"
        Me.TxtReciept.ReadOnly = True
        Me.TxtReciept.Size = New System.Drawing.Size(305, 162)
        Me.TxtReciept.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.ChGPS)
        Me.Panel3.Controls.Add(Me.ChLeather)
        Me.Panel3.Controls.Add(Me.ChCostum)
        Me.Panel3.Controls.Add(Me.ChSterio)
        Me.Panel3.Controls.Add(Me.ChModified)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(22, 118)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 250)
        Me.Panel3.TabIndex = 1
        '
        'ChGPS
        '
        Me.ChGPS.AutoSize = True
        Me.ChGPS.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChGPS.Location = New System.Drawing.Point(36, 207)
        Me.ChGPS.Name = "ChGPS"
        Me.ChGPS.Size = New System.Drawing.Size(83, 35)
        Me.ChGPS.TabIndex = 0
        Me.ChGPS.Text = "GPS"
        Me.ChGPS.UseVisualStyleBackColor = True
        '
        'ChLeather
        '
        Me.ChLeather.AutoSize = True
        Me.ChLeather.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChLeather.Location = New System.Drawing.Point(36, 161)
        Me.ChLeather.Name = "ChLeather"
        Me.ChLeather.Size = New System.Drawing.Size(214, 35)
        Me.ChLeather.TabIndex = 0
        Me.ChLeather.Text = "Leather Interior"
        Me.ChLeather.UseVisualStyleBackColor = True
        '
        'ChCostum
        '
        Me.ChCostum.AutoSize = True
        Me.ChCostum.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChCostum.Location = New System.Drawing.Point(36, 111)
        Me.ChCostum.Name = "ChCostum"
        Me.ChCostum.Size = New System.Drawing.Size(207, 35)
        Me.ChCostum.TabIndex = 0
        Me.ChCostum.Text = "Costum Details"
        Me.ChCostum.UseVisualStyleBackColor = True
        '
        'ChSterio
        '
        Me.ChSterio.AutoSize = True
        Me.ChSterio.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChSterio.Location = New System.Drawing.Point(36, 68)
        Me.ChSterio.Name = "ChSterio"
        Me.ChSterio.Size = New System.Drawing.Size(187, 35)
        Me.ChSterio.TabIndex = 0
        Me.ChSterio.Text = "Stereo System"
        Me.ChSterio.UseVisualStyleBackColor = True
        '
        'ChModified
        '
        Me.ChModified.AutoSize = True
        Me.ChModified.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChModified.Location = New System.Drawing.Point(36, 24)
        Me.ChModified.Name = "ChModified"
        Me.ChModified.Size = New System.Drawing.Size(135, 35)
        Me.ChModified.TabIndex = 0
        Me.ChModified.Text = "Modified"
        Me.ChModified.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.TxtMile)
        Me.Panel4.Controls.Add(Me.BtnReset)
        Me.Panel4.Controls.Add(Me.BtnConvert)
        Me.Panel4.Controls.Add(Me.TxtKilo)
        Me.Panel4.Controls.Add(Me.CmbKilo)
        Me.Panel4.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(351, 118)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(654, 250)
        Me.Panel4.TabIndex = 2
        '
        'TxtMile
        '
        Me.TxtMile.BackColor = System.Drawing.SystemColors.Control
        Me.TxtMile.Location = New System.Drawing.Point(47, 124)
        Me.TxtMile.Name = "TxtMile"
        Me.TxtMile.ReadOnly = True
        Me.TxtMile.Size = New System.Drawing.Size(540, 39)
        Me.TxtMile.TabIndex = 4
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(332, 187)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(120, 60)
        Me.BtnReset.TabIndex = 3
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnConvert
        '
        Me.BtnConvert.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConvert.Location = New System.Drawing.Point(195, 187)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(120, 60)
        Me.BtnConvert.TabIndex = 3
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'TxtKilo
        '
        Me.TxtKilo.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKilo.Location = New System.Drawing.Point(35, 64)
        Me.TxtKilo.Name = "TxtKilo"
        Me.TxtKilo.Size = New System.Drawing.Size(564, 39)
        Me.TxtKilo.TabIndex = 2
        '
        'CmbKilo
        '
        Me.CmbKilo.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbKilo.FormattingEnabled = True
        Me.CmbKilo.Location = New System.Drawing.Point(16, 3)
        Me.CmbKilo.Name = "CmbKilo"
        Me.CmbKilo.Size = New System.Drawing.Size(603, 39)
        Me.CmbKilo.TabIndex = 1
        Me.CmbKilo.Text = "Choose A Unit Of Mesure..."
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Controls.Add(Me.TxtTotal)
        Me.Panel7.Controls.Add(Me.TxtSub)
        Me.Panel7.Controls.Add(Me.LblTotal)
        Me.Panel7.Controls.Add(Me.LblSubTotal)
        Me.Panel7.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(527, 470)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(478, 168)
        Me.Panel7.TabIndex = 5
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTotal.Location = New System.Drawing.Point(170, 111)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(216, 39)
        Me.TxtTotal.TabIndex = 4
        '
        'TxtSub
        '
        Me.TxtSub.BackColor = System.Drawing.SystemColors.Control
        Me.TxtSub.Location = New System.Drawing.Point(166, 35)
        Me.TxtSub.Name = "TxtSub"
        Me.TxtSub.ReadOnly = True
        Me.TxtSub.Size = New System.Drawing.Size(220, 39)
        Me.TxtSub.TabIndex = 4
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(31, 119)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(80, 31)
        Me.LblTotal.TabIndex = 0
        Me.LblTotal.Text = "Total:"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.AutoSize = True
        Me.LblSubTotal.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotal.Location = New System.Drawing.Point(31, 43)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(129, 31)
        Me.LblSubTotal.TabIndex = 0
        Me.LblSubTotal.Text = "Sub Total:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.Controls.Add(Me.TxtTax)
        Me.Panel8.Controls.Add(Me.LblTax)
        Me.Panel8.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(527, 374)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(478, 90)
        Me.Panel8.TabIndex = 6
        '
        'TxtTax
        '
        Me.TxtTax.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTax.Location = New System.Drawing.Point(170, 32)
        Me.TxtTax.Name = "TxtTax"
        Me.TxtTax.ReadOnly = True
        Me.TxtTax.Size = New System.Drawing.Size(220, 39)
        Me.TxtTax.TabIndex = 4
        '
        'LblTax
        '
        Me.LblTax.AutoSize = True
        Me.LblTax.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTax.Location = New System.Drawing.Point(31, 35)
        Me.LblTax.Name = "LblTax"
        Me.LblTax.Size = New System.Drawing.Size(62, 31)
        Me.LblTax.TabIndex = 0
        Me.LblTax.Text = "Tax:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.Controls.Add(Me.BtnReceipt)
        Me.Panel9.Controls.Add(Me.BtnExit)
        Me.Panel9.Controls.Add(Me.BtnReset2)
        Me.Panel9.Controls.Add(Me.BtnTotal)
        Me.Panel9.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(22, 560)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(499, 78)
        Me.Panel9.TabIndex = 7
        '
        'BtnReceipt
        '
        Me.BtnReceipt.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceipt.Location = New System.Drawing.Point(124, 9)
        Me.BtnReceipt.Name = "BtnReceipt"
        Me.BtnReceipt.Size = New System.Drawing.Size(120, 60)
        Me.BtnReceipt.TabIndex = 3
        Me.BtnReceipt.Text = "Reciept"
        Me.BtnReceipt.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(376, 9)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(120, 60)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnReset2
        '
        Me.BtnReset2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset2.Location = New System.Drawing.Point(250, 9)
        Me.BtnReset2.Name = "BtnReset2"
        Me.BtnReset2.Size = New System.Drawing.Size(120, 60)
        Me.BtnReset2.TabIndex = 3
        Me.BtnReset2.Text = "Reset"
        Me.BtnReset2.UseVisualStyleBackColor = True
        '
        'BtnTotal
        '
        Me.BtnTotal.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTotal.Location = New System.Drawing.Point(3, 9)
        Me.BtnTotal.Name = "BtnTotal"
        Me.BtnTotal.Size = New System.Drawing.Size(120, 60)
        Me.BtnTotal.TabIndex = 3
        Me.BtnTotal.Text = "Total"
        Me.BtnTotal.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.CmbModel)
        Me.Panel6.Controls.Add(Me.CmbChosenCar)
        Me.Panel6.Controls.Add(Me.TxtBrand)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.LblBrand)
        Me.Panel6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(22, 374)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(499, 180)
        Me.Panel6.TabIndex = 4
        '
        'TxtBrand
        '
        Me.TxtBrand.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBrand.Location = New System.Drawing.Point(124, 120)
        Me.TxtBrand.Name = "TxtBrand"
        Me.TxtBrand.ReadOnly = True
        Me.TxtBrand.Size = New System.Drawing.Size(246, 39)
        Me.TxtBrand.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Model:"
        '
        'LblBrand
        '
        Me.LblBrand.AutoSize = True
        Me.LblBrand.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBrand.Location = New System.Drawing.Point(65, 30)
        Me.LblBrand.Name = "LblBrand"
        Me.LblBrand.Size = New System.Drawing.Size(143, 31)
        Me.LblBrand.TabIndex = 0
        Me.LblBrand.Text = "Car Brand:"
        '
        'CarDealershipDataSet
        '
        Me.CarDealershipDataSet.DataSetName = "CarDealershipDataSet"
        Me.CarDealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CARBindingSource
        '
        Me.CARBindingSource.DataMember = "CAR"
        Me.CARBindingSource.DataSource = Me.CarDealershipDataSet
        '
        'CARTableAdapter
        '
        Me.CARTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARTableAdapter = Me.CARTableAdapter
        Me.TableAdapterManager.CLIENTTableAdapter = Me.CLIENTTableAdapter
        Me.TableAdapterManager.MODELTableAdapter = Me.MODELTableAdapter
        Me.TableAdapterManager.RECEIPTTableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.CarDealershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'CmbChosenCar
        '
        Me.CmbChosenCar.DataSource = Me.CARBindingSource
        Me.CmbChosenCar.DisplayMember = "car_name"
        Me.CmbChosenCar.FormattingEnabled = True
        Me.CmbChosenCar.Location = New System.Drawing.Point(23, 64)
        Me.CmbChosenCar.Name = "CmbChosenCar"
        Me.CmbChosenCar.Size = New System.Drawing.Size(227, 39)
        Me.CmbChosenCar.TabIndex = 5
        Me.CmbChosenCar.ValueMember = "car_id"
        '
        'MODELBindingSource
        '
        Me.MODELBindingSource.DataMember = "MODEL"
        Me.MODELBindingSource.DataSource = Me.CarDealershipDataSet
        '
        'MODELTableAdapter
        '
        Me.MODELTableAdapter.ClearBeforeFill = True
        '
        'CmbModel
        '
        Me.CmbModel.DataSource = Me.MODELBindingSource
        Me.CmbModel.DisplayMember = "model_name"
        Me.CmbModel.FormattingEnabled = True
        Me.CmbModel.Location = New System.Drawing.Point(263, 64)
        Me.CmbModel.Name = "CmbModel"
        Me.CmbModel.Size = New System.Drawing.Size(228, 39)
        Me.CmbModel.TabIndex = 6
        Me.CmbModel.ValueMember = "model_id"
        '
        'CLIENTBindingSource
        '
        Me.CLIENTBindingSource.DataMember = "CLIENT"
        Me.CLIENTBindingSource.DataSource = Me.CarDealershipDataSet
        '
        'CLIENTTableAdapter
        '
        Me.CLIENTTableAdapter.ClearBeforeFill = True
        '
        'Client_nameLabel
        '
        Client_nameLabel.AutoSize = True
        Client_nameLabel.Location = New System.Drawing.Point(35, 112)
        Client_nameLabel.Name = "Client_nameLabel"
        Client_nameLabel.Size = New System.Drawing.Size(153, 31)
        Client_nameLabel.TabIndex = 2
        Client_nameLabel.Text = "client name:"
        '
        'Client_nameTextBox
        '
        Me.Client_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource, "client_name", True))
        Me.Client_nameTextBox.Location = New System.Drawing.Point(194, 109)
        Me.Client_nameTextBox.Name = "Client_nameTextBox"
        Me.Client_nameTextBox.Size = New System.Drawing.Size(148, 39)
        Me.Client_nameTextBox.TabIndex = 3
        '
        'Client_telLabel
        '
        Client_telLabel.AutoSize = True
        Client_telLabel.Location = New System.Drawing.Point(67, 156)
        Client_telLabel.Name = "Client_telLabel"
        Client_telLabel.Size = New System.Drawing.Size(121, 31)
        Client_telLabel.TabIndex = 3
        Client_telLabel.Text = "client tel:"
        '
        'Client_telTextBox
        '
        Me.Client_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource, "client_tel", True))
        Me.Client_telTextBox.Location = New System.Drawing.Point(194, 153)
        Me.Client_telTextBox.Name = "Client_telTextBox"
        Me.Client_telTextBox.Size = New System.Drawing.Size(148, 39)
        Me.Client_telTextBox.TabIndex = 4
        '
        'Client_addressLabel
        '
        Client_addressLabel.AutoSize = True
        Client_addressLabel.Location = New System.Drawing.Point(9, 201)
        Client_addressLabel.Name = "Client_addressLabel"
        Client_addressLabel.Size = New System.Drawing.Size(179, 31)
        Client_addressLabel.TabIndex = 5
        Client_addressLabel.Text = "client address:"
        AddHandler Client_addressLabel.Click, AddressOf Me.Client_addressLabel_Click
        '
        'Client_addressTextBox
        '
        Me.Client_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource, "client_address", True))
        Me.Client_addressTextBox.Location = New System.Drawing.Point(194, 198)
        Me.Client_addressTextBox.Name = "Client_addressTextBox"
        Me.Client_addressTextBox.Size = New System.Drawing.Size(148, 39)
        Me.Client_addressTextBox.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 41)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(194, 245)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 41)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(194, 293)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 41)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(53, 293)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 41)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CLIENTBindingSource1
        '
        Me.CLIENTBindingSource1.DataMember = "CLIENT"
        Me.CLIENTBindingSource1.DataSource = Me.CarDealershipDataSet
        '
        'Client_idLabel
        '
        Client_idLabel.AutoSize = True
        Client_idLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_idLabel.Location = New System.Drawing.Point(11, 17)
        Client_idLabel.Name = "Client_idLabel"
        Client_idLabel.Size = New System.Drawing.Size(177, 23)
        Client_idLabel.TabIndex = 11
        Client_idLabel.Text = "Choose your client:"
        '
        'Client_idComboBox
        '
        Me.Client_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource, "client_id", True))
        Me.Client_idComboBox.DataSource = Me.CLIENTBindingSource
        Me.Client_idComboBox.DisplayMember = "client_name"
        Me.Client_idComboBox.FormattingEnabled = True
        Me.Client_idComboBox.Location = New System.Drawing.Point(195, 10)
        Me.Client_idComboBox.Name = "Client_idComboBox"
        Me.Client_idComboBox.Size = New System.Drawing.Size(148, 39)
        Me.Client_idComboBox.TabIndex = 13
        Me.Client_idComboBox.ValueMember = "client_id"
        '
        'Client_idLabel1
        '
        Client_idLabel1.AutoSize = True
        Client_idLabel1.Location = New System.Drawing.Point(72, 69)
        Client_idLabel1.Name = "Client_idLabel1"
        Client_idLabel1.Size = New System.Drawing.Size(116, 31)
        Client_idLabel1.TabIndex = 13
        Client_idLabel1.Text = "client id:"
        '
        'Client_idTextBox
        '
        Me.Client_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTBindingSource, "client_id", True))
        Me.Client_idTextBox.Location = New System.Drawing.Point(195, 61)
        Me.Client_idTextBox.Name = "Client_idTextBox"
        Me.Client_idTextBox.Size = New System.Drawing.Size(147, 39)
        Me.Client_idTextBox.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents ChGPS As System.Windows.Forms.CheckBox
    Friend WithEvents ChLeather As System.Windows.Forms.CheckBox
    Friend WithEvents ChCostum As System.Windows.Forms.CheckBox
    Friend WithEvents ChSterio As System.Windows.Forms.CheckBox
    Friend WithEvents ChModified As System.Windows.Forms.CheckBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblSubTotal As System.Windows.Forms.Label
    Friend WithEvents LblTax As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LblBrand As System.Windows.Forms.Label
    Friend WithEvents Title1 As System.Windows.Forms.Label
    Friend WithEvents TxtReciept As System.Windows.Forms.TextBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnConvert As System.Windows.Forms.Button
    Friend WithEvents TxtKilo As System.Windows.Forms.TextBox
    Friend WithEvents CmbKilo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnReset2 As System.Windows.Forms.Button
    Friend WithEvents BtnTotal As System.Windows.Forms.Button
    Friend WithEvents BtnReceipt As System.Windows.Forms.Button
    Friend WithEvents TxtMile As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtSub As System.Windows.Forms.TextBox
    Friend WithEvents TxtTax As System.Windows.Forms.TextBox
    Friend WithEvents TxtBrand As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CarDealershipDataSet As WindowsApplication1.CarDealershipDataSet
    Friend WithEvents CARBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CARTableAdapter As WindowsApplication1.CarDealershipDataSetTableAdapters.CARTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.CarDealershipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CmbChosenCar As System.Windows.Forms.ComboBox
    Friend WithEvents MODELTableAdapter As WindowsApplication1.CarDealershipDataSetTableAdapters.MODELTableAdapter
    Friend WithEvents MODELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents CLIENTTableAdapter As WindowsApplication1.CarDealershipDataSetTableAdapters.CLIENTTableAdapter
    Friend WithEvents CLIENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Client_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_telTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CLIENTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Client_idComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Client_idTextBox As System.Windows.Forms.TextBox

End Class
