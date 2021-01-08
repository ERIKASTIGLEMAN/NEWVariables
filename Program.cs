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


            var userName = Console.ReadLine();


        }
    }
}
