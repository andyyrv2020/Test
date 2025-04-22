namespace Test6_CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class CustomStack<T>
    {
        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> PrevNode { get; private set; }

            public Node(T value, Node<T> prev = null)
            {
                this.Value = value;
                this.PrevNode = prev;
            }
        }

        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }
    }

}
