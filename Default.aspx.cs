using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txbNome.Attributes.Add("placeholder", "Nome");
            txbFuncao.Attributes.Add("placeholder", "Função");
            txbSetor.Attributes.Add("placeholder", "Setor / Área");
            txbEmail.Attributes.Add("placeholder", "xxxxxxx@prefeitura.sp.gov.br");
            txbTelefone1.Attributes.Add("placeholder", "55 11 3397-XXXX (fixo)");
            txbTelefone2.Attributes.Add("placeholder", "11 99999-9999 (celular)");
            txbEndereco.Attributes.Add("placeholder", "Rua Castro Alves, xx - xº Andar, Sala X");
            txbCEP.Attributes.Add("placeholder", "CEP: 01532-001 - Aclimação - São Paulo-SP");
            modeloEmail();
        }
    }

    protected void PreencheCodigoCaptcha()
    {
        try
        {
            Session["nome"] = txbNome.Text;
            Session["funcao"] = txbFuncao.Text;
            Session["setor"] = txbSetor.Text;
            Session["email"] = txbEmail.Text;
            Session["telefone1"] = txbTelefone1.Text;
            Session["telefone2"] = txbTelefone2.Text;
            Session["end1"] = txbEndereco.Text;
            Session["cep"] = txbCEP.Text;

            imgCodigoCaptcha.ImageUrl = "Assinatura.aspx?" + DateTime.Now.Ticks.ToString();
        }

        catch (Exception ex)
        {
            Response.Write(ex.Message);
            lblMsg.Text = ex.Message;
        }
    }
    protected void modeloEmail()
    {
        //StringBuilder nome = new StringBuilder();
        Session["nome"] = "Nome do Funcionário";
        Session["funcao"] = "Função";
        Session["setor"] = "Setor/Área";
        Session["email"] = "xxxxxx@prefeitura.sp.gov.br";
        Session["telefone1"] = "55 11 3397-xxxx";
        Session["telefone2"] = "55 11 99927-xxxx";

        Session["end1"] = "Rua Castro Alves, xx - Xº Andar, sala X";
        Session["cep"] = "CEP: 01532-001 - Aclimação - São Paulo-SP";
      
        imgCodigoCaptcha.ImageUrl = "Assinatura.aspx?" + DateTime.Now.Ticks.ToString();

    }

    protected void btnAtualizaCodigo_Click(object sender, EventArgs e)
    {
        PreencheCodigoCaptcha();
    }
}
