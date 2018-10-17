<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JobWebClient.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>FSD WCF Assignment 1 - Job service Web Client</h2>
            <asp:Label ID="Label1" runat="server" Text="Label">Search Job By Role: </asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Invoke Service" OnClick="Button1_Click" />
            <br /><br />
            <asp:Label ID="Label2" runat="server" Width="450px"></asp:Label><br />
            <br /><br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Code" HeaderText="Job Code" />
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="Role" HeaderText="Role" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
