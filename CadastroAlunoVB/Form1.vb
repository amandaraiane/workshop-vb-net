Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "Olá mundo"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.MouseMove





    End Sub

    Private Sub valor1_TextChanged(sender As Object, e As EventArgs) Handles valor1.TextChanged
        'firstNum = Convert.ToInt32(Me.TextBox1.Text)
        'Convert.ToInt32(Me.TextBox1.Text)


        If IsNumeric(valor1.Text) And IsNumeric(valor2.Text) Then
            Resultado.Text = CInt(valor1.Text) + CInt(valor2.Text)
        End If


        'Resultado.Text = Convert.ToInt32(Me.valor1.Text) + Convert.ToInt32(Me.valor2.Text)

    End Sub

    Private Sub Resultado_TextChanged(sender As Object, e As EventArgs) Handles Resultado.TextChanged

    End Sub

    Private Sub valor2_TextChanged(sender As Object, e As EventArgs) Handles valor2.TextChanged
        If IsNumeric(valor1.Text) And IsNumeric(valor2.Text) Then
            Resultado.Text = CInt(valor1.Text) + CInt(valor2.Text)
        End If
    End Sub
End Class
