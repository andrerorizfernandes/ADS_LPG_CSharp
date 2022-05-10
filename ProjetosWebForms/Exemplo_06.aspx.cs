using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetosWebForms
{
    public partial class Exemplo_06 : System.Web.UI.Page
    {
        public MySqlDataReader CarregarDadosBanco()
        {
            MySqlConnection con = new MySqlConnection(Conexao.StringConexao());
            con.Open();
            MySqlCommand comando = new MySqlCommand("SELECT id, matricula, nome, curso FROM aluno", con);
            MySqlDataReader dr = comando.ExecuteReader();

            return dr;
        }

        public bool InserirAluno(Aluno a)
        {
            MySqlConnection con = new MySqlConnection(Conexao.StringConexao());
            con.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO Aluno(Nome, Matricula, Curso) " +
                "VALUES (@Nome,@Matricula,@Curso)", con);

            comando.Parameters.AddWithValue("@Nome", a.Nome);
            comando.Parameters.AddWithValue("@Matricula", a.Matricula);
            comando.Parameters.AddWithValue("@Curso", a.Curso);

            MySqlDataReader dr = comando.ExecuteReader();

            return dr.RecordsAffected > 0;
        }

        public bool EditarAluno(Aluno a)
        {
            MySqlConnection con = new MySqlConnection(Conexao.StringConexao());
            con.Open();
            MySqlCommand comando = new MySqlCommand("UPDATE Aluno SET nome = @Nome," +
                " matricula = @Matricula, curso = @Curso WHERE id=@ID", con);

            comando.Parameters.AddWithValue("@ID", a.Id);
            comando.Parameters.AddWithValue("@Nome", a.Nome);
            comando.Parameters.AddWithValue("@Matricula", a.Matricula);
            comando.Parameters.AddWithValue("@Curso", a.Curso);

            MySqlDataReader dr = comando.ExecuteReader();

            return dr.RecordsAffected > 0;
        }

        public bool ExcluirAluno(Aluno a)
        {
            MySqlConnection con = new MySqlConnection(Conexao.StringConexao());
            con.Open();
            MySqlCommand comando = new MySqlCommand("DELETE FROM Aluno WHERE ID=@ID", con);

            comando.Parameters.AddWithValue("@ID", a.Id);
            MySqlDataReader dr = comando.ExecuteReader();

            return dr.RecordsAffected > 0;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grid.ListarDados(gvdAlunos, CarregarDadosBanco());
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Aluno aln = new Aluno();
            aln.Nome = txtNome_Add.Text;
            aln.Matricula = txtMatricula_Add.Text;
            aln.Curso = txtCurso_Add.Text;

            if (InserirAluno(aln))
            {
                lblRetornoOperacao.Text = "Aluno adicionado com sucesso.";
                txtNome_Add.Text = string.Empty;
                txtMatricula_Add.Text = string.Empty;
                txtCurso_Add.Text = string.Empty;
            }
            else
            {
                lblRetornoOperacao.Text = "Não foi possivel adicionar o novo aluno.";
            }

            Grid.ListarDados(gvdAlunos, CarregarDadosBanco());
        }

        protected void gvdAlunos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvdAlunos.EditIndex = -1;
            Grid.ListarDados(gvdAlunos, CarregarDadosBanco());
        }

        protected void gvdAlunos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Aluno a = new Aluno();
            a.Id = Convert.ToInt32((gvdAlunos.Rows[e.RowIndex].FindControl("lblId") as Label).Text);
            if (ExcluirAluno(a))
            {
                lblRetornoOperacao.Text = "Aluno excluido com sucesso.";
            }
            else
            {
                lblRetornoOperacao.Text = "Não foi possivel excluir o aluno.";
            }

            Grid.ListarDados(gvdAlunos, CarregarDadosBanco());
        }

        protected void gvdAlunos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvdAlunos.EditIndex = e.NewEditIndex;
            Grid.ListarDados(gvdAlunos, CarregarDadosBanco());
        }

        protected void gvdAlunos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Aluno a = new Aluno();
            GridViewRow linha = gvdAlunos.Rows[e.RowIndex];
            a.Id = Convert.ToInt32((gvdAlunos.Rows[e.RowIndex].FindControl("lblId") as Label).Text);
            a.Matricula = (linha.FindControl("txtMatricula") as TextBox).Text;
            a.Nome = (linha.FindControl("txtNome") as TextBox).Text;
            a.Curso = (linha.FindControl("txtCurso") as TextBox).Text;
            if (EditarAluno(a))
            {
                lblRetornoOperacao.Text = "Aluno alterado com sucesso.";
            }
            else
            {
                lblRetornoOperacao.Text = "Não foi possivel alterar o aluno.";
            }

            gvdAlunos.EditIndex = -1;
            Grid.ListarDados(gvdAlunos, CarregarDadosBanco());
        }
    }
}