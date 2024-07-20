using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Taking indices to swap
        Console.WriteLine("Enter the first index to swap:");
        int i1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second index to swap:");
        int i2 = int.Parse(Console.ReadLine());

        Swap(ref arr[i1], ref arr[i2]);


        Console.WriteLine("Array after swapping:");
         for (int i = 0; i < size; i++)
        {
           Console.WriteLine(arr[i]) ; 
        }
    }


    static void Swap(ref int num1, ref int num2) {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    } 

    static void Swap (int [] arr , int i1 , int i2) {
        int temp = arr[i1];
        arr[i1] = arr[i2];
        arr[i2] = temp;
    }
}

