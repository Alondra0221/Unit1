using System;
namespace Activity1;


internal class Principal
{

    private static void Main(string[] args)
    {


        Product p1 = new Product();
        p1.title = "Pants";
        p1.description = "Baggy";
        p1.price = 100;
        p1.quantity = 2;
        p1.codigo = 001;

        Product p2 = new Product();
        p2.title = "Skirt";
        p2.description = "Small blue skirt";
        p2.price = 250;
        p2.quantity = 5;
        p2.codigo = 002;

        Product p3 = new Product();
        p3.title = "Skirt";
        p3.description = "Small blue skirt";
        p3.price = 250;
        p3.quantity = 2;
        p3.codigo = 002;

        Product p4 = new Product();
        p4.title = "Skirt";
        p4.description = "Small blue skirt";
        p4.price = 250;
        p4.quantity = 2;
        p4.codigo = 002;



        Order[] orden = new Order[20];
        Order ord1 = new Order();

        ord1.addOrder(p1);
        ord1.addOrder(p2);
        ord1.addOrder(p3);
        ord1.shipping = 50;
        ord1.discount = 100;
        Console.WriteLine(" Amount: " + p1.total + "\nDiscount: "+ ord1.discount + "\nShipping: "+ ord1.shipping +"\nYou need to pay: " + ord1.totalP);
        Console.WriteLine(" Amount: " + p2.total + "\nDiscount: " + ord1.discount + "\nShipping: " + ord1.shipping + "\nYou need to pay: " + ord1.totalP);

        
    }
}


