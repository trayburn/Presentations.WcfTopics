<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WcfTopics_JQuery._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
    <p>

    <input type="text" id="stock" name="stock" value="MSFT" /><br />
    <input type="button" id="submit" name="submit" value="SUBMIT" /><br />

    <script>
        $(document).ready(function () {
            $('#submit').click(function () {
                $.ajax({
                    async: true,
                    complete: function () { alert('complete'); },
                    processData: false,
                    dataType: "text",
                    contentType: "application/json",
                    type: 'GET',
                    url: 'Stock.svc/GetPrice/' + $('#stock').val(),
                    error: function (x,e,t) { alert('Message : ' + e); },
                    success: function (r) { alert(r); }
                });
            });
        });
    </script>

    <div id="results"></div>

    </p>
</asp:Content>
