using System;

namespace LinkedList
{
    class Program
    {
        /// <summary>
        /// UC1-Creating simple Linked List 
        /// UC2- Method to add element in front
        /// UC3- Method to insert element at last. 
        /// UC4- Ability to add between two nodes
        /// UC5- Ability to delete first node
        /// UC6- Ability to delete last node
        /// UC7- Ability to search the Node
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
            linkedList.DeleteLast();
            linkedList.DisplayList();
            Console.Read();
        }
    }
}
