<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ArraysOddNumbers._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Enter a comma separated list of strings:</p>
            <asp:TextBox ID="arrayTextbox" runat="server"></asp:TextBox><br/>
            <asp:Button ID="arrayOKbutton" runat="server" Text="Calculate sum of odd numbers" OnClick="arrayOKbutton_Click" /><br/>
            <asp:Label ID="arrayLabel" runat="server"></asp:Label><br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
