using System;
namespace BubbleSort;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[]{45,33,12,55,77,22,33,14,67,12,35};
        int temp;
        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-1;j++)
            {
                if(arr[j] < arr[j+1])
                {
                    temp = arr[j+1];
                    arr[j+1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        System.Console.Write("Descending Order in Bubble Sort ");
        foreach(int i in arr)
        {
            System.Console.WriteLine(i);
        }
    }
}

