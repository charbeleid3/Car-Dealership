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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(choose_car))
        Me.CarDealershipDataSet = New ghabach_motors.CarDealershipDataSet()
        Me.RECEIPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECEIPTTableAdapter = New ghabach_motors.CarDealershipDataSetTableAdapters.RECEIPTTableAdapter()
        Me.TableAdapterManager = New ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.RECEIPTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RECEIPTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Brand_nameLabel = New System.Windows.Forms.Label()
        Model_nameLabel = New System.Windows.Forms.Label()
        Car_yearLabel1 = New System.Windows.Forms.Label()
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECEIPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECEIPTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RECEIPTBindingNavigator.SuspendLayout()
        CType(Me.C_brandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKMODELCbrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        AddHandler Brand_nameLabel.Click, AddressOf Me.Brand_nameLabel_Click
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
        AddHandler Model_nameLabel.Click, AddressOf Me.Model_nameLabel_Click
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'RECEIPTBindingNavigatorSaveItem
        '
        Me.RECEIPTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RECEIPTBindingNavigatorSaveItem.Image = CType(resources.GetObject("RECEIPTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RECEIPTBindingNavigatorSaveItem.Name = "RECEIPTBindingNavigatorSaveItem"
        Me.RECEIPTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RECEIPTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RECEIPTBindingNavigator
        '
        Me.RECEIPTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RECEIPTBindingNavigator.BindingSource = Me.RECEIPTBindingSource
        Me.RECEIPTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RECEIPTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RECEIPTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RECEIPTBindingNavigatorSaveItem})
        Me.RECEIPTBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RECEIPTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RECEIPTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RECEIPTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RECEIPTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RECEIPTBindingNavigator.Name = "RECEIPTBindingNavigator"
        Me.RECEIPTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RECEIPTBindingNavigator.Size = New System.Drawing.Size(797, 25)
        Me.RECEIPTBindingNavigator.TabIndex = 0
        Me.RECEIPTBindingNavigator.Text = "BindingNavigator1"
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
        Me.PriceTextBox.Location = New System.Drawing.Point(89, 144)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 10
        '
        'choose_car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 438)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtReciept)
        Me.Controls.Add(Car_yearLabel1)
        Me.Controls.Add(Me.Car_yearComboBox)
        Me.Controls.Add(Model_nameLabel)
        Me.Controls.Add(Me.Model_nameComboBox)
        Me.Controls.Add(Brand_nameLabel)
        Me.Controls.Add(Me.Brand_nameComboBox)
        Me.Controls.Add(Me.RECEIPTBindingNavigator)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Name = "choose_car"
        Me.Text = "choose_car"
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECEIPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECEIPTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RECEIPTBindingNavigator.ResumeLayout(False)
        Me.RECEIPTBindingNavigator.PerformLayout()
        CType(Me.C_brandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKMODELCbrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CarDealershipDataSet As ghabach_motors.CarDealershipDataSet
    Friend WithEvents RECEIPTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECEIPTTableAdapter As ghabach_motors.CarDealershipDataSetTableAdapters.RECEIPTTableAdapter
    Friend WithEvents TableAdapterManager As ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RECEIPTBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RECEIPTBindingNavigator As System.Windows.Forms.BindingNavigator
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
End Class
