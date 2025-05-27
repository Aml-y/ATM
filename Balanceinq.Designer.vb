<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Balanceinq
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
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblaccno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(134, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "نعم"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtpin
        '
        Me.txtpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpin.Location = New System.Drawing.Point(45, 59)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpin.Size = New System.Drawing.Size(268, 26)
        Me.txtpin.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "الرمز السري"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(190, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date:"
        '
        'lblaccno
        '
        Me.lblaccno.AutoSize = True
        Me.lblaccno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblaccno.Location = New System.Drawing.Point(12, 9)
        Me.lblaccno.Name = "lblaccno"
        Me.lblaccno.Size = New System.Drawing.Size(32, 18)
        Me.lblaccno.TabIndex = 12
        Me.lblaccno.Text = "no."
        '
        'Balanceinq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(353, 152)
        Me.Controls.Add(Me.lblaccno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpin)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Balanceinq"
        Me.Text = "الإستفسار عن الرصيد"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtpin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblaccno As System.Windows.Forms.Label
End Class
