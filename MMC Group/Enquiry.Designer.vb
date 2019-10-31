<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Enquiry
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
        Dim DateLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Passport_NoLabel As System.Windows.Forms.Label
        Dim CategoreyLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim City_VillageLabel As System.Windows.Forms.Label
        Dim Agent_RefLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enquiry))
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Passport_NoTextBox = New System.Windows.Forms.TextBox()
        Me.CategoreyComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMCDataSet = New MMC_Group.MMCDataSet()
        Me.Mobile_NoTextBox = New System.Windows.Forms.TextBox()
        Me.City_VillageTextBox = New System.Windows.Forms.TextBox()
        Me.RemarkTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EnquiryTableAdapter = New MMC_Group.MMCDataSetTableAdapters.CategoryTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SearchBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.EnquiryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New MMC_Group.MMCDataSetTableAdapters.TableAdapterManager()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MmcDataSet1 = New MMC_Group.MMCDataSet()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.EnquiryTableAdapter1 = New MMC_Group.MMCDataSetTableAdapters.EnquiryTableAdapter()
        Me.Agent_RefComboBox = New System.Windows.Forms.ComboBox()
        IDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Passport_NoLabel = New System.Windows.Forms.Label()
        CategoreyLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        City_VillageLabel = New System.Windows.Forms.Label()
        Agent_RefLabel = New System.Windows.Forms.Label()
        RemarkLabel = New System.Windows.Forms.Label()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnquiryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MmcDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(18, 78)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(18, 115)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(53, 20)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(18, 153)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 20)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name:"
        '
        'Passport_NoLabel
        '
        Passport_NoLabel.AutoSize = True
        Passport_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Passport_NoLabel.Location = New System.Drawing.Point(18, 193)
        Passport_NoLabel.Name = "Passport_NoLabel"
        Passport_NoLabel.Size = New System.Drawing.Size(112, 20)
        Passport_NoLabel.TabIndex = 7
        Passport_NoLabel.Text = "Passport No:"
        '
        'CategoreyLabel
        '
        CategoreyLabel.AutoSize = True
        CategoreyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoreyLabel.Location = New System.Drawing.Point(18, 232)
        CategoreyLabel.Name = "CategoreyLabel"
        CategoreyLabel.Size = New System.Drawing.Size(96, 20)
        CategoreyLabel.TabIndex = 9
        CategoreyLabel.Text = "Categorey:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(18, 279)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(93, 20)
        Mobile_NoLabel.TabIndex = 11
        Mobile_NoLabel.Text = "Mobile No:"
        '
        'City_VillageLabel
        '
        City_VillageLabel.AutoSize = True
        City_VillageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        City_VillageLabel.Location = New System.Drawing.Point(18, 324)
        City_VillageLabel.Name = "City_VillageLabel"
        City_VillageLabel.Size = New System.Drawing.Size(103, 20)
        City_VillageLabel.TabIndex = 13
        City_VillageLabel.Text = "City/Village:"
        '
        'Agent_RefLabel
        '
        Agent_RefLabel.AutoSize = True
        Agent_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Agent_RefLabel.Location = New System.Drawing.Point(18, 367)
        Agent_RefLabel.Name = "Agent_RefLabel"
        Agent_RefLabel.Size = New System.Drawing.Size(96, 20)
        Agent_RefLabel.TabIndex = 15
        Agent_RefLabel.Text = "Agent/Ref:"
        '
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RemarkLabel.Location = New System.Drawing.Point(18, 416)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(76, 20)
        RemarkLabel.TabIndex = 17
        RemarkLabel.Text = "Remark:"
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(135, 72)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(135, 115)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.DateDateTimePicker.TabIndex = 4
        Me.DateDateTimePicker.Value = New Date(2019, 2, 1, 0, 0, 0, 0)
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(135, 153)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NameTextBox.TabIndex = 6
        '
        'Passport_NoTextBox
        '
        Me.Passport_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passport_NoTextBox.Location = New System.Drawing.Point(135, 190)
        Me.Passport_NoTextBox.Name = "Passport_NoTextBox"
        Me.Passport_NoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Passport_NoTextBox.TabIndex = 8
        '
        'CategoreyComboBox
        '
        Me.CategoreyComboBox.AllowDrop = True
        Me.CategoreyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoryBindingSource, "Category", True))
        Me.CategoreyComboBox.DataSource = Me.CategoryBindingSource
        Me.CategoreyComboBox.DisplayMember = "Category"
        Me.CategoreyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoreyComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoreyComboBox.FormattingEnabled = True
        Me.CategoreyComboBox.Location = New System.Drawing.Point(135, 232)
        Me.CategoreyComboBox.Name = "CategoreyComboBox"
        Me.CategoreyComboBox.Size = New System.Drawing.Size(200, 28)
        Me.CategoreyComboBox.TabIndex = 10
        Me.CategoreyComboBox.ValueMember = "Category"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.MMCDataSet
        '
        'MMCDataSet
        '
        Me.MMCDataSet.DataSetName = "MMCDataSet"
        Me.MMCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mobile_NoTextBox
        '
        Me.Mobile_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_NoTextBox.Location = New System.Drawing.Point(135, 276)
        Me.Mobile_NoTextBox.Name = "Mobile_NoTextBox"
        Me.Mobile_NoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Mobile_NoTextBox.TabIndex = 12
        '
        'City_VillageTextBox
        '
        Me.City_VillageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_VillageTextBox.Location = New System.Drawing.Point(135, 324)
        Me.City_VillageTextBox.Name = "City_VillageTextBox"
        Me.City_VillageTextBox.Size = New System.Drawing.Size(200, 26)
        Me.City_VillageTextBox.TabIndex = 14
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarkTextBox.Location = New System.Drawing.Point(135, 416)
        Me.RemarkTextBox.Multiline = True
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(200, 68)
        Me.RemarkTextBox.TabIndex = 18
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(66, 596)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 42)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(233, 529)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 42)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(233, 596)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 42)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(66, 529)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 42)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(391, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(951, 507)
        Me.DataGridView1.TabIndex = 31
        '
        'EnquiryTableAdapter
        '
        Me.EnquiryTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.MMC_Group.My.Resources.Resources.blog_excel_logo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1218, 653)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 46)
        Me.Button1.TabIndex = 32
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SearchBox1
        '
        Me.SearchBox1.BackColor = System.Drawing.Color.White
        Me.SearchBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox1.Location = New System.Drawing.Point(956, 41)
        Me.SearchBox1.Name = "SearchBox1"
        Me.SearchBox1.Size = New System.Drawing.Size(202, 26)
        Me.SearchBox1.TabIndex = 33
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Date", "Name", "Passport No", "City/Village", "Category", "Agent/Ref", "Mobile No"})
        Me.ComboBox1.Location = New System.Drawing.Point(956, 87)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 28)
        Me.ComboBox1.TabIndex = 34
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1186, 86)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 28)
        Me.Button6.TabIndex = 35
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'EnquiryBindingSource
        '
        Me.EnquiryBindingSource.DataMember = "Enquiry"
        Me.EnquiryBindingSource.DataSource = Me.MMCDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Me.EnquiryTableAdapter
        Me.TableAdapterManager.EnquiryTableAdapter = Nothing
        Me.TableAdapterManager.HoldTableAdapter = Nothing
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MedicalTableAdapter = Nothing
        Me.TableAdapterManager.SelectedTableAdapter = Nothing
        Me.TableAdapterManager.SelectionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MMC_Group.MMCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisaTableAdapter = Nothing
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(451, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 36
        Me.DateTimePicker1.Value = New Date(2019, 2, 1, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(451, 89)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker2.TabIndex = 37
        Me.DateTimePicker2.Value = New Date(2019, 2, 1, 0, 0, 0, 0)
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(690, 89)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 28)
        Me.Button7.TabIndex = 38
        Me.Button7.Text = "Fliter"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'MmcDataSet1
        '
        Me.MmcDataSet1.DataSetName = "MMCDataSet"
        Me.MmcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(1092, 653)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 46)
        Me.Button8.TabIndex = 39
        Me.Button8.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(369, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Enquiry"
        Me.Label1.Visible = False
        '
        'PrintDocument1
        '
        '
        'EnquiryTableAdapter1
        '
        Me.EnquiryTableAdapter1.ClearBeforeFill = True
        '
        'Agent_RefComboBox
        '
        Me.Agent_RefComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "Agent/Ref", True))
        Me.Agent_RefComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Agent_RefComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agent_RefComboBox.FormattingEnabled = True
        Me.Agent_RefComboBox.Location = New System.Drawing.Point(135, 369)
        Me.Agent_RefComboBox.Name = "Agent_RefComboBox"
        Me.Agent_RefComboBox.Size = New System.Drawing.Size(200, 28)
        Me.Agent_RefComboBox.TabIndex = 41
        '
        'Enquiry
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
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SearchBox1)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(CategoreyLabel)
        Me.Controls.Add(Me.CategoreyComboBox)
        Me.Controls.Add(Mobile_NoLabel)
        Me.Controls.Add(Me.Mobile_NoTextBox)
        Me.Controls.Add(City_VillageLabel)
        Me.Controls.Add(Me.City_VillageTextBox)
        Me.Controls.Add(Agent_RefLabel)
        Me.Controls.Add(RemarkLabel)
        Me.Controls.Add(Me.RemarkTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Enquiry"
        Me.Text = "Enquiry"
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnquiryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MmcDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Passport_NoTextBox As TextBox
    Friend WithEvents CategoreyComboBox As ComboBox
    Friend WithEvents Mobile_NoTextBox As TextBox
    Friend WithEvents City_VillageTextBox As TextBox
    Friend WithEvents RemarkTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MMCDataSet As MMCDataSet
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents EnquiryTableAdapter As MMCDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents SearchBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents EnquiryBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As MMCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button7 As Button
    Friend WithEvents MmcDataSet1 As MMCDataSet
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button8 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents EnquiryTableAdapter1 As MMCDataSetTableAdapters.EnquiryTableAdapter
    Friend WithEvents Agent_RefComboBox As ComboBox
End Class
