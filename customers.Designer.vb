<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_customer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grid_view_customer = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.open_file = New System.Windows.Forms.OpenFileDialog()
        CType(Me.grid_view_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customers"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(324, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(433, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Load Customer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(580, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 42)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "BackUp DB"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'grid_view_customer
        '
        Me.grid_view_customer.AllowUserToAddRows = False
        Me.grid_view_customer.AllowUserToDeleteRows = False
        Me.grid_view_customer.AllowUserToResizeColumns = False
        Me.grid_view_customer.AllowUserToResizeRows = False
        Me.grid_view_customer.ColumnHeadersHeight = 29
        Me.grid_view_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_view_customer.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.grid_view_customer.Location = New System.Drawing.Point(153, 104)
        Me.grid_view_customer.MultiSelect = False
        Me.grid_view_customer.Name = "grid_view_customer"
        Me.grid_view_customer.ReadOnly = True
        Me.grid_view_customer.RowHeadersWidth = 51
        Me.grid_view_customer.RowTemplate.Height = 24
        Me.grid_view_customer.ShowCellErrors = False
        Me.grid_view_customer.ShowCellToolTips = False
        Me.grid_view_customer.ShowEditingIcon = False
        Me.grid_view_customer.Size = New System.Drawing.Size(517, 279)
        Me.grid_view_customer.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(12, 104)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 45)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Order Details"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(28, 155)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 43)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Products"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(28, 204)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 49)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Supply"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(28, 259)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 46)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Orders"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(28, 311)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 47)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Close"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'open_file
        '
        Me.open_file.FileName = "OpenFileDialog1"
        '
        'form_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(702, 395)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.grid_view_customer)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        CType(Me.grid_view_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents grid_view_customer As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents open_file As OpenFileDialog
End Class
