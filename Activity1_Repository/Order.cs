using System;
namespace Activity1
{
    public class Order
    {
        // Atributes
        public List<Product> productos;
        public float shipping { get; set; }
        public float discount { get; set; }
        public float totalP => gettotal();
        



        public Order()
        {
            // Constructor
            this.productos = new List<Product>();
        }


        public void addOrder(Product order) {

            if (order.title == "" && order.description == "" && order.price == 0 && order.quantity == 0)
            {
                Console.WriteLine("The product is empty");
            }

            else
            {
                for (int k = 0; k < productos.Count; k++)
                {
                    if (productos[k].codigo == order.codigo)
                    {
                        productos[k].quantity += order.quantity;
                        return;
                    }
                    
                }
                this.productos.Add(order);
            }
            
                
            }
            private float gettotal()
                    {
                        float total = 0;
                        foreach (Product order in this.productos)
                        {
                            total += order.total;
                        }

                        total = total + shipping - discount;
                        return total;

                    }
    }

        

       

        


    }


