<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1._1.WebForm1" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hur många versaler?</h1>
        <div>
            <asp:TextBox ID="Input" CssClass="input-field" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Output" CssClass="output-field" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="Button" CssClass="submit" runat="server" Text="Beräkna" onclick="Button_Click"/>
        </div>
    </div>
    </form>
</body>
</html>
