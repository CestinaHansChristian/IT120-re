<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_orders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_orders))
        Me.order_view = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Export_button_orders = New System.Windows.Forms.Button()
        CType(Me.order_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'order_view
        '
        Me.order_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.order_view.Location = New System.Drawing.Point(162, 127)
        Me.order_view.Name = "order_view"
        Me.order_view.RowHeadersWidth = 51
        Me.order_view.RowTemplate.Height = 24
        Me.order_view.Size = New System.Drawing.Size(393, 253)
        Me.order_view.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Orders"
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Location = New System.Drawing.Point(34, 127)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(83, 53)
        Me.btn_prod.TabIndex = 2
        Me.btn_prod.Text = "Order Items"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(34, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 43)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Supply"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(34, 262)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 49)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Products"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(34, 334)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 46)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Customers"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Export_button_orders
        '
        Me.Export_button_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Export_button_orders.Location = New System.Drawing.Point(480, 55)
        Me.Export_button_orders.Name = "Export_button_orders"
        Me.Export_button_orders.Size = New System.Drawing.Size(75, 50)
        Me.Export_button_orders.TabIndex = 6
        Me.Export_button_orders.Text = "Export"
        Me.Export_button_orders.UseVisualStyleBackColor = False
        '
        'Form_orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(567, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.Export_button_orders)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.order_view)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        CType(Me.order_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents order_view As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_prod As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Export_button_orders As Button
End Class
