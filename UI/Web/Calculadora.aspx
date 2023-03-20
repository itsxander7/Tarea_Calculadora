<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="UI.Web.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Height="33px" style="margin-left: 430px" Text="CALCULADORA " Width="70px"></asp:Label>
            <br />
            <asp:TextBox ID="txtSumador1" runat="server" style="margin-left: 373px" Width="217px" Height="37px"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtSumador2" runat="server" style="margin-left: 373px" Width="217px" Height="37px"></asp:TextBox>
        <div>
        </div>
        <p>
            <asp:Button ID="btnBorrar" runat="server" Height="33px" style="margin-left: 375px" Text="C" Width="70px" BackColor="White" ForeColor="Black" OnClick="btnBorrar_Click" />
            <asp:Button ID="btnMultiplicar" runat="server" Height="32px" style="margin-left: 15px" Text="*" Width="67px" BackColor="#FF9900" OnClick="btnMultiplicar_Click" />
            <asp:Button ID="btnDividir" runat="server" Height="31px" style="margin-left: 14px" Text="/" Width="62px" BackColor="#FF9900" OnClick="btnDividir_Click" />
        </p>
            <asp:Button ID="btnSuma" runat="server" Height="33px" style="margin-left: 375px" Text="+" Width="70px" BackColor="#FF9900" OnClick="btnSuma_Click"  />
            <asp:Button ID="btnRestar" runat="server" Height="32px" style="margin-left: 15px" Text="-" Width="67px" BackColor="#FF9900" OnClick="btnRestar_Click"/>
            <asp:Button ID="btnIgual" runat="server" Height="31px" style="margin-left: 14px" Text="=" Width="62px" BackColor="#FF9900" OnClick="btnIgual_Click"/>


        <br />
        &nbsp;<br />
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  El resultado es: <asp:Label ID="lblresultado" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
   