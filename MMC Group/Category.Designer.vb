﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Category
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MMCDataSet = New MMC_Group.MMCDataSet()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New MMC_Group.MMCDataSetTableAdapters.CategoryTableAdapter()
        Me.Process1 = New System.Diagnostics.Process()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New MMC_Group.MMCDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Category:"
        '
        'AddTextBox
        '
        Me.AddTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTextBox.Location = New System.Drawing.Point(193, 52)
        Me.AddTextBox.Name = "AddTextBox"
        Me.AddTextBox.Size = New System.Drawing.Size(246, 26)
        Me.AddTextBox.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(462, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(316, 183)
        Me.DataGridView1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(175, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(175, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 43)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(318, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 43)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MMCDataSet
        '
        Me.MMCDataSet.DataSetName = "MMCDataSet"
        Me.MMCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.MMCDataSet
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(318, 112)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 43)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Me.CategoryTableAdapter
        Me.TableAdapterManager.EnquiryTableAdapter = Nothing
        Me.TableAdapterManager.HoldTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MedicalTableAdapter = Nothing
        Me.TableAdapterManager.SelectionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MMC_Group.MMCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisaTableAdapter = Nothing
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(12, 12)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(33, 20)
        Me.IDTextBox.TabIndex = 8
        Me.IDTextBox.Visible = False
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 281)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AddTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Category"
        Me.Text = "Category"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AddTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MMCDataSet As MMCDataSet
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents CategoryTableAdapter As MMCDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents Process1 As Process
    Friend WithEvents Button4 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents TableAdapterManager As MMCDataSetTableAdapters.TableAdapterManager
End Class
