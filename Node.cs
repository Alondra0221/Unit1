using System;
namespace Trees
{
    public class Node
    {
        //Atributes
        public int data { get; set; }
        public Node? parent { get; set; }
        public Node? right;
        public Node? left;


        public Node()
        {
            //Constructor
            this.data = 0;
            this.right = null;
            this.left = null;
            this.parent = null;
        }
    }

}