<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="webapp.create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro webapp</title>
</head>
<body>
    <asp:HyperLink ID="HyperLink3" Text="Home" runat="server" NavigateUrl="default.aspx">Home</asp:HyperLink>&nbsp;|&nbsp;
    <br />    
    <form id="form1" runat="server">
    <div>
          <table>
              <tr><td>campo 1</td><td><asp:TextBox ID="txtcampo1" runat="server"></asp:TextBox></td>

              </tr>
              <tr><td>campo 2</td><td><asp:TextBox ID="txtcampo2" runat="server"></asp:TextBox></td></tr>
              <tr>
                  <td>campo 3</td><td><asp:TextBox ID="txtcampo3" runat="server"></asp:TextBox></td></tr>
              <tr><td>&nbsp;</td><td>
                  <asp:Button ID="btnenviar" runat="server" Text="Button" OnClick="btnenviar_Click" /></td></tr>
          </table>
          <asp:Label runat="server" ID="lblresultado" Text=""  />
         <br />
        <asp:HyperLink ID="HyperLink1" Text="Pesquisa" runat="server" NavigateUrl="search.aspx">Pesquisa</asp:HyperLink>&nbsp;|&nbsp;
        <asp:HyperLink ID="HyperLink2" Text="Home" runat="server" NavigateUrl="default.aspx">Home</asp:HyperLink>
    </div>
    </form>
</body>
</html>
