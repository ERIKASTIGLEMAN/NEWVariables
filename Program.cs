using System;

namespace NEWVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 1;
            var fullName = "Erika Stigleman";
            var today = DateTime.Now;

            Console.WriteLine($"Hello! My Name is {fullName}, on {today} I enjoyed {numberOfCupsOfCoffee} cup of coffee.");



            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you today {userName}.");

            Console.WriteLine("What are your two favorite numbers?");
            var firstNumberOperand = Console.ReadLine();
            var secondNumberOperand = Console.ReadLine();

            var firstNumber = double.Parse(firstNumberOperand);
            var secondNumber = double.Parse(secondNumberOperand);

            var sum = firstNumber + secondNumber;
            Console.WriteLine($" The sum of your two favorite numbers is {sum}");

            var difference = firstNumber - secondNumber;
            Console.WriteLine($" The difference of your two favorite numbers is {difference}");


            var product = firstNumber * secondNumber;

            Console.WriteLine($" The product of your two favorite numbers is {product}");

            var quotient = firstNumber / secondNumber;
            Console.WriteLine($" The quotient of your two favorite numbers is {quotient}");

            var remainder = secondNumber % firstNumber;
            Console.WriteLine($" The remainder when divding these two numbers is {remainder}");


            Console.WriteLine($"Fun Math! Your two numbers {firstNumber} and {secondNumber} are great numbers! The sum of these two numbers is {sum}. The differnece in these two numbers is {difference}. The product of these two numbers is {product}. When dividing, your result will be {quotient}, and perhaps, with a remainder of {remainder}.");




        }
    }
}
