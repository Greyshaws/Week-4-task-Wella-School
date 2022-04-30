using System;

namespace Week4Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a number checking app");

            //To perform a calculation
            Console.Write("Type in your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Type in your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int result = firstNumber + secondNumber;

            //To make a decision, I used the switch statement
            switch (result)
            {
                case int resultOfCalculation when resultOfCalculation <= 100:
                Console.WriteLine("True"); //return true
                break;
                case int resultOfCalculation when resultOfCalculation >= 100:
                Console.WriteLine("False"); //return false
                break;
                default:
                Console.WriteLine("Error: Try again");
                break;
            }
        }
    }
}
