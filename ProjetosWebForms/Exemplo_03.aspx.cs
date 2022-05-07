using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetosWebForms
{
    public partial class Exemplo_03 : System.Web.UI.Page
    {
        private double valMulher = 8;
        private double valHomem = 10;
        private double valCerveja = 6;
        private double valRefrigerante = 4.5;
        private double valEspetinho = 5;

        private void showMessageBox(string message)
        {
            string sJavaScript = "<script language=javascript>\n";
            sJavaScript += "alert('" + message + "');";
            sJavaScript += "\n";
            sJavaScript += "</script>";
            ClientScript.RegisterStartupScript(typeof(string), "MessageBox", sJavaScript);
        }

        private double CalcularVenda()
        {
            double valConta = 0;

            //calculando a taxa inicial para homens/mulheres
            switch (cboSexo.SelectedValue)
            {
                case "M":
                    valConta += valHomem;
                    break;
                case "F":
                    valConta += valMulher;
                    break;
            }

            //calculando a quantidade de cervejas consumidas
            valConta += Convert.ToUInt16(txtQtdCervejas.Text) * valCerveja;
            //calculando a quantidade de refrigerantes consumidos
            valConta += Convert.ToUInt16(txtQtdRefrigerantes.Text) * valRefrigerante;
            //calculando a quantidade de espetinhos consumidos
            valConta += Convert.ToUInt16(txtQtdEspetinhos.Text) * valEspetinho;

            return valConta;
        } 

        private double CalcularAcumuladoTotal(double pValorVenda)
        {
            return double.Parse(Session["TotalGeral"].ToString()) + pValorVenda;
        }

        private void Vender()
        {
            double lValorConta = CalcularVenda();
            lblTotalAtual.Text = "Total a pagar: " + lValorConta.ToString();
            Session["TotalGeral"] = CalcularAcumuladoTotal(lValorConta);
            LimparCaixastexto();
            lblTotalGeral.Text = "Total Geral Recebido: " + Session["TotalGeral"];
        }

        private void LimparCaixastexto()
        {
            txtQtdCervejas.Text = "0";
            txtQtdRefrigerantes.Text = "0";
            txtQtdEspetinhos.Text = "0";
        }

        private void LimparTela()
        {
            LimparCaixastexto();
            lblTotalAtual.Text = "Total a Pagar: 0";
            lblTotalGeral.Text = "Total Geral Recebido: 0";
            Session["TotalGeral"] = 0;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["TotalGeral"] = 0.0;
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Vender();
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
    }
}