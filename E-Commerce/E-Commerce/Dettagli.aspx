<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="E_Commerce.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <div class="container d-flex justify-content-center">
            <div class="card mx-2 my-2 bg-dark text-white border border-white">
                <asp:Image ID="ImageDetail" runat="server" CssClass="card-img-top img-fluid" />
                <div class="card-body">
                    <h5 class="card-title">
                        <asp:Label ID="LabelCardTitle" runat="server" Text="Pagina Non Valida"></asp:Label>
                    </h5>
                    <p class="card-text">
                        <asp:Label ID="LabelCardDescription" runat="server" Text="Pagina Non Valida"></asp:Label>
                    </p>
                    <p class="card-text">
                        <asp:Label ID="LabelCardPrezzo" runat="server" Text="Pagina Non Valida"></asp:Label>
                    </p>
                 
                </div>
            </div>
        </div>

    </div>
</asp:Content>
