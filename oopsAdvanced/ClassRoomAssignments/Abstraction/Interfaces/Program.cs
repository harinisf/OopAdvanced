using System;
namespace Interfaces;
class Program
{
    public static void Main(string[] args)
    {
        Square number = new Square();
        number.Number = 10;
        System.Console.WriteLine(number.claculate());
        Icalculate value = new Square();
        value.number = 20;
        System.Console.WriteLine(value.claculate());
    }
}