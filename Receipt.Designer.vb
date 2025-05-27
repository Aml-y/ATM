<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbldep = New System.Windows.Forms.Label()
        Me.lblwith = New System.Windows.Forms.Label()
        Me.lblbal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblnewbal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(120, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "نعم"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "الرصيد"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "حساب السحب"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "حساب الإيداع"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "تاريخ"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(167, 9)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(34, 15)
        Me.lbldate.TabIndex = 6
        Me.lbldate.Text = "تاريخ"
        '
        'lbldep
        '
        Me.lbldep.AutoSize = True
        Me.lbldep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldep.Location = New System.Drawing.Point(208, 138)
        Me.lbldep.Name = "lbldep"
        Me.lbldep.Size = New System.Drawing.Size(88, 18)
        Me.lbldep.TabIndex = 10
        Me.lbldep.Text = "حساب الإيداع"
        '
        'lblwith
        '
        Me.lblwith.AutoSize = True
        Me.lblwith.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwith.Location = New System.Drawing.Point(208, 101)
        Me.lblwith.Name = "lblwith"
        Me.lblwith.Size = New System.Drawing.Size(89, 18)
        Me.lblwith.TabIndex = 9
        Me.lblwith.Text = "حساب السحب"
        '
        'lblbal
        '
        Me.lblbal.AutoSize = True
        Me.lblbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbal.Location = New System.Drawing.Point(208, 69)
        Me.lblbal.Name = "lblbal"
        Me.lblbal.Size = New System.Drawing.Size(50, 18)
        Me.lblbal.TabIndex = 8
        Me.lblbal.Text = "الرصيد"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "رصيد الحساب الجديد"
        '
        'lblnewbal
        '
        Me.lblnewbal.AutoSize = True
        Me.lblnewbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewbal.Location = New System.Drawing.Point(208, 170)
        Me.lblnewbal.Name = "lblnewbal"
        Me.lblnewbal.Size = New System.Drawing.Size(0, 18)
        Me.lblnewbal.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "الإسم"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(88, 39)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(38, 18)
        Me.lblname.TabIndex = 14
        Me.lblname.Text = "الإسم"
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(317, 275)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblnewbal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbldep)
        Me.Controls.Add(Me.lblwith)
        Me.Controls.Add(Me.lblbal)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Receipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "الرصيد"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lbldep As System.Windows.Forms.Label
    Friend WithEvents lblwith As System.Windows.Forms.Label
    Friend WithEvents lblbal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblnewbal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
End Class
