using System;
using System.Collections.Generic;

//namespace HackerRank3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

class Program
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
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

    // Complete the insertNodeAtPosition function below.


    //    var headNode = head;
    //        for (; position >= 0; position--)
    //        {
    //            if (position == 1)
    //            {
    //                SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
    //    newNode.next = head.next;
    //                head.next = newNode;
    //                break;
    //            }
    //head = head.next;
    //        }
    //        return headNode;

    /*
    * For your reference:
    *
    * SinglyLinkedListNode {
    *     int data;
    *     SinglyLinkedListNode next;
    * }
    *
    */


    static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
    {
        SinglyLinkedListNode node = head;
        int i = 0;
        while (head != null)
        {
            if (i == position - 1)
            {
                SinglyLinkedListNode nodeToAdd = new SinglyLinkedListNode(data);
                nodeToAdd.next = head.next;
                head.next = nodeToAdd;
            }
            head = head.next;
            i++;
        }
        //List<int> arr = new List<int>(); 
        //while(head!= null)
        //{
        //    arr.Add(head.data);
        //    head = head.next;
        //}
        //arr.Add(data);
        //Array.Sort(arr.ToArray());

        return node;

    }

    static void Main(string[] args)
    {
        SinglyLinkedList llist = new SinglyLinkedList();

        int llistCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < llistCount; i++)
        {
            int llistItem = Convert.ToInt32(Console.ReadLine());
            llist.InsertNode(llistItem);
        }

        int data = Convert.ToInt32(Console.ReadLine());

        int position = Convert.ToInt32(Console.ReadLine());
        PrintSinglyLinkedList(llist.head, " ");
        Console.WriteLine();

        SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

        PrintSinglyLinkedList(llist_head, " ");
        Console.WriteLine();

    }
}
