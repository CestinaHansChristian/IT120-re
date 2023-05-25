Public Class Form1
    Dim adminU As String = "admin"
    Dim adminP As String = "adminPass"
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Try
            If txtbox_user.Text = adminU And txtbox_pass.Text = adminP Then
                MsgBox(txtbox_user.Text + " Logged in successfully", vbOKOnly, "Status")
                form_customer.Show()
                Me.Hide()
            Else
                MsgBox(txtbox_user.Text + " is not a valid user", vbOKOnly, "Information")
            End If
            txtbox_user.Clear()
            txtbox_pass.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub check_pass_CheckedChanged(sender As Object, e As EventArgs) Handles check_pass.CheckedChanged
        If check_pass.CheckState = check_pass.Checked Then
            txtbox_pass.UseSystemPasswordChar = False

        Else
            txtbox_pass.UseSystemPasswordChar = True
        End If
    End Sub
End Class
