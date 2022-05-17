using System;
using System.Web.UI.WebControls;
using Pojo;
using Bll;

namespace BandaCad
{
    public partial class Index : System.Web.UI.Page
    {
        private void Listar()
        {
            try {
                BandaBll bl = new BandaBll();
                gvdBanda.DataSource = bl.Listar();
                gvdBanda.DataBind();
            }
            catch (Exception ex)
            {
                lblRetornoOperacao.Text = "Falha ao listar dados. " +
                    "{Erro original:" + ex.Message + "}";
                lblRetornoOperacao.ForeColor = System.Drawing.Color.Red;
                return;
            }
        }

        private void Inserir()
        {
            Banda b = new Banda();

            b.Descricao = txtDescricaoCadastro.Text;
            b.Cidade = txtCidadeCadastro.Text;
            b.Uf = txtUfCadastro.Text;
            b.Vocalista = txtVocalistaCadastro.Text;

            BandaBll bl = new BandaBll();
            try
            {
                if (bl.Inserir(b))
                {
                    txtDescricaoCadastro.Text = string.Empty;
                    txtCidadeCadastro.Text = string.Empty;
                    txtUfCadastro.Text = string.Empty;
                    txtVocalistaCadastro.Text = string.Empty;
                    lblRetornoOperacao.Text = "Banda inserida com sucesso";
                    lblRetornoOperacao.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    lblRetornoOperacao.Text = "Não foi possível inserir a banda";
                    lblRetornoOperacao.ForeColor = System.Drawing.Color.Red;
                    return;
                }
            }
            catch (Exception ex)
            {
                lblRetornoOperacao.Text = "Falha ao inserir dados. " +
                    "{Erro original:" + ex.InnerException + "}";
                lblRetornoOperacao.ForeColor = System.Drawing.Color.Red;
                return;
            }            
        }

        private void Alterar(GridViewRow linhaSelecionada)
        {
            Banda b = new Banda();
            b.CodBanda = Convert.ToInt32((linhaSelecionada.FindControl("lblCodBanda") as Label).Text);
            b.Descricao = (linhaSelecionada.FindControl("txtDescricao") as TextBox).Text;
            b.Cidade = (linhaSelecionada.FindControl("txtCidade") as TextBox).Text;
            b.Uf = (linhaSelecionada.FindControl("txtUf") as TextBox).Text;
            b.Vocalista = (linhaSelecionada.FindControl("txtVocalista") as TextBox).Text;

            BandaBll bl = new BandaBll();
            try
            {
                if (bl.Alterar(b))
                {
                    lblRetornoOperacao.Text = "Banda alterada com sucesso";
                    lblRetornoOperacao.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    lblRetornoOperacao.Text = "Não foi possível alterar a banda";
                    lblRetornoOperacao.ForeColor = System.Drawing.Color.Red;
                    return;
                }
            }
            catch (Exception ex)
            {
                lblRetornoOperacao.Text = "Falha ao alterar dados. " +
                    "{Erro original:" + ex.InnerException + "}";
                lblRetornoOperacao.ForeColor = System.Drawing.Color.Red;
                return;
            }
        }

        private void Excluir(GridViewRow linhaSelecionada)
        {
            Banda b = new Banda();
            b.CodBanda = Convert.ToInt32((linhaSelecionada.FindControl("lblCodBanda") as Label).Text);
            
            BandaBll bl = new BandaBll();
            try
            {
                if (bl.Excluir(b))
                {
                    lblRetornoOperacao.Text = "Banda excluída com sucesso";
                    lblRetornoOperacao.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    lblRetornoOperacao.Text = "Não foi possível excluir a banda";
                    lblRetornoOperacao.ForeColor = System.Drawing.Color.Red;
                    return;
                }
            }
            catch (Exception ex)
            {
                lblRetornoOperacao.Text = "Falha ao excluir dados. " +
                    "{Erro original:" + ex.InnerException + "}";
                lblRetornoOperacao.ForeColor = System.Drawing.Color.Red;
                return;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar();
            }
        }

        protected void gvdBanda_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvdBanda.EditIndex = -1;
            Listar();
        }

        protected void gvdBanda_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Excluir(gvdBanda.Rows[e.RowIndex]);
            Listar();
        }

        protected void gvdBanda_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvdBanda.EditIndex = e.NewEditIndex;
            Listar();
        }

        protected void gvdBanda_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Alterar(gvdBanda.Rows[e.RowIndex]);
            gvdBanda.EditIndex = -1;
            Listar();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Inserir();
            Listar();
        }
    }
}