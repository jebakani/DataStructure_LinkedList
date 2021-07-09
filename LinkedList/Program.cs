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
            Console.WriteLine("Before Deleting");
            linkedList.DisplayList();
            Console.WriteLine("After deleting");
            linkedList.DeleteFirst();
            linkedList.DisplayList();
            Console.Read();
        }
    }
}
