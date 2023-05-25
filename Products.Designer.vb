<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_products
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_products))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_suppl = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.btn_oddr_dtls = New System.Windows.Forms.Button()
        Me.Export_button_Products = New System.Windows.Forms.Button()
        Me.prod_view = New System.Windows.Forms.DataGridView()
        CType(Me.prod_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Products"
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Location = New System.Drawing.Point(45, 131)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(92, 55)
        Me.btn_prod.TabIndex = 1
        Me.btn_prod.Text = "Order Items"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_suppl
        '
        Me.btn_suppl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_suppl.Location = New System.Drawing.Point(45, 212)
        Me.btn_suppl.Name = "btn_suppl"
        Me.btn_suppl.Size = New System.Drawing.Size(92, 48)
        Me.btn_suppl.TabIndex = 2
        Me.btn_suppl.Text = "Supply"
        Me.btn_suppl.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Location = New System.Drawing.Point(45, 288)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(92, 54)
        Me.btn_orders.TabIndex = 3
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'btn_oddr_dtls
        '
        Me.btn_oddr_dtls.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oddr_dtls.Location = New System.Drawing.Point(45, 366)
        Me.btn_oddr_dtls.Name = "btn_oddr_dtls"
        Me.btn_oddr_dtls.Size = New System.Drawing.Size(92, 53)
        Me.btn_oddr_dtls.TabIndex = 4
        Me.btn_oddr_dtls.Text = "Customers"
        Me.btn_oddr_dtls.UseVisualStyleBackColor = False
        '
        'Export_button_Products
        '
        Me.Export_button_Products.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Export_button_Products.Location = New System.Drawing.Point(680, 30)
        Me.Export_button_Products.Name = "Export_button_Products"
        Me.Export_button_Products.Size = New System.Drawing.Size(92, 55)
        Me.Export_button_Products.TabIndex = 5
        Me.Export_button_Products.Text = "Export"
        Me.Export_button_Products.UseVisualStyleBackColor = False
        '
        'prod_view
        '
        Me.prod_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.prod_view.Location = New System.Drawing.Point(181, 131)
        Me.prod_view.Name = "prod_view"
        Me.prod_view.RowHeadersWidth = 51
        Me.prod_view.RowTemplate.Height = 24
        Me.prod_view.Size = New System.Drawing.Size(591, 307)
        Me.prod_view.TabIndex = 6
        '
        'Form_products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.prod_view)
        Me.Controls.Add(Me.Export_button_Products)
        Me.Controls.Add(Me.btn_oddr_dtls)
        Me.Controls.Add(Me.btn_orders)
        Me.Controls.Add(Me.btn_suppl)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.Label1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        CType(Me.prod_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_suppl As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents btn_oddr_dtls As Button
    Friend WithEvents Export_button_Products As Button
    Friend WithEvents prod_view As DataGridView
End Class
