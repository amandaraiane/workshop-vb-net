<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.valor1 = New System.Windows.Forms.TextBox()
        Me.valor2 = New System.Windows.Forms.TextBox()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(233, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(298, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'valor1
        '
        Me.valor1.Location = New System.Drawing.Point(12, 142)
        Me.valor1.Name = "valor1"
        Me.valor1.Size = New System.Drawing.Size(100, 20)
        Me.valor1.TabIndex = 4
        Me.valor1.Text = "0"
        '
        'valor2
        '
        Me.valor2.Location = New System.Drawing.Point(118, 142)
        Me.valor2.Name = "valor2"
        Me.valor2.Size = New System.Drawing.Size(100, 20)
        Me.valor2.TabIndex = 5
        Me.valor2.Text = "0"
        '
        'Resultado
        '
        Me.Resultado.Location = New System.Drawing.Point(233, 142)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(100, 20)
        Me.Resultado.TabIndex = 6
        Me.Resultado.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.valor2)
        Me.Controls.Add(Me.valor1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Cdastro de aluno vb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents valor1 As TextBox
    Friend WithEvents valor2 As TextBox
    Friend WithEvents Resultado As TextBox
End Class
