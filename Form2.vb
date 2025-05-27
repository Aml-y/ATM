Public Class Regs_frm
    Dim constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ATMsystem.accdb"
    Dim adapt, adapt1 As New OleDb.OleDbDataAdapter
    Dim conn As New OleDb.OleDbConnection(constr)
    Dim dset As New DataSet
   

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If txtAcctNo.Text = "" And txtPincode.Text = "" And txtcontact.Text = "" And txtfname.Text = "" And txtlname.Text = "" And txtaddr.Text = "" And txtcontact.Text = "" And cbGender.Text = "" And cbday.Text = "" And cbmonth.Text = "" And cbyear.Text = "" Then
            MsgBox("إدخل كل الحقول")

        ElseIf txtAcctNo.Text = "" Or txtPincode.Text = "" Or txtcontact.Text = "" Or txtfname.Text = "" Or txtlname.Text = "" Or txtaddr.Text = "" Or txtcontact.Text = "" Or cbGender.Text = "" Or cbday.Text = "" Or cbmonth.Text = "" Or cbyear.Text = "" Then
            MsgBox("إدخل كل الحقول")

        Else
            Dim adapt1 As New OleDb.OleDbDataAdapter("select * from tblinfo where Firstname='" & txtfname.Text & "'", conn)
            Dim dset1 As New DataSet()
            adapt1.Fill(dset1)
            If dset1.Tables(0).Rows.Count <> 0 Then
                MsgBox("اسم الحساب موجود بالفعل")
            Else
                Dim dbcommand As String = "INSERT into tblinfo (account_no, Firstname, Lastname, Address, Contact_no, Gender, Birthday, pin_code , type, balance)" & " VALUES ('" & txtAcctNo.Text + "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtaddr.Text & "','" & txtcontact.Text & "','" & cbGender.Text & "','" & (cbmonth.Text + cbday.Text + cbyear.Text) & "','" & txtPincode.Text & "','" & "Active" & "','" & "0" & "')"
                Dim adapt As New OleDb.OleDbDataAdapter(dbcommand, conn)
                Dim dset As New DataSet()
                adapt.Fill(dset)
                MsgBox("لقد تم تسجيلك بنجاح!")
                Me.Hide()
                Login_frm.Show()
            End If
        End If
    End Sub

    Private Sub Regs_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbldate.Text = Date.Now

        conn.ConnectionString = constr
        conn.Open()
    End Sub

    Private Sub txtAcctNo_TextChanged(sender As Object, e As EventArgs) Handles txtAcctNo.TextChanged

    End Sub

    Private Sub txtPincode_TextChanged(sender As Object, e As EventArgs) Handles txtPincode.TextChanged

    End Sub

    Private Sub txtfname_TextChanged(sender As Object, e As EventArgs) Handles txtfname.TextChanged

    End Sub

    Private Sub txtlname_TextChanged(sender As Object, e As EventArgs) Handles txtlname.TextChanged

    End Sub

    Private Sub txtaddr_TextChanged(sender As Object, e As EventArgs) Handles txtaddr.TextChanged

    End Sub

    Private Sub txtcontact_TextChanged(sender As Object, e As EventArgs) Handles txtcontact.TextChanged

    End Sub

    Private Sub cbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGender.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Login_frm.Show()
    End Sub
End Class