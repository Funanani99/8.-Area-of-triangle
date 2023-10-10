Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        Dim L As Double
        Dim H As Double

        L = Val(TextBox1.Text)
        H = Val(TextBox2.Text)
        A = L * H
        TextBox3.Text = A
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim P As Double
        Dim L As Double
        Dim H As Double

        L = Val(TextBox1.Text)
        H = Val(TextBox2.Text)
        P = 2 * (L + H)

        TextBox4.Text = P
    End Sub
End Class
