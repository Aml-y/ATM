<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndep = New System.Windows.Forms.Button()
        Me.btnwith = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblaccno = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btndep)
        Me.GroupBox1.Controls.Add(Me.btnwith)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 205)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btndep
        '
        Me.btndep.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btndep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndep.Location = New System.Drawing.Point(223, 30)
        Me.btndep.Name = "btndep"
        Me.btndep.Size = New System.Drawing.Size(133, 58)
        Me.btndep.TabIndex = 2
        Me.btndep.Text = "إيداع"
        Me.btndep.UseVisualStyleBackColor = False
        '
        'btnwith
        '
        Me.btnwith.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnwith.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwith.Location = New System.Drawing.Point(47, 30)
        Me.btnwith.Name = "btnwith"
        Me.btnwith.Size = New System.Drawing.Size(133, 58)
        Me.btnwith.TabIndex = 1
        Me.btnwith.Text = "سحب"
        Me.btnwith.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(134, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 58)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "الرصيد"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(29, 321)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(133, 27)
        Me.btnlogout.TabIndex = 3
        Me.btnlogout.Text = "خروج"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.SteelBlue
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lbldate.Location = New System.Drawing.Point(280, 333)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(34, 15)
        Me.lbldate.TabIndex = 7
        Me.lbldate.Text = "تاريخ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(226, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "مرحبا"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(359, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "رقم الحساب"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.SteelBlue
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblname.Location = New System.Drawing.Point(165, 49)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(38, 18)
        Me.lblname.TabIndex = 10
        Me.lblname.Text = "الإسم"
        '
        'lblaccno
        '
        Me.lblaccno.AutoSize = True
        Me.lblaccno.BackColor = System.Drawing.Color.SteelBlue
        Me.lblaccno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblaccno.Location = New System.Drawing.Point(302, 0)
        Me.lblaccno.Name = "lblaccno"
        Me.lblaccno.Size = New System.Drawing.Size(77, 18)
        Me.lblaccno.TabIndex = 11
        Me.lblaccno.Text = "رقم الحساب"
        '
        'Mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(437, 351)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.lblaccno)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Mainmenu"
        Me.Text = "الصفحة الرئيسية"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btndep As System.Windows.Forms.Button
    Friend WithEvents btnwith As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblaccno As System.Windows.Forms.Label
End Class
