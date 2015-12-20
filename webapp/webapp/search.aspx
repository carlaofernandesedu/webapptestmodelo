<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="webapp.search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search webapp</title>
</head>
<body>
     <asp:HyperLink ID="HyperLink3" Text="Home" runat="server" NavigateUrl="default.aspx">Home</asp:HyperLink>&nbsp;|&nbsp;
    <br />  
    <form id="form1" runat="server">
    <div>
          <table>
              <tr><td>pesquisa</td><td><asp:TextBox ID="txtcampo1" runat="server"></asp:TextBox></td>

              </tr>
              <tr><td>&nbsp;</td><td>
                  <asp:Button ID="btnenviar" runat="server" Text="Pesquisar" OnClick="btnenviar_Click" /></td></tr>
          </table>
          <br />
        <asp:Table ID="tbresultado" runat="server"  ></asp:Table>
         <br />
    </div>
    </form>
</body>
</html>
