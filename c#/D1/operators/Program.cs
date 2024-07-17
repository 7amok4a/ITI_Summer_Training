using System;

class Program
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        bool expression1 = (number1 + number2) > number3;
        Console.WriteLine("Is the sum of {0} and {1} greater than {2}? {3}", number1, number2, number3, expression1);

        bool expression2 = (number1 > number2 && number1 < number3) || (number1 > number3 && number1 < number2);
        Console.WriteLine("Is {0} between {1} and {2}? {3}", number1, number2, number3, expression2);

        bool expression3 = (number1 * number3) <= (number2 * number2);
        Console.WriteLine("Is the product of {0} and {2} less than or equal to the square of {1}? {3}", number1, number2, number3, expression3);

        bool expression4 = (number1 != number2) && (number2 != number3) && (number1 != number3);
        Console.WriteLine("Are all three numbers different? {0}", expression4);

        bool expression5 = (number1 > number2) && (number1 > number3);
        Console.WriteLine("Is {0} the largest number? {1}", number1, expression5);
    }
}

