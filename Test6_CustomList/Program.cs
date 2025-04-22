namespace Test6_CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class CustomList
    {
        private class Node
        {
            private object element;
            private Node next;
            public Node(object element, Node prevNode)
            {
                this.Element = element;
                prevNode.Next = this;
            }
            public Node(object element)
            {
                this.Element = element;
            }
            public object Element
            {
                get { return this.element; }
                set { this.element = value; }
            }
            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }

        //полета
        //глава(начало) на списъка
        private Node head;
        //опашка(край) на списъка
        private Node tail;
        //броят на елементите в свързания списък
        private int count;
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }
        public void Add(object element)
        {
            if (count == 0)
            {
                Node newNode = new Node(element);
                head = newNode;
                tail = newNode;
                count++;
            }
            else
            {
                Node newNode = new Node(element, tail);
                tail = newNode;
                count++;
            }
        }
        
    }
}
