Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "Olá mundo"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.MouseMove
    End Sub


    Private Sub valor1_textchanged(sender As Object, e As EventArgs) Handles valor1.TextChanged, valor2.TextChanged
        soma()
    End Sub

    Private Sub soma()
        If IsNumeric(valor1.Text) And IsNumeric(valor2.Text) Then
            Resultado.Text = CInt(valor1.Text) + CInt(valor2.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class


'Private Sub Resultado_TextChanged(sender As Object, e As EventArgs) Handles Resultado.TextChanged
'    'firstNum = Convert.ToInt32(Me.TextBox1.Text)
'    'Convert.ToInt32(Me.TextBox1.Text)
'    'Resultado.Text = Convert.ToInt32(Me.valor1.Text) + Convert.ToInt32(Me.valor2.Text)
'    'If IsNumeric(valor1.Text) And IsNumeric(valor2.Text) Then
'    '    Resultado.Text = CInt(valor1.Text) + CInt(valor2.Text)
'    'End If
'End Sub

'Private Sub valor2_TextChanged(sender As Object, e As EventArgs) Handles valor2.TextChanged
'    If IsNumeric(valor1.Text) And IsNumeric(valor2.Text) Then
'        Resultado.Text = CInt(valor1.Text) + CInt(valor2.Text)
'    End If
'End Sub