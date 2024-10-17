// See https://aka.ms/new-console-template for more information
using LearnOopDataStructuresDesignPatterns;

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

Console.ReadLine();
