using System;

class MyMath
{
    
    public int Add(int a, int b)
    {
        return a + b;
    }

  
    public int Sub(int a, int b)
    {
        return a - b;
    }

  
    public int Mul(int a, int b)
    {
        return a * b;
    }

  
    public double Div(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN;
        }
        return (double)a / b;
    }

    public int Reminder(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
        return a % b;
    }
}

class Calculator
{
    static void Main()
    {
        MyMath math = new MyMath();

    
        Console.WriteLine("Select operation: +, -, *, /, %");
        char operation = Console.ReadLine()[0];

      
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

      
        switch (operation)
        {
            case '+':
                Console.WriteLine("Result: " + math.Add(num1, num2));
                break;
            case '-':
                Console.WriteLine("Result: " + math.Sub(num1, num2));
                break;
            case '*':
                Console.WriteLine("Result: " + math.Mul(num1, num2));
                break;
            case '/':
                double divResult = math.Div(num1, num2);
                if (!double.IsNaN(divResult))
                {
                    Console.WriteLine("Result: " + divResult);
                }
                break;
            case '%':
                Console.WriteLine("Result: " + math.Reminder(num1, num2));
                break;
            default:
                Console.WriteLine("Invalid operation selected.");
                break;
        }
    }
}

