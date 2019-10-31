Public Class MainManu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Enquiry()
        Enquiry.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New Selection()
        Selection.Show()
    End Sub

    Private Sub MainManu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False

        CenterToScreen()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim newForm As New Medical()
        Medical.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim newForm As New On_Hold()
        On_Hold.Show()



    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim newForm As New Category()
        Category.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim newForm As New Report()
        Report.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        Dim newForm As New Backup()
        Backup.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim newForm As New Form1()
        Form1.Show()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim newForm As New Visa
        Visa.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()




    End Sub

    Private Sub AddAgentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAgentToolStripMenuItem.Click
        Dim newForm As New Agent

        Agent.Show()

    End Sub

    Private Sub AddLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddLocationToolStripMenuItem.Click
        Dim newForm As New Locat
        Locat.Show()
    End Sub

    Private Sub AddSupervisorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSupervisorToolStripMenuItem.Click
        Dim newForm As New Selected
        Selected.Show()

    End Sub
End Class