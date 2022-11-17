using System;
namespace Project
{
    public class tree
    {
        //Atributes

        public Node? root;
        public Node encontrado;
        private int level;

        public tree()
        {
            //Constructor
            this.root = null;
        }

        // Buscar 
        public void addElement(Node Element, Node? Parent)
        {

            if (Parent == null)
            {
                root = Element;
                return;
            }

            buscar(Element.data);

            if (encontrado != null)
            {
                Console.WriteLine("You cant add the data " + Element.data + " because is already storage");
            }

            else if (Parent.left == null)
            {
                Parent.left = Element;
                return;
            }

            else if (Parent.right == null)
            {
                Parent.right = Element;
                return;
            }

            else if (Parent.left != null && Parent.right != null)
            {
                Console.WriteLine("You can't add the data " + Element.data + " because the node is completed");
            }


        }

        //Buscar
        public void BuscarInfo(int dato)
        {
            buscar(dato);

            if (encontrado != null)
            {

                Console.WriteLine("The nodo was found: " + " \nIt's data is: " + encontrado.data);

                if (encontrado.parent != null)
                {
                    Console.WriteLine("The parent is: " + encontrado.parent.data);
                }
                else
                {
                    Console.WriteLine("It doesn't has parent");
                }
                if (encontrado.left != null)
                {
                    Console.WriteLine("The left child is: " + encontrado.left.data);
                }
                else
                {
                    Console.WriteLine("It doesn't has left child");
                }

                if (encontrado.right != null)
                {
                    Console.WriteLine("The right child is: " + encontrado.right.data);
                }
                else
                {
                    Console.WriteLine("It doesn't has right child");
                }
            }

            else
            {
                Console.WriteLine("The node wasn't found");
            }

        }


        public void buscar(int dato)
        {
            bool flag = false;
            Node? aux = root;

            if (aux == null)
            {
                return;
            }
            search(aux, dato, flag);


        }
        private void search(Node? aux, int dato, bool flag)
        {


            if (aux.data != dato && flag == false)
            {
                if (aux.left != null)
                {

                    aux = aux.left;
                    search(aux, dato, flag);
                    aux = aux.parent;
                }

                if (aux.right != null)
                {
                    aux = aux.right;
                    search(aux, dato, flag);
                    aux = aux.parent;
                }


                return;

            }
            else
            {

                flag = true;
                encontrado = aux;
                return;

            }



        }


        public void printTree(Node? r, int c)
        {


            if (r == null) // We validate if the tree is null
            {
                return;
            }



            if (r.right != null)
            {

                printTree(r.right, c + 1);

            }

            for (int i = 0; i < c; i++) //I made this for because it's necesary to leave space btween each node.
            {
                Console.Write("         ");
            }


            Console.WriteLine(r.data);


            if (r.left != null)
            {

                printTree(r.left, c + 1);

            }


        }


        //Buscar
        public void removeElement(int dato)
        {

            buscar(dato);



            if (encontrado != null)
            {

                if (encontrado.parent.left.data == encontrado.data)

                {
                    encontrado.parent.left = null;

                }

                else
                {
                    encontrado.parent.right = null;

                }

            }

            else
            {
                Console.WriteLine("The data is not storage");
            }

        }

        public void inOrder(Node? r)
        {

            if (r != null)
            {
                inOrder(r.left);
                Console.Write(r.data + " ");
                inOrder(r.right);

            }

        }

        public void preOrder(Node? r)
        {
            if (r != null)
            {
                Console.Write(r.data + " ");
                preOrder(r.left);
                preOrder(r.right);

            }
        }

        public void postOrder(Node? r)
        {
            if (r != null)
            {
                postOrder(r.left);
                postOrder(r.right);
                Console.Write(r.data + " ");
            }


        }
    }
}


