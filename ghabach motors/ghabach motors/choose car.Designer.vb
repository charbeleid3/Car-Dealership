<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class choose_car
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
        Dim Brand_nameLabel As System.Windows.Forms.Label
        Dim Model_nameLabel As System.Windows.Forms.Label
        Dim Car_yearLabel1 As System.Windows.Forms.Label
        Dim Model_idLabel As System.Windows.Forms.Label
        Dim Client_id_showLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(choose_car))
        Me.CarDealershipDataSet = New ghabach_motors.CarDealershipDataSet()
        Me.RECEIPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECEIPTTableAdapter = New ghabach_motors.CarDealershipDataSetTableAdapters.RECEIPTTableAdapter()
        Me.TableAdapterManager = New ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager()
        Me.C_brandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C_brandTableAdapter = New ghabach_motors.CarDealershipDataSetTableAdapters.C_brandTableAdapter()
        Me.MODELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MODELTableAdapter = New ghabach_motors.CarDealershipDataSetTableAdapters.MODELTableAdapter()
        Me.Brand_nameComboBox = New System.Windows.Forms.ComboBox()
        Me.Model_nameComboBox = New System.Windows.Forms.ComboBox()
        Me.FKMODELCbrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Car_yearComboBox = New System.Windows.Forms.ComboBox()
        Me.TxtReciept = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New ghabach_motors.CarDealershipDataSetTableAdapters.ClientTableAdapter()
        Me.Model_idTextBox = New System.Windows.Forms.TextBox()
        Me.Client_id_showTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChooseClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Brand_nameLabel = New System.Windows.Forms.Label()
        Model_nameLabel = New System.Windows.Forms.Label()
        Car_yearLabel1 = New System.Windows.Forms.Label()
        Model_idLabel = New System.Windows.Forms.Label()
        Client_id_showLabel = New System.Windows.Forms.Label()
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECEIPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_brandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKMODELCbrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Brand_nameLabel
        '
        Brand_nameLabel.AutoSize = True
        Brand_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Brand_nameLabel.Location = New System.Drawing.Point(75, 138)
        Brand_nameLabel.Name = "Brand_nameLabel"
        Brand_nameLabel.Size = New System.Drawing.Size(134, 26)
        Brand_nameLabel.TabIndex = 1
        Brand_nameLabel.Text = "brand name:"
        '
        'Model_nameLabel
        '
        Model_nameLabel.AutoSize = True
        Model_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Model_nameLabel.Location = New System.Drawing.Point(70, 231)
        Model_nameLabel.Name = "Model_nameLabel"
        Model_nameLabel.Size = New System.Drawing.Size(139, 26)
        Model_nameLabel.TabIndex = 3
        Model_nameLabel.Text = "model name:"
        '
        'Car_yearLabel1
        '
        Car_yearLabel1.AutoSize = True
        Car_yearLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_yearLabel1.Location = New System.Drawing.Point(93, 324)
        Car_yearLabel1.Name = "Car_yearLabel1"
        Car_yearLabel1.Size = New System.Drawing.Size(96, 26)
        Car_yearLabel1.TabIndex = 6
        Car_yearLabel1.Text = "car year:"
        '
        'Model_idLabel
        '
        Model_idLabel.AutoSize = True
        Model_idLabel.Location = New System.Drawing.Point(321, 86)
        Model_idLabel.Name = "Model_idLabel"
        Model_idLabel.Size = New System.Drawing.Size(49, 13)
        Model_idLabel.TabIndex = 11
        Model_idLabel.Text = "model id:"
        Model_idLabel.Visible = False
        '
        'Client_id_showLabel
        '
        Client_id_showLabel.AutoSize = True
        Client_id_showLabel.Location = New System.Drawing.Point(117, 89)
        Client_id_showLabel.Name = "Client_id_showLabel"
        Client_id_showLabel.Size = New System.Drawing.Size(74, 13)
        Client_id_showLabel.TabIndex = 12
        Client_id_showLabel.Text = "client id show:"
        Client_id_showLabel.Visible = False
        '
        'CarDealershipDataSet
        '
        Me.CarDealershipDataSet.DataSetName = "CarDealershipDataSet"
        Me.CarDealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RECEIPTBindingSource
        '
        Me.RECEIPTBindingSource.DataMember = "RECEIPT"
        Me.RECEIPTBindingSource.DataSource = Me.CarDealershipDataSet
        '
        'RECEIPTTableAdapter
        '
        Me.RECEIPTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.C_brandTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.MODELTableAdapter = Nothing
        Me.TableAdapterManager.RECEIPTTableAdapter = Me.RECEIPTTableAdapter
        Me.TableAdapterManager.SUPPLIERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'C_brandBindingSource
        '
        Me.C_brandBindingSource.DataMember = "C_brand"
        Me.C_brandBindingSource.DataSource = Me.CarDealershipDataSet
        '
        'C_brandTableAdapter
        '
        Me.C_brandTableAdapter.ClearBeforeFill = True
        '
        'MODELBindingSource
        '
        Me.MODELBindingSource.DataMember = "FK_MODEL_C_brand"
        Me.MODELBindingSource.DataSource = Me.C_brandBindingSource
        '
        'MODELTableAdapter
        '
        Me.MODELTableAdapter.ClearBeforeFill = True
        '
        'Brand_nameComboBox
        '
        Me.Brand_nameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.C_brandBindingSource, "brand_name", True))
        Me.Brand_nameComboBox.DataSource = Me.C_brandBindingSource
        Me.Brand_nameComboBox.DisplayMember = "brand_name"
        Me.Brand_nameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Brand_nameComboBox.FormattingEnabled = True
        Me.Brand_nameComboBox.Location = New System.Drawing.Point(243, 135)
        Me.Brand_nameComboBox.Name = "Brand_nameComboBox"
        Me.Brand_nameComboBox.Size = New System.Drawing.Size(121, 33)
        Me.Brand_nameComboBox.TabIndex = 2
        Me.Brand_nameComboBox.ValueMember = "brand_name"
        '
        'Model_nameComboBox
        '
        Me.Model_nameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MODELBindingSource, "model_name", True))
        Me.Model_nameComboBox.DataSource = Me.MODELBindingSource
        Me.Model_nameComboBox.DisplayMember = "model_name"
        Me.Model_nameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model_nameComboBox.FormattingEnabled = True
        Me.Model_nameComboBox.Location = New System.Drawing.Point(243, 228)
        Me.Model_nameComboBox.Name = "Model_nameComboBox"
        Me.Model_nameComboBox.Size = New System.Drawing.Size(121, 33)
        Me.Model_nameComboBox.TabIndex = 4
        Me.Model_nameComboBox.ValueMember = "model_name"
        '
        'FKMODELCbrandBindingSource
        '
        Me.FKMODELCbrandBindingSource.DataMember = "FK_MODEL_C_brand"
        Me.FKMODELCbrandBindingSource.DataSource = Me.C_brandBindingSource
        '
        'Car_yearComboBox
        '
        Me.Car_yearComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MODELBindingSource, "car_year", True))
        Me.Car_yearComboBox.DataSource = Me.MODELBindingSource
        Me.Car_yearComboBox.DisplayMember = "car_year"
        Me.Car_yearComboBox.Enabled = False
        Me.Car_yearComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_yearComboBox.FormattingEnabled = True
        Me.Car_yearComboBox.Location = New System.Drawing.Point(243, 321)
        Me.Car_yearComboBox.Name = "Car_yearComboBox"
        Me.Car_yearComboBox.Size = New System.Drawing.Size(121, 33)
        Me.Car_yearComboBox.TabIndex = 7
        Me.Car_yearComboBox.ValueMember = "car_year"
        '
        'TxtReciept
        '
        Me.TxtReciept.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReciept.Location = New System.Drawing.Point(445, 109)
        Me.TxtReciept.Multiline = True
        Me.TxtReciept.Name = "TxtReciept"
        Me.TxtReciept.ReadOnly = True
        Me.TxtReciept.Size = New System.Drawing.Size(323, 276)
        Me.TxtReciept.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Receipt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKMODELCbrandBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(303, 365)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 10
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "Client"
        Me.ClientBindingSource.DataSource = Me.CarDealershipDataSet
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'Model_idTextBox
        '
        Me.Model_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MODELBindingSource, "model_id", True))
        Me.Model_idTextBox.Location = New System.Drawing.Point(376, 83)
        Me.Model_idTextBox.Name = "Model_idTextBox"
        Me.Model_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Model_idTextBox.TabIndex = 12
        Me.Model_idTextBox.Visible = False
        '
        'Client_id_showTextBox
        '
        Me.Client_id_showTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_id_show", True))
        Me.Client_id_showTextBox.Location = New System.Drawing.Point(197, 86)
        Me.Client_id_showTextBox.Name = "Client_id_showTextBox"
        Me.Client_id_showTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_id_showTextBox.TabIndex = 13
        Me.Client_id_showTextBox.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChooseClientToolStripMenuItem, Me.ViewPurchasesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChooseClientToolStripMenuItem
        '
        Me.ChooseClientToolStripMenuItem.Name = "ChooseClientToolStripMenuItem"
        Me.ChooseClientToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ChooseClientToolStripMenuItem.Text = "choose client"
        '
        'ViewPurchasesToolStripMenuItem
        '
        Me.ViewPurchasesToolStripMenuItem.Name = "ViewPurchasesToolStripMenuItem"
        Me.ViewPurchasesToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ViewPurchasesToolStripMenuItem.Text = "View Purchases"
        '
        'choose_car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 446)
        Me.Controls.Add(Model_idLabel)
        Me.Controls.Add(Me.Model_idTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtReciept)
        Me.Controls.Add(Car_yearLabel1)
        Me.Controls.Add(Me.Car_yearComboBox)
        Me.Controls.Add(Model_nameLabel)
        Me.Controls.Add(Me.Model_nameComboBox)
        Me.Controls.Add(Brand_nameLabel)
        Me.Controls.Add(Me.Brand_nameComboBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Client_id_showLabel)
        Me.Controls.Add(Me.Client_id_showTextBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "choose_car"
        Me.Text = "choose_car"
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECEIPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_brandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKMODELCbrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CarDealershipDataSet As ghabach_motors.CarDealershipDataSet
    Friend WithEvents RECEIPTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECEIPTTableAdapter As ghabach_motors.CarDealershipDataSetTableAdapters.RECEIPTTableAdapter
    Friend WithEvents TableAdapterManager As ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents C_brandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents C_brandTableAdapter As ghabach_motors.CarDealershipDataSetTableAdapters.C_brandTableAdapter
    Friend WithEvents MODELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MODELTableAdapter As ghabach_motors.CarDealershipDataSetTableAdapters.MODELTableAdapter
    Friend WithEvents Brand_nameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Model_nameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FKMODELCbrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Car_yearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TxtReciept As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As ghabach_motors.CarDealershipDataSetTableAdapters.ClientTableAdapter
    Friend WithEvents Model_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_id_showTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChooseClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPurchasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
