using System;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Node[] nodes = new Node[5];
            Node node5 = new Node(5);
            Node node4 = new Node(4,node5);
            Node node3 = new Node(3,node4);
            Node node2 = new Node(2,node3);
            Node node1 = new Node(1,node2);
            PrintList(node1);

        }

        private static void PrintList(Node node5)
        {
            Node node = node5;
            while (true)
            {
                if(node != null)
                {
                    Console.WriteLine(node.num);
                    node = node.nextLink;

                }
                else
                {
                    break;
                }
            }

        }
    }
    public class Node
    {
        public int num;
        public Node nextLink;

        public Node(int i)
        {
            num = i;
        }
        public Node(int i,Node node)
        {
            num = i;
            nextLink = node;
        }
        public void Show()
        {
            Console.WriteLine(num);
        }
        
    }
}
