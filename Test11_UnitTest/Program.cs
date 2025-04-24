using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.ComponentModel;
using CategoryAttribute = NUnit.Framework.CategoryAttribute;

namespace Test11_UnitTest
{
    public class Program
    {
        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;

            if (operation == "+")
            {
                result = Add(a, b);
            }
            else if (operation == "*")
            {
                result = Multiply(a, b);
            }
            else if (operation == "-")
            {
                result = Subtract(a, b);
            }
            else if (operation == "/")
            {
                try
                {
                    result = Division(a, b);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Invalid result caused by division by zero!");
                }
            }

            Console.WriteLine(result);
        }
    }

    public class Tests
    {
        [Test]
        [Category("Addition")]
        public void TestAddingTwoPositiveIntegerNumbers()
        {
            //Arrange
            int a = 5;
            int b = 9;

            //Act
            double result = Program.Add(a, b);

            //ClassicAssert
             ClassicAssert.AreEqual(result, 14);
        }

        [Test]
        [Category("Addition")]
        public void TestAddingTwoPositiveFloatingPointNumbers()
        {
            //Arrange
            double a = 5.43;
            double b = 0.33;

            //Act
            double result = Program.Add(a, b);

            //ClassicAssert
            ClassicAssert.AreEqual(result, 5.76);
        }

        [Test]
        [Category("Addition")]
        public void TestAddingTwoNegativeNumbers()
        {
            //Arrange
            double a = -3.431;
            double b = -3.241;

            //Act
            double result = Program.Add(a, b);

            //ClassicAssert
            ClassicAssert.AreEqual(result, -6.672, 0.0001);
        }

        [Test]
        [Category("Addition")]
        public void TestAddingTwoZeroes()
        {
            double a = 0;
            double b = 0;

            double result = Program.Add(a, b);
            ClassicAssert.AreEqual(result, 0);
        }

        [Test]
        [Category("Addition")]
        public void TestAddingZeroAndNumber()
        {
            double a = 1;
            double b = 0;

            double result = Program.Add(a, b);
            ClassicAssert.AreEqual(result, 1);
        }

        [Test]
        [Category("Addition")]
        public void TestAddingOppositeNumbers()
        {
            double a = -5.34;
            double b = 5.34;

            double result = Program.Add(a, b);
            ClassicAssert.AreEqual(result, 0);
        }

        [Test]
        [Category("Subtraction")]
        public void TestSubtractionFirstBigger()
        {
            double a = 5;
            double b = 3;

            double result = Program.Subtract(a, b);

            ClassicAssert.AreEqual(result, 2);
        }

        [Test]
        [Category("Subtraction")]
        public void TestSubtractionSecondBigger()
        {
            double a = 3;
            double b = 5;

            double result = Program.Subtract(a, b);

            ClassicAssert.AreEqual(result, -2);
        }

        [Test]
        [Category("Subtraction")]
        public void TestSubtractZero()
        {
            double a = 3;
            double b = 0;

            double result = Program.Subtract(a, b);

            ClassicAssert.AreEqual(result, 3);
        }

        [Test]
        [Category("Subtraction")]
        public void TestSubtractNegativeNumbers()
        {
            double a = -3;
            double b = -5;

            double result = Program.Subtract(a, b);
            ClassicAssert.AreEqual(result, 2);
        }

        [Test]
        [Category("Multiplication")]
        public void TestMultiplicationTwoPositiveNumbers()
        {
            double a = 3;
            double b = 2.5;

            double result = Program.Multiply(a, b);

            ClassicAssert.AreEqual(result, 7.5);
        }

        [Test]
        [Category("Multiplication")]
        public void TestMultiplicationTwoNegativeNumbers()
        {
            double a = -3;
            double b = -2;
            double result = Program.Add(a, b);
            ClassicAssert.AreEqual(result, 6);
        }
        [Test]
        [Category("Multiplication")]
        public void TestMultiplicationTwoDifferentSignedNumbers()
        {
            double a = -3;
            double b = 2;
            double result = Program.Multiply(a, b);
            ClassicAssert.AreEqual(result, -6);
        }

        [Test]
        [Category("Multiplication")]
        public void TestMultiplicationWithZero()
        {
            double a = 0;
            double b = 3;

            double result = Program.Multiply(a, b);

            ClassicAssert.AreEqual(result, 0);
        }

        [Test]
        [Category("Division")]
        public void TestDivisionWithTwoNumbers()
        {
            double a = 3;
            double b = 2;

            double result = Program.Division(a, b);
        
            ClassicAssert.AreEqual(result, 1.5);
        }

        [Test]
        [Category("Division")]
        public void TestDivisionWithBiggerNumber()
        {
            double a = 3;
            double b = 5;

            double result = Program.Division(a, b);

            ClassicAssert.AreEqual(result, 0.6);
        }

        [Test]
        [Category("Division")]
        public void TestDivisionZeroByNumber()
        {
            double a = 0;
            double b = 5;

            double result = Program.Division(a, b);


        }

        [Test]
        [Category("Division")]
        public void TestDivisionByZero()
        {
            double a = 5;
            double b = 0;
            Assert.Throws<DivideByZeroException>(() => Program.Division(a, b));

        }
    }
}
