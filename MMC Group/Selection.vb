Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop
Public Class Selection
    Dim con As New OleDb.OleDbConnection
    Dim Search As String
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer
    Private Sub Selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMCDataSet.Selection' table. You can move, or remove it, as needed.

        MaximizeBox = False

        CenterToScreen()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MMC.accdb"
        'DateDateTimePicker.Format = DateTimePickerFormat.Custom
        'DateDateTimePicker.CustomFormat = "dd/mm/yyyy"
        'Passport_Expiry_DateDateTimePicker.Format = DateTimePickerFormat.Custom
        'Passport_Expiry_DateDateTimePicker.CustomFormat = "dd/mm/yyyy"
        'DateTimePicker1.Format = DateTimePickerFormat.Custom
        'DateTimePicker1.CustomFormat = "dd/mm/yyyy"
        'DateTimePicker2.Format = DateTimePickerFormat.Custom
        'DateTimePicker2.CustomFormat = "dd/mm/yyyy"

        Location = New Point(0, 0)

        Size = Screen.PrimaryScreen.WorkingArea.Size

        Combo()
        DisplayData()
        NewInvoiceNo()
        agnt()
        loc()
        selected()

    End Sub
    Private Sub Selection_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed

        MainManu.Show()



    End Sub
    Private Sub selected()
        con.Open()
        Dim command As New OleDbCommand("SELECT * from Selected", con)
        Dim adapter As New OleDbDataAdapter
        Dim dt As New DataTable
        adapter.SelectCommand = command
        adapter.Fill(dt)

        adapter.Dispose()
        command.Dispose()
        Selected_ByComboBox.DataSource = dt
        Selected_ByComboBox.DisplayMember = "Selected By"

        con.Close()
    End Sub
    Private Sub loc()
        con.Open()
        Dim command As New OleDbCommand("SELECT * from Location", con)
        Dim adapter As New OleDbDataAdapter
        Dim dt As New DataTable
        adapter.SelectCommand = command
        adapter.Fill(dt)

        adapter.Dispose()
        command.Dispose()
        LocationComboBox.DataSource = dt
        LocationComboBox.DisplayMember = "Location"

        con.Close()
    End Sub
    Private Sub agnt()
        con.Open()
        Dim command As New OleDbCommand("SELECT * from Agent", con)
        Dim adapter As New OleDbDataAdapter
        Dim dt As New DataTable
        adapter.SelectCommand = command
        adapter.Fill(dt)

        adapter.Dispose()
        command.Dispose()
        Agent_RefComboBox.DataSource = dt
        Agent_RefComboBox.DisplayMember = "Agent"

        con.Close()
    End Sub
    Private Sub NewInvoiceNo()

        Dim ConnectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MMC.accdb"


        Try
            Dim sqlString As String = "SELECT MAX(ID)+1 FROM Selection"

            Dim dbConnection As New OleDbConnection(ConnectString)

            Dim command As New OleDb.OleDbCommand(sqlString, dbConnection)

            dbConnection.Open()
            Dim num
            num = command.ExecuteScalar()
            IDTextBox.Text = num

            dbConnection.Close()

        Catch sqlex As Exception

            MessageBox.Show(sqlex.Message)

        End Try

    End Sub

    Private Sub Combo()
        con.Open()
        Dim command As New OleDbCommand("SELECT * from Category", con)
        Dim adapter As New OleDbDataAdapter
        Dim dt As New DataTable
        adapter.SelectCommand = command
        adapter.Fill(dt)

        adapter.Dispose()
        command.Dispose()
        CategoryComboBox.DataSource = dt
        CategoryComboBox.DisplayMember = "Category"

        con.Close()
    End Sub
    Private Sub DisplayData()
        'checking whether the connection is opened or not
        con.Open()
        Dim command As New OleDbCommand("SELECT * from Selection", con)
        Dim adapter As New OleDbDataAdapter
        Dim dt As New DataTable
        adapter.SelectCommand = command
        adapter.Fill(dt)
        DataGridView1.DataSource = dt
        adapter.Dispose()
        command.Dispose()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Len(Trim(DateDateTimePicker.Text)) = 0 Then
            MessageBox.Show("Please Enter the Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateDateTimePicker.Focus()
            Exit Sub
        End If
        If Len(Trim(NameTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter the Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NameTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Passport_NoTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Passport Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Passport_NoTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(CategoryComboBox.Text)) = 0 Then
            MessageBox.Show("Please Select Categorey", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CategoryComboBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Mobile_NoTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Mobile Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Mobile_NoTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(City_VillageTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter City or Village", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            City_VillageTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Agent_RefComboBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Agent or Reference", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Agent_RefComboBox.Focus()
            Exit Sub
        End If
        If Len(Trim(LocationComboBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Remark or Just Press SpaceBar", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LocationComboBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Passport_Expiry_DateDateTimePicker.Text)) = 0 Then
            MessageBox.Show("Please Select Passport Expiry Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Passport_Expiry_DateDateTimePicker.Focus()
            Exit Sub
        End If
        If Len(Trim(Salary_OfferedTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Salary Details", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Salary_OfferedTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(StatuesComboBox.Text)) = 0 Then
            MessageBox.Show("Please Select The Status  ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            StatuesComboBox.Focus()
            Exit Sub
        End If
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = con
            If Not con.State = ConnectionState.Open Then
                con.Open()
                cmd.CommandText = "INSERT INTO Selection VALUES ('" & IDTextBox.Text & "','" & NameTextBox.Text & "', '" & Passport_NoTextBox.Text & "','" & CategoryComboBox.Text & "', '" & Mobile_NoTextBox.Text & "',  '" & Agent_RefComboBox.Text & "','" & City_VillageTextBox.Text & "','" & DateDateTimePicker.Text & "','" & LocationComboBox.Text & "','" & Salary_OfferedTextBox.Text & "','" & Selected_ByComboBox.Text & "','" & Passport_Expiry_DateDateTimePicker.Text & "','" & StatuesComboBox.Text & "','" & RemarkTextBox.Text.ToString & "')"
                '  cmd.Parameters.AddWithValue("@dt", OleDbType.Date).Value = DateDateTimePicker.Value
                '   cmd.Parameters.AddWithValue("@psdt", OleDbType.Date).Value = Passport_Expiry_DateDateTimePicker.Value

                cmd.ExecuteNonQuery()
                MessageBox.Show("Selection details added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If StatuesComboBox.Text = "MEDICAL OK" Then

                cmd.CommandText = "INSERT INTO Medical VALUES ('" & IDTextBox.Text & "' , '" & DateDateTimePicker.Text & "','" & NameTextBox.Text & "', '" & Passport_NoTextBox.Text & "','" & CategoryComboBox.Text & "', '" & Mobile_NoTextBox.Text & "',  '" & Agent_RefComboBox.Text & "','" & City_VillageTextBox.Text & "', @Ecr ,@medical)"
                ' cmd.Parameters.AddWithValue("@dt", OleDbType.Date).Value = DateDateTimePicker.Value
                cmd.Parameters.AddWithValue("@id", DBNull.Value)
                ' cmd.Parameters.AddWithValue("@Date", DBNull.Value)
                cmd.Parameters.AddWithValue("@Ecr", DBNull.Value)
                cmd.Parameters.AddWithValue("@medical", DBNull.Value)
                cmd.ExecuteNonQuery()
            ElseIf StatuesComboBox.Text = "VISA CAME" Then
                cmd.CommandText = "INSERT INTO Visa VALUES ('" & IDTextBox.Text & "' ,@Ind,'" & NameTextBox.Text & "', '" & Passport_NoTextBox.Text & "','" & CategoryComboBox.Text & "', '" & Mobile_NoTextBox.Text & "',  '" & Agent_RefComboBox.Text & "','" & City_VillageTextBox.Text & "',@Ecr,'" & Salary_OfferedTextBox.Text & "','" & Selected_ByComboBox.Text & "',@visaissue,@visaexpiry)"
                'cmd.Parameters.AddWithValue("@dt", OleDbType.Date).Value = Me.DateDateTimePicker.Value
                'cmd.Parameters.AddWithValue("@psdt", OleDbType.Date).Value = Me.Passport_Expiry_DateDateTimePicker.Value
                'cmd.Parameters.AddWithValue("@ID", DBNull.Value)
                'cmd.Parameters.AddWithValue("@Ind", DBNull.Value)
                cmd.Parameters.AddWithValue("@Date", DBNull.Value)
                cmd.Parameters.AddWithValue("@Ecr", DBNull.Value)
                cmd.Parameters.AddWithValue("@visaissue", DBNull.Value)
                cmd.Parameters.AddWithValue("@visaexpiry", DBNull.Value)
                cmd.ExecuteNonQuery()
            ElseIf StatuesComboBox.Text = "ON HOLD" Then
                cmd.CommandText = " INSERT INTO Hold VALUES ('" & IDTextBox.Text & "','" & NameTextBox.Text & "', '" & Passport_NoTextBox.Text & "','" & CategoryComboBox.Text & "', '" & Mobile_NoTextBox.Text & "',  '" & Agent_RefComboBox.Text & "','" & City_VillageTextBox.Text & "','" & DateDateTimePicker.Text & "','" & LocationComboBox.Text & "','" & Salary_OfferedTextBox.Text & "','" & Selected_ByComboBox.Text & "','" & Passport_Expiry_DateDateTimePicker.Text & "','" & StatuesComboBox.Text & "','" & RemarkTextBox.Text.ToString & "')"

                cmd.Parameters.AddWithValue("@dt", OleDbType.Date).Value = Me.DateDateTimePicker.Value
                cmd.Parameters.AddWithValue("@psdt", OleDbType.Date).Value = Me.Passport_Expiry_DateDateTimePicker.Value
                cmd.ExecuteNonQuery()


            End If
            con.Close()
            'IDTextBox.Clear()
            NameTextBox.Clear()
            Mobile_NoTextBox.Clear()

            Salary_OfferedTextBox.Clear()
            City_VillageTextBox.Clear()
            Passport_NoTextBox.Clear()
            Agent_RefComboBox.Refresh()

            RemarkTextBox.Clear()
            DisplayData()
            NewInvoiceNo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If DataGridView1.Rows.Count > 0 Then

            If DataGridView1.SelectedRows.Count > 0 Then
                Dim intStId As Integer = DataGridView1.SelectedRows(0).Cells("ID").Value

                'opening connection
                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                'get data into data table
                Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Selection WHERE ID =" & intStId, con)
                Dim dt As New DataTable
                da.Fill(dt)

                IDTextBox.Text = intStId
                DateDateTimePicker.Tag = dt.Rows(0).Item("Date")
                NameTextBox.Text = dt.Rows(0).Item("Name")
                Passport_NoTextBox.Text = dt.Rows(0).Item("Passport No")
                CategoryComboBox.Text = dt.Rows(0).Item("Category")
                Mobile_NoTextBox.Text = dt.Rows(0).Item("Mobile No")
                City_VillageTextBox.Text = dt.Rows(0).Item("City/Village")
                Agent_RefComboBox.Text = dt.Rows(0).Item("Agent/Ref")
                Salary_OfferedTextBox.Text = dt.Rows(0).Item("Salary Offered")
                Selected_ByComboBox.Text = dt.Rows(0).Item("Selected By")
                Passport_Expiry_DateDateTimePicker.Tag = dt.Rows(0).Item("Passport Expiry Date")
                StatuesComboBox.Text = dt.Rows(0).Item("Status")
                LocationComboBox.Text = dt.Rows(0).Item("Location")
                RemarkTextBox.Text = dt.Rows(0).Item("Remark").ToString

                'hide the course id to be edited
                IDTextBox.Tag = intStId

                'changing button name from add to update

                'disabling button edit
                Button5.Enabled = False
                Button2.Enabled = False
                'closing connection
                con.Close()
            Else
                MessageBox.Show("No record selected for edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No record to be edit. Add some record first", "Edit Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Len(Trim(DateDateTimePicker.Text)) = 0 Then
            MessageBox.Show("Please Enter the Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateDateTimePicker.Focus()
            Exit Sub
        End If
        If Len(Trim(NameTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter the Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NameTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Passport_NoTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Passport Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Passport_NoTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Passport_NoTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Passport Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Passport_NoTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(CategoryComboBox.Text)) = 0 Then
            MessageBox.Show("Please Select Categorey", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CategoryComboBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Mobile_NoTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Mobile Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Mobile_NoTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(City_VillageTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter City or Village", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            City_VillageTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Agent_RefComboBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Agent or Reference", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Agent_RefComboBox.Focus()
            Exit Sub
        End If
        If Len(Trim(LocationComboBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Remark or Just Press SpaceBar", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LocationComboBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Passport_Expiry_DateDateTimePicker.Text)) = 0 Then
            MessageBox.Show("Please Select Passport Expiry Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Passport_Expiry_DateDateTimePicker.Focus()
            Exit Sub
        End If
        If Len(Trim(Salary_OfferedTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Salary Details", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Salary_OfferedTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(StatuesComboBox.Text)) = 0 Then
            MessageBox.Show("Please Select The Status  ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            StatuesComboBox.Focus()
            Exit Sub
        End If
        Try

            Dim cmd As New OleDb.OleDbCommand
            If Not con.State = ConnectionState.Open Then
                con.Open()
                cmd.Connection = con

                'checking whether any existing value is in db or not if yes then update otherwise insert
                If Me.IDTextBox.Tag & "" = "" Then

                    ' if not any data then add new one

                    '                cmd.CommandText = "INSERT INTO Selection VALUES ('" & IDTextBox.Text & "','" & NameTextBox.Text & "', '" & Passport_NoTextBox.Text & "','" & CategoryComboBox.Text & "', '" & Mobile_NoTextBox.Text & "',  '" & Agent_RefComboBox.Text & "','" & City_VillageTextBox.Text & "','" & Salary_OfferedTextBox.Text & "','" & Selected_ByTextBox.Text & "','" & Passport_Expiry_DateDateTimePicker.Text & "','" & StatuesComboBox.Text & "','" & RemarkTextBox.Text.ToString & "')"
                    cmd.CommandText = "INSERT INTO Selection VALUES ('" & IDTextBox.Text & "','" & NameTextBox.Text & "', '" & Passport_NoTextBox.Text & "','" & CategoryComboBox.Text & "', '" & Mobile_NoTextBox.Text & "',  '" & Agent_RefComboBox.Text & "','" & City_VillageTextBox.Text & "','" & DateDateTimePicker.Text & "','" & LocationComboBox.Text & "','" & Salary_OfferedTextBox.Text & "','" & Selected_ByComboBox.Text & "','" & Passport_Expiry_DateDateTimePicker.Text & "','" & StatuesComboBox.Text & "','" & RemarkTextBox.Text.ToString & "')"

                    cmd.Parameters.AddWithValue("@dt", OleDbType.Date).Value = Me.DateDateTimePicker.Value
                    cmd.Parameters.AddWithValue("@psdt", OleDbType.Date).Value = Me.Passport_Expiry_DateDateTimePicker.Value

                    cmd.ExecuteNonQuery()


                    MessageBox.Show("Selection details added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'otherwise update existing
                Else
                    cmd.CommandText = "UPDATE Selection SET " &
                " [ID]='" & IDTextBox.Text & "', " &
                " [Name]='" & NameTextBox.Text & "', " &
                " [Passport No]='" & Passport_NoTextBox.Text & "', " &
                " [Category]='" & CategoryComboBox.Text & "', " &
                " [Mobile No]='" & Mobile_NoTextBox.Text & "', " &
                " [Agent/Ref]='" & Agent_RefComboBox.Text & "', " &
                " [City/Village]='" & City_VillageTextBox.Text & "', " &
                " [Date]='" & DateDateTimePicker.Value & "', " &
                " [Location]='" & LocationComboBox.Text & "', " &
                " [Salary Offered]='" & Salary_OfferedTextBox.Text & "', " &
                " [Selected By]='" & Selected_ByComboBox.Text & "', " &
                " [Passport Expiry Date]='" & Passport_Expiry_DateDateTimePicker.Value & "', " &
                " [Status]='" & StatuesComboBox.Text & "', " &
                " [Remark]='" & RemarkTextBox.ToString & "'" &
                " WHERE ID = " & IDTextBox.Tag & ""
                    cmd.Parameters.AddWithValue("@dt", OleDbType.Date).Value = Me.DateDateTimePicker.Value
                    cmd.Parameters.AddWithValue("@psdt", OleDbType.Date).Value = Me.Passport_Expiry_DateDateTimePicker.Value

                    cmd.ExecuteNonQuery()




                    If StatuesComboBox.Text = "MEDICAL OK" Then

                        cmd.CommandText = "INSERT INTO Medical VALUES ('" & IDTextBox.Text & "' , @Date,'" & NameTextBox.Text & "', '" & Passport_NoTextBox.Text & "','" & CategoryComboBox.Text & "', '" & Mobile_NoTextBox.Text & "',  '" & Agent_RefComboBox.Text & "','" & City_VillageTextBox.Text & "',@Ecr,@medical)"

                        '     cmd.Parameters.AddWithValue("@ID", DBNull.Value)
                        cmd.Parameters.AddWithValue("@Date", DBNull.Value)
                        cmd.Parameters.AddWithValue("@Ecr", DBNull.Value)
                        cmd.Parameters.AddWithValue("@medical", DBNull.Value)
                        cmd.ExecuteNonQuery()
                    ElseIf StatuesComboBox.Text = "VISA CAME" Then
                        cmd.CommandText = "INSERT INTO Visa VALUES ('" & IDTextBox.Text & "' ,@Ind,'" & NameTextBox.Text & "', '" & Passport_NoTextBox.Text & "','" & CategoryComboBox.Text & "', '" & Mobile_NoTextBox.Text & "',  '" & Agent_RefComboBox.Text & "','" & City_VillageTextBox.Text & "',@Ecr,'" & Salary_OfferedTextBox.Text & "','" & Selected_ByComboBox.Text & "',@visaissue,@visaexpiry)"
                        'cmd.Parameters.AddWithValue("@dt", OleDbType.Date).Value = Me.DateDateTimePicker.Value
                        'cmd.Parameters.AddWithValue("@psdt", OleDbType.Date).Value = Me.Passport_Expiry_DateDateTimePicker.Value

                        '  cmd.Parameters.AddWithValue("@ID", DBNull.Value)
                        cmd.Parameters.AddWithValue("@Ind", DBNull.Value)
                        cmd.Parameters.AddWithValue("@Date", DBNull.Value)
                        cmd.Parameters.AddWithValue("@Ecr", DBNull.Value)
                        cmd.Parameters.AddWithValue("@visaissue", DBNull.Value)
                        cmd.Parameters.AddWithValue("@visaexpiry", DBNull.Value)
                        cmd.ExecuteNonQuery()
                    ElseIf StatuesComboBox.Text = "ON HOLD" Then
                        cmd.CommandText = "INSERT INTO Selection VALUES ('" & IDTextBox.Text & "','" & NameTextBox.Text & "', '" & Passport_NoTextBox.Text & "','" & CategoryComboBox.Text & "', '" & Mobile_NoTextBox.Text & "',  '" & Agent_RefComboBox.Text & "','" & City_VillageTextBox.Text & "','" & DateDateTimePicker.Text & "','" & LocationComboBox.Text & "','" & Salary_OfferedTextBox.Text & "','" & Selected_ByComboBox.Text & "','" & Passport_Expiry_DateDateTimePicker.Text & "','" & StatuesComboBox.Text & "','" & RemarkTextBox.Text.ToString & "')"
                        cmd.Parameters.AddWithValue("@dt", OleDbType.Date).Value = Me.DateDateTimePicker.Value
                        cmd.Parameters.AddWithValue("@psdt", OleDbType.Date).Value = Me.Passport_Expiry_DateDateTimePicker.Value

                        cmd.ExecuteNonQuery()

                    End If

                    MessageBox.Show("Records updated ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                con.Close()
                ' refreshing data
                DisplayData()
                Button5.Enabled = True
                Button2.Enabled = True
                '   IDTextBox.Clear()
                NameTextBox.Clear()
                Mobile_NoTextBox.Clear()
                City_VillageTextBox.Clear()
                Passport_NoTextBox.Clear()
                Agent_RefComboBox.Refresh()


                Salary_OfferedTextBox.Clear()
                StatuesComboBox.ResetText()
                RemarkTextBox.Clear()
                NewInvoiceNo()

                'closing connection 
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Me.DataGridView1.Rows.Count > 0 Then
                If DataGridView1.SelectedRows.Count > 0 Then
                    Dim intStID As Integer = Me.DataGridView1.SelectedRows(0).Cells("ID").Value

                    'opening connection
                    If Not con.State = ConnectionState.Open Then
                        con.Open()
                    End If

                    'deleting data from table
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = con

                    If MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                        cmd.CommandText = "DELETE FROM Selection WHERE ID=" & intStID
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Deletion aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    End If


                    'refresh data


                    'closing connection
                    con.Close()
                    DisplayData()
                    NewInvoiceNo()

                Else
                    MessageBox.Show("No record selected for delete.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No record to be delete.", "Deletion Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If DataGridView1.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12
                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Len(Trim(SearchBox1.Text)) = 0 Then
            MessageBox.Show("Please Enter Something", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SearchBox1.Focus()
            Exit Sub
        End If
        If Len(Trim(ComboBox1.Text)) = 0 Then
            MessageBox.Show("Please Select Somthing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox1.Focus()
            Exit Sub
        End If
        Try
            ' EnquiryBindingSource.Filter = String.Format("{0} LIKE '{1}*'", ComboBox1.Text, SearchBox1.Text)

            Dim cmd As New OleDb.OleDbCommand

            If Not con.State = ConnectionState.Open Then
                con.Open()

                'Dim command As New OleDbCommand("SELECT * FROM Enquiry WHERE  CONCAT(Date,Name, City/Village, Passport No) like '%" & SearchBox1.Text & "%'")
                ' Dim command As New OleDbCommand("select * from Enquiry where  (  [Name] like '%' + @fname + '%') or ([Passport No] like '%' + @lname + '%') or ([Mobile No] like '%' + @dept + '%') or ([City/Village] '%' + @pos + '%') or ([Agent/Ref] '%' + @agent + '%')", con)

                '  With command.Parameters
                '        .AddWithValue("@id", SearchBox1.Text)
                '        .AddWithValue("@fname", SearchBox1.Text)
                '        .AddWithValue("@lname", SearchBox1.Text)
                '        .AddWithValue("@dept", SearchBox1.Text)
                '        .AddWithValue("@pos", SearchBox1.Text)
                '        .AddWithValue("@agent", SearchBox1.Text)
                '    End With
                '    ' Dim command As New OleDbCommand
                '    '                Command.CommandText = String.Format("SELECT * From Enquiry WHERE CONCAT([Date],[Name],[Passport No],[Mobile No],[City/Village],[Agent/Ref]) like '%" & SearchBox1.Text & "%' ", con)

                Dim command As New OleDbCommand("select * from Selection", con)
                Dim adapter As New OleDbDataAdapter
                Dim dt As New DataTable
                Dim ds As DataSet = New DataSet
                Dim datagrid As New DataSet
                'command.Fill(ds)
                adapter.SelectCommand = command
                adapter.Fill(dt)
                DataGridView1.DataSource = dt
                '  datagrid = dt
                If ComboBox1.Text = "Date" Then
                    dt.DefaultView.RowFilter = " [Date] LIKE '%" & SearchBox1.Text & "%'"

                End If
                If ComboBox1.Text = "Name" Then
                    dt.DefaultView.RowFilter = " [Name] LIKE '%" & SearchBox1.Text & "%'"

                End If
                If ComboBox1.Text = "Passport No" Then
                    dt.DefaultView.RowFilter = " [Passport No] LIKE '%" & SearchBox1.Text & "%'"

                End If
                If ComboBox1.Text = "City/Village" Then
                    dt.DefaultView.RowFilter = " [City/Village] LIKE '%" & SearchBox1.Text & "%'"

                End If
                If ComboBox1.Text = "Category" Then
                    dt.DefaultView.RowFilter = " [Category] LIKE '%" & SearchBox1.Text & "%'"

                End If
                If ComboBox1.Text = "Agent/Ref" Then
                    dt.DefaultView.RowFilter = " [Agent/Ref] LIKE '%" & SearchBox1.Text & "%'"

                End If
                If ComboBox1.Text = "Mobile No" Then
                    dt.DefaultView.RowFilter = " [Mobile No] LIKE '%" & SearchBox1.Text & "%'"

                End If
                If ComboBox1.Text = "Expiry Date" Then
                    dt.DefaultView.RowFilter = " [Passport Expiry Date] LIKE '%" & SearchBox1.Text & "%'"

                End If
                If ComboBox1.Text = "Selected By" Then
                    dt.DefaultView.RowFilter = " [Selected By] LIKE '%" & SearchBox1.Text & "%'"

                End If
                If ComboBox1.Text = "Status" Then
                    dt.DefaultView.RowFilter = " [Status] LIKE '%" & SearchBox1.Text & "%'"

                End If
                If ComboBox1.Text = "Location" Then
                    dt.DefaultView.RowFilter = " [Location] LIKE '%" & SearchBox1.Text & "%'"

                End If
                '                dt.DefaultView.RowFilter = " [City/Village] LIKE '%" & SearchBox1.Text & "%'"
                adapter.Dispose()
                command.Dispose()

                con.Close()

            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12
                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            con.Open()
            Dim command As New OleDbCommand("SELECT * FROM `Selection` WHERE `Date` BETWEEN @d1 AND @d2", con)
            Dim adapter As New OleDbDataAdapter
            Dim dt As New DataTable
            command.Parameters.AddWithValue("@d1", OleDbType.Date).Value = Me.DateTimePicker1.Value.Date
            command.Parameters.AddWithValue("@d2", OleDbType.Date).Value = Me.DateTimePicker2.Value.Date
            command.Parameters.AddWithValue("@d1", "Date").Value = DateTimePicker1.Value
            command.Parameters.AddWithValue("@d2", "Date").Value = DateTimePicker2.Value
            adapter.SelectCommand = command
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
            adapter.Dispose()
            command.Dispose()

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PrintDocument1.Print()
    End Sub
    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        ''this removes the printed page margins
        PrintDocument1.OriginAtMargins = True
        PrintDocument1.DefaultPageSettings.Margins = New Drawing.Printing.Margins(0, 0, 0, 0)

        pages = New Dictionary(Of Integer, pageDetails)

        Dim maxWidth As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width) - 40
        Dim maxHeight As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Height) - 40 + Label1.Height

        Dim pageCounter As Integer = 0
        pages.Add(pageCounter, New pageDetails)

        Dim columnCounter As Integer = 0

        Dim columnSum As Integer = DataGridView1.RowHeadersWidth

        For c As Integer = 0 To DataGridView1.Columns.Count - 1
            If columnSum + DataGridView1.Columns(c).Width < maxWidth Then
                columnSum += DataGridView1.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = DataGridView1.RowHeadersWidth + DataGridView1.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New pageDetails With {.startCol = c})
            End If
            If c = DataGridView1.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                End If
            End If
        Next

        maxPagesWide = pages.Keys.Max + 1

        pageCounter = 0

        Dim rowCounter As Integer = 0

        Dim rowSum As Integer = DataGridView1.ColumnHeadersHeight

        For r As Integer = 0 To DataGridView1.Rows.Count - 2
            If rowSum + DataGridView1.Rows(r).Height < maxHeight Then
                rowSum += DataGridView1.Rows(r).Height
                rowCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
                For x As Integer = 1 To maxPagesWide - 1
                    pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
                Next

                pageCounter += maxPagesWide
                For x As Integer = 0 To maxPagesWide - 1
                    pages.Add(pageCounter + x, New pageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
                Next

                rowSum = DataGridView1.ColumnHeadersHeight + DataGridView1.Rows(r).Height
                rowCounter = 1
            End If
            If r = DataGridView1.Rows.Count - 2 Then
                For x As Integer = 0 To maxPagesWide - 1
                    If pages(pageCounter + x).rows = 0 Then
                        pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
                    End If
                Next
            End If
        Next

        maxPagesTall = pages.Count \ maxPagesWide


    End Sub
    Public Function GetRTLCoordinates(container As Rectangle, drawRectangle As Rectangle) _
    As Rectangle
        Return New Rectangle(container.Width - drawRectangle.Width - drawRectangle.X,
        drawRectangle.Y, drawRectangle.Width, drawRectangle.Height)
    End Function


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim rect As New Rectangle(20, 20,
                CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), Label1.Height)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        sf.Trimming = StringTrimming.EllipsisCharacter
        sf.FormatFlags = StringFormatFlags.NoWrap
        e.Graphics.DrawString(Label1.Text, Label1.Font, Brushes.Black, rect, sf)

        sf.Alignment = StringAlignment.Near

        Dim startX As Integer = 50
        Dim startY As Integer = rect.Bottom

        Static startPage As Integer = 0

        For p As Integer = startPage To pages.Count - 1
            Dim cell As New Rectangle(startX, startY, DataGridView1.RowHeadersWidth, DataGridView1.ColumnHeadersHeight)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
            e.Graphics.DrawRectangle(Pens.Black, cell)

            startY += DataGridView1.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                cell = New Rectangle(startX, startY, DataGridView1.RowHeadersWidth, DataGridView1.Rows(r).Height)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(DataGridView1.Rows(r).HeaderCell.Value, DataGridView1.Font, Brushes.Black, cell, sf)
                startY += DataGridView1.Rows(r).Height
            Next

            startX += cell.Width
            startY = rect.Bottom

            For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                cell = New Rectangle(startX, startY, DataGridView1.Columns(c).Width, DataGridView1.ColumnHeadersHeight)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(DataGridView1.Columns(c).HeaderCell.Value.ToString, DataGridView1.Font, Brushes.Black, cell, sf)
                startX += DataGridView1.Columns(c).Width
            Next

            startY = rect.Bottom + DataGridView1.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                startX = 50 + DataGridView1.RowHeadersWidth
                For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                    cell = New Rectangle(startX, startY, DataGridView1.Columns(c).Width, DataGridView1.Rows(r).Height)
                    e.Graphics.DrawRectangle(Pens.Black, cell)
                    e.Graphics.DrawString(DataGridView1(c, r).Value, DataGridView1.Font, Brushes.Black, cell, sf)
                    startX += DataGridView1.Columns(c).Width
                Next
                startY += DataGridView1.Rows(r).Height
            Next

            If p <> pages.Count - 1 Then
                startPage = p + 1
                e.HasMorePages = True
                Return
            Else
                startPage = 0
            End If

        Next

    End Sub


End Class