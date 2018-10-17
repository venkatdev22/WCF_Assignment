<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HelloWebClient.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>FSD WCF Assignment 1 - Web Client</h2>
            <asp:Label ID="Label1" runat="server" Text="Label">Enter Your Name: </asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Width="450px"></asp:Label><br/>
            <asp:Label ID="Label3" runat="server" Width="450px"></asp:Label><br/>
            <asp:Label ID="Label4" runat="server" Width="450px"></asp:Label>
            <br />
            <br />
            <asp:Button id="Button1" runat="server" Text="Invoke HTTP" OnClick="Button1_Click" />
            <asp:Button id="Button2" runat="server" Text="Invoke TCP" OnClick="Button2_Click" />
        </div>
    </form>
</body>

</html>
