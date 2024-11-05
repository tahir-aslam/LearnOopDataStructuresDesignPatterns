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
            //O(n)
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

        //Insert a new node at the beggining
        public void Insert(int data)
        {
            //0(1)
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        //Remove node

        // Print all nodes
        public void Print()
        {
            //(O(n))
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

    //Stacks

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedListStack<T>
    {
        private Node<T> top;

        public LinkedListStack()
        {
            top = null;
        }

        // Push operation - Adds an element to the top of the stack
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = top;  // Link the new node to the previous top
            top = newNode;  // Make the new node the new top
            Console.WriteLine($"{data} pushed onto the stack.");
        }

        // Pop operation - Removes and returns the top element
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty. Cannot perform pop operation.");
            }

            T value = top.Data;
            top = top.Next;  // Move top to the next node
            Console.WriteLine($"{value} popped from the stack.");
            return value;
        }

        // Peek operation - Returns the top element without removing it
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return top.Data;
        }

        // IsEmpty operation - Checks if the stack is empty
        public bool IsEmpty()
        {
            return top == null;
        }

        // Print the stack contents
        public void PrintStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Node<T> currentNode = top;
            Console.WriteLine("Stack contents (from top to bottom):");
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
    }

    //Queue
    public class CustomQueue<T>
    {
        private Node<T> head; // Front of the queue
        private Node<T> tail; // Rear of the queue
        private int size;     // Number of elements in the queue

        // Constructor
        public CustomQueue()
        {
            head = null;
            tail = null;
            size = 0;
        }

        // Enqueue: Add an element to the rear of the queue
        public void Enqueue(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (tail == null) // If the queue is empty
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode; // Link the old tail to the new node
                tail = newNode;      // Update the tail
            }

            size++;
        }

        // Dequeue: Remove and return the front element from the queue
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T frontValue = head.Data;
            head = head.Next; // Move the head to the next node

            if (head == null) // If the queue is now empty
            {
                tail = null; // Reset the tail as well
            }

            size--;
            return frontValue;
        }

        // Peek: Return the front element without removing it
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return head.Data;
        }

        // IsEmpty: Check if the queue is empty
        public bool IsEmpty()
        {
            return head == null;
        }

        // Size: Get the number of elements in the queue
        public int Size()
        {
            return size;
        }

        // Display the queue (for testing purposes)
        public void DisplayQueue()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    //HashMap
    public class CustomHashTable
    {
        public class Node
        {
            public string Key { get; set; }
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(string key, int value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        private readonly int size;
        private readonly Node[] buckets;

        public CustomHashTable(int size)
        {
            this.size = size;
            buckets = new Node[size];  // Initialize the buckets (array of linked lists)
        }

        // Hash function to convert key to index
        private int GetBucketIndex(string key)
        {
            int hashCode = key.GetHashCode();    // Get the hash code of the string key
            int index = Math.Abs(hashCode % size);  // Use modulus to get an index within the array size
            return index;
        }

        // Insert or update a key-value pair in the hash table
        public void Insert(string key, int value)
        {
            int index = GetBucketIndex(key);   // Get the bucket index for the key
            Node head = buckets[index];        // Get the head of the linked list at that index

            // Check if the key already exists, if so, update the value
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    head.Value = value;  // Update the existing value
                    return;
                }
                head = head.Next;  // Move to the next node in the linked list
            }

            // Key does not exist, insert new node at the head of the linked list
            Node newNode = new Node(key, value);
            newNode.Next = buckets[index];  // Point the new node to the current head
            buckets[index] = newNode;       // Make the new node the new head
        }

        // Retrieve the value associated with the given key
        public int Get(string key)
        {
            int index = GetBucketIndex(key);   // Get the bucket index for the key
            Node head = buckets[index];        // Get the head of the linked list at that index

            // Search for the key in the linked list
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    return head.Value;  // Return the associated value99999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999++-9
                }
                head = head.Next;  // Move to the next node in the list
            }

            throw new Exception("Key not found");  // If key not found, throw an exception
        }

        // Remove the key-value pair for the given key
        public void Remove(string key)
        {
            int index = GetBucketIndex(key);   // Get the bucket index for the key
            Node head = buckets[index];        // Get the head of the linked list at that index
            Node previous = null;

            // Search for the key in the linked list
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    if (previous == null)
                    {
                        // Key is at the head, so update the head to the next node
                        buckets[index] = head.Next;
                    }
                    else
                    {
                        // Bypass the node to remove it
                        previous.Next = head.Next;
                    }
                    return;
                }


                previous = head;

                throw new Exception("Key not found");
            }
        }

    }

    //Binary Tree
    public class BinaryTree
    {
        public class TreeNode
        {
            public int Value;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        public TreeNode Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Insert a node into the binary tree
        public void Insert(int value)
        {
            Root = InsertRecursively(Root, value);
        }

        private TreeNode InsertRecursively(TreeNode node, int value)
        {
            if (node == null)
            {
                return new TreeNode(value);
            }

            if (value < node.Value)
            {
                node.Left = InsertRecursively(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = InsertRecursively(node.Right, value);
            }

            return node;
        }

        // In-Order Traversal: Left -> Root -> Right
        public void InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }
        }

        // Pre-Order Traversal: Root -> Left -> Right
        public void PreOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        // Post-Order Traversal: Left -> Right -> Root
        public void PostOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.Write(node.Value + " ");
            }
        }
    }

    //Binary Search Tree
    public class BinarySearchTree
    {
        public class TreeNode
        {
            public int Value;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        public TreeNode Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        // Insert a node into the BST
        public void Insert(int value)
        {
            Root = InsertRecursively(Root, value);
        }

        private TreeNode InsertRecursively(TreeNode node, int value)
        {
            if (node == null)
            {
                return new TreeNode(value);
            }

            if (value < node.Value)
            {
                node.Left = InsertRecursively(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = InsertRecursively(node.Right, value);
            }

            return node;
        }

        // Search for a value in the BST
        public bool Search(int value)
        {
            return SearchRecursively(Root, value);
        }

        private bool SearchRecursively(TreeNode node, int value)
        {
            if (node == null)
            {
                return false;
            }

            if (value == node.Value)
            {
                return true;
            }
            else if (value < node.Value)
            {
                return SearchRecursively(node.Left, value);
            }
            else
            {
                return SearchRecursively(node.Right, value);
            }
        }

        // In-Order Traversal: Left -> Root -> Right (Sorted order for BST)
        public void InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }
        }
    }
}


