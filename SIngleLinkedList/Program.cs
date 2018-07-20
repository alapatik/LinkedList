using System;

namespace SIngleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Node node = new Node(3);

            LinkedList linkedList = new LinkedList();
            linkedList.root = node;

            node.next = new Node(5);
            node.next.next = new Node(2);
            node.next.next.next = new Node(1);
            //linkedList.Reverse();
            linkedList.Print();
            linkedList.Sort();
            linkedList.Print();
            //Console.WriteLine("-------");
            //Node temp = new Node('D');
            //linkedList.Insert(temp, 3);
            //linkedList.Print();
            //Console.WriteLine("-------");
            //linkedList.DeleteLastNode();
            //linkedList.Print();
            //linkedList.DeleteFirstNode();
            //Console.WriteLine("-------");
            //linkedList.Print();
            Console.Read();
        }
    }
    class LinkedList
    {  
        public Node root;
        
        public void Print()
        {
            Node node = root;
            while (node != null)
            {
                Console.WriteLine(node.info);
                node = node.next;
            }
        }
        public void DeleteFirstNode()
        {
            this.root = root.next;
        }
        public void DeleteLastNode()
        {
            Node node = root;
            while(node.next.next != null)
            {
                node = node.next;
            }
            node.next = null;
        }
        public void Insert(Node node, int index)
        {
            Node currNode = root;
            int count = 1;
            while(count != index)
            {
                currNode = currNode.next;
                count++;
            }
            node.next = currNode.next;
            currNode.next = node;
        }
        public void Reverse()
        {
            Node prev, p, next;
            prev = null;
            p = root;
            next =null;
            while(p != null)
            {
                next = p.next;
                p.next = prev;
                prev = p;
                p = next;
            }
            root = prev;
        }
        public void Sort()
        {
            Node p, end;
            p = root;
            end = null;
            for (end = null; end != root; end = p)
            {
                for (p = root; end != p.next && p.next != null; p = p.next)
                {
                    if (p.info > p.next.info)
                    {
                        int temp = p.info;
                        p.info = p.next.info;
                        p.next.info = temp;
                    }
                }
            }
            
        }
        
    }
    class Node
    {
        public Node(int info)
        {
            this.info = info;
        }
        public Node next;
        public int info;
    }
}
