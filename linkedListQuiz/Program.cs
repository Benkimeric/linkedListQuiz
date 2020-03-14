using System;

namespace linkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var lList = new LinkedList();
            lList.addNode("B");
            lList.addNode("A");
            lList.addNode("B");
            lList.addNode("E");
            lList.addNode("E");
            lList.addNode("B");
            lList.addNode("E");
            Console.WriteLine("Input values are:----->");
            lList.printNodesList();
            lList.deleteRepeatedNodes();
            Console.WriteLine();
            Console.WriteLine("Values after calling the method:----->");
            lList.printNodesList();
        }
    }
}
