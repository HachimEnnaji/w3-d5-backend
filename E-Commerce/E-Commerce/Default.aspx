<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_Commerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center text-white">
        <div class="row justify-content-center">
            <asp:Repeater ID="Repeater1" ItemType="E_Commerce.Shoes" runat="server">
                <ItemTemplate>
                    <div class="card mx-2 my-2 bg-dark text-white border border-white" style="width: 200px">
                        <img src='<%# Eval("Image") %>' class="card-img-top mt-2" style="object-fit: contain; max-height:250px; border-radius:5px" alt='<%# Eval("Name") %>'>
                        <div class="card-body d-flex flex-column justify-content-end">
                            <h5 class="card-title"><%# Eval("Name") %></h5>
                            
                            <p class="card-text"><%# Eval("Price", "{0:c2}") %></p>
                            
                            <a href='<%# "Dettagli.aspx?IDShoes=" + Eval("ID") %>' class="btn btn-sm btn-secondary">Dettagli</a>
                            <asp:Button ID="AggiungiACarrello" runat="server" Text="Aggiungi al carrello" CssClass="btn btn-sm btn-info mt-2" OnClick="AggiungiACarrello_Click" CommandArgument='<%# Eval("ID") %>' />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
