// See https://aka.ms/new-console-template for more information
using LearnOopDataStructuresDesignPatterns;
using System.Collections;
using System.Collections.Concurrent;

Console.WriteLine("Hello, World!");

//Extension mentiod
var result = "abc".IsNullOrEmpty();
var isEven = 5.IsEven();
int? number = null;
var isNullNumber = number.IsNull();

//Delegate
Process process = new Process();
process.ProcessCompleted += Process_ProcessCompleted;
void Process_ProcessCompleted()
{}
process.Start();

//Linked List
LinkedList linkedList = new LinkedList();
linkedList.Add(1);
linkedList.Add(2);
linkedList.Add(3);
linkedList.Print();

// Stack
LinkedListStack<int> stack = new LinkedListStack<int>();
// Push elements onto the stack
stack.Push(10);
stack.Push(20);
stack.Push(30);

// Peek at the top element
Console.WriteLine($"Top element is: {stack.Peek()}");

// Pop elements from the stack
stack.Pop();
stack.Pop();

// Check the top element again
Console.WriteLine($"Top element after pops is: {stack.Peek()}");


string firstName = "tahir";
Console.WriteLine($" HashCode:  {firstName.GetHashCode()}");

Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

//hashmap
CustomHashTable hashTable = new CustomHashTable(3);
hashTable.Insert("Alice", 25);
hashTable.Insert("Bob", 30);
hashTable.Insert("Charlie", 35);
Console.WriteLine("Alice's age: " + hashTable.Get("Alice"));  // Output: 25
Console.WriteLine("Bob's age: " + hashTable.Get("Bob"));      // Output: 30

//Dictationary
var dictionary = new Dictionary<string, int>();
dictionary["apple"] = 1;
int value = dictionary["apple"]; // Fast access using key

//Hashset just unique values
var hashSet = new HashSet<int>();
hashSet.Add(1);
hashSet.Add(2);
bool contains = hashSet.Contains(2); // Fast lookup

//ConcurrentDicationary Threadsafe
var concurrentDict = new ConcurrentDictionary<string, int>();
concurrentDict.TryAdd("key1", 100);
concurrentDict.TryUpdate("key1", 200, 100);

//Hashtable
var hashtable = new Hashtable();
hashtable["apple"] = 1;
int valuehashtable = (int)hashtable["apple"]; // Requires casting

//Binar Tree
// Create a binary tree and insert nodes
Console.WriteLine("\n---Binary Tree----:");
BinaryTree tree = new BinaryTree();
//tree.Insert(50);
//tree.Insert(30);
//tree.Insert(70);
//tree.Insert(20);
//tree.Insert(40);
//tree.Insert(60);
//tree.Insert(80);

tree.Insert(1);
tree.Insert(2);
tree.Insert(3);
tree.Insert(4);
tree.Insert(5);
tree.Insert(6);
tree.Insert(7);

Console.WriteLine("In-Order Traversal:");
tree.InOrderTraversal(tree.Root);

Console.WriteLine("\nPre-Order Traversal:");
tree.PreOrderTraversal(tree.Root);

Console.WriteLine("\nPost-Order Traversal:");
tree.PostOrderTraversal(tree.Root);

//50
///    \
//     30      70
//    /  \    /  \
//   20   40  60  80


Console.WriteLine("\n\n---Binary Search Tree----:");
// Create a binary search tree and insert nodes
BinarySearchTree bst = new BinarySearchTree();
bst.Insert(50);
bst.Insert(30);
bst.Insert(70);
bst.Insert(20);
bst.Insert(40);
bst.Insert(60);
bst.Insert(80);

Console.WriteLine("In-Order Traversal:");
bst.InOrderTraversal(bst.Root); // Outputs: 20 30 40 50 60 70 80

// Search for a value in the BST
Console.WriteLine("\nSearch for 40: " + bst.Search(40)); // Outputs: true
Console.WriteLine("Search for 90: " + bst.Search(90)); // Outputs: false


Console.ReadLine();
