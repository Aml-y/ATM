﻿Public Class AdminForm
    Dim da As New OleDb.OleDbDataAdapter
    Dim con As New OleDb.OleDbConnection
    Dim dt As New DataTable
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AdminForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ATMsystem.accdb"
        Label11.Text = Date.Now


        btnblock.Enabled = False
        btnunblock.Enabled = False
        GroupBox2.Enabled = False

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i, j As Integer

        i = e.RowIndex
        j = e.ColumnIndex
        If j = 0 Then
            txtAcctNo.Text = DataGridView1.Rows(i).Cells(j).Value
            txtfnme.Text = DataGridView1.Rows(i).Cells(j + 1).Value
            lblhide.Text = DataGridView1.Rows(i).Cells(j + 1).Value
            txtlnme.Text = DataGridView1.Rows(i).Cells(j + 2).Value
            'txtlname.Text = DataGridView1.Rows(i).Cells(j + 2).Value
            txtaddr.Text = DataGridView1.Rows(i).Cells(j + 3).Value
            txtcontact.Text = DataGridView1.Rows(i).Cells(j + 4).Value
            cbGender.Text = DataGridView1.Rows(i).Cells(j + 5).Value
            txtbday.Text = DataGridView1.Rows(i).Cells(j + 6).Value
            txtPincode.Text = DataGridView1.Rows(i).Cells(j + 7).Value

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        con.Open()

        Dim ad As New OleDb.OleDbDataAdapter("select * from tblinfo", con)
        Dim data As New DataSet
        ad.Fill(data, "info")
        DataGridView1.DataSource = data.Tables("info").DefaultView

        data.Dispose()
        ad.Dispose()
        con.Close()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        GroupBox2.Enabled = True
        btnedit.Enabled = False

        btnblock.Enabled = True
        btnunblock.Enabled = True

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        GroupBox2.Enabled = False
        btnedit.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Login_frm.Show()

        Me.Hide()

    End Sub

    Private Sub btnblock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnblock.Click
        con.Open()

        Dim ad As New OleDb.OleDbDataAdapter("select * from tblinfo", con)

        sql = "UPDATE tblinfo SET type='" & "Block" & "'" & " Where Firstname ='" & txtfnme.Text & "'"
        cmd.CommandText = sql
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        MsgBox("تم توقيفة")

        con.Close()
        Button5_Click(sender, e)
    End Sub

    Private Sub btnunblock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnunblock.Click
        con.Open()

        Dim ad As New OleDb.OleDbDataAdapter("select * from tblinfo", con)
        
        sql = "UPDATE tblinfo SET type='" & "Active" & "'" & " Where Firstname ='" & txtfnme.Text & "'"
        cmd.CommandText = sql
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        MsgBox("تم تنشيطة")

        con.Close()
        Button5_Click(sender, e)
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class