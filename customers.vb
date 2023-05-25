Imports Microsoft.VisualBasic.FileIO

Public Class form_customer
    Private Sub form_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openDB()
        Dim formThis As String = "Select * from customers"
        cstmr_gridview = grid_view_customer
        load_data_to_grid(formThis)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form_products.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form_orderItems.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form_supply.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form_orders.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        closeDB()
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' load file
            open_file.Title = "Select a load file"
            open_file.Filter = "CSV FILES | *.csv"
            open_file.ShowDialog()

            ' store file location and name
            Dim file_loc As String = open_file.FileName

            Dim reader As New TextFieldParser(file_loc)
            reader.SetDelimiters(",")
            reader.TextFieldType = FieldType.Delimited
            Dim thisRow As String()
            While Not reader.EndOfData
                Try
                    thisRow = reader.ReadFields
                    grid_view_customer.Rows.Add(thisRow)
                Catch ex As Exception
                    MsgBox(ex.Message & "Invalid option")
                End Try
                Dim pass = grid_view_customer
            End While
        Catch ex As Exception
            MsgBox(ex.Message & "invalid option")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Process.Start("cmd", "/c mysqldump -u root -p it120e --port 3309> C:\Users\user\Desktop\backupDB.sql")
            MsgBox("Backup successfully created and added to Desktop", vbOKOnly + vbInformation, "Status")
        Catch ex As Exception
            MsgBox("Unable to create backup file", vbOKOnly, "Status")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openDB()
        toExcel(grid_view_customer, "Customer Details")
    End Sub
End Class