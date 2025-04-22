namespace Test3_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

        }
    }

    class Book
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string pages;
        public string Pages
        {
            get { return pages; }
            set { pages = value; }
        }
    }

    class School
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string information;
        public string Information
        {
            get { return information; }
            set { information = value; }
        }
    }
}
