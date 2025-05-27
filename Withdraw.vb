Public Class Withdraw
    Dim da As New OleDb.OleDbDataAdapter
    Dim con As New OleDb.OleDbConnection
    Dim dset As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim balance As String
    Dim num1, num2, total As Integer


    Private Sub Withdraw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbldate.Text = Date.Now
        lblaccno.Text = Mainmenu.lblaccno.Text
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click

        Dim sql As String
        Dim Log_in As New DataTable

        Try



            con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ATMsystem.accdb")
            sql = "SELECT * FROM tblinfo where  account_no = " & lblaccno.Text & ""

            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(Log_in)
            If Log_in.Rows.Count > 0 Then
                balance = Log_in.Rows(0).Item("balance")
                num1 = balance
                num2 = txtamount.Text

                If num2 > 10000 Then
                    MsgBox("الحد الأقصى لمبلغ السحب هو 10.000 ريال")
                ElseIf num2 < 200 Then
                    MsgBox("الحد الأدنى للسحب هو 200")
                ElseIf num1 < num2 Then
                    MsgBox(" الرصيد غير كافي")

                Else
                    total = num1 - num2

                    Receipt.Show()

                    Receipt.lblbal.Text = balance
                    Receipt.Label4.Hide()
                    Receipt.lbldep.Hide()
                    Receipt.lblwith.Text = num2
                    Receipt.lblnewbal.Text = total

                    Receipt.Label5.Show()
                    Receipt.Label6.Show()


                    Receipt.lblbal.Show()
                    Receipt.Label4.Hide()
                    Receipt.lbldep.Hide()
                    Receipt.lblwith.Show()
                    Receipt.lblnewbal.Show()
                    'MsgBox("success")
                    Receipt.lblname.Text = Mainmenu.lblname.Text
                    Me.Hide()


                End If
            Else


            End If






        Catch ex As Exception
            MsgBox(" ادخل مبلغ")
            'MsgBox(ex.Message)
        End Try
        txtamount.Text = ""



    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Mainmenu.Show()
        Me.Hide()
    End Sub
End Class