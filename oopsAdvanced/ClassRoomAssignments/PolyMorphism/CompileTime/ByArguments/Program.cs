using System;
namespace ByArguments;
class Program
{
    static void Display(int number)
    {
        System.Console.WriteLine(number);
    }
    static void Display(int number1,int number2)
    {
        System.Console.WriteLine($"First {number1} Second {number2}");
    }
    static void Main(string[] args)
    {
        Display(number);
        Display(number1,number2);
        Console.ReadLine();
        
    }
}
