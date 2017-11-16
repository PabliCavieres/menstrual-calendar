<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Calendar.View.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <h1>Error</h1>
    <% 
        try {
            String error = Session["error"].ToString();

            if (error == null) {
                Response.Redirect("Index.aspx");
            }

            Response.Write("ERROR: "+error);
        } catch (Exception) {
            Response.Redirect("Index.aspx");
        }
       
    %>

     <a href="Index.aspx">Volver</a>
</body>
</html>
