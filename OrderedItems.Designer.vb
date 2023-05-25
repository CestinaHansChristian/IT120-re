<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_orderItems
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
        Me.oi_table = New System.Windows.Forms.DataGridView()
        Me.btn_suppl = New System.Windows.Forms.Button()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_oddr_dtls = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.Export_Ordered_items = New System.Windows.Forms.Button()
        Me.oi_insert_qty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.oi_insert_ProdPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.oi_insert_TAmount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.oi_insert_ProdID = New System.Windows.Forms.TextBox()
        Me.insert_dated_picker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.oi_update_DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.oi_update_ProdID = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.oi_update_TotalAmnt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.oi_update_ProdPrice = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.oi_update_ID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dlte_field = New System.Windows.Forms.TextBox()
        Me.btn_io_update = New System.Windows.Forms.Button()
        Me.btn_proceed_deleteTable = New System.Windows.Forms.Button()
        Me.btn_oi_insert = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.oi_update_qty = New System.Windows.Forms.TextBox()
        CType(Me.oi_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ordered Items"
        '
        'oi_table
        '
        Me.oi_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.oi_table.Location = New System.Drawing.Point(796, 150)
        Me.oi_table.Name = "oi_table"
        Me.oi_table.RowHeadersWidth = 51
        Me.oi_table.RowTemplate.Height = 24
        Me.oi_table.Size = New System.Drawing.Size(607, 454)
        Me.oi_table.TabIndex = 1
        '
        'btn_suppl
        '
        Me.btn_suppl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_suppl.Location = New System.Drawing.Point(796, 18)
        Me.btn_suppl.Name = "btn_suppl"
        Me.btn_suppl.Size = New System.Drawing.Size(100, 56)
        Me.btn_suppl.TabIndex = 2
        Me.btn_suppl.Text = "Supply"
        Me.btn_suppl.UseVisualStyleBackColor = False
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Location = New System.Drawing.Point(796, 80)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(101, 49)
        Me.btn_prod.TabIndex = 3
        Me.btn_prod.Text = "Products"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_oddr_dtls
        '
        Me.btn_oddr_dtls.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oddr_dtls.Location = New System.Drawing.Point(937, 18)
        Me.btn_oddr_dtls.Name = "btn_oddr_dtls"
        Me.btn_oddr_dtls.Size = New System.Drawing.Size(95, 56)
        Me.btn_oddr_dtls.TabIndex = 4
        Me.btn_oddr_dtls.Text = "Customers"
        Me.btn_oddr_dtls.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Location = New System.Drawing.Point(937, 80)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(95, 49)
        Me.btn_orders.TabIndex = 5
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'Export_Ordered_items
        '
        Me.Export_Ordered_items.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Export_Ordered_items.Location = New System.Drawing.Point(1328, 18)
        Me.Export_Ordered_items.Name = "Export_Ordered_items"
        Me.Export_Ordered_items.Size = New System.Drawing.Size(75, 56)
        Me.Export_Ordered_items.TabIndex = 6
        Me.Export_Ordered_items.Text = "Export"
        Me.Export_Ordered_items.UseVisualStyleBackColor = False
        '
        'oi_insert_qty
        '
        Me.oi_insert_qty.Location = New System.Drawing.Point(681, 216)
        Me.oi_insert_qty.Name = "oi_insert_qty"
        Me.oi_insert_qty.Size = New System.Drawing.Size(100, 22)
        Me.oi_insert_qty.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 38)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Update"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(581, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 38)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Insert"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(575, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(517, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 29)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Product Price"
        '
        'oi_insert_ProdPrice
        '
        Me.oi_insert_ProdPrice.Location = New System.Drawing.Point(681, 258)
        Me.oi_insert_ProdPrice.Name = "oi_insert_ProdPrice"
        Me.oi_insert_ProdPrice.Size = New System.Drawing.Size(100, 22)
        Me.oi_insert_ProdPrice.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(517, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total Amount"
        '
        'oi_insert_TAmount
        '
        Me.oi_insert_TAmount.Location = New System.Drawing.Point(681, 301)
        Me.oi_insert_TAmount.Name = "oi_insert_TAmount"
        Me.oi_insert_TAmount.Size = New System.Drawing.Size(100, 22)
        Me.oi_insert_TAmount.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(575, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 29)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Quantity"
        '
        'oi_insert_ProdID
        '
        Me.oi_insert_ProdID.Location = New System.Drawing.Point(681, 369)
        Me.oi_insert_ProdID.Name = "oi_insert_ProdID"
        Me.oi_insert_ProdID.Size = New System.Drawing.Size(100, 22)
        Me.oi_insert_ProdID.TabIndex = 15
        '
        'insert_dated_picker
        '
        Me.insert_dated_picker.CustomFormat = "yyyy-MM-dd"
        Me.insert_dated_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.insert_dated_picker.Location = New System.Drawing.Point(681, 337)
        Me.insert_dated_picker.Name = "insert_dated_picker"
        Me.insert_dated_picker.Size = New System.Drawing.Size(100, 22)
        Me.insert_dated_picker.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(517, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 29)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Todays Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 29)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Todays Date"
        '
        'oi_update_DatePicker
        '
        Me.oi_update_DatePicker.CustomFormat = "yyyy-MM-dd"
        Me.oi_update_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.oi_update_DatePicker.Location = New System.Drawing.Point(169, 367)
        Me.oi_update_DatePicker.Name = "oi_update_DatePicker"
        Me.oi_update_DatePicker.Size = New System.Drawing.Size(100, 22)
        Me.oi_update_DatePicker.TabIndex = 27
        '
        'oi_update_ProdID
        '
        Me.oi_update_ProdID.AutoSize = True
        Me.oi_update_ProdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oi_update_ProdID.Location = New System.Drawing.Point(29, 404)
        Me.oi_update_ProdID.Name = "oi_update_ProdID"
        Me.oi_update_ProdID.Size = New System.Drawing.Size(125, 29)
        Me.oi_update_ProdID.TabIndex = 26
        Me.oi_update_ProdID.Text = "Product ID"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(169, 404)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 29)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Total Amount"
        '
        'oi_update_TotalAmnt
        '
        Me.oi_update_TotalAmnt.Location = New System.Drawing.Point(169, 332)
        Me.oi_update_TotalAmnt.Name = "oi_update_TotalAmnt"
        Me.oi_update_TotalAmnt.Size = New System.Drawing.Size(100, 22)
        Me.oi_update_TotalAmnt.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-4, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 29)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Product Price"
        '
        'oi_update_ProdPrice
        '
        Me.oi_update_ProdPrice.Location = New System.Drawing.Point(169, 294)
        Me.oi_update_ProdPrice.Name = "oi_update_ProdPrice"
        Me.oi_update_ProdPrice.Size = New System.Drawing.Size(100, 22)
        Me.oi_update_ProdPrice.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(118, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 29)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "ID"
        '
        'oi_update_ID
        '
        Me.oi_update_ID.Location = New System.Drawing.Point(169, 223)
        Me.oi_update_ID.Name = "oi_update_ID"
        Me.oi_update_ID.Size = New System.Drawing.Size(100, 22)
        Me.oi_update_ID.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(344, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 38)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Delete"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(331, 209)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 29)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "ID"
        '
        'dlte_field
        '
        Me.dlte_field.Location = New System.Drawing.Point(373, 216)
        Me.dlte_field.Name = "dlte_field"
        Me.dlte_field.Size = New System.Drawing.Size(100, 22)
        Me.dlte_field.TabIndex = 30
        '
        'btn_io_update
        '
        Me.btn_io_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_io_update.Location = New System.Drawing.Point(19, 444)
        Me.btn_io_update.Name = "btn_io_update"
        Me.btn_io_update.Size = New System.Drawing.Size(75, 35)
        Me.btn_io_update.TabIndex = 32
        Me.btn_io_update.Text = "Save"
        Me.btn_io_update.UseVisualStyleBackColor = False
        '
        'btn_proceed_deleteTable
        '
        Me.btn_proceed_deleteTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_proceed_deleteTable.Location = New System.Drawing.Point(351, 444)
        Me.btn_proceed_deleteTable.Name = "btn_proceed_deleteTable"
        Me.btn_proceed_deleteTable.Size = New System.Drawing.Size(75, 35)
        Me.btn_proceed_deleteTable.TabIndex = 33
        Me.btn_proceed_deleteTable.Text = "Save"
        Me.btn_proceed_deleteTable.UseVisualStyleBackColor = False
        '
        'btn_oi_insert
        '
        Me.btn_oi_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oi_insert.Location = New System.Drawing.Point(681, 444)
        Me.btn_oi_insert.Name = "btn_oi_insert"
        Me.btn_oi_insert.Size = New System.Drawing.Size(75, 35)
        Me.btn_oi_insert.TabIndex = 34
        Me.btn_oi_insert.Text = "Save"
        Me.btn_oi_insert.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(54, 251)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 29)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Quantity"
        '
        'oi_update_qty
        '
        Me.oi_update_qty.Location = New System.Drawing.Point(169, 258)
        Me.oi_update_qty.Name = "oi_update_qty"
        Me.oi_update_qty.Size = New System.Drawing.Size(100, 22)
        Me.oi_update_qty.TabIndex = 35
        '
        'Form_orderItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1415, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.oi_update_qty)
        Me.Controls.Add(Me.btn_oi_insert)
        Me.Controls.Add(Me.btn_proceed_deleteTable)
        Me.Controls.Add(Me.btn_io_update)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dlte_field)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.oi_update_DatePicker)
        Me.Controls.Add(Me.oi_update_ProdID)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.oi_update_TotalAmnt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.oi_update_ProdPrice)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.oi_update_ID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.insert_dated_picker)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.oi_insert_ProdID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.oi_insert_TAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.oi_insert_ProdPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.oi_insert_qty)
        Me.Controls.Add(Me.Export_Ordered_items)
        Me.Controls.Add(Me.btn_orders)
        Me.Controls.Add(Me.btn_oddr_dtls)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_suppl)
        Me.Controls.Add(Me.oi_table)
        Me.Controls.Add(Me.Label1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_orderItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordered_Items"
        CType(Me.oi_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents oi_table As DataGridView
    Friend WithEvents btn_suppl As Button
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_oddr_dtls As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents Export_Ordered_items As Button
    Friend WithEvents oi_insert_qty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents oi_insert_ProdPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents oi_insert_TAmount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents oi_insert_ProdID As TextBox
    Friend WithEvents insert_dated_picker As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents oi_update_DatePicker As DateTimePicker
    Friend WithEvents oi_update_ProdID As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents oi_update_TotalAmnt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents oi_update_ProdPrice As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents oi_update_ID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dlte_field As TextBox
    Friend WithEvents btn_io_update As Button
    Friend WithEvents btn_proceed_deleteTable As Button
    Friend WithEvents btn_oi_insert As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents oi_update_qty As TextBox
End Class
