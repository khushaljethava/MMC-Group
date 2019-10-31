Imports System.Data.OleDb
Public Class Agent
    Dim con As New OleDb.OleDbConnection
    Private Sub Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False

        'Me.CategoryTableAdapter.Fill(Me.MMCDataSet.Category)
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MMC.accdb"
        DisplayData()
        NewInvoiceNo()
    End Sub

    Private Sub NewInvoiceNo()

        Dim ConnectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MMC.accdb"

        Try
                Dim sqlString As String = "SELECT MAX(ID)+1 FROM Agent"

                Dim dbConnection As New OleDbConnection(ConnectString)

                Dim command As New OleDb.OleDbCommand(sqlString, dbConnection)

                dbConnection.Open()

                IDTextBox.Text = command.ExecuteScalar()

                dbConnection.Close()

            Catch sqlex As Exception

                MessageBox.Show(sqlex.Message)

            End Try

    End Sub
    Private Sub DisplayData()
        'checking whether the connection is opened or not
        con.Open()
        Dim command As New OleDbCommand("SELECT * from Agent", con)
        Dim adapter As New OleDbDataAdapter
        Dim dt As New DataTable
        adapter.SelectCommand = command
        adapter.Fill(dt)
        DataGridView1.DataSource = dt
        adapter.Dispose()
        command.Dispose()

        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(Trim(AddTextBox.Text)) = 0 Then
            MessageBox.Show("Please enter Agent", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddTextBox.Focus()
            Exit Sub
        End If
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = con
            If Not con.State = ConnectionState.Open Then
                con.Open()
                cmd.CommandText = "INSERT INTO Agent VALUES ('" & IDTextBox.Text & "','" & AddTextBox.Text & "')"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Agent details added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            AddTextBox.Clear()


            con.Close()
            NewInvoiceNo()
            DisplayData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.Rows.Count > 0 Then

            If DataGridView1.SelectedRows.Count > 0 Then
                Dim intStId As Integer = DataGridView1.SelectedRows(0).Cells("ID").Value

                'opening connection
                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                'get data into data table
                Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Agent WHERE ID =" & intStId, con)
                Dim dt As New DataTable
                da.Fill(dt)

                IDTextBox.Text = intStId
                AddTextBox.Text = dt.Rows(0).Item("Agent")

                'hide the course id to be edited
                IDTextBox.Tag = intStId

                'changing button name from add to update

                'disabling button edit
                Button1.Enabled = False
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
        If Len(Trim(AddTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter the Agent", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddTextBox.Focus()
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

                    cmd.CommandText = "INSERT INTO Agent VALUES ('" & IDTextBox.Text & "','" & AddTextBox.Text & "')"
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Agent details added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'otherwise update existing
                Else
                    cmd.CommandText = "UPDATE Agent SET " &
                    " [Agent]='" & AddTextBox.Text & "'" &
                " WHERE ID = " & IDTextBox.Tag & ""
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Records updated ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                con.Close()
                ' refreshing data
                DisplayData()
                Button1.Enabled = True
                Button2.Enabled = True
                AddTextBox.Clear()
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

                    cmd.CommandText = "DELETE FROM Agent WHERE ID =" & intStID
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
    End Sub
    Private Sub Agent_FormClose()

    End Sub
End Class