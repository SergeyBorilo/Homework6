
namespace Homework6;


using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the number in decimal format: ");

        if (int.TryParse(Console.ReadLine(), out var number) && number >= 0)
        {
            var binary = Convert.ToString(number, 2);
            Console.WriteLine($"Binary representation of a number {number}: {binary}");

            var divisibleByTwo = "0$";
            if (Regex.IsMatch(binary, divisibleByTwo))
                Console.WriteLine($"The number {binary} is divisible by 2 without remainder");
            else
                Console.WriteLine($"The number {binary} is not divisible by 2");
        }
        else
            Console.WriteLine("Enter a valid positive integer: ");
    }
}
