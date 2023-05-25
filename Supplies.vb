Public Class Form_supply
    Private Sub Supplies_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openDB()
        Dim formThis As String = "Select * from products"
        load_data_to_grid(formThis, supply_view)
    End Sub

    Private Sub Export_button_excel_Click(sender As Object, e As EventArgs) Handles Export_button_excel.Click
        toExcel(supply_view, "Supplies")
    End Sub

    Private Sub btn_orderItems_Click(sender As Object, e As EventArgs) Handles btn_orderItems.Click
        Form_orderItems.Show()
        Me.Close()
    End Sub

    Private Sub btn_prod_Click(sender As Object, e As EventArgs) Handles btn_prod.Click
        Form_products.Show()
        Me.Close()
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        Form_orders.Show()
        Me.Close()
    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        form_customer.Show()
        Me.Close()
    End Sub
End Class