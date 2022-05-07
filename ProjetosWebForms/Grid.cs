using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProjetosWebForms
{
    public class Grid
    {
        public static void ListarDados(GridView pGrid, DataSet pDados)
        {
            pGrid.DataSource = pDados;
            pGrid.DataBind();
        }

        public static void ListarDados(GridView pGrid, List<Aluno> pDados)
        {
            pGrid.DataSource = pDados;
            pGrid.DataBind();
        }

        public static void ListarDados(GridView pGrid, MySqlDataReader pDados)
        {
            pGrid.DataSource = pDados;
            pGrid.DataBind();
        }
    }
}