<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ArraysExcedrsize.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="TextBox1" /> <asp:TextBox runat="server" ID="TextBox2" />
            <asp:TextBox runat="server" ID="TextBox3" /> <asp:TextBox runat="server" ID="TextBox4" />
            <asp:TextBox runat="server" ID="TextBox5" /><br />

            <asp:Button runat="server" Text="Change" ID="changeButton" OnClick="changeButton_Click" /><br />

            <asp:Label runat="server" Text="" ID="resultLabel" /><br />
        </div>
    </form>
</body>
</html>
