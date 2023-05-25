<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_supply
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
        Me.btn_orderItems = New System.Windows.Forms.Button()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.btn_customers = New System.Windows.Forms.Button()
        Me.Export_button_excel = New System.Windows.Forms.Button()
        Me.supply_view = New System.Windows.Forms.DataGridView()
        CType(Me.supply_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplies"
        '
        'btn_orderItems
        '
        Me.btn_orderItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orderItems.Location = New System.Drawing.Point(43, 118)
        Me.btn_orderItems.Name = "btn_orderItems"
        Me.btn_orderItems.Size = New System.Drawing.Size(92, 42)
        Me.btn_orderItems.TabIndex = 1
        Me.btn_orderItems.Text = "Order Items"
        Me.btn_orderItems.UseVisualStyleBackColor = False
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Location = New System.Drawing.Point(43, 187)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(92, 43)
        Me.btn_prod.TabIndex = 2
        Me.btn_prod.Text = "Products"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Location = New System.Drawing.Point(43, 257)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(92, 42)
        Me.btn_orders.TabIndex = 3
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'btn_customers
        '
        Me.btn_customers.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_customers.Location = New System.Drawing.Point(43, 326)
        Me.btn_customers.Name = "btn_customers"
        Me.btn_customers.Size = New System.Drawing.Size(92, 45)
        Me.btn_customers.TabIndex = 4
        Me.btn_customers.Text = "Customers"
        Me.btn_customers.UseVisualStyleBackColor = False
        '
        'Export_button_excel
        '
        Me.Export_button_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Export_button_excel.Location = New System.Drawing.Point(616, 44)
        Me.Export_button_excel.Name = "Export_button_excel"
        Me.Export_button_excel.Size = New System.Drawing.Size(108, 41)
        Me.Export_button_excel.TabIndex = 5
        Me.Export_button_excel.Text = "Export"
        Me.Export_button_excel.UseVisualStyleBackColor = False
        '
        'supply_view
        '
        Me.supply_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.supply_view.Location = New System.Drawing.Point(171, 118)
        Me.supply_view.Name = "supply_view"
        Me.supply_view.RowHeadersWidth = 51
        Me.supply_view.RowTemplate.Height = 24
        Me.supply_view.Size = New System.Drawing.Size(553, 300)
        Me.supply_view.TabIndex = 6
        '
        'Form_supply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(736, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.supply_view)
        Me.Controls.Add(Me.Export_button_excel)
        Me.Controls.Add(Me.btn_customers)
        Me.Controls.Add(Me.btn_orders)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_orderItems)
        Me.Controls.Add(Me.Label1)
        Me.HelpButton = True
        Me.Name = "Form_supply"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplies"
        CType(Me.supply_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_orderItems As Button
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents btn_customers As Button
    Friend WithEvents Export_button_excel As Button
    Friend WithEvents supply_view As DataGridView
End Class
