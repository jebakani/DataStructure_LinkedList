using System;
using System.Collections.Generic;

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
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(70);
            linkedList.AddLast(58);
            linkedList.AddLast(30);
            foreach (int i in linkedList)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
