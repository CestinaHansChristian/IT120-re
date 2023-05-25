Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Module codes
    Public myconn As MySqlConnection
    Public myConnectionStr As String
    Public strSql As String
    Public cstmr_gridview As DataGridView
    Public sqlcommand As MySqlCommand

    Public Sub openDB()
        myConnectionStr = "server=localhost;" _
                    & "port=3309;" _
                    & "uid=root;" _
                    & "pwd=Admin123;" _
                    & "database=It120e"
        myconn = New MySqlConnection(myConnectionStr)
        Try
            myconn.Open()
        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password!")
            End Select
        End Try
    End Sub
    Public Sub closeDB()
        myconn.Dispose()
        myconn.Close()
    End Sub

    Public Sub load_data_to_grid(ByVal query As String)
        With form_customer
            openDB()
            Dim dtable As New DataTable()
            Dim adapter As New MySqlDataAdapter(query, myconn)
            adapter.Fill(dtable)
            cstmr_gridview.DataSource = dtable
        End With
    End Sub

    Public Sub toExcel(ByVal dataView As DataGridView, ByVal formName As String)
        Dim xlsPath As String = System.IO.Directory.GetCurrentDirectory & "\..\..\reportXls\template\"
        Dim xlsFile As String = System.IO.Directory.GetCurrentDirectory & "\..\..\reportXls\reportGenerated\"
        Dim excelApp As Excel.Application
        Dim excelWBook As Excel.Workbook
        Dim excelSheet As Excel.Worksheet
        Dim date_time As DateTime = DateTime.Now

        Try
            excelApp = New Excel.Application
            excelWBook = excelApp.Workbooks.Add()
            excelSheet = excelWBook.Worksheets(1)
            Dim excelRange As Excel.Range = excelSheet.Range("B5").Resize(dataView.RowCount, dataView.ColumnCount)
            Dim cellvalues(dataView.RowCount - 1, dataView.ColumnCount - 1) As Object
            For indexA As Integer = 0 To dataView.Rows.Count - 1
                For indexB As Integer = 0 To dataView.Columns.Count - 1
                    cellvalues(indexA, indexB) = dataView.Rows(indexA).Cells(indexB).Value
                Next
            Next

            excelSheet.Cells(3, 4) = formName

            excelRange.Value = cellvalues
            excelSheet.Cells.EntireColumn.AutoFit()
            excelSheet.Protect("adminOnly")
            excelApp.Visible = True
            excelApp.UserControl = True
            excelApp.Quit()

            releaseObject(excelApp)
            releaseObject(excelSheet)
            releaseObject(excelWBook)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub releaseObject(ByVal systemObj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(systemObj)
            systemObj = Nothing
        Catch ex As Exception
            systemObj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub load_data_to_grid(ByVal query As String, ByVal gridview As DataGridView)
        openDB()
        Dim dtable As New DataTable()
        Dim adapter As New MySqlDataAdapter(query, myconn)
        adapter.Fill(dtable)
        gridview.DataSource = dtable
    End Sub
End Module
