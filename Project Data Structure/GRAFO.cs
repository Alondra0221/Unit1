using System;
namespace Project
{
	public class GRAFO
	{
        //atributes
        private List<VERTEX> vertexes;
        private List<EDGE> edges;
        private List<List<int>> listas;
        private List<VERTEX> visitados;
        private List<VERTEX> visitados2;
        private List<VERTEX> visitados3;
        private List<EDGE> iguales;
        private int aux;
        private VERTEX v;

        public GRAFO()
		{
            //constructor
            this.vertexes = new List<VERTEX>();
            this.edges = new List<EDGE>();
            this.listas = new List<List<int>>();
            this.visitados = new List<VERTEX>();
            this.visitados2 = new List<VERTEX>();
            this.visitados3 = new List<VERTEX>();
            this.iguales = new List<EDGE>();
        }


        public void insertVertex(VERTEX v)
        {

            vertexes.Add(v);

            listas.Add(new List<int>());

            for (int i = 0; i < (listas.Count - 1); i++)
            {
                listas[i].Add(0);
                listas[listas.Count - 1].Add(0);

            }

            listas[listas.Count - 1].Add(0);


        }

        public void BFS_travers(VERTEX inicio)
        {
            visitados.Add(inicio);
            for (int i = 0; i < visitados.Count; i++)
            {
                BFS_recorrer(visitados[i]);
            }

            printBFS();
        }

        private void BFS_recorrer(VERTEX referencia)
        {
            Boolean bandera = false;

            for (int i = 0; i < edges.Count; i++)
            {
                if (edges[i].vertex_inicio.data == referencia.data)
                {
                    bandera = BFS_check(edges[i].vertex_final);
                    if (bandera == false)
                    {
                        visitados.Add(edges[i].vertex_final);
                    }

                }
            }

        }

        private Boolean BFS_check(VERTEX comparar)
        {

            Boolean bandera = false;
            for (int j = 0; j < visitados.Count; j++)
            {
                if (comparar.data == visitados[j].data)
                {
                    bandera = true;
                    return bandera;
                }
            }
            return bandera;
        }


        private void printBFS()
        {
            Console.WriteLine("BFS traversing:");
            Console.WriteLine("");
            for (int j = 0; j < visitados.Count; j++)
            {
                Console.Write(visitados[j].data + " ");
            }

        }


        public void DFS_travers(VERTEX root)
        {
            visitados2.Add(root);
            DFS_recorrer(root);
            printDFS();

        }


        private void DFS_recorrer(VERTEX root)
        {
            Boolean bandera = false;

            for (int i = 0; i < edges.Count; i++)
            {
                if (edges[i].vertex_inicio.data == root.data)
                {
                    bandera = DFS_check(edges[i].vertex_final);

                    if (bandera == false)
                    {
                        visitados2.Add(edges[i].vertex_final);

                    }

                    DFS_recorrer(edges[i].vertex_final);

                }

            }
        }

        private Boolean DFS_check(VERTEX compare)
        {

            Boolean bandera = false;
            for (int j = 0; j < visitados2.Count; j++)
            {
                if (compare.data == visitados2[j].data)
                {
                    bandera = true;
                    return bandera;
                }
            }
            return bandera;
        }


        private void printDFS()
        {
            Console.WriteLine("");
            Console.WriteLine("DFS traversing:");
            Console.WriteLine("");

            for (int j = visitados2.Count - 1; j >= 0; j--) //backtraking
            {
                Console.Write(visitados2[j].data + " ");

            }

            //for (int j = 0; j < visitados2.Count; j++)
            //{
            //Console.Write(visitados2[j].data + " ");
            //}

        }



        public void deleteVertex(VERTEX v, int p1)
        {
            vertexes.Remove(v);

            for (int i = 0; i < listas.Count; i++)
            {
                listas[i][p1] = 0;
                listas[p1][i] = 0;

            }


        }


        public void insertEdges(EDGE e, int p1, int p2)
        {
            edges.Add(e);
            listas[p1][p2] = 1;
        }


        public void deletEdge(EDGE e, int p1, int p2)
        {
            edges.Remove(e);
            listas[p1][p2] = 0;

        }


        public void print()
        {
            for (int i = 0; i < listas.Count; i++)
            {
                for (int j = 0; j < listas.Count; j++)
                {
                    Console.Write(listas[i][j] + " ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine();
        }


        public void showVertex()
        {
            Console.WriteLine("The data of my vertexes");
            for (int i = 0; i < vertexes.Count; i++)
            {
                Console.Write(vertexes[i].data + ", ");
            }
        }

        public void showEdges()
        {
            Console.WriteLine();
            for (int i = 0; i < edges.Count; i++)
            {
                Console.WriteLine("The edge : " + (i + 1));
                Console.WriteLine("Has an initial vertex: " + edges[i].vertex_inicio.data);
                Console.WriteLine("Has a final vertex: " + edges[i].vertex_final.data);
                Console.WriteLine("Its weight is: " + edges[i].weight);
                Console.WriteLine();

            }


        }



        public void shortest_path(VERTEX inicio, VERTEX final)
        {

            if (visitados3.Count== 0)
            {
                visitados3.Add(inicio);

            }

            else {
                visitados3.Clear();
                visitados3.Add(inicio);
            }
            
            

            for (int i = 0; i < visitados3.Count; i++)
            {
                if (visitados3[i].data == final.data)
                {
                    print_path();
                    Console.WriteLine("");
                }

                else
                {
                    search(visitados3[i]);
                }
            }

        }

        private void search(VERTEX point)
        {
            iguales.Clear();

            for (int i = 0; i < edges.Count; i++)
            {

                if (edges[i].vertex_inicio.data == point.data)
                {
                    //Console.WriteLine(edges[i].vertex_final.data);
                    iguales.Add(edges[i]);
                }
            }

            aux = 10000;

            for (int j = 0; j < iguales.Count; j++)
            {

                if (iguales[j].weight < aux)
                {
                    aux = iguales[j].weight;
                    v = iguales[j].vertex_final;
                }
            }
           
            visitados3.Add(v);

        }

        private void print_path()
        {
            Console.WriteLine("");
            Console.WriteLine("Shortest path:");
            Console.WriteLine("");

            for(int i =0; i<visitados3.Count; i++)
            {
                Console.Write(visitados3[i].data + " ");
            }
        }


        public VERTEX  searchVertex(int number)
        {
            for (int i = 0; i<vertexes.Count; i++)
            {
                if (vertexes[i].data == number)
                {
                    return vertexes[i];
                }
            }
            return null;

        }

        public EDGE searchEdges(int number1, int number2)
        {
            for (int i = 0; i < edges.Count; i++)
            {
                if (edges[i].vertex_inicio.data == number1 && edges[i].vertex_final.data==number2)
                {
                    return edges[i];
                }
            }
            return null;

        }


    }
}

