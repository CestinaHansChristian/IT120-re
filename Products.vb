Public Class Form_products
    Private Sub Form_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openDB()
        Dim formThis As String = "Select * from products"
        load_data_to_grid(formThis, prod_view)
    End Sub

    Private Sub Export_button_Products_Click(sender As Object, e As EventArgs) Handles Export_button_Products.Click
        toExcel(prod_view, "Products")
    End Sub

    Private Sub btn_prod_Click(sender As Object, e As EventArgs) Handles btn_prod.Click
        Form_orderItems.Show()
        Me.Close()
    End Sub

    Private Sub btn_suppl_Click(sender As Object, e As EventArgs) Handles btn_suppl.Click
        Form_supply.Show()
        Me.Close()
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        Form_orders.Show()
        Me.Close()
    End Sub

    Private Sub btn_oddr_dtls_Click(sender As Object, e As EventArgs) Handles btn_oddr_dtls.Click
        form_customer.Show()
        Me.Close()
    End Sub
End Class