Public Class Login_frm
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim con As New OleDb.OleDbConnection
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim sql As String
        Dim Log_in As New DataTable
        Try
            If txtpin.Text = "" Then
                MsgBox("الرجاء إدخال رمز الدخول")

            Else
                con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ATMsystem.accdb")
                sql = "SELECT * FROM tblinfo where pin_code = " & txtpin.Text & ""

                With cmd
                    .Connection = con
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(Log_in)
                If Log_in.Rows.Count > 0 Then
                    Dim Type, Fullname, accno As String
                    Type = Log_in.Rows(0).Item("type")
                    Fullname = Log_in.Rows(0).Item("Firstname")
                    accno = Log_in.Rows(0).Item("account_no")
                    If Type = "admin" Then
                        MsgBox("المسؤول " & Fullname & " لقد تم تسجيلك ")
                        AdminForm.Show()
                        Me.Hide()

                    ElseIf Type = "Block" Then
                        MsgBox("حسابك مغلق حاليا")
                        MsgBox("تواصل بالمسؤول للحصول على المساعدة")

                    Else
                        MsgBox("مرحباَ " & Fullname)

                        Mainmenu.lblname.Text = Fullname
                        Mainmenu.lblaccno.Text = accno
                        Mainmenu.Show()
                        Me.Hide()

                    End If

                Else
                    MsgBox("انت لم تسجل")
                    MsgBox("الرجاء التسجيل إذا كنت جديدًا")


                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtpin.Text = ""


    End Sub

    Private Sub llblreg_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblreg.LinkClicked
        Regs_frm.Show()


    End Sub

    Private Sub Login_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
