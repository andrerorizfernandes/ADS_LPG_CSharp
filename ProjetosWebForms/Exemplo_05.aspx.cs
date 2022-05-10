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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AlunoDAO alnDAO = new AlunoDAO();
                Grid.ListarDados(gvDados, alnDAO.CarregarDadosBanco());
            }
            
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Aluno aln = new Aluno();
            AlunoDAO alnDAO = new AlunoDAO();
            aln.Nome = txtNome.Text;
            aln.Matricula = txtMatricula.Text;
            aln.Curso = txtCurso.Text;

            if (alnDAO.InserirAluno(aln))
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
            
            Grid.ListarDados(gvDados, alnDAO.CarregarDadosBanco());
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Aluno aln = new Aluno();
            AlunoDAO alnDAO = new AlunoDAO();
            aln.Id = Convert.ToInt32(txtID.Text);
            aln.Nome = txtNome.Text;
            aln.Matricula = txtMatricula.Text;
            aln.Curso = txtCurso.Text;

            if (alnDAO.EditarAluno(aln))
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

            Grid.ListarDados(gvDados, alnDAO.CarregarDadosBanco());
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Aluno aln = new Aluno();
            AlunoDAO alnDAO = new AlunoDAO();
            aln.Id = Convert.ToInt32(txtID.Text);

            if (alnDAO.ExcluirAluno(aln))
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

            Grid.ListarDados(gvDados, alnDAO.CarregarDadosBanco());
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            AlunoDAO alnDAO = new AlunoDAO();
            Grid.ListarDados(gvDados, alnDAO.CarregarDadosBanco());
        }
    }
}