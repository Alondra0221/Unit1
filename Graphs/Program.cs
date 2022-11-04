using System;
namespace Activity1;
using GRAFOS;

internal class Principal
{

    private static void Main(string[] args)
    {
        GRAFO g1 = new GRAFO();


        VERTEX v0 = new VERTEX();

        v0.data = 0; //p0


        VERTEX v1 = new VERTEX();

        v1.data = 1; //p1

        VERTEX v2 = new VERTEX();

        v2.data = 2; //p2

        VERTEX v3 = new VERTEX();

        v3.data = 3; //p3

        VERTEX v4 = new VERTEX();

        v4.data = 4; //p4

        VERTEX v5 = new VERTEX();
        v5.data = 5; //p5

        VERTEX v6 = new VERTEX();
        v6.data = 6; //p6

        VERTEX v7 = new VERTEX();
        v7.data = 7; //p7

        VERTEX v8 = new VERTEX();
        v8.data = 8; //p8

        VERTEX v9 = new VERTEX();
        v9.data = 9; //p9

        VERTEX v10 = new VERTEX();
        v10.data = 10; //p10


        EDGE e1 = new EDGE();

        e1.vertex_inicio = v0;
        e1.vertex_final = v1;
        e1.weight = 3;


        EDGE e2 = new EDGE();

        e2.vertex_inicio = v0;
        e2.vertex_final = v2;
        e2.weight = 2;


        EDGE e3 = new EDGE();

        e3.vertex_inicio = v0;
        e3.vertex_final = v3;
        e3.weight = 1;

        EDGE e4 = new EDGE();

        e4.vertex_inicio = v1;
        e4.vertex_final = v4;
        e4.weight = 4;

        EDGE e5 = new EDGE();

        e5.vertex_inicio = v1;
        e5.vertex_final = v5;
        e5.weight = 6;

        EDGE e6 = new EDGE();

        e6.vertex_inicio = v2;
        e6.vertex_final = v6;
        e6.weight = 3;

        EDGE e7 = new EDGE();

        e7.vertex_inicio = v2;
        e7.vertex_final = v7;
        e7.weight = 5;

        EDGE e8 = new EDGE();

        e8.vertex_inicio = v3;
        e8.vertex_final = v8;
        e8.weight = 2;

        EDGE e9 = new EDGE();

        e9.vertex_inicio = v3;
        e9.vertex_final = v9;
        e9.weight = 4;

        EDGE e10 = new EDGE();

        e10.vertex_inicio = v4;
        e10.vertex_final = v10;
        e10.weight = 8;

        EDGE e11 = new EDGE();

        e11.vertex_inicio = v5;
        e11.vertex_final = v10;
        e11.weight = 10;

        EDGE e12 = new EDGE();

        e12.vertex_inicio = v6;
        e12.vertex_final = v10;
        e12.weight = 9;

        EDGE e13 = new EDGE();

        e13.vertex_inicio = v7;
        e13.vertex_final = v10;
        e13.weight = 7;

        EDGE e14 = new EDGE();

        e14.vertex_inicio = v8;
        e14.vertex_final = v10;
        e14.weight = 30;

        EDGE e15 = new EDGE();

        e15.vertex_inicio = v9;
        e15.vertex_final = v10;
        e15.weight = 5;

        EDGE e16 = new EDGE();

        e16.vertex_inicio = v9;
        e16.vertex_final = v8;
        e16.weight = 3;

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

        //Console.WriteLine("The matriz without edges or conections");
        //Console.WriteLine("");
        //g1.print();



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
        g1.insertEdges(e16, 9, 8);


        //Console.WriteLine("The matriz with the edges");
        //Console.WriteLine("");
        //g1.print();

        //g1.deleteVertex(v6,6);
        //Console.WriteLine("The vertex was deleted");
        //Console.WriteLine("");
        //g1.print();

        //g1.deletEdge(e3, 1, 3);
        //g1.print();

        //Console.WriteLine("");
        //g1.showVertex();
        //Console.WriteLine("");
        //g1.showEdges();

        //g1.BFS_travers(v0);
        //Console.WriteLine("");
        //g1.DFS_travers(v0);

        g1.shortest_path(v0,v10);


    }

}
