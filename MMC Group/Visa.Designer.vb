<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visa
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
        Dim IND_NoLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Passport_NoLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim Agent_RefLabel As System.Windows.Forms.Label
        Dim City_VillageLabel As System.Windows.Forms.Label
        Dim ECR_StatusLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim Selected_ByLabel As System.Windows.Forms.Label
        Dim Visa_Issue_DateLabel As System.Windows.Forms.Label
        Dim Visa_Expiry_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visa))
        Me.MMCDataSet = New MMC_Group.MMCDataSet()
        Me.VisaTableAdapter = New MMC_Group.MMCDataSetTableAdapters.VisaTableAdapter()
        Me.TableAdapterManager = New MMC_Group.MMCDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.IND_NoTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Passport_NoTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Mobile_NoTextBox = New System.Windows.Forms.TextBox()
        Me.City_VillageTextBox = New System.Windows.Forms.TextBox()
        Me.ECR_StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Visa_Issue_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Visa_Expiry_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
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
        Me.VisaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Agent_RefComboBox = New System.Windows.Forms.ComboBox()
        Me.Selected_ByComboBox = New System.Windows.Forms.ComboBox()
        IDLabel = New System.Windows.Forms.Label()
        IND_NoLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Passport_NoLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        Agent_RefLabel = New System.Windows.Forms.Label()
        City_VillageLabel = New System.Windows.Forms.Label()
        ECR_StatusLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        Selected_ByLabel = New System.Windows.Forms.Label()
        Visa_Issue_DateLabel = New System.Windows.Forms.Label()
        Visa_Expiry_DateLabel = New System.Windows.Forms.Label()
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(22, 44)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IND_NoLabel
        '
        IND_NoLabel.AutoSize = True
        IND_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IND_NoLabel.Location = New System.Drawing.Point(22, 80)
        IND_NoLabel.Name = "IND_NoLabel"
        IND_NoLabel.Size = New System.Drawing.Size(72, 20)
        IND_NoLabel.TabIndex = 3
        IND_NoLabel.Text = "IND No:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(22, 119)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 20)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name:"
        '
        'Passport_NoLabel
        '
        Passport_NoLabel.AutoSize = True
        Passport_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Passport_NoLabel.Location = New System.Drawing.Point(20, 150)
        Passport_NoLabel.Name = "Passport_NoLabel"
        Passport_NoLabel.Size = New System.Drawing.Size(112, 20)
        Passport_NoLabel.TabIndex = 7
        Passport_NoLabel.Text = "Passport No:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.Location = New System.Drawing.Point(20, 186)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(86, 20)
        CategoryLabel.TabIndex = 9
        CategoryLabel.Text = "Category:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(22, 221)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(93, 20)
        Mobile_NoLabel.TabIndex = 11
        Mobile_NoLabel.Text = "Mobile No:"
        '
        'Agent_RefLabel
        '
        Agent_RefLabel.AutoSize = True
        Agent_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Agent_RefLabel.Location = New System.Drawing.Point(22, 255)
        Agent_RefLabel.Name = "Agent_RefLabel"
        Agent_RefLabel.Size = New System.Drawing.Size(96, 20)
        Agent_RefLabel.TabIndex = 13
        Agent_RefLabel.Text = "Agent/Ref:"
        '
        'City_VillageLabel
        '
        City_VillageLabel.AutoSize = True
        City_VillageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        City_VillageLabel.Location = New System.Drawing.Point(20, 290)
        City_VillageLabel.Name = "City_VillageLabel"
        City_VillageLabel.Size = New System.Drawing.Size(103, 20)
        City_VillageLabel.TabIndex = 15
        City_VillageLabel.Text = "City/Village:"
        '
        'ECR_StatusLabel
        '
        ECR_StatusLabel.AutoSize = True
        ECR_StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ECR_StatusLabel.Location = New System.Drawing.Point(20, 326)
        ECR_StatusLabel.Name = "ECR_StatusLabel"
        ECR_StatusLabel.Size = New System.Drawing.Size(109, 20)
        ECR_StatusLabel.TabIndex = 17
        ECR_StatusLabel.Text = "ECR Status:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalaryLabel.Location = New System.Drawing.Point(22, 358)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(64, 20)
        SalaryLabel.TabIndex = 19
        SalaryLabel.Text = "Salary:"
        '
        'Selected_ByLabel
        '
        Selected_ByLabel.AutoSize = True
        Selected_ByLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Selected_ByLabel.Location = New System.Drawing.Point(22, 390)
        Selected_ByLabel.Name = "Selected_ByLabel"
        Selected_ByLabel.Size = New System.Drawing.Size(110, 20)
        Selected_ByLabel.TabIndex = 21
        Selected_ByLabel.Text = "Selected By:"
        '
        'Visa_Issue_DateLabel
        '
        Visa_Issue_DateLabel.AutoSize = True
        Visa_Issue_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visa_Issue_DateLabel.Location = New System.Drawing.Point(20, 423)
        Visa_Issue_DateLabel.Name = "Visa_Issue_DateLabel"
        Visa_Issue_DateLabel.Size = New System.Drawing.Size(142, 20)
        Visa_Issue_DateLabel.TabIndex = 23
        Visa_Issue_DateLabel.Text = "Visa Issue Date:"
        '
        'Visa_Expiry_DateLabel
        '
        Visa_Expiry_DateLabel.AutoSize = True
        Visa_Expiry_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visa_Expiry_DateLabel.Location = New System.Drawing.Point(22, 457)
        Visa_Expiry_DateLabel.Name = "Visa_Expiry_DateLabel"
        Visa_Expiry_DateLabel.Size = New System.Drawing.Size(146, 20)
        Visa_Expiry_DateLabel.TabIndex = 25
        Visa_Expiry_DateLabel.Text = "Visa Expiry Date:"
        '
        'MMCDataSet
        '
        Me.MMCDataSet.DataSetName = "MMCDataSet"
        Me.MMCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisaTableAdapter
        '
        Me.VisaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.MedicalTableAdapter = Nothing
        Me.TableAdapterManager.SelectedTableAdapter = Nothing
        Me.TableAdapterManager.SelectionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MMC_Group.MMCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisaTableAdapter = Me.VisaTableAdapter
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(174, 44)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(231, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'IND_NoTextBox
        '
        Me.IND_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IND_NoTextBox.Location = New System.Drawing.Point(174, 80)
        Me.IND_NoTextBox.Name = "IND_NoTextBox"
        Me.IND_NoTextBox.Size = New System.Drawing.Size(231, 26)
        Me.IND_NoTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(174, 112)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(231, 26)
        Me.NameTextBox.TabIndex = 6
        '
        'Passport_NoTextBox
        '
        Me.Passport_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passport_NoTextBox.Location = New System.Drawing.Point(174, 144)
        Me.Passport_NoTextBox.Name = "Passport_NoTextBox"
        Me.Passport_NoTextBox.Size = New System.Drawing.Size(231, 26)
        Me.Passport_NoTextBox.TabIndex = 8
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(174, 178)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(231, 28)
        Me.CategoryComboBox.TabIndex = 10
        '
        'Mobile_NoTextBox
        '
        Me.Mobile_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_NoTextBox.Location = New System.Drawing.Point(174, 221)
        Me.Mobile_NoTextBox.Name = "Mobile_NoTextBox"
        Me.Mobile_NoTextBox.Size = New System.Drawing.Size(231, 26)
        Me.Mobile_NoTextBox.TabIndex = 12
        '
        'City_VillageTextBox
        '
        Me.City_VillageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_VillageTextBox.Location = New System.Drawing.Point(174, 290)
        Me.City_VillageTextBox.Name = "City_VillageTextBox"
        Me.City_VillageTextBox.Size = New System.Drawing.Size(231, 26)
        Me.City_VillageTextBox.TabIndex = 16
        '
        'ECR_StatusComboBox
        '
        Me.ECR_StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ECR_StatusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECR_StatusComboBox.FormattingEnabled = True
        Me.ECR_StatusComboBox.Items.AddRange(New Object() {"ECR", "ECNR", "OTHER"})
        Me.ECR_StatusComboBox.Location = New System.Drawing.Point(174, 326)
        Me.ECR_StatusComboBox.Name = "ECR_StatusComboBox"
        Me.ECR_StatusComboBox.Size = New System.Drawing.Size(231, 28)
        Me.ECR_StatusComboBox.TabIndex = 18
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaryTextBox.Location = New System.Drawing.Point(174, 358)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(231, 26)
        Me.SalaryTextBox.TabIndex = 20
        '
        'Visa_Issue_DateDateTimePicker
        '
        Me.Visa_Issue_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visa_Issue_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Visa_Issue_DateDateTimePicker.Location = New System.Drawing.Point(174, 423)
        Me.Visa_Issue_DateDateTimePicker.Name = "Visa_Issue_DateDateTimePicker"
        Me.Visa_Issue_DateDateTimePicker.Size = New System.Drawing.Size(231, 26)
        Me.Visa_Issue_DateDateTimePicker.TabIndex = 24
        Me.Visa_Issue_DateDateTimePicker.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'Visa_Expiry_DateDateTimePicker
        '
        Me.Visa_Expiry_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visa_Expiry_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Visa_Expiry_DateDateTimePicker.Location = New System.Drawing.Point(174, 457)
        Me.Visa_Expiry_DateDateTimePicker.Name = "Visa_Expiry_DateDateTimePicker"
        Me.Visa_Expiry_DateDateTimePicker.Size = New System.Drawing.Size(231, 26)
        Me.Visa_Expiry_DateDateTimePicker.TabIndex = 26
        Me.Visa_Expiry_DateDateTimePicker.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(139, 580)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 42)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(287, 513)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 42)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(287, 580)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 42)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(139, 513)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 42)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(420, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(922, 494)
        Me.DataGridView1.TabIndex = 39
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1169, 97)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 28)
        Me.Button6.TabIndex = 45
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Date", "Name", "Passport No", "City/Village", "Category", "Agent/Ref", "Mobile No", "IND No", "Selected By", "Issue Date", "Expiry Date"})
        Me.ComboBox1.Location = New System.Drawing.Point(938, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 28)
        Me.ComboBox1.TabIndex = 44
        '
        'SearchBox1
        '
        Me.SearchBox1.BackColor = System.Drawing.Color.White
        Me.SearchBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox1.Location = New System.Drawing.Point(938, 44)
        Me.SearchBox1.Name = "SearchBox1"
        Me.SearchBox1.Size = New System.Drawing.Size(202, 26)
        Me.SearchBox1.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.MMC_Group.My.Resources.Resources.blog_excel_logo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1214, 655)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 48)
        Me.Button1.TabIndex = 46
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(712, 96)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 28)
        Me.Button7.TabIndex = 49
        Me.Button7.Text = "Fliter"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(485, 98)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker2.TabIndex = 48
        Me.DateTimePicker2.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(485, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 47
        Me.DateTimePicker1.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(1080, 657)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 46)
        Me.Button8.TabIndex = 50
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(445, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 24)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Visa"
        Me.Label1.Visible = False
        '
        'VisaBindingSource
        '
        Me.VisaBindingSource.DataMember = "Visa"
        Me.VisaBindingSource.DataSource = Me.MMCDataSet
        '
        'Agent_RefComboBox
        '
        Me.Agent_RefComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisaBindingSource, "Agent/Ref", True))
        Me.Agent_RefComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Agent_RefComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agent_RefComboBox.FormattingEnabled = True
        Me.Agent_RefComboBox.Location = New System.Drawing.Point(174, 257)
        Me.Agent_RefComboBox.Name = "Agent_RefComboBox"
        Me.Agent_RefComboBox.Size = New System.Drawing.Size(231, 28)
        Me.Agent_RefComboBox.TabIndex = 53
        '
        'Selected_ByComboBox
        '
        Me.Selected_ByComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisaBindingSource, "Selected By", True))
        Me.Selected_ByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Selected_ByComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Selected_ByComboBox.FormattingEnabled = True
        Me.Selected_ByComboBox.Location = New System.Drawing.Point(174, 390)
        Me.Selected_ByComboBox.Name = "Selected_ByComboBox"
        Me.Selected_ByComboBox.Size = New System.Drawing.Size(231, 28)
        Me.Selected_ByComboBox.TabIndex = 54
        '
        'Visa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Selected_ByComboBox)
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
        Me.Controls.Add(IND_NoLabel)
        Me.Controls.Add(Me.IND_NoTextBox)
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
        Me.Controls.Add(ECR_StatusLabel)
        Me.Controls.Add(Me.ECR_StatusComboBox)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Selected_ByLabel)
        Me.Controls.Add(Visa_Issue_DateLabel)
        Me.Controls.Add(Me.Visa_Issue_DateDateTimePicker)
        Me.Controls.Add(Visa_Expiry_DateLabel)
        Me.Controls.Add(Me.Visa_Expiry_DateDateTimePicker)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Visa"
        Me.Text = "Visa"
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MMCDataSet As MMCDataSet
    Friend WithEvents VisaTableAdapter As MMCDataSetTableAdapters.VisaTableAdapter
    Friend WithEvents TableAdapterManager As MMCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents IND_NoTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Passport_NoTextBox As TextBox
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents Mobile_NoTextBox As TextBox
    Friend WithEvents City_VillageTextBox As TextBox
    Friend WithEvents ECR_StatusComboBox As ComboBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents Visa_Issue_DateDateTimePicker As DateTimePicker
    Friend WithEvents Visa_Expiry_DateDateTimePicker As DateTimePicker
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
    Friend WithEvents VisaBindingSource As BindingSource
    Friend WithEvents Agent_RefComboBox As ComboBox
    Friend WithEvents Selected_ByComboBox As ComboBox
End Class
