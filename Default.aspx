<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <link href="css/table-responsive.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/style.css" rel="stylesheet" type="text/css" />
    <link href="assets/bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="assets/bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
    <script src="assets/js/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="assets/js/jquery.backstretch.min.js" type="text/javascript"></script>
    <script src="js/jquery.maskedinput.js" type="text/javascript"></script>
    <title>Assinatura E-mail</title>
    <script type="text/javascript">
         jQuery(function ($) {
             $("#txbTelefone1").mask("55 11 9999-9999");
             $("#txbTelefone2").mask("55 11 99999-9999");
         });
    </script>
    <style type="text/css">
        .style1
        {
            width: 45%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <!-- Início do formulário-->
        <!-- Top content -->
        <div class="top-content">
            <div>
                <div class="container">
                    <div class="row">
                        <div class="col-sm-12">
                            <div class="form-box">
                                <div class="form-top">
                                    <div class="text-center">
                                        <h3>
                                            Informe os dados abaixo e tecle "Enviar" para atualizar a imagem.</h3>
                                    </div>
                                    <div class="text-center">
                                        <h3>Assinatura exclusiva para e-mail institucional (@hspm.sp.gov.br / @prefeitura.sp.gov.br)</h3>
                                    </div>
                                </div>
                                <div class="table-responsive">
                                    <table class="table">
                                        <tr>
                                            <td class="style1" rowspan="3">
                                                <div class="form-bottom">
                                                    <form id="login" method="post" class="login-form">
                                                    <div class="form-group">
                                                        <asp:Label ID="lblMsg" runat="server" Text="" Font-Bold="True" Font-Names="Arial Black"
                                                            Font-Size="Medium" ForeColor="#6600FF"></asp:Label>
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txbNome" runat="server" CssClass="form-control" MaxLength="28"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txbFuncao" runat="server" CssClass="form-control" MaxLength="33"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txbSetor" runat="server" CssClass="form-control" MaxLength="37"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txbEmail" runat="server" CssClass="form-control" MaxLength="39"></asp:TextBox>
                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txbEmail" ValidationExpression="\S+@\S+.\S{2,3}" runat="server" ErrorMessage="e-mail inválido"></asp:RegularExpressionValidator>
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txbTelefone1" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txbTelefone2" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txbEndereco" runat="server" CssClass="form-control" MaxLength="42"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txbCEP" runat="server" CssClass="form-control" MaxLength="42"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group" align="center">
                                                        <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="btnAtualizaCodigo_Click" CssClass="btn btn-primary" />
                                                    </div>
                                                    </form>
                                                </div>
                                            </td>
                                            <td align="center">
                                                <div>
                                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                        <ContentTemplate>
                                                            <table border="1">
                                                                <tr>
                                                                    <td>
                                                                        <asp:Image ID="imgCodigoCaptcha" runat="server" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-top">
                                                    <div class="text-center">
                                                        <h3>
                                                            Posicione o cursor sobre a imagem e aperte o botão direito do mouse para salva-la</h3>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                    <!-- <div class="text-center">
                                                <div class="form-top">
                                                        <h3>
                                                            Veja o vídeo explicativo 
                                                            <asp:HyperLink ID="HyperLink1" runat="server" 
                                                                NavigateUrl="~/video/video.aspx">Aqui</asp:HyperLink></h3>
                                                    </div>
                                                </div>-->
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
    <!-- Fim do Formulário -->

    <script type="text/javascript">
            $.backstretch(["Images/1.jpg"],
                {
                   fade:500
                });
                
               
    </script>

</body>
</html>
