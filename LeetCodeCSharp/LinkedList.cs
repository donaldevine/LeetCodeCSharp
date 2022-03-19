using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class Node
    {

        public Node Next { get; set; }
        
        public int Data { get; set; }
        
        public Node(int data)
        {
            this.Data = data;
        }

        public void append(int data)
        {
            Node current = this;

            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(data);
        }
    }

    public class LinkedList
    {
        Node head;

        public void Append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            Node current = head;

            while(current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node(data);
        }

        public void Prepend(int data)
        {
            Node newHead = new Node(data);
            newHead.Next = head;
            head = newHead;
        }

        public void DeleteWithValue(int data)
        {
            if (head == null) return;

            if(head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while(current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }                
            }
        }
    }
}
