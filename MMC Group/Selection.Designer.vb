<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selection
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim Passport_NoLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim Agent_RefLabel As System.Windows.Forms.Label
        Dim City_VallageLabel As System.Windows.Forms.Label
        Dim Salary_OfferedLabel As System.Windows.Forms.Label
        Dim Selected_ByLabel As System.Windows.Forms.Label
        Dim Passport_Expiry_DateLabel As System.Windows.Forms.Label
        Dim StatuesLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Selection))
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Passport_NoTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Mobile_NoTextBox = New System.Windows.Forms.TextBox()
        Me.City_VillageTextBox = New System.Windows.Forms.TextBox()
        Me.Passport_Expiry_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatuesComboBox = New System.Windows.Forms.ComboBox()
        Me.RemarkTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SearchBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MMCDataSet = New MMC_Group.MMCDataSet()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectionTableAdapter = New MMC_Group.MMCDataSetTableAdapters.SelectionTableAdapter()
        Me.TableAdapterManager = New MMC_Group.MMCDataSetTableAdapters.TableAdapterManager()
        Me.Agent_RefComboBox = New System.Windows.Forms.ComboBox()
        Me.LocationComboBox = New System.Windows.Forms.ComboBox()
        Me.Salary_OfferedTextBox = New System.Windows.Forms.TextBox()
        Me.Selected_ByComboBox = New System.Windows.Forms.ComboBox()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Passport_NoLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        Agent_RefLabel = New System.Windows.Forms.Label()
        City_VallageLabel = New System.Windows.Forms.Label()
        Salary_OfferedLabel = New System.Windows.Forms.Label()
        Selected_ByLabel = New System.Windows.Forms.Label()
        Passport_Expiry_DateLabel = New System.Windows.Forms.Label()
        StatuesLabel = New System.Windows.Forms.Label()
        RemarkLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(26, 27)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(26, 64)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 20)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'Passport_NoLabel
        '
        Passport_NoLabel.AutoSize = True
        Passport_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Passport_NoLabel.Location = New System.Drawing.Point(26, 105)
        Passport_NoLabel.Name = "Passport_NoLabel"
        Passport_NoLabel.Size = New System.Drawing.Size(112, 20)
        Passport_NoLabel.TabIndex = 5
        Passport_NoLabel.Text = "Passport No:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.Location = New System.Drawing.Point(26, 137)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(86, 20)
        CategoryLabel.TabIndex = 7
        CategoryLabel.Text = "Category:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(26, 178)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(93, 20)
        Mobile_NoLabel.TabIndex = 9
        Mobile_NoLabel.Text = "Mobile No:"
        '
        'Agent_RefLabel
        '
        Agent_RefLabel.AutoSize = True
        Agent_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Agent_RefLabel.Location = New System.Drawing.Point(26, 221)
        Agent_RefLabel.Name = "Agent_RefLabel"
        Agent_RefLabel.Size = New System.Drawing.Size(96, 20)
        Agent_RefLabel.TabIndex = 11
        Agent_RefLabel.Text = "Agent/Ref:"
        '
        'City_VallageLabel
        '
        City_VallageLabel.AutoSize = True
        City_VallageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        City_VallageLabel.Location = New System.Drawing.Point(25, 259)
        City_VallageLabel.Name = "City_VallageLabel"
        City_VallageLabel.Size = New System.Drawing.Size(103, 20)
        City_VallageLabel.TabIndex = 13
        City_VallageLabel.Text = "City/Village:"
        '
        'Salary_OfferedLabel
        '
        Salary_OfferedLabel.AutoSize = True
        Salary_OfferedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Salary_OfferedLabel.Location = New System.Drawing.Point(25, 358)
        Salary_OfferedLabel.Name = "Salary_OfferedLabel"
        Salary_OfferedLabel.Size = New System.Drawing.Size(130, 20)
        Salary_OfferedLabel.TabIndex = 15
        Salary_OfferedLabel.Text = "Salary Offered:"
        '
        'Selected_ByLabel
        '
        Selected_ByLabel.AutoSize = True
        Selected_ByLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Selected_ByLabel.Location = New System.Drawing.Point(26, 401)
        Selected_ByLabel.Name = "Selected_ByLabel"
        Selected_ByLabel.Size = New System.Drawing.Size(110, 20)
        Selected_ByLabel.TabIndex = 17
        Selected_ByLabel.Text = "Selected By:"
        '
        'Passport_Expiry_DateLabel
        '
        Passport_Expiry_DateLabel.AutoSize = True
        Passport_Expiry_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Passport_Expiry_DateLabel.Location = New System.Drawing.Point(25, 438)
        Passport_Expiry_DateLabel.Name = "Passport_Expiry_DateLabel"
        Passport_Expiry_DateLabel.Size = New System.Drawing.Size(182, 20)
        Passport_Expiry_DateLabel.TabIndex = 19
        Passport_Expiry_DateLabel.Text = "Passport Expiry Date:"
        '
        'StatuesLabel
        '
        StatuesLabel.AutoSize = True
        StatuesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatuesLabel.Location = New System.Drawing.Point(25, 474)
        StatuesLabel.Name = "StatuesLabel"
        StatuesLabel.Size = New System.Drawing.Size(77, 20)
        StatuesLabel.TabIndex = 21
        StatuesLabel.Text = "Statues:"
        '
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RemarkLabel.Location = New System.Drawing.Point(26, 513)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(76, 20)
        RemarkLabel.TabIndex = 23
        RemarkLabel.Text = "Remark:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(26, 292)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(53, 20)
        DateLabel.TabIndex = 42
        DateLabel.Text = "Date:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(26, 327)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(83, 20)
        LocationLabel.TabIndex = 54
        LocationLabel.Text = "Location:"
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(211, 21)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(258, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(211, 58)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(258, 26)
        Me.NameTextBox.TabIndex = 4
        '
        'Passport_NoTextBox
        '
        Me.Passport_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passport_NoTextBox.Location = New System.Drawing.Point(211, 97)
        Me.Passport_NoTextBox.Name = "Passport_NoTextBox"
        Me.Passport_NoTextBox.Size = New System.Drawing.Size(258, 26)
        Me.Passport_NoTextBox.TabIndex = 6
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(210, 137)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(258, 28)
        Me.CategoryComboBox.TabIndex = 8
        '
        'Mobile_NoTextBox
        '
        Me.Mobile_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_NoTextBox.Location = New System.Drawing.Point(211, 178)
        Me.Mobile_NoTextBox.Name = "Mobile_NoTextBox"
        Me.Mobile_NoTextBox.Size = New System.Drawing.Size(258, 26)
        Me.Mobile_NoTextBox.TabIndex = 10
        '
        'City_VillageTextBox
        '
        Me.City_VillageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_VillageTextBox.Location = New System.Drawing.Point(210, 253)
        Me.City_VillageTextBox.Name = "City_VillageTextBox"
        Me.City_VillageTextBox.Size = New System.Drawing.Size(258, 26)
        Me.City_VillageTextBox.TabIndex = 14
        '
        'Passport_Expiry_DateDateTimePicker
        '
        Me.Passport_Expiry_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passport_Expiry_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Passport_Expiry_DateDateTimePicker.Location = New System.Drawing.Point(210, 432)
        Me.Passport_Expiry_DateDateTimePicker.Name = "Passport_Expiry_DateDateTimePicker"
        Me.Passport_Expiry_DateDateTimePicker.Size = New System.Drawing.Size(258, 26)
        Me.Passport_Expiry_DateDateTimePicker.TabIndex = 20
        Me.Passport_Expiry_DateDateTimePicker.Value = New Date(2019, 1, 28, 0, 0, 0, 0)
        '
        'StatuesComboBox
        '
        Me.StatuesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatuesComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatuesComboBox.FormattingEnabled = True
        Me.StatuesComboBox.Items.AddRange(New Object() {"MEDICAL OK", "MEDICAL PANDING", "AT MEDICAL NOW", "MEDICAL OKAY BUT NOT RECEIVED", "UNFIT", "NOT AGREE", "WILL GO", "AT PASSPORT RENEW", "VISA CAME", "ON HOLD", "OTHER"})
        Me.StatuesComboBox.Location = New System.Drawing.Point(210, 466)
        Me.StatuesComboBox.Name = "StatuesComboBox"
        Me.StatuesComboBox.Size = New System.Drawing.Size(258, 28)
        Me.StatuesComboBox.TabIndex = 22
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarkTextBox.Location = New System.Drawing.Point(210, 510)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(258, 26)
        Me.RemarkTextBox.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(497, 137)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(845, 507)
        Me.DataGridView1.TabIndex = 25
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(210, 623)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 42)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(358, 556)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 42)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(358, 623)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 42)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(210, 556)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 42)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1212, 96)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 28)
        Me.Button6.TabIndex = 38
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Date", "Name", "Passport No", "City/Village", "Category", "Agent/Ref", "Mobile No", "Selected By", "Expiry Date", "Status", "Location"})
        Me.ComboBox1.Location = New System.Drawing.Point(989, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 28)
        Me.ComboBox1.TabIndex = 37
        '
        'SearchBox1
        '
        Me.SearchBox1.BackColor = System.Drawing.Color.White
        Me.SearchBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox1.Location = New System.Drawing.Point(989, 44)
        Me.SearchBox1.Name = "SearchBox1"
        Me.SearchBox1.Size = New System.Drawing.Size(202, 26)
        Me.SearchBox1.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1222, 662)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 48)
        Me.Button1.TabIndex = 39
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(776, 97)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 28)
        Me.Button7.TabIndex = 42
        Me.Button7.Text = "Fliter"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(549, 97)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker2.TabIndex = 41
        Me.DateTimePicker2.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(549, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 40
        Me.DateTimePicker1.Value = New Date(2019, 1, 28, 0, 0, 0, 0)
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(210, 287)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(258, 26)
        Me.DateDateTimePicker.TabIndex = 43
        Me.DateDateTimePicker.Value = New Date(2019, 1, 29, 0, 0, 0, 0)
        '
        'MMCDataSet
        '
        Me.MMCDataSet.DataSetName = "MMCDataSet"
        Me.MMCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintDocument1
        '
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(1084, 664)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 46)
        Me.Button8.TabIndex = 51
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(565, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Selection"
        Me.Label1.Visible = False
        '
        'SelectionBindingSource
        '
        Me.SelectionBindingSource.DataMember = "Selection"
        Me.SelectionBindingSource.DataSource = Me.MMCDataSet
        '
        'SelectionTableAdapter
        '
        Me.SelectionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SelectionTableAdapter = Me.SelectionTableAdapter
        Me.TableAdapterManager.UpdateOrder = MMC_Group.MMCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisaTableAdapter = Nothing
        '
        'Agent_RefComboBox
        '
        Me.Agent_RefComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectionBindingSource, "Agent/Ref", True))
        Me.Agent_RefComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Agent_RefComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agent_RefComboBox.FormattingEnabled = True
        Me.Agent_RefComboBox.Location = New System.Drawing.Point(210, 213)
        Me.Agent_RefComboBox.Name = "Agent_RefComboBox"
        Me.Agent_RefComboBox.Size = New System.Drawing.Size(258, 28)
        Me.Agent_RefComboBox.TabIndex = 54
        '
        'LocationComboBox
        '
        Me.LocationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectionBindingSource, "Location", True))
        Me.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LocationComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationComboBox.FormattingEnabled = True
        Me.LocationComboBox.Location = New System.Drawing.Point(210, 321)
        Me.LocationComboBox.Name = "LocationComboBox"
        Me.LocationComboBox.Size = New System.Drawing.Size(258, 28)
        Me.LocationComboBox.TabIndex = 55
        '
        'Salary_OfferedTextBox
        '
        Me.Salary_OfferedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salary_OfferedTextBox.Location = New System.Drawing.Point(211, 355)
        Me.Salary_OfferedTextBox.Name = "Salary_OfferedTextBox"
        Me.Salary_OfferedTextBox.Size = New System.Drawing.Size(258, 26)
        Me.Salary_OfferedTextBox.TabIndex = 16
        '
        'Selected_ByComboBox
        '
        Me.Selected_ByComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectionBindingSource, "Selected By", True))
        Me.Selected_ByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Selected_ByComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Selected_ByComboBox.FormattingEnabled = True
        Me.Selected_ByComboBox.Location = New System.Drawing.Point(210, 393)
        Me.Selected_ByComboBox.Name = "Selected_ByComboBox"
        Me.Selected_ByComboBox.Size = New System.Drawing.Size(258, 28)
        Me.Selected_ByComboBox.TabIndex = 56
        '
        'Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Selected_ByComboBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationComboBox)
        Me.Controls.Add(Me.Agent_RefComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SearchBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Passport_NoLabel)
        Me.Controls.Add(Me.Passport_NoTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Mobile_NoLabel)
        Me.Controls.Add(Me.Mobile_NoTextBox)
        Me.Controls.Add(Agent_RefLabel)
        Me.Controls.Add(City_VallageLabel)
        Me.Controls.Add(Me.City_VillageTextBox)
        Me.Controls.Add(Salary_OfferedLabel)
        Me.Controls.Add(Me.Salary_OfferedTextBox)
        Me.Controls.Add(Selected_ByLabel)
        Me.Controls.Add(Passport_Expiry_DateLabel)
        Me.Controls.Add(Me.Passport_Expiry_DateDateTimePicker)
        Me.Controls.Add(StatuesLabel)
        Me.Controls.Add(Me.StatuesComboBox)
        Me.Controls.Add(RemarkLabel)
        Me.Controls.Add(Me.RemarkTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Selection"
        Me.Text = "Selection"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MMCDataSet As MMCDataSet
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Passport_NoTextBox As TextBox
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents Mobile_NoTextBox As TextBox
    Friend WithEvents City_VillageTextBox As TextBox
    Friend WithEvents Passport_Expiry_DateDateTimePicker As DateTimePicker
    Friend WithEvents StatuesComboBox As ComboBox
    Friend WithEvents RemarkTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SearchBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectionBindingSource As BindingSource
    Friend WithEvents SelectionTableAdapter As MMCDataSetTableAdapters.SelectionTableAdapter
    Friend WithEvents TableAdapterManager As MMCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Agent_RefComboBox As ComboBox
    Friend WithEvents LocationComboBox As ComboBox
    Friend WithEvents Salary_OfferedTextBox As TextBox
    Friend WithEvents Selected_ByComboBox As ComboBox
End Class
