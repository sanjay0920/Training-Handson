<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_03_10_2022.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Booking Form</h1>
        </div>
        <label>User ID:</label>
        <input type ="text" name ="Userid" /> <br /> <br />
        <label>Password:</label> 
        <input type ="text" name ="password" /> <br /> <br />
        <button type ="submit">Login</button>

    </form>
</body>
</html>
