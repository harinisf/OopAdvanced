using System;
namespace ByType;
class Program
{
    static void Display(int number)
    {
        System.Console.WriteLine(number);
    }

    static void Display(string name)
    {
        System.Console.WriteLine(name);
    }
    static void Main(string[] args)
    {
        Display(100);
        Display("harini");
        Console.ReadLine();
        
    }
}