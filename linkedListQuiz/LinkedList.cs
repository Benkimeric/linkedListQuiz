using System;
namespace linkedList
{
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            this.head = null;
        }

        // Adds new node at the beginning
        public void addNode(string data)
        {

            var newNode = new Node(data);
            newNode.next = this.head;
            this.head = newNode;
        }

        public void printNodesList()
        {
            Node current = this.head;
            while (current != null)
            {
                Console.Write(current.data);
                if (current.next != null)
                {
                    Console.Write("-");
                }
                current = current.next;
            }
        }

        public void deleteRepeatedNodes()
        {
            var listHelper = new ListHelper();
            listHelper.removeRepeated(this.head);
        }
    }
}