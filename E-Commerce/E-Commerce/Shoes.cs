using System.Collections.Generic;

namespace E_Commerce
{
    public class Shoes
    {
        // Proprietà della classe Shoes
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        // Lista di oggetti Shoes
        public static List<Shoes> ListaShoes = new List<Shoes>();
        public static List<Shoes> ListaCarrello = new List<Shoes>();

    }
}