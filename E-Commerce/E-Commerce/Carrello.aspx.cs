using System;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //al caricamento della pagina aggiorna la griglia con i prodotti presenti nel carrello e il totale
            GridCarrello.DataSource = Shoes.ListaCarrello;
            GridCarrello.DataBind();
            double prezzoCarrelloTotale = 0;
            foreach (Shoes shoes in Shoes.ListaCarrello)
            {
                prezzoCarrelloTotale += shoes.Price; ;
            }
            totale.InnerHtml = prezzoCarrelloTotale.ToString() + " €";
        }

        //funzione che rimuove il prodotto dal carrello
        protected void btnRimuovi_Click(object sender, EventArgs e)
        {

            string idShoes = (sender as Button).CommandArgument;
            foreach (Shoes shoes in Shoes.ListaCarrello)
            {
                if (idShoes == shoes.ID.ToString())
                {
                    Shoes.ListaCarrello.Remove(shoes);
                }
            }
        }

    }
}