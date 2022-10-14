using System;
namespace Activity1
{

    public class Product
    {
        //Atributes

        public string title { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
        public int codigo { get; set; }
        public float total => (price * quantity);


        public Product()
        {
            //Constructo
            this.title = "";
            this.description = "";
            this.price = 0;
            this.quantity = 0;

        }
        
        


    }



}


