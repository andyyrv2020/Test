using System.Xml.Linq;

namespace Test4_AdvancedAnimals
{

    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                IAnimal animal = CreateAnimal(line);
                animals.Add(animal);
            }

            string trainerName = Console.ReadLine();



            Trainer trainer = null;



            string name = Console.ReadLine();



            while (name != "End")

            {

                IAnimal current = animals.Where(a => a.Name.Equals(name)).FirstOrDefault();



                if (current == null)

                {

                    Console.WriteLine("No such name in the Database!");

                }


                else

                {

                    if (trainer == null)

                    {

                        trainer = new Trainer(trainerName, current);

                    }

                    trainer.Work(current);

                    trainer.Make();

                }   
                name = Console.ReadLine();
            }

        }

        private static IAnimal CreateAnimal(string[] line)

        {

            IAnimal animal = null;

            switch (line[0])

            {

                case "Cat":

                    animal = new Cat(line[1]);

                    break;

                case "Dog":

                    animal = new Dog(line[1]);

                    break;

            }

            return animal;

        }

    }

    interface IAnimal

    {

        public string Type { get; }

        public string Name { get; }

        void Perform();

    }

    abstract class Animal : IAnimal
    {
        private string name;
        private string type;
        protected Animal(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be null or empty!");
                }
                name = value;
            }
        }

        public string Type
        {
            get { return type; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Type can't be null or empty!");
                }
                type = value;
            }
        }


        public void Perform()
        {
            Console.WriteLine($">>> {this.MakeNoise()}");
            Console.WriteLine($">>> {this.MakeTrick()}");
        }
        public abstract string MakeNoise();
        public abstract string MakeTrick();

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Cat : Animal  
    {
        public Cat(string name) : base(name, "Cat")
        {

        }

        public override string MakeNoise()
        {
            return ($"Meow!");
        }

        public override string MakeTrick()
        {
            return ($"No trick for you! I'm too lazy!");
        }
    }


    class Dog : Animal
    {
        public Dog(string name) : base(name, "Dog")
        {

        }

        public override string MakeNoise()
        {
            return ($"Woof!");
        }

        public override string MakeTrick()
        {

             return ($"Hold my paw, human!");

        }
    }

    class Trainer
    {

        private IAnimal entity;

        private string name;



        public Trainer(string name, IAnimal entity)

        {

            this.Name = name;

            this.Entity = entity;

        }



        public string Name

        {
            get { return name; }

            private set

            {

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))

                {

                    throw new ArgumentException("Name can't be null or empty!");
                }

                name = value;

            }

        }

        public IAnimal Entity

        {

            get { return entity; }

            private set

            {

                entity = value;

            }

        }



        public void Work(IAnimal entity)

        {

            this.Entity = entity;

            Console.WriteLine($"Trainer {this.Name} works with {entity.Name}!");

        }



        public void Make()

        {

            this.Entity.Perform();

        }

    }
}
