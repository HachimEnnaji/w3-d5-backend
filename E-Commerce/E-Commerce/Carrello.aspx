<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="E_Commerce.Carrello" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
<h2 class="m-3">Carrello</h2>
     
    <asp:Repeater ID="RepeaterCarrello" runat="server" >
        <ItemTemplate>
            <div class="m-3">
                <h4><%# Eval("Name") %></h4>
                <p>Colore: <%# Eval("Color") %></p>
                <p>Brand: <%# Eval("Brand") %></p>
                <p>Da pagare: <%# Eval("Price") %></p>
                <asp:Button ID="Button1" runat="server" Text="Rimuovi" CssClass="btn btn-danger" OnClick="Button1_Click" CommandArgument='<%# Eval("Id") %>' />
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <hr class="m-3" />
    <h1 class="m-3">Totale: <span id="totale" class="display-5" runat="server"></span></h1>
</asp:Content>
