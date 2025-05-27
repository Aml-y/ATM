<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdraw
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblaccno = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblaccno
        '
        Me.lblaccno.AutoSize = True
        Me.lblaccno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblaccno.Location = New System.Drawing.Point(279, 9)
        Me.lblaccno.Name = "lblaccno"
        Me.lblaccno.Size = New System.Drawing.Size(77, 18)
        Me.lblaccno.TabIndex = 17
        Me.lblaccno.Text = "رقم الحساب"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbldate.Location = New System.Drawing.Point(285, 169)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(34, 15)
        Me.lbldate.TabIndex = 16
        Me.lbldate.Text = "تاريخ"
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(148, 124)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(88, 36)
        Me.btnok.TabIndex = 13
        Me.btnok.Text = "نعم"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(51, 67)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(268, 26)
        Me.txtamount.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "المبلغ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(83, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "الحد الأقصى لمبلغ السحب هو 10.000 ريال"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 164)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(112, 20)
        Me.LinkLabel1.TabIndex = 30
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "الصفحة الرئيسية"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(339, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "رقم الحساب"
        '
        'Withdraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(406, 193)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.lblaccno)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.btnok)
        Me.Name = "Withdraw"
        Me.Text = "سحب"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblaccno As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As Label
End Class
