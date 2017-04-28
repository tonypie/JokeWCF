<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestAjaxWebService.aspx.cs" Inherits="TestAjaxWebService.TestAjaxWebService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager runat="server">
        <Services>
            <asp:ServiceReference Path="http://localhost:60165/JokeServiceAJAX.svc" />
                
        </Services>
    </asp:ScriptManager>
    <script type="text/javascript">
        var service = new IJokeServiceAJAX();

        service.AddJoke(
            {
                JokeId: 0
                , Title: "Chicken Poet"
                , JokeText: "A chicken crossing the road is poultry in motion!"
            }
            , function () {
                alert("Joke Added!");
            }
            , function (error)
            {
                alert("An error occurred " + error._message);
            }
        );

        service.GetAllJokes(
            function (jokes) {
                var table = document.getElementById("jokeList");
                var output = "";
                for (var i = 0; i < jokes.length; i++)
                {
                    output += "<tr><td>" + jokes[i].JokeId + "</td><td>" +
                        jokes[i].Title + "</td></tr>";
                }
                table.innerHTML = output;
            }
        );
    </script>
    <div>
        <table id="jokeList"></table>
    </div>
    </form>
</body>
</html>
