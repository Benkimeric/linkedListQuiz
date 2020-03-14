using System;
using NUnit.Framework;
using System.IO;
using linkedList;


namespace linkedListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void test_node_can_return()
        {
            Node node = new Node("A");
            Assert.AreEqual(node.data, "A");
        }

        [Test]
        public void test_adding_node_to_lis()
        {
            var linkedList = new LinkedList();
            linkedList.addNode("E");
            linkedList.addNode("B");
            Assert.AreEqual(linkedList.head.data, "B");
            Assert.AreEqual(linkedList.head.next.data, "E");
        }

        [Test]
        public void test_can_print_nodes()
        {
            var linkedList = new LinkedList();
            linkedList.addNode("A");
            linkedList.addNode("E");
            linkedList.addNode("E");
            linkedList.printNodesList();
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                linkedList.printNodesList();
                var result = stringWriter.ToString().Trim();
                Assert.AreEqual(result, "E-E-A");
            }

        }

        [Test]
        public void test_remove_nodes()
        {
            var lList = new LinkedList();
            lList.addNode("B");
            lList.addNode("A");
            lList.addNode("B");
            lList.addNode("E");
            lList.addNode("E");
            lList.addNode("B");
            lList.addNode("E");
            lList.deleteRepeatedNodes();
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                lList.printNodesList();
                var result = stringWriter.ToString().Trim();
                Assert.AreEqual(result, "E-B-E-B-A");
            }

        }

    }
}
