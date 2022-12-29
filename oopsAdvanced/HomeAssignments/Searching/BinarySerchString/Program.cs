using System;
namespace BinarySerchString;
class Program
{
    public static int BinarySerchString(String[] arr,string search)
    {
        int first = 0;
        int last = arr.Length - 1;
        while(first <= last)
        {
            int middle = (first+last)/2;
            if(search.Equals(arr[middle]))
            {
                return middle;
            }
            else if(search.CompareTo(arr[middle]) < 0)
            {
                last = middle - 1;
            }
            else
            {
                first = middle + 1;
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the value you want to search");
        string search = Console.ReadLine();
        string[] arr = new string[] {"SF3023", "SF3021", "SF3067", "SF3043","SF3053","SF3032","SF3063","SF3089","SF3062","SF3092"};
        Array.Sort(arr);
        int result = BinarySerchString(arr,search);
        if(result < 0)
        {
            System.Console.WriteLine("Element are not found");
        }
        else
        {
            System.Console.WriteLine($"Element found at {result}");
        }
    }
}