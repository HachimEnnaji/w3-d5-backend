using System;
using System.Web.UI;

namespace E_Commerce
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //al caricamento della pagina aggiorna la griglia con i prodotti presenti nel carrello e il totale
            string path = Request.Url.LocalPath;
            //se si trova in carrello.aspx aggiorna la griglia con i prodotti presenti nel carrello e il totale
            if (path == "/Dettagli")
            {
                LabelCarrelloAggiungi.Visible = true;
            }
            LabelCarrelloNumeroArticoli.Text = Shoes.ListaCarrello.Count.ToString();
            int prezzoCarrelloTotale = 0;
            foreach (Shoes shoes in Shoes.ListaCarrello)
            {
                prezzoCarrelloTotale += shoes.Price;
            }
            LabelCarrelloTotale.Text = prezzoCarrelloTotale.ToString() + " €";

        }

        //funzione che manda al carrello il prodotto selezionato e lo salva nella sessione
        protected void LabelCarrelloAggiungi_Click(object sender, EventArgs e)
        {
            // funzione che manda al carrello il prodotto selezionato 
            string idShoes = Request.QueryString["IDShoes"];
            //se l'id del prodotto è uguale a quello passato nella query string allora aggiorna la pagina con i dettagli del prodotto
            foreach (Shoes shoes in Shoes.ListaShoes)
            {
                if (idShoes == shoes.ID.ToString())
                {
                    Shoes.ListaCarrello.Add(shoes);
                    LabelCarrelloNumeroArticoli.Text = (int.Parse(LabelCarrelloNumeroArticoli.Text) + 1).ToString();
                    // prendo totale carrello tolgo il simbolo dell'eurpo e lo converto in intero
                    // poi aggiungo il prezzo del prodotto selezionato e lo aggiorno aggiungendo il simbolo dell'euro
                    int prezzoCarrelloTotale = int.Parse(LabelCarrelloTotale.Text.Replace(" €", ""));

                    prezzoCarrelloTotale += shoes.Price;

                    LabelCarrelloTotale.Text = prezzoCarrelloTotale.ToString() + " €";
                }
            }
        }

        //funzione che svuota il carrello
        protected void ResettaCarrello_Click(object sender, EventArgs e)
        {

            Shoes.ListaCarrello.Clear();
            LabelCarrelloTotale.Text = "0 €";
            LabelCarrelloNumeroArticoli.Text = "0";
            //se si trova in carrello.aspx rimanda alla stessa pagina per aggiornare la griglia altrimenti resta nella pagina corrente
            if (Request.Url.LocalPath == "/Carrello")
            {
                Response.Redirect("Carrello.aspx");
            }
        }
    }
}