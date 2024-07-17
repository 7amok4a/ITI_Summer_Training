using System;

class Program
{
    static void Main()
    {
        byte sum = 0;
        while (true)
        {
            try
            {
                Console.Write("Enter a byte value to add: ");
                byte value = byte.Parse(Console.ReadLine());

        
                sum = checked((byte)(sum + value));
                
                Console.WriteLine($"Current sum: {sum}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow occurred! Resetting sum to zero.");
                sum = 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid byte value.");
            }
        }
    }
}

