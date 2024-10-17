using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOopDataStructuresDesignPatterns
{
    internal class DataStructtures
    {
    }

    //Linked List
    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        // Insert a new node at the end
        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        // Print all nodes
        public void Print()
        {
            Console.WriteLine("Linked List");
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }

    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
