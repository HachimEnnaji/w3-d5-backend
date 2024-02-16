using System;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Aggiorna la griglia con i prodotti presenti nel carrello e il totale al caricamento della pagina
            RepeaterCarrello.DataSource = Shoes.ListaCarrello;
            RepeaterCarrello.DataBind();
            double prezzoCarrelloTotale = 0;
            foreach (Shoes shoes in Shoes.ListaCarrello)
            {
                prezzoCarrelloTotale += shoes.Price;
            }
            totale.InnerHtml = prezzoCarrelloTotale.ToString() + " €";
        }

        // Rimuove il prodotto dal carrello
        protected void Button1_Click(object sender, EventArgs e)
        {
            string idShoes = (sender as Button).CommandArgument;
            // trova il prodotto da rimuovere dal carrello con il find method
            Shoes shoesToRemove = Shoes.ListaCarrello.Find(shoes => shoes.ID.ToString() == idShoes);
            if (shoesToRemove != null)
            {
                Shoes.ListaCarrello.Remove(shoesToRemove);
                Response.Redirect("Carrello");
            }
        }
    }
}