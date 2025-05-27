<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regs_frm
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAccNo = New System.Windows.Forms.Label()
        Me.txtAcctNo = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbyear = New System.Windows.Forms.ComboBox()
        Me.cbmonth = New System.Windows.Forms.ComboBox()
        Me.cbday = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtPincode)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.lblAccNo)
        Me.groupBox1.Controls.Add(Me.txtAcctNo)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(495, 114)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "معلومات الحساب"
        '
        'txtPincode
        '
        Me.txtPincode.Location = New System.Drawing.Point(30, 65)
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(298, 20)
        Me.txtPincode.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "الرمز السري"
        '
        'lblAccNo
        '
        Me.lblAccNo.AutoSize = True
        Me.lblAccNo.Location = New System.Drawing.Point(176, 132)
        Me.lblAccNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccNo.Name = "lblAccNo"
        Me.lblAccNo.Size = New System.Drawing.Size(0, 13)
        Me.lblAccNo.TabIndex = 4
        '
        'txtAcctNo
        '
        Me.txtAcctNo.Location = New System.Drawing.Point(30, 26)
        Me.txtAcctNo.Name = "txtAcctNo"
        Me.txtAcctNo.Size = New System.Drawing.Size(298, 20)
        Me.txtAcctNo.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(330, 26)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(79, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "رقم الحساب"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(30, 33)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(337, 20)
        Me.txtfname.TabIndex = 3
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(30, 71)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(337, 20)
        Me.txtlname.TabIndex = 5
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(373, 69)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(83, 20)
        Me.label5.TabIndex = 2
        Me.label5.Text = "الإسم الأخير"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(373, 107)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(52, 20)
        Me.label4.TabIndex = 1
        Me.label4.Text = "العنوان"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(248, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "إلغاء"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.Button1)
        Me.groupBox2.Controls.Add(Me.cbyear)
        Me.groupBox2.Controls.Add(Me.cbmonth)
        Me.groupBox2.Controls.Add(Me.cbday)
        Me.groupBox2.Controls.Add(Me.btnRegister)
        Me.groupBox2.Controls.Add(Me.Label8)
        Me.groupBox2.Controls.Add(Me.cbGender)
        Me.groupBox2.Controls.Add(Me.Label1)
        Me.groupBox2.Controls.Add(Me.txtaddr)
        Me.groupBox2.Controls.Add(Me.Label7)
        Me.groupBox2.Controls.Add(Me.txtcontact)
        Me.groupBox2.Controls.Add(Me.txtlname)
        Me.groupBox2.Controls.Add(Me.txtfname)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Location = New System.Drawing.Point(12, 144)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(495, 297)
        Me.groupBox2.TabIndex = 5
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "معلومات الشخصية"
        '
        'cbyear
        '
        Me.cbyear.FormattingEnabled = True
        Me.cbyear.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014"})
        Me.cbyear.Location = New System.Drawing.Point(305, 217)
        Me.cbyear.Name = "cbyear"
        Me.cbyear.Size = New System.Drawing.Size(52, 21)
        Me.cbyear.TabIndex = 17
        '
        'cbmonth
        '
        Me.cbmonth.FormattingEnabled = True
        Me.cbmonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cbmonth.Location = New System.Drawing.Point(198, 217)
        Me.cbmonth.Name = "cbmonth"
        Me.cbmonth.Size = New System.Drawing.Size(52, 21)
        Me.cbmonth.TabIndex = 16
        '
        'cbday
        '
        Me.cbday.FormattingEnabled = True
        Me.cbday.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbday.Location = New System.Drawing.Point(256, 217)
        Me.cbday.Name = "cbday"
        Me.cbday.Size = New System.Drawing.Size(43, 21)
        Me.cbday.TabIndex = 15
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(150, 255)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(92, 36)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "تسجيل"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(373, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "يوم الميلاد"
        '
        'cbGender
        '
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(264, 187)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(93, 21)
        Me.cbGender.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(373, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "الجنس"
        '
        'txtaddr
        '
        Me.txtaddr.Location = New System.Drawing.Point(30, 109)
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(337, 20)
        Me.txtaddr.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(373, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "رقم الإتصال"
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(30, 146)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(337, 20)
        Me.txtcontact.TabIndex = 9
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(373, 31)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(77, 20)
        Me.label3.TabIndex = 0
        Me.label3.Text = "الإسم الأول"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbldate.Location = New System.Drawing.Point(332, 450)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(34, 15)
        Me.lbldate.TabIndex = 6
        Me.lbldate.Text = "تاريخ"
        '
        'Regs_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(527, 474)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Name = "Regs_frm"
        Me.Text = "تسجيل "
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtPincode As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents lblAccNo As System.Windows.Forms.Label
    Private WithEvents txtAcctNo As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtfname As System.Windows.Forms.TextBox
    Private WithEvents txtlname As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents txtaddr As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtcontact As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents cbGender As System.Windows.Forms.ComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbday As System.Windows.Forms.ComboBox
    Friend WithEvents cbmonth As System.Windows.Forms.ComboBox
    Friend WithEvents cbyear As System.Windows.Forms.ComboBox
    Friend WithEvents lbldate As System.Windows.Forms.Label
End Class
