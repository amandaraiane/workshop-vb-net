Public Class frmCadastroAluno
    Dim strConexao As String = "Data Source=(local)\sqlexpress;UID=nutec;PWD=nutec; Initial Catalog=Nutec;"
    Private Sub frmCadastroAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click, btnLimpar.Click, btnExcluir.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        Dim conexao As New System.Data.SqlClient.SqlConnection
        conexao.ConnectionString = strConexao
        conexao.Open()

        Dim comando As New System.Data.SqlClient.SqlCommand
        comando.Connection = conexao
        comando.CommandText = String.Format("Insert Into Alunos (Nome, Telefone) Values ('{0}', '{1}')", txtNome.Text, txtTelefone.Text)
        comando.ExecuteNonQuery()

        conexao.Close()

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim conexao As New System.Data.SqlClient.SqlConnection
        conexao.ConnectionString = strConexao
        conexao.Open()

        Dim comando As New System.Data.SqlClient.SqlCommand
        comando.Connection = conexao
        comando.CommandText = String.Format("Select * from Alunos")

        Dim banco As New DataSet
        Dim adaptadordeDados As New System.Data.SqlClient.SqlDataAdapter(comando.CommandText, conexao)
        adaptadordeDados.Fill(banco)

        conexao.Close()

        DataGridView1.DataSource = banco.Tables(0)
        DataGridView1.Refresh()
    End Sub
End Class