<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deposit
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.lblaccno = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(84, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "الحد الأقصى لمبلغ الإيداع هو 10.000 ريال"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "المبلغ"
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(57, 73)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(268, 26)
        Me.txtamount.TabIndex = 26
        '
        'lblaccno
        '
        Me.lblaccno.AutoSize = True
        Me.lblaccno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblaccno.Location = New System.Drawing.Point(277, 12)
        Me.lblaccno.Name = "lblaccno"
        Me.lblaccno.Size = New System.Drawing.Size(77, 18)
        Me.lblaccno.TabIndex = 25
        Me.lblaccno.Text = "رقم الحساب"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbldate.Location = New System.Drawing.Point(291, 188)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(42, 15)
        Me.lbldate.TabIndex = 24
        Me.lbldate.Text = "التاريخ"
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(171, 130)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(88, 37)
        Me.btnok.TabIndex = 21
        Me.btnok.Text = "نعم"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(11, 183)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(112, 20)
        Me.LinkLabel1.TabIndex = 29
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "الصفحة الرئيسية"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(351, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "رقم الحساب"
        '
        'Deposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(431, 212)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.lblaccno)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.btnok)
        Me.Name = "Deposit"
        Me.Text = "إيداع"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents lblaccno As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As Label
End Class
