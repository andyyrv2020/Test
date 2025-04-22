namespace Test3_BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit(100);
            Console.WriteLine(account);
            account.Withdraw(50);
            Console.WriteLine(account);
        }
    }

    public class BankAccount

    {

        private int id;

        private decimal balance;

        private decimal amount;



        public BankAccount()

        {

            Id = id;

            Balance = balance;

        }

        public int Id

        {

            get { return id; }

            private set

            {

                if (value < 0)

                {

                    Console.WriteLine("Id must be positive number!");

                }

                id = value;

            }

        }

        public decimal Balance

        {

            get { return balance; }

            private set { balance = value; }

        }

        public void Deposit(decimal amount)

        {

            if (amount < 0)

            {

                Console.WriteLine("Amount must be positive number!");

            }

            this.Balance += amount;

        }

        public void Withdraw(decimal amount)

        {

            if (true)

            {

                Console.WriteLine("Insufficient Balance!");

            }

            this.Balance -= amount;

        }

        public override string ToString()

        {

            return $"Account {this.Id}, balance {this.Balance}";

        }

    }
}
