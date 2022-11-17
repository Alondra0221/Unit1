using System;
namespace Project;
using Project;


internal class Principal
{
    



    private static void Main(string[] args)
    {
        ///Extra variables
        List<int> aux1 = new List<int>();
        List<int> aux2 = new List<int>();
        List<int> aux3 = new List<int>();


        ///Tree objects
        Node n1 = new Node();
        Node n2 = new Node();
        Node n3 = new Node();
        Node n4 = new Node();
        Node n5 = new Node();
        Node n6 = new Node();
        Node n7 = new Node();
        Node n8 = new Node();
        Node n10 = new Node();
        Node n11 = new Node();
        Node n12 = new Node();
        Node n14 = new Node();
        Node n15 = new Node();
        tree t1 = new tree();

        //Graph Objects
        GRAFO g1 = new GRAFO();
        VERTEX v0 = new VERTEX();
        VERTEX v1 = new VERTEX();
        VERTEX v2 = new VERTEX();
        VERTEX v3 = new VERTEX();
        VERTEX v4 = new VERTEX();
        VERTEX v5 = new VERTEX();
        VERTEX v6 = new VERTEX();
        VERTEX v7 = new VERTEX();
        VERTEX v8 = new VERTEX();
        VERTEX v9 = new VERTEX();
        VERTEX v10 = new VERTEX();
        EDGE e1 = new EDGE();
        EDGE e2 = new EDGE();
        EDGE e3 = new EDGE();
        EDGE e4 = new EDGE();
        EDGE e5 = new EDGE();
        EDGE e6 = new EDGE();
        EDGE e7 = new EDGE();
        EDGE e8 = new EDGE();
        EDGE e9 = new EDGE();
        EDGE e10 = new EDGE();
        EDGE e11 = new EDGE();
        EDGE e12 = new EDGE();
        EDGE e13 = new EDGE();
        EDGE e14 = new EDGE();
        EDGE e15 = new EDGE();

        int option = 0;
        do
        {

        
        ///Program 
        Console.WriteLine("Welcome to DataStructure.\nWhat you want to check?\n1.Trees\n2.Graphs\n3.Exit");

        option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {

            case 1:

                Console.WriteLine("The tree has 13 nodes available, please insert the data");
                for (int i = 0; i < 13; i++)
                {
                    Console.WriteLine("Node " + (i + 1) + " : ");
                    int nodo = Convert.ToInt32(Console.ReadLine());
                    aux1.Add(nodo);
                }

                ///Tree objects
                
                n1.data = aux1[0];
                n1.parent = null;

                n2.data = aux1[1];
                n2.parent = n1;

                n3.data = aux1[2];
                n3.parent = n1;

                n4.data = aux1[3];
                n4.parent = n2;

                n5.data = aux1[4];
                n5.parent = n2;

                n6.data = aux1[5];
                n6.parent = n4;

                n7.data = aux1[6];
                n7.parent = n4;

                n8.data = aux1[7];
                n8.parent = n5;

                n10.data = aux1[8];
                n10.parent = n3;

                n11.data = aux1[9];
                n11.parent = n10;

                n12.data = aux1[10];
                n12.parent = n10;

                n14.data = aux1[11];
                n14.parent = n3;

                n15.data = aux1[12];
                n15.parent = n14;


                t1.addElement(n1, null);
                t1.addElement(n2, n2.parent);
                t1.addElement(n3, n3.parent);
                t1.addElement(n4, n4.parent);
                t1.addElement(n5, n5.parent);
                t1.addElement(n6, n6.parent);
                t1.addElement(n7, n7.parent);
                t1.addElement(n8, n8.parent);
                t1.addElement(n10, n10.parent);
                t1.addElement(n11, n11.parent);
                t1.addElement(n12, n12.parent);
                t1.addElement(n14, n14.parent);
                t1.addElement(n15, n15.parent);

                int optionT = 0;

                do {
                Console.WriteLine("\nWhat you want to perform?, please choose a number.\n");
                Console.WriteLine("1.Print Tree.\n2.Remove Element\n3.Search Information of a node\n4.Traversing in-Order\n5.Traversing in-PreOrder\n6.Traversing in-PostOrder\n7.Exit");
                optionT = Convert.ToInt32(Console.ReadLine());

                

                    switch (optionT)
                    {
                        case 1:
                            t1.printTree(t1.root, 0);
                            break;
                        case 2:

                            Console.WriteLine("Insert the node that you want to remove");
                            int remove = Convert.ToInt32(Console.ReadLine());
                            t1.removeElement(remove);

                            break;
                        case 3:

                            Console.WriteLine("Insert the node that you want to search");
                            int search = Convert.ToInt32(Console.ReadLine());
                            t1.BuscarInfo(search);

                            break;
                        case 4:
                            t1.inOrder(t1.root);
                            break;
                        case 5:
                            t1.preOrder(t1.root);
                            break;
                        case 6:
                            t1.postOrder(t1.root);
                            break;
                    }



                } while (optionT != 7);

                

                break;

            case 2:

                Console.WriteLine("The graph has 11 vertexes available, please insert the data");
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine("Vertex " + i + " : ");
                    int vertice = Convert.ToInt32(Console.ReadLine());
                    aux2.Add(vertice);
                }

                v0.data = aux2[0]; //p0

                v1.data = aux2[1]; //p1

                v2.data = aux2[2]; //p2

                v3.data = aux2[3]; //p3

                v4.data = aux2[4]; //p4

                v5.data = aux2[5]; //p5

                v6.data = aux2[6]; //p6

                v7.data = aux2[7]; //p7

                v8.data = aux2[8]; //p8

                v9.data = aux2[9]; //p9

                v10.data = aux2[10]; //p10

                g1.insertVertex(v0);
                g1.insertVertex(v1);
                g1.insertVertex(v2);
                g1.insertVertex(v3);
                g1.insertVertex(v4);
                g1.insertVertex(v5);
                g1.insertVertex(v6);
                g1.insertVertex(v7);
                g1.insertVertex(v8);
                g1.insertVertex(v9);
                g1.insertVertex(v10);

                Console.WriteLine("The graph has 15 edges available, please insert the weight");
                for (int j = 0; j < 15; j++)
                {
                    Console.WriteLine("Edge: " + (j+1) + " : ");
                    int arista = Convert.ToInt32(Console.ReadLine());
                    aux3.Add(arista);
                }

                e1.vertex_inicio = v0;
                e1.vertex_final = v1;
                e1.weight = aux3[0];

                e2.vertex_inicio = v0;
                e2.vertex_final = v2;
                e2.weight = aux3[1];

                e3.vertex_inicio = v0;
                e3.vertex_final = v3;
                e3.weight = aux3[2];

                e4.vertex_inicio = v1;
                e4.vertex_final = v4;
                e4.weight = aux3[3];

                e5.vertex_inicio = v1;
                e5.vertex_final = v5;
                e5.weight = aux3[4];

                e6.vertex_inicio = v2;
                e6.vertex_final = v6;
                e6.weight = aux3[5];

                e7.vertex_inicio = v2;
                e7.vertex_final = v7;
                e7.weight = aux3[6];

                e8.vertex_inicio = v3;
                e8.vertex_final = v8;
                e8.weight = aux3[7];

                e9.vertex_inicio = v3;
                e9.vertex_final = v9;
                e9.weight = aux3[8];

                e10.vertex_inicio = v4;
                e10.vertex_final = v10;
                e10.weight = aux3[9];

                e11.vertex_inicio = v5;
                e11.vertex_final = v10;
                e11.weight = aux3[10];

                e12.vertex_inicio = v6;
                e12.vertex_final = v10;
                e12.weight = aux3[11];

                e13.vertex_inicio = v7;
                e13.vertex_final = v10;
                e13.weight = aux3[12];

                e14.vertex_inicio = v8;
                e14.vertex_final = v10;
                e14.weight = aux3[13];

                e15.vertex_inicio = v9;
                e15.vertex_final = v10;
                e15.weight = aux3[14];

                g1.insertEdges(e1, 0, 1);
                g1.insertEdges(e2, 0, 2);
                g1.insertEdges(e3, 0, 3);
                g1.insertEdges(e4, 1, 4);
                g1.insertEdges(e5, 1, 5);
                g1.insertEdges(e6, 2, 6);
                g1.insertEdges(e7, 2, 7);
                g1.insertEdges(e8, 3, 8);
                g1.insertEdges(e9, 3, 9);
                g1.insertEdges(e10, 4, 10);
                g1.insertEdges(e11, 5, 10);
                g1.insertEdges(e12, 6, 10);
                g1.insertEdges(e13, 7, 10);
                g1.insertEdges(e14, 8, 10);
                g1.insertEdges(e15, 9, 10);


                int optionG = 0;

                do
                {
                    Console.WriteLine("\nWhat you want to perform?, please choose a number.\n");
                    Console.WriteLine("1.Print Matrix.\n2.Delete Vertex\n3.Delete Edge\n4.Show the data of the vertexes\n5.Show info of the edges\n6.BFS Traversing\n7.DFS Traversing\n8.Shortest Path\n9.Exit");
                    optionG = Convert.ToInt32(Console.ReadLine());



                    switch (optionG)
                    {
                        case 1:
                            g1.print();
                            break;
                        case 2:

                            Console.WriteLine("Insert the position:");
                            int position = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Insert the vertex:");
                            int v = Convert.ToInt32(Console.ReadLine());

                            VERTEX vertice = g1.searchVertex(v);
                            g1.deleteVertex(vertice, position);

                            break;
                        case 3:

                            Console.WriteLine("Insert the position 1:");
                            int position1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Insert the position 2:");
                            int position2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Insert the initial vertex where is linked:");
                            int edge1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Insert the final vertex where is linked:");
                            int edge2 = Convert.ToInt32(Console.ReadLine());

                            EDGE arista = g1.searchEdges(edge1,edge2);
                            g1.deletEdge(arista, position1, position2);

                            break;
                        case 4:
                            g1.showVertex();
                            break;
                        case 5:
                            g1.showEdges();
                            break;
                        case 6:
                            g1.BFS_travers(v0);
                            break;
                        case 7:
                            g1.DFS_travers(v0);
                            break;
                        case 8:

                            Console.WriteLine("Insert the initial vertex");
                            int vertex1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Insert the final vertex");
                            int vertex2 = Convert.ToInt32(Console.ReadLine());

                            VERTEX ver1 = g1.searchVertex(vertex1);
                            VERTEX ver2 = g1.searchVertex(vertex2);

                            g1.shortest_path(ver1,ver2);
                            break;
                    }
                } while (optionG != 9) ;


                    break;

        }

        } while (option != 3);





    }
}


