using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetosWebForms
{
    public class AlunoDAO
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
    }
}