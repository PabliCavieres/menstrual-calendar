<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Calendario.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    

    <script language="C#" runat="server">

      void Selection_Change(Object sender, EventArgs e) 
      {
         Label1.Text = "The selected date is " + Calendar1.SelectedDate.ToShortDateString();
      }

   </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            Tus datos han sido cargados correctamente

            <asp:Calendar ID="Calendar1" runat="server"  
           SelectionMode="Day" 
           ShowGridLines="True"
           OnSelectionChanged="Selection_Change">


         <SelectedDayStyle BackColor="Yellow"
                           ForeColor="Red">
         </SelectedDayStyle>

      </asp:Calendar>   


         <br />

      <asp:Label id="Label1" runat="server" />

        </div>
    </form>
</body>
</html>
