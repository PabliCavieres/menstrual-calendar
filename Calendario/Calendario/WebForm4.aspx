<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Calendario.WebForm4" %>



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
    <form action="" method="post" runat="server">
        <div>
            Tus datos han sido cargados correctamente
            <br />
       
                  
        
        <asp:Label 
            ID="Label1" 
            runat="server" 
            ForeColor="BlueViolet"
            Font-Italic="true"
            Font-Names="Comic Sans MS"
            Font-Size="Large"
            />
        <br /><br />
        <asp:Calendar 
            ID="Calendar1" 
            runat="server" 
            SelectionMode="DayWeekMonth" 
            OnSelectionChanged="Calendar1_SelectionChanged"
            ForeColor="WhiteSmoke"  
            DayNameFormat="Full"  
            Font-Names="Book Antiqua"  
            Font-Size="Medium"
            >
            <DayHeaderStyle  
                 BackColor="OliveDrab"  
                 />  
            <DayStyle  
                 BackColor="DarkGreen"  
                 BorderColor="ForestGreen"  
                 BorderWidth="1"  
                 Font-Bold="true"  
                 Font-Italic="true"  
                 Font-Size="Large"  
                 />  
            <NextPrevStyle  
                 Font-Italic="true"  
                 Font-Names="Arial CE"  
                 />  
            <SelectedDayStyle  
                 BackColor="Crimson"  
                 BorderColor="Tomato"  
                 />  
            <SelectorStyle  
                 BackColor="Olive"  
                 ForeColor="Snow"  
                 Font-Names="Times New Roman Greek"  
                 Font-Size="Small"  
                 BorderColor="OliveDrab"  
                 BorderWidth="1"  
                 />  
            <TitleStyle  
                 BackColor="DarkGreen"
                 Height="36"  
                 Font-Size="Large"  
                 Font-Names="Courier New Baltic"  
                 />
        </asp:Calendar>

            <br/>

      <input type="button" onclick="location.href='WebForm5.aspx'" value="Aceptar" /> 
        
        </div>
    </form>
</body>
</html>
