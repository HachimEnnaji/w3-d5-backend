using System;
using System.Web.UI;

namespace E_Commerce
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //crea la lista di prodotti
                Shoes.ListaShoes.Clear();
                Shoes s001 = new Shoes();
                s001.ID = 1;
                s001.Name = "Nike Air Max 90";
                s001.Price = 120;
                s001.Brand = "Nike";
                s001.Color = "White";
                s001.Image = "https://static.nike.com/a/videos/t_PDP_1280_v1/f_auto,q_auto:eco,so_2.4/51431284-10fb-43b6-aa82-2a55040f5ea3/scarpa-air-max-90-ltr-ZTZdWM.jpg";
                Shoes.ListaShoes.Add(s001);

                Shoes s002 = new Shoes();
                s002.ID = 2;
                s002.Name = "Adidas Superstar";
                s002.Price = 100;
                s002.Brand = "Adidas";
                s002.Color = "Black";
                s002.Image = "https://www.lillylab.it/wp-content/uploads/2023/02/Adidas-Superstar-Bold-Personalizzate-Total-White-Bande-e-Lacci-Strass-Acquamarina5.jpg";
                Shoes.ListaShoes.Add(s002);

                Shoes s003 = new Shoes();
                s003.ID = 3;
                s003.Name = "Vans Old Skool";
                s003.Price = 80;
                s003.Brand = "Vans";
                s003.Color = "Black";
                s003.Image = "https://i.pinimg.com/originals/91/c5/60/91c56043fb2711df0245c28e36b01459.jpg";
                Shoes.ListaShoes.Add(s003);

                Shoes s004 = new Shoes();
                s004.ID = 4;
                s004.Name = "Converse All Star";
                s004.Price = 70;
                s004.Brand = "Converse";
                s004.Color = "White";
                s004.Image = "https://racoon-lab.it/cdn/shop/products/scarpe-converse-all-star-borchiate-nere_IND.jpg?v=1679929364";
                Shoes.ListaShoes.Add(s004);

                Shoes s005 = new Shoes();
                s005.ID = 5;
                s005.Name = "Puma Suede";
                s005.Price = 90;
                s005.Brand = "Puma";
                s005.Color = "Black";
                s005.Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQG-u81rQ0ouLk74wUSLl6VDxjqnwElUwO50Q&usqp=CAU";
                Shoes.ListaShoes.Add(s005);

                Shoes s006 = new Shoes();
                s006.ID = 6;
                s006.Name = "Reebok Classic";
                s006.Price = 85;
                s006.Brand = "Reebok";
                s006.Color = "White";
                s006.Image = "https://images.asos-media.com/products/reebok-classic-leather-sneakers-in-pelle-bianche/202748351-1-white?$n_640w$&wid=513&fit=constrain";
                Shoes.ListaShoes.Add(s006);

                Shoes s007 = new Shoes();
                s007.ID = 7;
                s007.Name = "New Balance 574";
                s007.Price = 110;
                s007.Brand = "New Balance";
                s007.Color = "Black";
                s007.Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxp63abQMQZqGYXxpT_N4YftGIDBUTYJRtCg&usqp=CAU";
                Shoes.ListaShoes.Add(s007);

                Shoes s008 = new Shoes();
                s008.ID = 8;
                s008.Name = "Fila Disruptor";
                s008.Price = 95;
                s008.Brand = "Fila";
                s008.Color = "White";
                s008.Image = "https://upremium.net/cdn/shop/products/unhPzUKXAUOzT21u0000200729084_1__1_300x.jpg?v=1648027955";
                Shoes.ListaShoes.Add(s008);

                Shoes s009 = new Shoes();
                s009.ID = 9;
                s009.Name = "Asics Gel Lyte";
                s009.Price = 100;
                s009.Brand = "Asics";
                s009.Color = "Black";
                s009.Image = "https://image-cdn.hypb.st/https%3A%2F%2Fhypebeast.com%2Fimage%2F2015%2F06%2Fasics-gel-lyte-iii-white-black-2-1.jpg?cbr=1&q=90";
                Shoes.ListaShoes.Add(s009);

                Shoes s010 = new Shoes();
                s010.ID = 10;
                s010.Name = "Diadora N9000";
                s010.Price = 90;
                s010.Brand = "Diadora";
                s010.Color = "White";
                s010.Image = "https://sneakerbardetroit.com/wp-content/uploads/2016/02/diadora-n9000-white-gum.jpg";
                Shoes.ListaShoes.Add(s010);

                Shoes s011 = new Shoes();
                s011.ID = 11;
                s011.Name = "Lacoste Carnaby";
                s011.Price = 80;
                s011.Brand = "Lacoste";
                s011.Color = "Black";
                s011.Image = "https://images.asos-media.com/products/lacoste-carnaby-sneakers-nere/12055061-1-black?$n_750w$&wid=750&hei=750&fit=crop";
                Shoes.ListaShoes.Add(s011);

                Shoes s012 = new Shoes();
                s012.ID = 12;
                s012.Name = "Le Coq Sportif Omega";
                s012.Price = 85;
                s012.Brand = "Le Coq Sportif";
                s012.Color = "White";
                s012.Image = "https://i.pinimg.com/originals/c5/d3/f6/c5d3f62e785bb2e72f7ad3bf9c8d96b7.jpg";
                Shoes.ListaShoes.Add(s012);

                Shoes s013 = new Shoes();
                s013.ID = 13;
                s013.Name = "Saucony Jazz";
                s013.Price = 95;
                s013.Brand = "Saucony";
                s013.Color = "Black";
                s013.Image = "https://images.asos-media.com/products/saucony-jazz-original-s70368-9-scarpe-da-ginnastica-vintage-nere/8355800-1-black?$n_640w$&wid=513&fit=constrain";
                Shoes.ListaShoes.Add(s013);

                Shoes s014 = new Shoes();
                s014.ID = 14;
                s014.Name = "Etnies Marana";
                s014.Price = 75;
                s014.Brand = "Etnies";
                s014.Color = "White";
                s014.Image = "https://img.eobuwie.cloud/eob_product_656w_656h(7/1/3/4/7134b6da05966821aa6e47fc26b7a523c7aacf08_10_0000300506257_RP.jpg,jpg)/sneakers-etnies-marana-4101000403-white-gum-104.jpg";
                Shoes.ListaShoes.Add(s014);

                Shoes s015 = new Shoes();
                s015.ID = 15;
                s015.Name = "Air Jordan Retro 4";
                s015.Price = 400;
                s015.Brand = "Jordan";
                s015.Color = "Black";
                s015.Image = "https://5.imimg.com/data5/SELLER/Default/2022/5/QJ/AB/HD/96403645/ce630e62-00cf-418b-834f-0ebfae43c64e.jpg";
                Shoes.ListaShoes.Add(s015);

                //aggiorna la griglia con i prodotti
                Repeater1.DataSource = Shoes.ListaShoes;
                Repeater1.DataBind();



            }
        }

        protected void AggiungiACarrello_Click(object sender, EventArgs e)
        {
            // funzione che manda al carrello il prodotto selezionato e lo salva nella sessione

            string idShoes = ((System.Web.UI.WebControls.Button)sender).CommandArgument;
            foreach (Shoes shoes in Shoes.ListaShoes)
            {
                if (idShoes == shoes.ID.ToString())
                {
                    Shoes.ListaCarrello.Add(shoes);
                    Session["ListaCarrello"] = Shoes.ListaCarrello;


                    Response.Redirect("Default");
                }
            }
        }
    }
}