using System;

namespace LinkedList
{
    class Program
    {
        /// <summary>
        /// UC1-Creating simple Linked List 
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Implementation");
            //creating object for collection class linked list 
            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            linkedList.AddFirst(70);
            linkedList.AddFirst(30);
            linkedList.AddFirst(56);
            linkedList.DisplayList();
            Console.WriteLine("Adding last");
            MyLinkedList<int> linkedList1 = new MyLinkedList<int>();
            linkedList1.AddLast(56);
            linkedList1.AddLast(30);
            linkedList1.AddLast(70);
            linkedList1.InsertNextTo(45, 30);
            linkedList1.DisplayList();
            Console.Read();
        }
    }
}
