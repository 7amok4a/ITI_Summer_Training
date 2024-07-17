using System;

class Program
{
    static void Main()
    {
        int[] array = new int[10];
        ReadArray(array);
        PrintArray(array);

        int minValue = FindMin(array);
        int maxValue = FindMax(array);
        Console.WriteLine($"Minimum value: {minValue}");
        Console.WriteLine($"Maximum value: {maxValue}");

        SortArray(array);
        Console.WriteLine("Sorted array:");
        PrintArray(array);

        Console.Write("Enter a number to search: ");
        int searchNumber = int.Parse(Console.ReadLine());
        int index = SearchNumber(array, searchNumber);

        if (index != -1)
        {
            Console.WriteLine($"Number {searchNumber} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Number {searchNumber} not found in the array.");
        }
    }

    static void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("Array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static int FindMin(int[] array)
    {
        int minValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }
        return minValue;
    }

    static int FindMax(int[] array)
    {
        int maxValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }
        return maxValue;
    }

    static void SortArray(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static int SearchNumber(int[] array, int number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                return i;
            }
        }
        return -1;
    }
}



/* static int [] FindMinMax(int[] array)
    {
        int minValue = array[0];
        int maxValue = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }
    }
  return  new int[] { minValue, maxValue } ; 
} */

