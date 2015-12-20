<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="webapp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home webapp</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:HyperLink ID="HyperLinkpesquisa" Text="Pesquisa" runat="server" NavigateUrl="search.aspx">Pesquisa</asp:HyperLink>&nbsp;|&nbsp;
        <asp:HyperLink ID="HyperLinkcadastro" Text="Cadastro" runat="server" NavigateUrl="create.aspx">Cadastro</asp:HyperLink>
         <br />
         <br />
         <p><asp:Label ID="lblregistros" runat="server" ></asp:Label></p> 
         <p><asp:Label ID="lbldatahora" runat="server" ></asp:Label></p>
    </div>
    </form>
</body>
</html>
