using System;
namespace Linear;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[]{45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        int search;
        System.Console.WriteLine("Enter the value to search");
        search = int.Parse(Console.ReadLine());
        bool check = true;
        for(int i=0;i<arr.Length;i++)
        {
            if(search == arr[i])
            {
                check = false;
                System.Console.WriteLine($"search value {search} is {i} position");
            }
        }
        if(check)
        {
            System.Console.WriteLine("search value not found");
        }
    }
}