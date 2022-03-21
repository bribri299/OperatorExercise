using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int diff = a - b;
            int prduct = a * b;

            double quotient = a / b;
            double remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {diff}");
            Console.WriteLine($"{a} * {b} is {prduct}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder is {remainder}");

            Console.WriteLine("What is the radius of your cicle?");
            double radius = double.Parse(Console.ReadLine());

            double cicleArea = Math.PI * Math.Pow(radius, 2 );
            Console.WriteLine($"The area is: {cicleArea}");



        }
    }
}
