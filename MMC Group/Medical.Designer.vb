<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medical
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Passport_NoLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim Agent_RefLabel As System.Windows.Forms.Label
        Dim City_VillageLabel As System.Windows.Forms.Label
        Dim ECR_StatuesLabel As System.Windows.Forms.Label
        Dim Medical_Expiry_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medical))
        Me.MMCDataSet = New MMC_Group.MMCDataSet()
        Me.MedicalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicalTableAdapter = New MMC_Group.MMCDataSetTableAdapters.MedicalTableAdapter()
        Me.TableAdapterManager = New MMC_Group.MMCDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Passport_NoTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Mobile_NoTextBox = New System.Windows.Forms.TextBox()
        Me.City_VillageTextBox = New System.Windows.Forms.TextBox()
        Me.ECR_StatuesComboBox = New System.Windows.Forms.ComboBox()
        Me.Medical_Expiry_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SearchBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HoldBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoldTableAdapter = New MMC_Group.MMCDataSetTableAdapters.HoldTableAdapter()
        Me.Agent_RefComboBox = New System.Windows.Forms.ComboBox()
        IDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Passport_NoLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        Agent_RefLabel = New System.Windows.Forms.Label()
        City_VillageLabel = New System.Windows.Forms.Label()
        ECR_StatuesLabel = New System.Windows.Forms.Label()
        Medical_Expiry_DateLabel = New System.Windows.Forms.Label()
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(26, 40)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(26, 81)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(53, 20)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(26, 127)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 20)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name:"
        '
        'Passport_NoLabel
        '
        Passport_NoLabel.AutoSize = True
        Passport_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Passport_NoLabel.Location = New System.Drawing.Point(26, 169)
        Passport_NoLabel.Name = "Passport_NoLabel"
        Passport_NoLabel.Size = New System.Drawing.Size(112, 20)
        Passport_NoLabel.TabIndex = 7
        Passport_NoLabel.Text = "Passport No:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.Location = New System.Drawing.Point(26, 221)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(86, 20)
        CategoryLabel.TabIndex = 9
        CategoryLabel.Text = "Category:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(26, 264)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(93, 20)
        Mobile_NoLabel.TabIndex = 11
        Mobile_NoLabel.Text = "Mobile No:"
        '
        'Agent_RefLabel
        '
        Agent_RefLabel.AutoSize = True
        Agent_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Agent_RefLabel.Location = New System.Drawing.Point(26, 310)
        Agent_RefLabel.Name = "Agent_RefLabel"
        Agent_RefLabel.Size = New System.Drawing.Size(96, 20)
        Agent_RefLabel.TabIndex = 13
        Agent_RefLabel.Text = "Agent/Ref:"
        '
        'City_VillageLabel
        '
        City_VillageLabel.AutoSize = True
        City_VillageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        City_VillageLabel.Location = New System.Drawing.Point(26, 353)
        City_VillageLabel.Name = "City_VillageLabel"
        City_VillageLabel.Size = New System.Drawing.Size(103, 20)
        City_VillageLabel.TabIndex = 15
        City_VillageLabel.Text = "City/Village:"
        '
        'ECR_StatuesLabel
        '
        ECR_StatuesLabel.AutoSize = True
        ECR_StatuesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ECR_StatuesLabel.Location = New System.Drawing.Point(26, 399)
        ECR_StatuesLabel.Name = "ECR_StatuesLabel"
        ECR_StatuesLabel.Size = New System.Drawing.Size(119, 20)
        ECR_StatuesLabel.TabIndex = 17
        ECR_StatuesLabel.Text = "ECR Statues:"
        '
        'Medical_Expiry_DateLabel
        '
        Medical_Expiry_DateLabel.AutoSize = True
        Medical_Expiry_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medical_Expiry_DateLabel.Location = New System.Drawing.Point(26, 447)
        Medical_Expiry_DateLabel.Name = "Medical_Expiry_DateLabel"
        Medical_Expiry_DateLabel.Size = New System.Drawing.Size(172, 20)
        Medical_Expiry_DateLabel.TabIndex = 19
        Medical_Expiry_DateLabel.Text = "Medical Expiry Date:"
        '
        'MMCDataSet
        '
        Me.MMCDataSet.DataSetName = "MMCDataSet"
        Me.MMCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicalBindingSource
        '
        Me.MedicalBindingSource.DataMember = "Medical"
        Me.MedicalBindingSource.DataSource = Me.MMCDataSet
        '
        'MedicalTableAdapter
        '
        Me.MedicalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.EnquiryTableAdapter = Nothing
        Me.TableAdapterManager.HoldTableAdapter = Nothing
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MedicalTableAdapter = Me.MedicalTableAdapter
        Me.TableAdapterManager.SelectedTableAdapter = Nothing
        Me.TableAdapterManager.SelectionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MMC_Group.MMCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisaTableAdapter = Nothing
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(218, 40)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(232, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MedicalBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(218, 81)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(232, 26)
        Me.DateDateTimePicker.TabIndex = 4
        Me.DateDateTimePicker.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(218, 127)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(232, 26)
        Me.NameTextBox.TabIndex = 6
        '
        'Passport_NoTextBox
        '
        Me.Passport_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalBindingSource, "Passport No", True))
        Me.Passport_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passport_NoTextBox.Location = New System.Drawing.Point(218, 169)
        Me.Passport_NoTextBox.Name = "Passport_NoTextBox"
        Me.Passport_NoTextBox.Size = New System.Drawing.Size(232, 26)
        Me.Passport_NoTextBox.TabIndex = 8
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalBindingSource, "Category", True))
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(218, 221)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(232, 28)
        Me.CategoryComboBox.TabIndex = 10
        '
        'Mobile_NoTextBox
        '
        Me.Mobile_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalBindingSource, "Mobile No", True))
        Me.Mobile_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_NoTextBox.Location = New System.Drawing.Point(218, 264)
        Me.Mobile_NoTextBox.Name = "Mobile_NoTextBox"
        Me.Mobile_NoTextBox.Size = New System.Drawing.Size(232, 26)
        Me.Mobile_NoTextBox.TabIndex = 12
        '
        'City_VillageTextBox
        '
        Me.City_VillageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalBindingSource, "City/Village", True))
        Me.City_VillageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_VillageTextBox.Location = New System.Drawing.Point(218, 353)
        Me.City_VillageTextBox.Name = "City_VillageTextBox"
        Me.City_VillageTextBox.Size = New System.Drawing.Size(232, 26)
        Me.City_VillageTextBox.TabIndex = 16
        '
        'ECR_StatuesComboBox
        '
        Me.ECR_StatuesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalBindingSource, "ECR Statues", True))
        Me.ECR_StatuesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ECR_StatuesComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECR_StatuesComboBox.FormattingEnabled = True
        Me.ECR_StatuesComboBox.Items.AddRange(New Object() {"ECR", "ECNR", "OTHER"})
        Me.ECR_StatuesComboBox.Location = New System.Drawing.Point(218, 399)
        Me.ECR_StatuesComboBox.Name = "ECR_StatuesComboBox"
        Me.ECR_StatuesComboBox.Size = New System.Drawing.Size(232, 28)
        Me.ECR_StatuesComboBox.TabIndex = 18
        '
        'Medical_Expiry_DateDateTimePicker
        '
        Me.Medical_Expiry_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MedicalBindingSource, "Medical Expiry Date", True))
        Me.Medical_Expiry_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medical_Expiry_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Medical_Expiry_DateDateTimePicker.Location = New System.Drawing.Point(218, 447)
        Me.Medical_Expiry_DateDateTimePicker.Name = "Medical_Expiry_DateDateTimePicker"
        Me.Medical_Expiry_DateDateTimePicker.Size = New System.Drawing.Size(232, 26)
        Me.Medical_Expiry_DateDateTimePicker.TabIndex = 20
        Me.Medical_Expiry_DateDateTimePicker.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(183, 581)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 42)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(331, 514)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 42)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(331, 581)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 42)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(183, 514)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 42)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(489, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(853, 503)
        Me.DataGridView1.TabIndex = 39
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1198, 82)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 28)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Date", "Name", "Passport No", "City/Village", "Category", "Agent/Ref", "Mobile No", "Expiry Date"})
        Me.ComboBox1.Location = New System.Drawing.Point(957, 81)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 28)
        Me.ComboBox1.TabIndex = 41
        '
        'SearchBox1
        '
        Me.SearchBox1.BackColor = System.Drawing.Color.White
        Me.SearchBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox1.Location = New System.Drawing.Point(957, 40)
        Me.SearchBox1.Name = "SearchBox1"
        Me.SearchBox1.Size = New System.Drawing.Size(202, 26)
        Me.SearchBox1.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1208, 654)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 48)
        Me.Button1.TabIndex = 43
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(798, 79)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 28)
        Me.Button7.TabIndex = 46
        Me.Button7.Text = "Fliter"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(568, 81)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker2.TabIndex = 45
        Me.DateTimePicker2.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(568, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 44
        Me.DateTimePicker1.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(1076, 656)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 46)
        Me.Button8.TabIndex = 51
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(485, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 24)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Medical"
        Me.Label1.Visible = False
        '
        'HoldBindingSource
        '
        Me.HoldBindingSource.DataMember = "Hold"
        Me.HoldBindingSource.DataSource = Me.MMCDataSet
        '
        'HoldTableAdapter
        '
        Me.HoldTableAdapter.ClearBeforeFill = True
        '
        'Agent_RefComboBox
        '
        Me.Agent_RefComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Agent/Ref", True))
        Me.Agent_RefComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Agent_RefComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agent_RefComboBox.FormattingEnabled = True
        Me.Agent_RefComboBox.Location = New System.Drawing.Point(218, 310)
        Me.Agent_RefComboBox.Name = "Agent_RefComboBox"
        Me.Agent_RefComboBox.Size = New System.Drawing.Size(232, 28)
        Me.Agent_RefComboBox.TabIndex = 53
        '
        'Medical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Agent_RefComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SearchBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Passport_NoLabel)
        Me.Controls.Add(Me.Passport_NoTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Mobile_NoLabel)
        Me.Controls.Add(Me.Mobile_NoTextBox)
        Me.Controls.Add(Agent_RefLabel)
        Me.Controls.Add(City_VillageLabel)
        Me.Controls.Add(Me.City_VillageTextBox)
        Me.Controls.Add(ECR_StatuesLabel)
        Me.Controls.Add(Me.ECR_StatuesComboBox)
        Me.Controls.Add(Medical_Expiry_DateLabel)
        Me.Controls.Add(Me.Medical_Expiry_DateDateTimePicker)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Medical"
        Me.Text = "Medical"
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MMCDataSet As MMCDataSet
    Friend WithEvents MedicalBindingSource As BindingSource
    Friend WithEvents MedicalTableAdapter As MMCDataSetTableAdapters.MedicalTableAdapter
    Friend WithEvents TableAdapterManager As MMCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Passport_NoTextBox As TextBox
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents Mobile_NoTextBox As TextBox
    Friend WithEvents City_VillageTextBox As TextBox
    Friend WithEvents ECR_StatuesComboBox As ComboBox
    Friend WithEvents Medical_Expiry_DateDateTimePicker As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SearchBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button8 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents HoldBindingSource As BindingSource
    Friend WithEvents HoldTableAdapter As MMCDataSetTableAdapters.HoldTableAdapter
    Friend WithEvents Agent_RefComboBox As ComboBox
End Class
