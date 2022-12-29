using System;
namespace BinarySearch;
class Program
{
    public static int BinarySearching(int[] array,int search)
    {
        int firstElement = 0;
        int lastElement = array.Length-1;
        while(firstElement <= lastElement)
        {
            int middle = (firstElement + lastElement)/2;
            if(search == array[middle])
            {
                return middle;
            }
            else if(search < array[middle])
            {
                lastElement = middle - 1;
            }
            else
            {
                firstElement = middle +1;
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter you want to search ");
        int search = int.Parse(Console.ReadLine());
        int[] arr = new int[] {45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        Array.Sort(arr);
        int results = BinarySearching(arr,search);
        if(results < 0)
        {
            System.Console.WriteLine("The required element is not there");
        }
        else
        {
            System.Console.WriteLine($"Element is {results}");
        }
    }
}