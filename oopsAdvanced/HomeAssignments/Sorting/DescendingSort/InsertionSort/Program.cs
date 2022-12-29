using System;
namespace InsertionSort;
class Program
{
    public static void Main(string[] args)
    {
        float[] arr = new float[]{1.1f,65.3f,93.9f,55.5f,3.5f,6.9f};
        float temp;
        int i,j;
        for(i = 1;i<arr.Length;i++)
        {
            temp = arr[i];
            j = i;
            while(j>0 && arr[j-1]>temp)
            {
                arr[j] = arr[j-1];
                j = j-1;
            }
            arr[j] = temp;
        }
        System.Console.WriteLine("Descending order of insertion sort");
        for(i = arr.Length-1;i>=0;i--)
        {
            System.Console.WriteLine(arr[i]);
        }
    }
}

