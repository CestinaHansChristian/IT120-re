Public Class Form_orders
    Private Sub Form_orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openDB()
        Dim formThis As String = "Select * from orders"
        load_data_to_grid(formThis, order_view)
    End Sub

    Private Sub Export_button_orders_Click(sender As Object, e As EventArgs) Handles Export_button_orders.Click
        toExcel(order_view, "Orders")
    End Sub

    Private Sub btn_prod_Click(sender As Object, e As EventArgs) Handles btn_prod.Click
        Form_orderItems.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_supply.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form_products.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        form_customer.Show()
        Me.Close()
    End Sub
End Class