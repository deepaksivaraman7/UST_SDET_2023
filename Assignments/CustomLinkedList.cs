using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CustomLinkedList
    {
        private Node head;

        public CustomLinkedList()
        {
            head = null;
        }
        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddNode(TaskItem data)
        {
            var newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Console.WriteLine($"Added: {data.TaskDescription}");
        }

        public bool RemoveNode(int id)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty. Cannot remove.");
                return false;
            }

            if (head.Data.TaskId.Equals(id))
            {
                head = head.Next;
                Console.WriteLine($"Removed: {head.Data.TaskDescription}");
                return true;
            }

            var current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(head.Data.TaskDescription))
                {
                    current.Next = current.Next.Next;
                    Console.WriteLine($"Removed: {head.Data.TaskId}");
                    return true;
                }
                current = current.Next;
            }
            Console.WriteLine($"Data not found: {head.Data.TaskDescription}");
            return false;
        }

        public void DisplayList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }

            var current = head;
            Console.Write("List: ");
            while (current != null)
            {
                Console.Write(current.Data.TaskDescription + "  ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
