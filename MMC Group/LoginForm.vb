Imports System.Data.OleDb
Public Class Login
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBoxPassword.UseSystemPasswordChar = True Then

            ' show password
            TextBoxPassword.UseSystemPasswordChar = False

        Else

            ' hide password
            TextBoxPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        MaximizeBox = False

    End Sub
    Private Sub Login()
        If Len(Trim(TextBoxUsername.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxUsername.Focus()
            Exit Sub
        End If
        'change the txtPassword whatever your textbox name is
        If Len(Trim(TextBoxPassword.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxPassword.Focus()
            Exit Sub
        End If
        Try
            Dim myConnection As OleDbConnection
            myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MMC.accdb")

            Dim myCommand As OleDbCommand

            myCommand = New OleDbCommand("SELECT Username,Password FROM Login WHERE Username = @user_name AND Password = @pass_word", myConnection)

            Dim uName As New OleDbParameter("@user_name", SqlDbType.VarChar)

            Dim uPassword As New OleDbParameter("@pass_word", SqlDbType.VarChar)

            uName.Value = TextBoxUsername.Text

            uPassword.Value = TextBoxPassword.Text

            myCommand.Parameters.Add(uName)

            myCommand.Parameters.Add(uPassword)

            myCommand.Connection.Open()

            Dim myReader As OleDbDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

            Dim Login As Object = 0

            If myReader.HasRows Then

                myReader.Read()

                Login = myReader(Login)

            End If

            If Login = Nothing Then

                MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                TextBoxUsername.Clear()
                TextBoxPassword.Clear()
                TextBoxPassword.Focus()

            Else
                MsgBox("Successfully Login", MsgBoxStyle.Information)
                TextBoxUsername.Text = ""
                TextBoxPassword.Text = ""
                Me.Hide()
                MainManu.Show()
                Me.Close()

            End If

            myCommand.Dispose()
            myConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
