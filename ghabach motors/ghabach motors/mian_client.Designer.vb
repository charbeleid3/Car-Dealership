<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client_select
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
        Dim Client_fnameLabel As System.Windows.Forms.Label
        Dim Client_lnameLabel As System.Windows.Forms.Label
        Dim Client_telLabel As System.Windows.Forms.Label
        Dim Client_emailLabel As System.Windows.Forms.Label
        Dim Client_IDLabel As System.Windows.Forms.Label
        Me.CarDealershipDataSet = New ghabach_motors.CarDealershipDataSet()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New ghabach_motors.CarDealershipDataSetTableAdapters.ClientTableAdapter()
        Me.TableAdapterManager = New ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager()
        Me.ClientComboBox = New System.Windows.Forms.ComboBox()
        Me.Client_fnameTextBox = New System.Windows.Forms.TextBox()
        Me.Client_lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Client_telTextBox = New System.Windows.Forms.TextBox()
        Me.Client_emailTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Client_IDTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChooseCarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Client_fnameLabel = New System.Windows.Forms.Label()
        Client_lnameLabel = New System.Windows.Forms.Label()
        Client_telLabel = New System.Windows.Forms.Label()
        Client_emailLabel = New System.Windows.Forms.Label()
        Client_IDLabel = New System.Windows.Forms.Label()
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Client_fnameLabel
        '
        Client_fnameLabel.AutoSize = True
        Client_fnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_fnameLabel.Location = New System.Drawing.Point(78, 77)
        Client_fnameLabel.Name = "Client_fnameLabel"
        Client_fnameLabel.Size = New System.Drawing.Size(136, 26)
        Client_fnameLabel.TabIndex = 1
        Client_fnameLabel.Text = "client fname:"
        '
        'Client_lnameLabel
        '
        Client_lnameLabel.AutoSize = True
        Client_lnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_lnameLabel.Location = New System.Drawing.Point(78, 115)
        Client_lnameLabel.Name = "Client_lnameLabel"
        Client_lnameLabel.Size = New System.Drawing.Size(135, 26)
        Client_lnameLabel.TabIndex = 3
        Client_lnameLabel.Text = "client lname:"
        '
        'Client_telLabel
        '
        Client_telLabel.AutoSize = True
        Client_telLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_telLabel.Location = New System.Drawing.Point(78, 154)
        Client_telLabel.Name = "Client_telLabel"
        Client_telLabel.Size = New System.Drawing.Size(98, 26)
        Client_telLabel.TabIndex = 5
        Client_telLabel.Text = "client tel:"
        '
        'Client_emailLabel
        '
        Client_emailLabel.AutoSize = True
        Client_emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_emailLabel.Location = New System.Drawing.Point(78, 191)
        Client_emailLabel.Name = "Client_emailLabel"
        Client_emailLabel.Size = New System.Drawing.Size(128, 26)
        Client_emailLabel.TabIndex = 7
        Client_emailLabel.Text = "client email:"
        '
        'Client_IDLabel
        '
        Client_IDLabel.AutoSize = True
        Client_IDLabel.Location = New System.Drawing.Point(12, 62)
        Client_IDLabel.Name = "Client_IDLabel"
        Client_IDLabel.Size = New System.Drawing.Size(50, 13)
        Client_IDLabel.TabIndex = 13
        Client_IDLabel.Text = "Client ID:"
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
        'ClientComboBox
        '
        Me.ClientComboBox.DataSource = Me.ClientBindingSource
        Me.ClientComboBox.DisplayMember = "client_id_show"
        Me.ClientComboBox.FormattingEnabled = True
        Me.ClientComboBox.Location = New System.Drawing.Point(83, 35)
        Me.ClientComboBox.Name = "ClientComboBox"
        Me.ClientComboBox.Size = New System.Drawing.Size(300, 21)
        Me.ClientComboBox.TabIndex = 1
        Me.ClientComboBox.ValueMember = "Client_ID"
        '
        'Client_fnameTextBox
        '
        Me.Client_fnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_fname", True))
        Me.Client_fnameTextBox.Location = New System.Drawing.Point(218, 83)
        Me.Client_fnameTextBox.Name = "Client_fnameTextBox"
        Me.Client_fnameTextBox.Size = New System.Drawing.Size(165, 20)
        Me.Client_fnameTextBox.TabIndex = 2
        '
        'Client_lnameTextBox
        '
        Me.Client_lnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_lname", True))
        Me.Client_lnameTextBox.Location = New System.Drawing.Point(219, 121)
        Me.Client_lnameTextBox.Name = "Client_lnameTextBox"
        Me.Client_lnameTextBox.Size = New System.Drawing.Size(164, 20)
        Me.Client_lnameTextBox.TabIndex = 4
        '
        'Client_telTextBox
        '
        Me.Client_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_tel", True))
        Me.Client_telTextBox.Location = New System.Drawing.Point(218, 160)
        Me.Client_telTextBox.Name = "Client_telTextBox"
        Me.Client_telTextBox.Size = New System.Drawing.Size(165, 20)
        Me.Client_telTextBox.TabIndex = 6
        '
        'Client_emailTextBox
        '
        Me.Client_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_email", True))
        Me.Client_emailTextBox.Location = New System.Drawing.Point(218, 197)
        Me.Client_emailTextBox.Name = "Client_emailTextBox"
        Me.Client_emailTextBox.Size = New System.Drawing.Size(165, 20)
        Me.Client_emailTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add New Client"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(83, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(242, 238)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 30)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(155, 283)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 46)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Choose"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Client_IDTextBox
        '
        Me.Client_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "Client_ID", True))
        Me.Client_IDTextBox.Location = New System.Drawing.Point(68, 59)
        Me.Client_IDTextBox.Name = "Client_IDTextBox"
        Me.Client_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_IDTextBox.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChooseCarToolStripMenuItem, Me.ViewPurchasesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(490, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChooseCarToolStripMenuItem
        '
        Me.ChooseCarToolStripMenuItem.Name = "ChooseCarToolStripMenuItem"
        Me.ChooseCarToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ChooseCarToolStripMenuItem.Text = "choose car"
        '
        'ViewPurchasesToolStripMenuItem
        '
        Me.ViewPurchasesToolStripMenuItem.Name = "ViewPurchasesToolStripMenuItem"
        Me.ViewPurchasesToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ViewPurchasesToolStripMenuItem.Text = "View purchases"
        '
        'client_select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 394)
        Me.Controls.Add(Client_IDLabel)
        Me.Controls.Add(Me.Client_IDTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Client_fnameLabel)
        Me.Controls.Add(Me.Client_fnameTextBox)
        Me.Controls.Add(Client_lnameLabel)
        Me.Controls.Add(Me.Client_lnameTextBox)
        Me.Controls.Add(Client_telLabel)
        Me.Controls.Add(Me.Client_telTextBox)
        Me.Controls.Add(Client_emailLabel)
        Me.Controls.Add(Me.Client_emailTextBox)
        Me.Controls.Add(Me.ClientComboBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "client_select"
        Me.Text = "client select"
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CarDealershipDataSet As ghabach_motors.CarDealershipDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As ghabach_motors.CarDealershipDataSetTableAdapters.ClientTableAdapter
    Friend WithEvents TableAdapterManager As ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Client_fnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_lnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_telTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Client_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChooseCarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPurchasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
