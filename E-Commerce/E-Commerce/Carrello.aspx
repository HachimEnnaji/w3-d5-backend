<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="E_Commerce.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h2 class="m-3">Carrello</h2>
     
    <asp:GridView ID="GridCarrello" CssClass="table table-light m-3" AutoGenerateColumns="false" runat="server" ItemType="E-commerce.Shoes.ListaCarrello">
        <Columns>

            
            <asp:BoundField DataField="Name" HeaderText="Nome Shoes" />
            <asp:BoundField DataField="Color" HeaderText="Colore" />
            <asp:BoundField DataField="Brand" HeaderText="Brand" />
            <asp:BoundField DataField="Price" HeaderText="Da pagare" />
        

        </Columns>
    </asp:GridView>
    <hr class="m-3" />
    <h1 class="m-3">Totale: <span id="totale" class="display-5" runat="server"></span></h1>
</asp:Content>
