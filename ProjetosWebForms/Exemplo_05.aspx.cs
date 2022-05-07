using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetosWebForms
{
    public partial class Exemplo_05 : System.Web.UI.Page
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
                Grid.ListarDados(gvDados, CarregarDadosBanco());
            }
            
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Aluno aln = new Aluno();
            aln.Nome = txtNome.Text;
            aln.Matricula = txtMatricula.Text;
            aln.Curso = txtCurso.Text;

            if (InserirAluno(aln))
            {
                lblRetornoOperacao.Text = "Aluno adicionado com sucesso.";
                txtID.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtMatricula.Text = string.Empty;
                txtCurso.Text = string.Empty;
            }
            else
            {
                lblRetornoOperacao.Text = "Não foi possivel adicionar o novo aluno.";
            }
            
            Grid.ListarDados(gvDados, CarregarDadosBanco());
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Aluno aln = new Aluno();
            aln.Id = Convert.ToInt32(txtID.Text);
            aln.Nome = txtNome.Text;
            aln.Matricula = txtMatricula.Text;
            aln.Curso = txtCurso.Text;

            if (EditarAluno(aln))
            {
                lblRetornoOperacao.Text = "Aluno alterado com sucesso.";
                txtID.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtMatricula.Text = string.Empty;
                txtCurso.Text = string.Empty;
            }
            else
            {
                lblRetornoOperacao.Text = "Não foi possivel alterar o aluno.";
            }

            Grid.ListarDados(gvDados, CarregarDadosBanco());
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Aluno aln = new Aluno();
            aln.Id = Convert.ToInt32(txtID.Text);

            if (ExcluirAluno(aln))
            {
                lblRetornoOperacao.Text = "Aluno excluido com sucesso.";
                txtID.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtMatricula.Text = string.Empty;
                txtCurso.Text = string.Empty;
            }
            else
            {
                lblRetornoOperacao.Text = "Não foi possivel excluir o aluno.";
            }

            Grid.ListarDados(gvDados, CarregarDadosBanco());
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Grid.ListarDados(gvDados, CarregarDadosBanco());
        }
    }
}