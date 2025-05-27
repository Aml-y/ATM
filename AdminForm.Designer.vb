<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.btnblock = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnunblock = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbday = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtlnme = New System.Windows.Forms.TextBox()
        Me.txtfnme = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAcctNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblhide = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnblock
        '
        Me.btnblock.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnblock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnblock.Location = New System.Drawing.Point(0, 364)
        Me.btnblock.Name = "btnblock"
        Me.btnblock.Size = New System.Drawing.Size(138, 31)
        Me.btnblock.TabIndex = 0
        Me.btnblock.Text = "توقيف"
        Me.btnblock.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(501, 378)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(138, 31)
        Me.btnedit.TabIndex = 4
        Me.btnedit.Text = "تعديل"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnunblock
        '
        Me.btnunblock.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnunblock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnunblock.Location = New System.Drawing.Point(144, 364)
        Me.btnunblock.Name = "btnunblock"
        Me.btnunblock.Size = New System.Drawing.Size(138, 31)
        Me.btnunblock.TabIndex = 3
        Me.btnunblock.Text = "تنشيط"
        Me.btnunblock.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(477, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(493, 314)
        Me.DataGridView1.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(809, 378)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 31)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "عرض الكل "
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox2.Controls.Add(Me.txtbday)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btnunblock)
        Me.GroupBox2.Controls.Add(Me.btncancel)
        Me.GroupBox2.Controls.Add(Me.cbGender)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtaddr)
        Me.GroupBox2.Controls.Add(Me.btnblock)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtcontact)
        Me.GroupBox2.Controls.Add(Me.txtlnme)
        Me.GroupBox2.Controls.Add(Me.txtfnme)
        Me.GroupBox2.Controls.Add(Me.label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtPincode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtAcctNo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 442)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "معلومات الحساب"
        '
        'txtbday
        '
        Me.txtbday.Location = New System.Drawing.Point(58, 259)
        Me.txtbday.Name = "txtbday"
        Me.txtbday.Size = New System.Drawing.Size(178, 20)
        Me.txtbday.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(275, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "يوم الميلاد"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(285, 424)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 15)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "تاريخ"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(288, 364)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(125, 31)
        Me.btncancel.TabIndex = 24
        Me.btncancel.Text = "إلغاء"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'cbGender
        '
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(168, 297)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(70, 21)
        Me.cbGender.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "الجنس"
        '
        'txtaddr
        '
        Me.txtaddr.Location = New System.Drawing.Point(58, 180)
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(178, 20)
        Me.txtaddr.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(266, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "رقم الإتصال"
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(58, 217)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(178, 20)
        Me.txtcontact.TabIndex = 25
        '
        'txtlnme
        '
        Me.txtlnme.Location = New System.Drawing.Point(58, 142)
        Me.txtlnme.Name = "txtlnme"
        Me.txtlnme.Size = New System.Drawing.Size(178, 20)
        Me.txtlnme.TabIndex = 22
        '
        'txtfnme
        '
        Me.txtfnme.Location = New System.Drawing.Point(58, 104)
        Me.txtfnme.Name = "txtfnme"
        Me.txtfnme.Size = New System.Drawing.Size(178, 20)
        Me.txtfnme.TabIndex = 21
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(266, 142)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(83, 20)
        Me.label5.TabIndex = 20
        Me.label5.Text = "الإسم الأخير"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(291, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "العنوان"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(271, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "الإسم الأول"
        '
        'txtPincode
        '
        Me.txtPincode.Location = New System.Drawing.Point(58, 65)
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(178, 20)
        Me.txtPincode.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(266, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "الرمز السري"
        '
        'txtAcctNo
        '
        Me.txtAcctNo.Location = New System.Drawing.Point(58, 26)
        Me.txtAcctNo.Name = "txtAcctNo"
        Me.txtAcctNo.Size = New System.Drawing.Size(178, 20)
        Me.txtAcctNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(266, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "رقم الحساب"
        '
        'lblhide
        '
        Me.lblhide.AutoSize = True
        Me.lblhide.Location = New System.Drawing.Point(655, 444)
        Me.lblhide.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhide.Name = "lblhide"
        Me.lblhide.Size = New System.Drawing.Size(0, 13)
        Me.lblhide.TabIndex = 4
        Me.lblhide.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(654, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "خروج"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(867, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "معلومات العملاء"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(993, 466)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lblhide)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnedit)
        Me.Name = "AdminForm"
        Me.Text = "الموظف"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnblock As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnunblock As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents txtPincode As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents lblhide As System.Windows.Forms.Label
    Private WithEvents txtAcctNo As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents cbGender As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtaddr As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtcontact As System.Windows.Forms.TextBox
    Private WithEvents txtlnme As System.Windows.Forms.TextBox
    Private WithEvents txtfnme As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents txtbday As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Label1 As Label
End Class
