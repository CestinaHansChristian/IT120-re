<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox_user = New System.Windows.Forms.TextBox()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.check_pass = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'txtbox_user
        '
        Me.txtbox_user.Location = New System.Drawing.Point(196, 117)
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.Size = New System.Drawing.Size(169, 22)
        Me.txtbox_user.TabIndex = 1
        '
        'txtbox_pass
        '
        Me.txtbox_pass.Location = New System.Drawing.Point(196, 177)
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.Size = New System.Drawing.Size(169, 22)
        Me.txtbox_pass.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.login_btn.Location = New System.Drawing.Point(52, 246)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(110, 57)
        Me.login_btn.TabIndex = 5
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.exit_btn.Location = New System.Drawing.Point(262, 246)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(103, 57)
        Me.exit_btn.TabIndex = 6
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'check_pass
        '
        Me.check_pass.AutoSize = True
        Me.check_pass.Checked = True
        Me.check_pass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check_pass.Location = New System.Drawing.Point(196, 220)
        Me.check_pass.Name = "check_pass"
        Me.check_pass.Size = New System.Drawing.Size(120, 20)
        Me.check_pass.TabIndex = 7
        Me.check_pass.Text = "Hide password"
        Me.check_pass.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(458, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.check_pass)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.txtbox_user)
        Me.Controls.Add(Me.Label1)
        Me.HelpButton = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtbox_user As TextBox
    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents login_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents check_pass As CheckBox
End Class
