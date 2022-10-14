using System;
namespace Trees
{
    internal class Principal
    {

        private static void Main(string[] args)
        {
            Node n1 = new Node();
            n1.data = 7;
            n1.parent = null;

            Node n2 = new Node();
            n2.data = 3;
            n2.parent = n1;

            Node n3 = new Node();
            n3.data = 12;
            n3.parent = n1;

            Node n4 = new Node();
            n4.data = 1;
            n4.parent = n2;

            Node n5 = new Node();
            n5.data = 6;
            n5.parent = n2;

            Node n6 = new Node();
            n6.data = 0;
            n6.parent = n4;

            Node n7 = new Node();
            n7.data = 2;
            n7.parent = n4;

            Node n8 = new Node();
            n8.data = 4;
            n8.parent = n5;

            Node n9 = new Node();
            n9.data = 5;
            n9.parent = n8;

            Node n10 = new Node();
            n10.data = 9;
            n10.parent = n3;

            Node n11 = new Node();
            n11.data = 8;
            n11.parent = n10;

            Node n12 = new Node();
            n12.data = 11;
            n12.parent = n10;

            Node n13 = new Node();
            n13.data = 10;
            n13.parent = n12;

            Node n14 = new Node();
            n14.data = 13;
            n14.parent = n3;

            Node n18 = new Node();
            n18.data = 20;
            n18.parent = n9;


            Node n15 = new Node();
            n15.data = 15;
            n15.parent = n14;

            Node n16 = new Node();
            n16.data = 14;
            n16.parent = n15;



            Tree t1 = new Tree();
            t1.addElement(n1, null);
            t1.addElement(n2, n2.parent);
            t1.addElement(n3, n3.parent);
            t1.addElement(n4, n4.parent);
            t1.addElement(n5, n5.parent);
            t1.addElement(n6, n6.parent);
            t1.addElement(n7, n7.parent);
            t1.addElement(n8, n8.parent);
            t1.addElement(n9, n9.parent);
            t1.addElement(n10, n10.parent);
            t1.addElement(n11, n11.parent);
            t1.addElement(n12, n12.parent);
            t1.addElement(n13, n13.parent);
            t1.addElement(n14, n14.parent);
            t1.addElement(n15, n15.parent);
            t1.addElement(n16, n16.parent);
            t1.addElement(n18, n18.parent);

            //t1.printTree(t1.root, 0);

           

            //t1.removeElement(3);

            

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            t1.printTree(t1.root, 0);

            //t1.BuscarInfo(3);

            //t1.printTree(t1.root, 0);



            //Console.WriteLine("\nInOrder\n");
            //t1.inOrder(t1.root);

            //Console.WriteLine();

            //Console.WriteLine("\nPreOrder\n");
            //t1.preOrder(t1.root);

            //Console.WriteLine();

            //Console.WriteLine("\nPostOrder\n");
            //t1.postOrder(t1.root);










        }

    }
}

