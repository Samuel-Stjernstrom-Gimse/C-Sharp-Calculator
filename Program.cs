using System;

namespace ConsoleApplication1
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("input first number");
            var number1 = Console.ReadLine();
            Console.WriteLine("input second Number");
            var number2 = Console.ReadLine();

            var num1 = int.Parse(number1 ?? throw new InvalidOperationException());
            var num2 =  int.Parse(number2 ?? throw new InvalidOperationException());


            var sum = num1 + num2; 
            
            Console.WriteLine("sum of number "+ sum);
        }
    }
}