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
        Client_fnameLabel = New System.Windows.Forms.Label()
        Client_lnameLabel = New System.Windows.Forms.Label()
        Client_telLabel = New System.Windows.Forms.Label()
        Client_emailLabel = New System.Windows.Forms.Label()
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.CARTableAdapter = Nothing
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
        'Client_fnameLabel
        '
        Client_fnameLabel.AutoSize = True
        Client_fnameLabel.Location = New System.Drawing.Point(102, 88)
        Client_fnameLabel.Name = "Client_fnameLabel"
        Client_fnameLabel.Size = New System.Drawing.Size(67, 13)
        Client_fnameLabel.TabIndex = 1
        Client_fnameLabel.Text = "client fname:"
        '
        'Client_fnameTextBox
        '
        Me.Client_fnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_fname", True))
        Me.Client_fnameTextBox.Location = New System.Drawing.Point(175, 85)
        Me.Client_fnameTextBox.Name = "Client_fnameTextBox"
        Me.Client_fnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_fnameTextBox.TabIndex = 2
        '
        'Client_lnameLabel
        '
        Client_lnameLabel.AutoSize = True
        Client_lnameLabel.Location = New System.Drawing.Point(102, 114)
        Client_lnameLabel.Name = "Client_lnameLabel"
        Client_lnameLabel.Size = New System.Drawing.Size(66, 13)
        Client_lnameLabel.TabIndex = 3
        Client_lnameLabel.Text = "client lname:"
        '
        'Client_lnameTextBox
        '
        Me.Client_lnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_lname", True))
        Me.Client_lnameTextBox.Location = New System.Drawing.Point(175, 111)
        Me.Client_lnameTextBox.Name = "Client_lnameTextBox"
        Me.Client_lnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_lnameTextBox.TabIndex = 4
        '
        'Client_telLabel
        '
        Client_telLabel.AutoSize = True
        Client_telLabel.Location = New System.Drawing.Point(102, 140)
        Client_telLabel.Name = "Client_telLabel"
        Client_telLabel.Size = New System.Drawing.Size(49, 13)
        Client_telLabel.TabIndex = 5
        Client_telLabel.Text = "client tel:"
        '
        'Client_telTextBox
        '
        Me.Client_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_tel", True))
        Me.Client_telTextBox.Location = New System.Drawing.Point(175, 137)
        Me.Client_telTextBox.Name = "Client_telTextBox"
        Me.Client_telTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_telTextBox.TabIndex = 6
        '
        'Client_emailLabel
        '
        Client_emailLabel.AutoSize = True
        Client_emailLabel.Location = New System.Drawing.Point(102, 166)
        Client_emailLabel.Name = "Client_emailLabel"
        Client_emailLabel.Size = New System.Drawing.Size(62, 13)
        Client_emailLabel.TabIndex = 7
        Client_emailLabel.Text = "client email:"
        '
        'Client_emailTextBox
        '
        Me.Client_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_email", True))
        Me.Client_emailTextBox.Location = New System.Drawing.Point(175, 163)
        Me.Client_emailTextBox.Name = "Client_emailTextBox"
        Me.Client_emailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_emailTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add New Client"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(83, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(242, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 30)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'client_select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 325)
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
        Me.Name = "client_select"
        Me.Text = "client select"
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
