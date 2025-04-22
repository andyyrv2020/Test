namespace Test4_Salary
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    abstract class BaseEmployee
    {
        public string Name { get; set; }
        public abstract double CalculateSalary(int workingHours);
    }

    abstract class FullTimeEmployee : BaseEmployee
    {
        public override double CalculateSalary(int workingHours)
        {

            return 250 + workingHours * 10.8;

        }
    }

    abstract class ContractEmployee : BaseEmployee
    {
        public override double CalculateSalary(int workingHours)
        {

            return 250 + workingHours * 20;

        }
    }
}
