<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CarDealershipDataSet = New ghabach_motors.CarDealershipDataSet()
        Me.CarDealershipDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New ghabach_motors.CarDealershipDataSetTableAdapters.ClientTableAdapter()
        Me.ClientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager()
        Me.Client_fnameTextBox = New System.Windows.Forms.TextBox()
        Client_fnameLabel = New System.Windows.Forms.Label()
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDealershipDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientBindingSource
        Me.ComboBox1.DisplayMember = "client_fname"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(96, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "client_fname"
        '
        'CarDealershipDataSet
        '
        Me.CarDealershipDataSet.DataSetName = "CarDealershipDataSet"
        Me.CarDealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarDealershipDataSetBindingSource
        '
        Me.CarDealershipDataSetBindingSource.DataSource = Me.CarDealershipDataSet
        Me.CarDealershipDataSetBindingSource.Position = 0
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "Client"
        Me.ClientBindingSource.DataSource = Me.CarDealershipDataSetBindingSource
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'ClientBindingSource1
        '
        Me.ClientBindingSource1.DataMember = "Client"
        Me.ClientBindingSource1.DataSource = Me.CarDealershipDataSet
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
        'Client_fnameLabel
        '
        Client_fnameLabel.AutoSize = True
        Client_fnameLabel.Location = New System.Drawing.Point(37, 41)
        Client_fnameLabel.Name = "Client_fnameLabel"
        Client_fnameLabel.Size = New System.Drawing.Size(67, 13)
        Client_fnameLabel.TabIndex = 1
        Client_fnameLabel.Text = "client fname:"
        '
        'Client_fnameTextBox
        '
        Me.Client_fnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource1, "client_fname", True))
        Me.Client_fnameTextBox.Location = New System.Drawing.Point(110, 38)
        Me.Client_fnameTextBox.Name = "Client_fnameTextBox"
        Me.Client_fnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_fnameTextBox.TabIndex = 2
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Client_fnameLabel)
        Me.Controls.Add(Me.Client_fnameTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "main"
        Me.Text = "main"
        CType(Me.CarDealershipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDealershipDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CarDealershipDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CarDealershipDataSet As ghabach_motors.CarDealershipDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As ghabach_motors.CarDealershipDataSetTableAdapters.ClientTableAdapter
    Friend WithEvents ClientBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As ghabach_motors.CarDealershipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Client_fnameTextBox As System.Windows.Forms.TextBox
End Class
