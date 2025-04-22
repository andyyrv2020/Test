namespace Test4_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog bo = new Dog();
            bo.MakeTrick(); 

            Animal kotka = new Animal();
            kotka.MakeTrick(); 
        }
    }

    class Animal
    {
        public virtual void MakeTrick()
        {
            Console.WriteLine("No trick!");
        }
    }

    class Dog : Animal
    {
        public virtual void MakeTrick()
        {
            Console.WriteLine("Give a paw!");
        }
    }
}
