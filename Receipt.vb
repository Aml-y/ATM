Public Class Receipt
    Dim da As New OleDb.OleDbDataAdapter
    Dim con As New OleDb.OleDbConnection
    Dim dt As New DataTable
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand

    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ATMsystem.accdb"
        lbldate.Text = Date.Now

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If lblnewbal.Text = "" Then


        Else

            con.Open()

            Dim total As Integer = lblnewbal.Text
            Dim ad As New OleDb.OleDbDataAdapter("select * from tblinfo", con)

            sql = "UPDATE tblinfo SET balance='" & total & "'" & " Where Firstname='" & lblname.Text & "'"
            cmd.CommandText = sql
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            con.Close()



            
        End If

        If MessageBox.Show("هل تريد إكمال العملية", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Mainmenu.Show()
        Else
            MsgBox("شكراً")

            Login_frm.Show()

        End If
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class