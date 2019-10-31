<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class On_Hold
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Passport_NoLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim Agent_RefLabel As System.Windows.Forms.Label
        Dim City_VillageLabel As System.Windows.Forms.Label
        Dim Salary_OfferedLabel As System.Windows.Forms.Label
        Dim Selected_ByLabel As System.Windows.Forms.Label
        Dim Passport_Expiry_DateLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(On_Hold))
        Me.MMCDataSet = New MMC_Group.MMCDataSet()
        Me.HoldBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoldTableAdapter = New MMC_Group.MMCDataSetTableAdapters.HoldTableAdapter()
        Me.TableAdapterManager = New MMC_Group.MMCDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Passport_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_NoTextBox = New System.Windows.Forms.TextBox()
        Me.City_VillageTextBox = New System.Windows.Forms.TextBox()
        Me.Salary_OfferedTextBox = New System.Windows.Forms.TextBox()
        Me.Passport_Expiry_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RemarkTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SearchBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Agent_RefComboBox = New System.Windows.Forms.ComboBox()
        Me.LocationComboBox = New System.Windows.Forms.ComboBox()
        Me.SelectedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectedTableAdapter = New MMC_Group.MMCDataSetTableAdapters.SelectedTableAdapter()
        Me.Selected_ByComboBox = New System.Windows.Forms.ComboBox()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Passport_NoLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        Agent_RefLabel = New System.Windows.Forms.Label()
        City_VillageLabel = New System.Windows.Forms.Label()
        Salary_OfferedLabel = New System.Windows.Forms.Label()
        Selected_ByLabel = New System.Windows.Forms.Label()
        Passport_Expiry_DateLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        RemarkLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(24, 31)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(22, 64)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 20)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'Passport_NoLabel
        '
        Passport_NoLabel.AutoSize = True
        Passport_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Passport_NoLabel.Location = New System.Drawing.Point(22, 105)
        Passport_NoLabel.Name = "Passport_NoLabel"
        Passport_NoLabel.Size = New System.Drawing.Size(112, 20)
        Passport_NoLabel.TabIndex = 5
        Passport_NoLabel.Text = "Passport No:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.Location = New System.Drawing.Point(24, 146)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(86, 20)
        CategoryLabel.TabIndex = 7
        CategoryLabel.Text = "Category:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(22, 187)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(93, 20)
        Mobile_NoLabel.TabIndex = 9
        Mobile_NoLabel.Text = "Mobile No:"
        '
        'Agent_RefLabel
        '
        Agent_RefLabel.AutoSize = True
        Agent_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Agent_RefLabel.Location = New System.Drawing.Point(24, 230)
        Agent_RefLabel.Name = "Agent_RefLabel"
        Agent_RefLabel.Size = New System.Drawing.Size(96, 20)
        Agent_RefLabel.TabIndex = 11
        Agent_RefLabel.Text = "Agent/Ref:"
        '
        'City_VillageLabel
        '
        City_VillageLabel.AutoSize = True
        City_VillageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        City_VillageLabel.Location = New System.Drawing.Point(22, 267)
        City_VillageLabel.Name = "City_VillageLabel"
        City_VillageLabel.Size = New System.Drawing.Size(103, 20)
        City_VillageLabel.TabIndex = 13
        City_VillageLabel.Text = "City/Village:"
        '
        'Salary_OfferedLabel
        '
        Salary_OfferedLabel.AutoSize = True
        Salary_OfferedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Salary_OfferedLabel.Location = New System.Drawing.Point(24, 376)
        Salary_OfferedLabel.Name = "Salary_OfferedLabel"
        Salary_OfferedLabel.Size = New System.Drawing.Size(130, 20)
        Salary_OfferedLabel.TabIndex = 15
        Salary_OfferedLabel.Text = "Salary Offered:"
        '
        'Selected_ByLabel
        '
        Selected_ByLabel.AutoSize = True
        Selected_ByLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Selected_ByLabel.Location = New System.Drawing.Point(24, 417)
        Selected_ByLabel.Name = "Selected_ByLabel"
        Selected_ByLabel.Size = New System.Drawing.Size(110, 20)
        Selected_ByLabel.TabIndex = 17
        Selected_ByLabel.Text = "Selected By:"
        '
        'Passport_Expiry_DateLabel
        '
        Passport_Expiry_DateLabel.AutoSize = True
        Passport_Expiry_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Passport_Expiry_DateLabel.Location = New System.Drawing.Point(24, 462)
        Passport_Expiry_DateLabel.Name = "Passport_Expiry_DateLabel"
        Passport_Expiry_DateLabel.Size = New System.Drawing.Size(182, 20)
        Passport_Expiry_DateLabel.TabIndex = 19
        Passport_Expiry_DateLabel.Text = "Passport Expiry Date:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(24, 503)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(67, 20)
        StatusLabel.TabIndex = 21
        StatusLabel.Text = "Status:"
        '
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RemarkLabel.Location = New System.Drawing.Point(22, 545)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(76, 20)
        RemarkLabel.TabIndex = 23
        RemarkLabel.Text = "Remark:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(24, 298)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(53, 20)
        DateLabel.TabIndex = 47
        DateLabel.Text = "Date:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(24, 344)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(83, 20)
        LocationLabel.TabIndex = 54
        LocationLabel.Text = "Location:"
        '
        'MMCDataSet
        '
        Me.MMCDataSet.DataSetName = "MMCDataSet"
        Me.MMCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.EnquiryTableAdapter = Nothing
        Me.TableAdapterManager.HoldTableAdapter = Me.HoldTableAdapter
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MedicalTableAdapter = Nothing
        Me.TableAdapterManager.SelectedTableAdapter = Nothing
        Me.TableAdapterManager.SelectionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MMC_Group.MMCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisaTableAdapter = Nothing
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(222, 25)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(228, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(222, 58)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(228, 26)
        Me.NameTextBox.TabIndex = 4
        '
        'Passport_NoTextBox
        '
        Me.Passport_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Passport No", True))
        Me.Passport_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passport_NoTextBox.Location = New System.Drawing.Point(222, 99)
        Me.Passport_NoTextBox.Name = "Passport_NoTextBox"
        Me.Passport_NoTextBox.Size = New System.Drawing.Size(228, 26)
        Me.Passport_NoTextBox.TabIndex = 6
        '
        'Mobile_NoTextBox
        '
        Me.Mobile_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Mobile No", True))
        Me.Mobile_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_NoTextBox.Location = New System.Drawing.Point(222, 181)
        Me.Mobile_NoTextBox.Name = "Mobile_NoTextBox"
        Me.Mobile_NoTextBox.Size = New System.Drawing.Size(228, 26)
        Me.Mobile_NoTextBox.TabIndex = 10
        '
        'City_VillageTextBox
        '
        Me.City_VillageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "City/Village", True))
        Me.City_VillageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_VillageTextBox.Location = New System.Drawing.Point(222, 261)
        Me.City_VillageTextBox.Name = "City_VillageTextBox"
        Me.City_VillageTextBox.Size = New System.Drawing.Size(228, 26)
        Me.City_VillageTextBox.TabIndex = 14
        '
        'Salary_OfferedTextBox
        '
        Me.Salary_OfferedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Salary Offered", True))
        Me.Salary_OfferedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salary_OfferedTextBox.Location = New System.Drawing.Point(222, 370)
        Me.Salary_OfferedTextBox.Name = "Salary_OfferedTextBox"
        Me.Salary_OfferedTextBox.Size = New System.Drawing.Size(228, 26)
        Me.Salary_OfferedTextBox.TabIndex = 16
        '
        'Passport_Expiry_DateDateTimePicker
        '
        Me.Passport_Expiry_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HoldBindingSource, "Passport Expiry Date", True))
        Me.Passport_Expiry_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passport_Expiry_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Passport_Expiry_DateDateTimePicker.Location = New System.Drawing.Point(222, 456)
        Me.Passport_Expiry_DateDateTimePicker.Name = "Passport_Expiry_DateDateTimePicker"
        Me.Passport_Expiry_DateDateTimePicker.Size = New System.Drawing.Size(228, 26)
        Me.Passport_Expiry_DateDateTimePicker.TabIndex = 20
        Me.Passport_Expiry_DateDateTimePicker.Value = New Date(2019, 2, 1, 0, 0, 0, 0)
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Remark", True))
        Me.RemarkTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarkTextBox.Location = New System.Drawing.Point(222, 539)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(228, 26)
        Me.RemarkTextBox.TabIndex = 24
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(170, 651)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 42)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(337, 584)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 42)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(337, 651)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 42)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(170, 584)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 42)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(472, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(870, 509)
        Me.DataGridView1.TabIndex = 35
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(731, 93)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 28)
        Me.Button7.TabIndex = 44
        Me.Button7.Text = "Fliter"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(492, 93)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker2.TabIndex = 43
        Me.DateTimePicker2.Value = New Date(2019, 2, 1, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(492, 45)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 42
        Me.DateTimePicker1.Value = New Date(2019, 2, 1, 0, 0, 0, 0)
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1227, 90)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 28)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Date", "Name", "Passport No", "City/Village", "Category", "Agent/Ref", "Mobile No", "Selected By", "Status", "Expiry Date", "Location"})
        Me.ComboBox1.Location = New System.Drawing.Point(997, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 28)
        Me.ComboBox1.TabIndex = 40
        '
        'SearchBox1
        '
        Me.SearchBox1.BackColor = System.Drawing.Color.White
        Me.SearchBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox1.Location = New System.Drawing.Point(997, 45)
        Me.SearchBox1.Name = "SearchBox1"
        Me.SearchBox1.Size = New System.Drawing.Size(202, 26)
        Me.SearchBox1.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1227, 675)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 46)
        Me.Button1.TabIndex = 45
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Category", True))
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(222, 143)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(228, 28)
        Me.CategoryComboBox.TabIndex = 46
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Status", True))
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"MEDICAL OK", "MEDICAL PANDING", "AT MADICAL", "MEDICAL OKAY BUT NOT RECEIVED", "UNFIT", "NOT AGREE", "WILL GO", "AT PASSPORT RENEW", "VISA CAME", "ON HOLD", "OTHER"})
        Me.StatusComboBox.Location = New System.Drawing.Point(222, 500)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(228, 28)
        Me.StatusComboBox.TabIndex = 47
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HoldBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(222, 298)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(228, 26)
        Me.DateDateTimePicker.TabIndex = 48
        Me.DateDateTimePicker.Value = New Date(2019, 2, 1, 0, 0, 0, 0)
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(1092, 675)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 46)
        Me.Button8.TabIndex = 52
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(533, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 26)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "On Hold "
        Me.Label1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Agent_RefComboBox
        '
        Me.Agent_RefComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Agent/Ref", True))
        Me.Agent_RefComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Agent_RefComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agent_RefComboBox.FormattingEnabled = True
        Me.Agent_RefComboBox.Location = New System.Drawing.Point(222, 222)
        Me.Agent_RefComboBox.Name = "Agent_RefComboBox"
        Me.Agent_RefComboBox.Size = New System.Drawing.Size(228, 28)
        Me.Agent_RefComboBox.TabIndex = 54
        '
        'LocationComboBox
        '
        Me.LocationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Location", True))
        Me.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LocationComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationComboBox.FormattingEnabled = True
        Me.LocationComboBox.Location = New System.Drawing.Point(222, 335)
        Me.LocationComboBox.Name = "LocationComboBox"
        Me.LocationComboBox.Size = New System.Drawing.Size(228, 28)
        Me.LocationComboBox.TabIndex = 55
        '
        'SelectedBindingSource
        '
        Me.SelectedBindingSource.DataMember = "Selected"
        Me.SelectedBindingSource.DataSource = Me.MMCDataSet
        '
        'SelectedTableAdapter
        '
        Me.SelectedTableAdapter.ClearBeforeFill = True
        '
        'Selected_ByComboBox
        '
        Me.Selected_ByComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HoldBindingSource, "Selected By", True))
        Me.Selected_ByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Selected_ByComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Selected_ByComboBox.FormattingEnabled = True
        Me.Selected_ByComboBox.Location = New System.Drawing.Point(222, 414)
        Me.Selected_ByComboBox.Name = "Selected_ByComboBox"
        Me.Selected_ByComboBox.Size = New System.Drawing.Size(228, 28)
        Me.Selected_ByComboBox.TabIndex = 56
        '
        'On_Hold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Selected_ByComboBox)
        Me.Controls.Add(Me.LocationComboBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.Agent_RefComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
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
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Passport_NoLabel)
        Me.Controls.Add(Me.Passport_NoTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Mobile_NoLabel)
        Me.Controls.Add(Me.Mobile_NoTextBox)
        Me.Controls.Add(Agent_RefLabel)
        Me.Controls.Add(City_VillageLabel)
        Me.Controls.Add(Me.City_VillageTextBox)
        Me.Controls.Add(Salary_OfferedLabel)
        Me.Controls.Add(Me.Salary_OfferedTextBox)
        Me.Controls.Add(Selected_ByLabel)
        Me.Controls.Add(Passport_Expiry_DateLabel)
        Me.Controls.Add(Me.Passport_Expiry_DateDateTimePicker)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(RemarkLabel)
        Me.Controls.Add(Me.RemarkTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "On_Hold"
        Me.Text = "On_Hold"
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MMCDataSet As MMCDataSet
    Friend WithEvents HoldBindingSource As BindingSource
    Friend WithEvents HoldTableAdapter As MMCDataSetTableAdapters.HoldTableAdapter
    Friend WithEvents TableAdapterManager As MMCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Passport_NoTextBox As TextBox
    Friend WithEvents Mobile_NoTextBox As TextBox
    Friend WithEvents City_VillageTextBox As TextBox
    Friend WithEvents Salary_OfferedTextBox As TextBox
    Friend WithEvents Passport_Expiry_DateDateTimePicker As DateTimePicker
    Friend WithEvents RemarkTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button7 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SearchBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents Button8 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Agent_RefComboBox As ComboBox
    Friend WithEvents LocationComboBox As ComboBox
    Friend WithEvents SelectedBindingSource As BindingSource
    Friend WithEvents SelectedTableAdapter As MMCDataSetTableAdapters.SelectedTableAdapter
    Friend WithEvents Selected_ByComboBox As ComboBox
End Class
