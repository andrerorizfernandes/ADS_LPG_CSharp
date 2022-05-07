using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetosWebForms
{
    public partial class Exemplo_04 : System.Web.UI.Page
    {
        private DataSet CarregarDadosXml()
        {
            DataSet ds = new DataSet();
            string lCaminhoAplicao = Request.PhysicalApplicationPath;
            ds.ReadXml(lCaminhoAplicao + "Alunos.xml");

            return ds;
        }

        private List<Aluno> CarregarDadosLista()
        {
            List<Aluno> lAlunos = new List<Aluno>();
            for(int i = 0; i <= 10; i++)
            {
                Aluno a = new Aluno();
                a.Id = i;
                a.Nome = "Aluno " + i;
                a.Matricula = "Matricula " + i;
                a.Curso = "Curso " + i;

                lAlunos.Add(a);
            }

            return lAlunos;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grid.ListarDados(gvDados, CarregarDadosLista());
            }
        }
    }
}