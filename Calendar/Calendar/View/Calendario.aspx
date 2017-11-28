<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="Calendar.View.Calendario" %>
<%@ Import Namespace="Calendar.Model" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <script runat="server">
    protected void Calendar1_SelectionChanged(object sender, System.EventArgs e) {

        Label1.Text = "Tus datos seleccionados son : <br />";
       
        for (int i=0; i<Calendar1.SelectedDates.Count; i++){
            Label1.Text += Calendar1.SelectedDates[i].ToShortDateString() +
                "<br />";
        }
    }
        </script>
</head>
<body>
<center>
    <div class="formCostado">

        

         <h3>Tips</h3>
        
        <%  
            Data d = new Data();
            Random r = new Random();
            int num_A = r.Next(1,13);


            foreach (Tips t in d.getTip(r)) {

                 Response.Write("<br/>"+d.getTip(r).ToString());
            }

           
        %> 

        
        
        <div style="margin-top:420px;">

            <hr/>
            Ver Registro <br/><input type="button" onclick="location.href = 'VerRegistro.aspx'" value="Aquí" class="button1" />
        </div>
    </div>

    <div class="CerrarSesion">
    <input type="button" onclick="location.href = '../Controller/CerrarSesion.ashx'" value="Cerrar sesión" class="button1" id="btnSesion" /> 
    </div>

    <div class="form">
        <div><br><br>
            Tus datos han sido cargados correctamente
            <br /><br>
        </div>
    <form id="form1" runat="server">

        <asp:Label ID="Label1" 
                    runat="server" 
                    ForeColor="BlueViolet"
                    Font-Italic="true"
                    Font-Names="Comic Sans MS"
                    Font-Size="Large"/>
         <asp:Calendar ID="Calendar1" runat="server" BackColor="#ffe6e6" BorderStyle="Outset" BorderColor="indianred" BorderWidth="1px" Font-Names="Arial" Font-Size="11pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="360px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="white" VerticalAlign="Bottom" Font-Underline="false"/>
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="indianred" ForeColor="White" />
            <TitleStyle BackColor="indianred" BorderColor="indianred" BorderStyle="Outset" BorderWidth="2px" Font-Bold="True" Font-Size="12pt" ForeColor="white" Height="30px" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
    </form>
     <br>
    Cuéntanos ..¿Cómo te sientes hoy?<br> <input type="button" onclick="location.href = 'Registro.aspx'" value="Aquí" class="button1" id="btnEspecial"/> 
    <br><br>
    </div>
    <br><br><br>

    <br>  
</center>
</body>
<style>
body{
        Background-image:url("../Imagenes/fondoCal.jpg");
    }
    .button1 {
        border-style: none;
        border-color: inherit;
        border-width: medium;
        background: indianred;
        color: #f2f2f2;
        padding: 10px;
        font-size: 18px;
        border-radius: 5px;
        position: relative;
        box-sizing: border-box;
        transition: all 500ms ease;
        top: 0px;
        left: 0px;
    }

     .button1:hover {
        background: rgba(0,0,0,0);
        color: indianred;
        box-shadow: inset 0 0 0 3px indianred;
     }

    .cuadros {
        width: 300px;
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid purple;
        border-radius: 4px;
        box-sizing: border-box;
    }

    .form {
        font-family: "Lucida Sans Unicode", "Lucida Grande", sans-serif;
        border-style:outset;
        max-width: 600px;
        border-radius: 30px 30px 30px 30px;
        border-color:indianred;
        background-color:white;
        margin-left:110px;
        

    }
     .formCostado {
        font-family: "Lucida Sans Unicode", "Lucida Grande", sans-serif;
        border-style:outset;
        width: 280px;
        height:570px;
        border-radius: 30px 30px 30px 30px;
        border-color:indianred;
        background-color:white;
        margin-right:1000px;
    }

    .titulo{
        border-color:indianred;
        background-color:indianred;
        border-style:solid;
        width: 400px;
        border-radius: 40px 40px 40px 40px;
        margin-top:-40px;
        color: white;
    }

    .imag{
        width:2px; height:2px;
        margin-right: 300px;
    }
    #btnEspecial{
        width: 250px;
    }
    .CerrarSesion{
        width: 200px;
        margin-top: -570px;
        margin-left:980px;
    }
    #btnSesion{
        width:200px;
    }
</style>
</html>
