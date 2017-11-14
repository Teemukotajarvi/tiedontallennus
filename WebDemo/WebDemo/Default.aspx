<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h1>Hei, maailma!<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Henkilo_id" DataSourceID="SqlDataSource1">
       <Columns>
           <asp:BoundField DataField="Henkilo_id" HeaderText="Henkilo_id" InsertVisible="False" ReadOnly="True" SortExpression="Henkilo_id" />
           <asp:BoundField DataField="Etunimi" HeaderText="Etunimi" SortExpression="Etunimi" />
           <asp:BoundField DataField="Sukunimi" HeaderText="Sukunimi" SortExpression="Sukunimi" />
           <asp:BoundField DataField="Osoite" HeaderText="Osoite" SortExpression="Osoite" />
       </Columns>
       </asp:GridView>
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestiTietokantaConnectionString %>" SelectCommand="SELECT [Henkilo_id], [Etunimi], [Sukunimi], [Osoite] FROM [Henkilot]"></asp:SqlDataSource>
    </h1>

</asp:Content>
