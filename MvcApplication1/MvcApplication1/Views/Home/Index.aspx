<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<OdeToFood.Entity.Restaurant>>" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Restaurant List
</asp:Content>

<asp:Content ID="indexFeatured" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <% foreach(OdeToFood.Entity.Restaurant resto in Model) { %>
        <div>
            <h4><%: resto.Name %></h4>
            <div><%: resto.City %>, <%: resto.Country %></div>
            <div>Ratings : <%: resto.Reviews.Count().ToString() %></div>
            <hr />
        </div>
    <% } %>
    <div>
        
    </div>
</asp:Content>
