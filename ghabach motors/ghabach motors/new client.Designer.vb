<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_client
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
        Dim Client_id_showLabel As System.Windows.Forms.Label
        Dim Client_fnameLabel As System.Windows.Forms.Label
        Dim Client_lnameLabel As System.Windows.Forms.Label
        Dim Client_telLabel As System.Windows.Forms.Label
        Dim Client_emailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(new_client))
        Me.CarDealershipDataSet = New ghabach_motors.CarDealershipDataSet()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New ghabach_motors.CarDealershipDataSetTableAdapters.ClientTableAdapter()
        Me.TableAdapterManager = New ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager()
        Me.Client_id_showTextBox = New System.Windows.Forms.TextBox()
        Me.Client_fnameTextBox = New System.Windows.Forms.TextBox()
        Me.Client_lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Client_telTextBox = New System.Windows.Forms.TextBox()
        Me.Client_emailTextBox = New System.Windows.Forms.TextBox()
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
        Me.ClientBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Client_id_showLabel = New System.Windows.Forms.Label()
        Client_fnameLabel = New System.Windows.Forms.Label()
        Client_lnameLabel = New System.Windows.Forms.Label()
        Client_telLabel = New System.Windows.Forms.Label()
        Client_emailLabel = New System.Windows.Forms.Label()
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Client_id_showLabel
        '
        Client_id_showLabel.AutoSize = True
        Client_id_showLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_id_showLabel.Location = New System.Drawing.Point(12, 50)
        Client_id_showLabel.Name = "Client_id_showLabel"
        Client_id_showLabel.Size = New System.Drawing.Size(149, 26)
        Client_id_showLabel.TabIndex = 1
        Client_id_showLabel.Text = "client id show:"
        '
        'Client_fnameLabel
        '
        Client_fnameLabel.AutoSize = True
        Client_fnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_fnameLabel.Location = New System.Drawing.Point(12, 98)
        Client_fnameLabel.Name = "Client_fnameLabel"
        Client_fnameLabel.Size = New System.Drawing.Size(136, 26)
        Client_fnameLabel.TabIndex = 3
        Client_fnameLabel.Text = "client fname:"
        '
        'Client_lnameLabel
        '
        Client_lnameLabel.AutoSize = True
        Client_lnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_lnameLabel.Location = New System.Drawing.Point(12, 144)
        Client_lnameLabel.Name = "Client_lnameLabel"
        Client_lnameLabel.Size = New System.Drawing.Size(135, 26)
        Client_lnameLabel.TabIndex = 5
        Client_lnameLabel.Text = "client lname:"
        '
        'Client_telLabel
        '
        Client_telLabel.AutoSize = True
        Client_telLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_telLabel.Location = New System.Drawing.Point(12, 192)
        Client_telLabel.Name = "Client_telLabel"
        Client_telLabel.Size = New System.Drawing.Size(98, 26)
        Client_telLabel.TabIndex = 7
        Client_telLabel.Text = "client tel:"
        '
        'Client_emailLabel
        '
        Client_emailLabel.AutoSize = True
        Client_emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_emailLabel.Location = New System.Drawing.Point(12, 247)
        Client_emailLabel.Name = "Client_emailLabel"
        Client_emailLabel.Size = New System.Drawing.Size(128, 26)
        Client_emailLabel.TabIndex = 9
        Client_emailLabel.Text = "client email:"
        '
        'CarDealershipDataSet
        '
        Me.CarDealershipDataSet.DataSetName = "CarDealershipDataSet"
        Me.CarDealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.C_brandTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Me.ClientTableAdapter
        Me.TableAdapterManager.MODELTableAdapter = Nothing
        Me.TableAdapterManager.RECEIPTTableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'Client_id_showTextBox
        '
        Me.Client_id_showTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_id_show", True))
        Me.Client_id_showTextBox.Location = New System.Drawing.Point(167, 56)
        Me.Client_id_showTextBox.Name = "Client_id_showTextBox"
        Me.Client_id_showTextBox.Size = New System.Drawing.Size(130, 20)
        Me.Client_id_showTextBox.TabIndex = 2
        '
        'Client_fnameTextBox
        '
        Me.Client_fnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_fname", True))
        Me.Client_fnameTextBox.Location = New System.Drawing.Point(167, 104)
        Me.Client_fnameTextBox.Name = "Client_fnameTextBox"
        Me.Client_fnameTextBox.Size = New System.Drawing.Size(130, 20)
        Me.Client_fnameTextBox.TabIndex = 4
        '
        'Client_lnameTextBox
        '
        Me.Client_lnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_lname", True))
        Me.Client_lnameTextBox.Location = New System.Drawing.Point(167, 150)
        Me.Client_lnameTextBox.Name = "Client_lnameTextBox"
        Me.Client_lnameTextBox.Size = New System.Drawing.Size(130, 20)
        Me.Client_lnameTextBox.TabIndex = 6
        '
        'Client_telTextBox
        '
        Me.Client_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_tel", True))
        Me.Client_telTextBox.Location = New System.Drawing.Point(167, 198)
        Me.Client_telTextBox.Name = "Client_telTextBox"
        Me.Client_telTextBox.Size = New System.Drawing.Size(130, 20)
        Me.Client_telTextBox.TabIndex = 8
        '
        'Client_emailTextBox
        '
        Me.Client_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_email", True))
        Me.Client_emailTextBox.Location = New System.Drawing.Point(167, 253)
        Me.Client_emailTextBox.Name = "Client_emailTextBox"
        Me.Client_emailTextBox.Size = New System.Drawing.Size(130, 20)
        Me.Client_emailTextBox.TabIndex = 10
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
        'ClientBindingNavigatorSaveItem
        '
        Me.ClientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientBindingNavigatorSaveItem.Name = "ClientBindingNavigatorSaveItem"
        Me.ClientBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClientBindingNavigator
        '
        Me.ClientBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientBindingNavigator.BindingSource = Me.ClientBindingSource
        Me.ClientBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientBindingNavigatorSaveItem})
        Me.ClientBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientBindingNavigator.Name = "ClientBindingNavigator"
        Me.ClientBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientBindingNavigator.Size = New System.Drawing.Size(380, 25)
        Me.ClientBindingNavigator.TabIndex = 0
        Me.ClientBindingNavigator.Text = "BindingNavigator1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(75, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Back to client select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'new_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 369)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Client_id_showLabel)
        Me.Controls.Add(Me.Client_id_showTextBox)
        Me.Controls.Add(Client_fnameLabel)
        Me.Controls.Add(Me.Client_fnameTextBox)
        Me.Controls.Add(Client_lnameLabel)
        Me.Controls.Add(Me.Client_lnameTextBox)
        Me.Controls.Add(Client_telLabel)
        Me.Controls.Add(Me.Client_telTextBox)
        Me.Controls.Add(Client_emailLabel)
        Me.Controls.Add(Me.Client_emailTextBox)
        Me.Controls.Add(Me.ClientBindingNavigator)
        Me.Name = "new_client"
        Me.Text = "new_client"
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientBindingNavigator.ResumeLayout(False)
        Me.ClientBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CarDealershipDataSet As ghabach_motors.CarDealershipDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As ghabach_motors.CarDealershipDataSetTableAdapters.ClientTableAdapter
    Friend WithEvents TableAdapterManager As ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Client_id_showTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_fnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_lnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_telTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_emailTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents ClientBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
