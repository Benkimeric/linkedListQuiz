using System;
namespace linkedList
{
    public class ListHelper
    {
        public void removeRepeated(Node head)
        {
            Node current = head;
            while (current != null && current.next != null)
            {
                Node temp = current;
                int count = 1;
                while (temp != null && temp.next != null)
                {
                    if (current.data == temp.next.data)
                    {
                        count = count + 1;
                    }
                    if (count > 2 && current.data == temp.next.data)
                    {
                        temp.next = temp.next.next;
                    }
                    temp = temp.next;
                }
                current = current.next;
            }
        }
    }
}
