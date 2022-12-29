using System;
namespace SelectionSort;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[]{45,33,12,55,77,22,33,14,67,12,35};
        int i,k;
        int flag = 0;
        for(int j=0;j<arr.Length;j++)
        {
            i=j;
            for(k=j+1;k<arr.Length;k++)
            {
                if(arr[k] > arr[i])
                {
                    i = k;
                }
            }
            flag = arr[i];
            arr[i] = arr[j];
            arr[j] = flag;
        }
        System.Console.WriteLine("Descending order of Selection sort");
        foreach(int j in arr)
        {
            System.Console.WriteLine(j);
        }
    }
}