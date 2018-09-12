using System;
using System.Collections;
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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Text;

public partial class GerarCaptcha : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string nome = Session["nome"].ToString();
        //string nome = "Daniela Avancini Daniela Ava";// 28 caracteres
        string cargo = Session["funcao"].ToString();
        string setor = Session["setor"].ToString();
        string email = Session["email"].ToString();
        string telefone1 = Session["telefone1"].ToString();
        string telefone2 = Session["telefone2"].ToString();
        string endereco1 = Session["end1"].ToString();
        string endereco2 = Session["cep"].ToString();
       

        try
        {
            Response.Clear();
            System.Drawing.Image objBmp = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("assinatura.jpg")); // set image


            // Cor rgb para cargo
            Color myColor = Color.FromArgb(89, 122, 142);
            SolidBrush myBrush = new SolidBrush(myColor);



            Graphics graphics = Graphics.FromImage(objBmp);

            RectangleF rectf = new RectangleF(10, 10, 0, 0);
            Graphics objGraphics = Graphics.FromImage(objBmp);

            using (StringFormat sf = new StringFormat())
            {
                var format = new StringFormat() { Alignment = StringAlignment.Far };

                objGraphics.DrawString(nome, new Font("Arial", 13, FontStyle.Bold), System.Drawing.Brushes.Black, new RectangleF(10, 30, 300, 50), format);
                objGraphics.DrawString(cargo, new Font("Arial", 12, FontStyle.Regular), myBrush, new RectangleF(10, 55, 300, 20), format);//Função
                objGraphics.DrawString(setor, new Font("Arial", 12, FontStyle.Regular), System.Drawing.Brushes.Black, new RectangleF(10, 80, 300, 50), format);//Setor

                objGraphics.DrawString(email, new Font("Arial", 11.7F, FontStyle.Regular), System.Drawing.Brushes.Black, new RectangleF(10, 120, 300, 50), format);//e-mail
                objGraphics.DrawString(telefone1, new Font("Arial", 11.7F, FontStyle.Regular), System.Drawing.Brushes.Black, new RectangleF(10, 140, 300, 50), format);//tel1
                objGraphics.DrawString(telefone2, new Font("Arial", 11.7F, FontStyle.Regular), System.Drawing.Brushes.Black, new RectangleF(10, 160, 300, 50), format);//tel2

                //Endereço
                objGraphics.DrawString(endereco1, new Font("Arial", 9.6F, FontStyle.Regular), System.Drawing.Brushes.Black, new RectangleF(10, 195, 300, 25), format);
                objGraphics.DrawString(endereco2, new Font("Arial", 9.6F, FontStyle.Regular), System.Drawing.Brushes.Black, new RectangleF(10, 212, 300, 25), format);


                // Top/Right. Borda dos parágrafos
                //sf.Alignment = StringAlignment.Far;         // Right.
                //objGraphics.DrawRectangle(Pens.Black, Rectangle.Round(new RectangleF(10, 20, 245, 20)));
                // objGraphics.DrawRectangle(Pens.Black, Rectangle.Round(new RectangleF(10, 55, 300, 20)));
                //objGraphics.DrawRectangle(Pens.Black, Rectangle.Round(new RectangleF(10, 80, 245, 20)));
                //objGraphics.DrawRectangle(Pens.Black, Rectangle.Round(new RectangleF(10, 100, 245, 20)));
                //objGraphics.DrawRectangle(Pens.Black, Rectangle.Round(new RectangleF(10, 125, 245, 20)));
                //objGraphics.DrawRectangle(Pens.Black, Rectangle.Round(new RectangleF(10, 158, 245, 20)));
                //objGraphics.DrawRectangle(Pens.Black, Rectangle.Round(new RectangleF(10, 224, 245, 15)));
                //objGraphics.DrawRectangle(Pens.Black, Rectangle.Round(new RectangleF(10, 244, 245, 15)));
            }

            // Codigo original abaixo
            objGraphics.Flush();
            Response.ContentType = "image/jpeg";
            objBmp.Save(Response.OutputStream, ImageFormat.Jpeg);
            objGraphics.Dispose();
            objBmp.Dispose();
            Response.Flush();

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
