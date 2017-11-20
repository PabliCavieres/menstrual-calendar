<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="Calendar.View.Calendario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <script runat="server">
    protected void Calendar1_SelectionChanged(object sender, System.EventArgs e) {

        Label1.Text = "You selected date(s) : <br />";
       
        for (int i=0; i<Calendar1.SelectedDates.Count; i++){
            Label1.Text += Calendar1.SelectedDates[i].ToShortDateString() +
                "<br />";
        }
    }
        </script>


</head>
<body>
       
    Tus datos han sido cargados correctamente
            <br />
    
    <form id="form1" runat="server">

        <asp:Label ID="Label1" 
                    runat="server" 
                    ForeColor="BlueViolet"
                    Font-Italic="true"
                    Font-Names="Comic Sans MS"
                    Font-Size="Large"/>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
    </form>
    
    Cuéntanos como te sientes hoy <input type="button" onclick="location.href='Registro.aspx'" value="Aquí" /> 
    <a href="../Controller/CerrarSesion.ashx">Cerrar sesión</a>

</body>
</html>
