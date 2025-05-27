<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_frm
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
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.llblreg = New System.Windows.Forms.LinkLabel()
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnlogin.Location = New System.Drawing.Point(138, 83)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(102, 33)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "دخول"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "رمز الدخول"
        '
        'llblreg
        '
        Me.llblreg.AutoSize = True
        Me.llblreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblreg.Location = New System.Drawing.Point(9, 131)
        Me.llblreg.Name = "llblreg"
        Me.llblreg.Size = New System.Drawing.Size(112, 20)
        Me.llblreg.TabIndex = 4
        Me.llblreg.TabStop = True
        Me.llblreg.Text = "تسجيل عميل جديد"
        '
        'txtpin
        '
        Me.txtpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpin.Location = New System.Drawing.Point(82, 48)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpin.Size = New System.Drawing.Size(202, 29)
        Me.txtpin.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox1.Controls.Add(Me.txtpin)
        Me.GroupBox1.Controls.Add(Me.llblreg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnlogin)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 154)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Login_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(402, 187)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Login_frm"
        Me.Text = "تسجيل دخول"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnlogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents llblreg As LinkLabel
    Friend WithEvents txtpin As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
