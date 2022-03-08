Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim f As Double
        Dim r As Double

        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        d = TextBox4.Text

        f = a + b + c + d
        r = f / 4
        TextBox5.Text = r


    End Sub
End Class
