using System;

namespace E_Commerce
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { //al caricamento della pagina aggiorna la griglia con i prodotti presenti nel carrello e il totale
            string idShoes = Request.QueryString["IDShoes"];

            foreach (Shoes shoes in Shoes.ListaShoes)
            {
                //se l'id del prodotto è uguale a quello passato nella query string allora aggiorna la pagina con i dettagli del prodotto
                if (idShoes == shoes.ID.ToString())
                {
                    ImageDetail.ImageUrl = shoes.Image;
                    LabelCardTitle.Text = shoes.Name;
                    LabelCardPrezzo.Text = shoes.Price.ToString("c2");
                    LabelCardDescription.Text = shoes.Brand;

                }
            }
        }
    }
}