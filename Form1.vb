Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False 'hide picture
        Label1.Text = CStr(Int(Rnd() * 10)) 'pick numbers
        Label2.Text = CStr(Int(Rnd() * 10)) 'pick numbers
        Label3.Text = CStr(Int(Rnd() * 10)) 'pick numbers
        ' if any number is 7 display picture and beep
        If (Label1.Text = "7") Or (Label2.Text = "7") Or (Label3.Text = "7") Then
            PictureBox1.Visible = True
            Beep()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
