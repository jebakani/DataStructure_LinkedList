using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        MyLinkedList<int> linkedList;

        [TestInitialize]
        public void SetUp()
        {
            linkedList = new MyLinkedList<int>();
        }
        [TestMethod]
        public void SearchTest1()
        {
            //Assign
            linkedList.AddFirst(70);
            linkedList.AddFirst(30);
            linkedList.AddFirst(56);
            //act
            int actual=linkedList.SearchNode(30);
            int expected = 1;
            //Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}
