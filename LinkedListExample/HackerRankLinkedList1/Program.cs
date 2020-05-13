using System;
using System.Collections.Generic;

namespace HackerRankLinkedList1
{
    class Program
    {
        class Node
        {
            public Node(int data, Node nextNode)
            {
                Data = data;
                NextNode = nextNode;
            }
            public int Data { get; set; }
            public Node NextNode { get; set; }
            public static int Length(Node head)
            {
                Node node = head;
                int i = 0;
                while (node != null)
                {
                    i++;
                    node = node.NextNode;
                }
                return i;
            }
            public static void PrintList(Node firstNode)
            {
                int position = 0;
                Node node = firstNode;
                while (node != null)
                {

                    Console.WriteLine($"Postion -- {position}, Data -- {node.Data}, Has next node {node.NextNode != null}");
                    node = node.NextNode;
                    position++;

                }

            }
            public static Node CreateAndAddNodes(int n, int[] dataForNodes)
            {
                Node FirstNode = null;
                for (int i = n - 1; i >= 0; i--)
                {
                    int data = dataForNodes[i];
                    FirstNode = new Node(data, FirstNode);
                }
                return FirstNode;
            }
            public static Node insertNodeAtPositionOld(Node head, int data, int position)
            {
                Node nodeToCheck = head;
                List<int> dataForNodesList = new List<int>();
                int i = 0;
                while (nodeToCheck != null)
                {
                    if (position == i)
                    {
                        Console.WriteLine($"position to add {i}");
                        dataForNodesList.Add(data);
                        dataForNodesList.Add(nodeToCheck.Data);
                        nodeToCheck.Data = data;
                    }
                    else
                    {
                        dataForNodesList.Add(nodeToCheck.Data);
                    }
                    nodeToCheck = nodeToCheck.NextNode;
                    i++;
                }
                int[] dataForNodes = dataForNodesList.ToArray();
                Node node = Node.CreateAndAddNodes(dataForNodes.Length, dataForNodes);
                return node;

            }
            public static Node InsetAtTail(Node head, int data)
            {
                var tmp = new Node(data, null);
                if (head == null)
                {
                    head = tmp;
                    return head;
                }
                var current = head;
                while (current.NextNode != null)
                {
                    current = current.NextNode;
                }
                current.NextNode = tmp;
                return head;


            }

            public static Node insertNodeAtPosition(Node head, int data, int position)
            {
                var headNode = head;
                for (; position >= 0; position--)
                {
                    if (position == 1)
                    {
                        Node newNode = new Node(data, head.NextNode);
                        head.NextNode = newNode;
                        break;
                    }
                    head = head.NextNode;
                }
                return headNode;
            }
            public static Node insertNodeAtHead(Node head, int data, int position)
            {
                var headNode = head;
                for (; position >= 0; position--)
                {
                    if (position == 1)
                    {
                        Node newNode = new Node(data, head.NextNode);
                        head.NextNode = newNode;
                        break;
                    }
                    head = head.NextNode;
                }
                return headNode;
            }
        }
        public class DoublyLinkedListNode
        {
            public int data;
            public DoublyLinkedListNode next;
            public DoublyLinkedListNode prev;

            public DoublyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
                this.prev = null;
            }

        }
        class DoublyLinkedList
        {
            public DoublyLinkedListNode head;
            public DoublyLinkedListNode tail;

            public DoublyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                    node.prev = this.tail;
                }

                this.tail = node;
            }
            public static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep)
            {
                while (node != null)
                {
                    Console.Write(node.data);

                    node = node.next;

                    if (node != null)
                    {
                        Console.Write(sep);
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            do
            {
                // Examples runing
                //Console.WriteLine("Enter n");
                //int n = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine($"Enter {n} numbers");
                //int[] dataForNodes = new int[n];
                //for (int i = 0; i < n; i++)
                //{
                //    dataForNodes[i] = Convert.ToInt32(Console.ReadLine());
                //}
                //Node FirstNode = Node.CreateAndAddNodes(n, dataForNodes);
                //Console.WriteLine("Enter node data");
                //int nodeToAddData = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter node position");
                //int nodeToAddPosition = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("\n");
                //Node.PrintList(FirstNode);
                //Console.WriteLine("\n");
                ////Node newNode = Node.insertNodeAtPosition(FirstNode, nodeToAddData, nodeToAddPosition);
                //Node newNode = Node.InsetAtTail(FirstNode, nodeToAddData);
                //Node.PrintList(newNode);

                //int t = Convert.ToInt32(Console.ReadLine());

                //for (int tItr = 0; tItr < t; tItr++)
                //{
                //    DoublyLinkedList llist = new DoublyLinkedList();

                //    int llistCount = Convert.ToInt32(Console.ReadLine());

                //    for (int i = 0; i < llistCount; i++)
                //    {
                //        int llistItem = Convert.ToInt32(Console.ReadLine());
                //        llist.InsertNode(llistItem);
                //    }

                //    int data = Convert.ToInt32(Console.ReadLine());

                //    DoublyLinkedListNode llist1 = DoublyLinkedListNode.sortedInsert(llist.head, data);

                //    DoublyLinkedList.PrintDoublyLinkedList(llist1, " ");
                //    Console.WriteLine();
                //}



            } while (Console.ReadKey().Key != ConsoleKey.C);
        }

    }
}
