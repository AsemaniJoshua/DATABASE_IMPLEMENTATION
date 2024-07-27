Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll

        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel1.VerticalScroll.Value = e.NewValue
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Brand.Click

    End Sub



    Private Sub HOME_BUTTON_MouseHover(sender As Object, e As EventArgs) Handles HOME_BUTTON.MouseHover, LOGIN.MouseHover, SIGN_UP.MouseHover

        HOME_BUTTON.BackColor = Color.Green

    End Sub


End Class
