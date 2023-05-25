Imports MySql.Data.MySqlClient

Public Class Form_orderItems
    Private Sub Form_orderItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openDB()
        Dim formThis As String = "Select * from orderitems"
        load_data_to_grid(formThis, oi_table)
    End Sub

    Private Sub Export_Ordered_items_Click(sender As Object, e As EventArgs) Handles Export_Ordered_items.Click
        toExcel(oi_table, "Ordered Items")
    End Sub

    Private Sub btn_suppl_Click(sender As Object, e As EventArgs) Handles btn_suppl.Click
        Form_supply.Show()
        Me.Close()
    End Sub

    Private Sub btn_prod_Click(sender As Object, e As EventArgs) Handles btn_prod.Click
        Form_products.Show()
        Me.Close()
    End Sub

    Private Sub btn_oddr_dtls_Click(sender As Object, e As EventArgs) Handles btn_oddr_dtls.Click
        form_customer.Show()
        Me.Close()
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        Form_orders.Show()
        Me.Close()
    End Sub

    Private Sub btn_proceed_deleteTable_Click(sender As Object, e As EventArgs) Handles btn_proceed_deleteTable.Click
        openDB()
        Dim sqlquery = "DELETE FROM orderItems WHERE id = " & dlte_field.Text & " "
        sqlcommand = New MySqlCommand(sqlquery, myconn)
        sqlcommand.ExecuteNonQuery()
        MsgBox("Record deleted", vbOK, "Status")
    End Sub

    Private Sub btn_oi_insert_Click(sender As Object, e As EventArgs) Handles btn_oi_insert.Click
        openDB()
        Try
            Dim queryAdd As String = "INSERT INTO orderitems (Quantity,Prod_Price,Total_Amount,Todays_date,Prod_id)
                                  VALUES ('" & oi_insert_qty.Text & "', '" & oi_insert_ProdPrice.Text & "', '" & oi_insert_TAmount.Text & "', '" & insert_dated_picker.Text & "' , '" & oi_insert_ProdID.Text & "')"
            sqlcommand = New MySqlCommand(queryAdd, myconn)
            sqlcommand.ExecuteNonQuery()
            MsgBox("15% vat added", MsgBoxStyle.Exclamation, "System Information")
        Catch ex As Exception
            MsgBox(ex.Message + "Error Occured")
        End Try
        MsgBox("Order added", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub btn_io_update_Click(sender As Object, e As EventArgs) Handles btn_io_update.Click
        openDB()
        Try
            Dim sqlquery As String = " UPDATE orderItems set Quantity = '" & oi_update_qty.Text & "', Prod_price = '" & oi_update_ProdPrice.Text & "', Total_amount = '" & oi_update_TotalAmnt.Text & "', Prod_id = '" & oi_update_prodI_ID.Text & "' , Todays_date = '" & oi_update_DatePicker.Text & "' WHERE id = '" & oi_update_ID.Text & "' "
            sqlcommand = New MySqlCommand(sqlquery, myconn)
            sqlcommand.ExecuteNonQuery()
            MsgBox("15% vat added", MsgBoxStyle.Exclamation, "System Information")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxResult.Ok, "System Information")
        End Try
        MsgBox("Record updated", vbOK, "Status")
    End Sub
End Class