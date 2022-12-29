using System;
namespace OperatorOverloading;
class program
{
    public static void Main(string[] args)
    {
        Box box1 = new Box(21,12,23);
        Box box2 = new Box(14,24,24);
        System.Console.WriteLine($"Volume of the first box {box1.Volume}");
        System.Console.WriteLine($"Volume of the second box {box2.Volume}");
        Box box = box1+box2;
        System.Console.WriteLine($"Volume of the total box {box.Volume}");
        Box box4 = 
    }
}
