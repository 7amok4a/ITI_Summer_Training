using System;

class Program
{
    static void Main()
    {
        int year, month, day;

        Console.Write("Please enter year (2000-2024): ");
        year = int.Parse(Console.ReadLine());
        while (!IsValidYear(year))
        {
            Console.Write("Invalid year. Please enter a valid year (2000-2024): ");
            year = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter month (1-12): ");
        month = int.Parse(Console.ReadLine());
        while (!IsValidMonth(month))
        {
            Console.Write("Invalid month. Please enter a valid month (1-12): ");
            month = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter day: ");
        day = int.Parse(Console.ReadLine());
        while (!IsValidDay(year, month, day))
        {
            Console.Write("Invalid day. Please enter a valid day: ");
            day = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You entered a valid date: {0}-{1}-{2}", year, month, day);
    }

    static bool IsValidYear(int year)
    {
        return year >= 2000 && year <= 2024;
    }

    static bool IsValidMonth(int month)
    {
        return month >= 1 && month <= 12;
    }

    static bool IsValidDay(int year, int month, int day)
    {
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            return day >= 1 && day <= 31;
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            return day >= 1 && day <= 30;
        }
        else if (month == 2)
        {
            if (IsLeapYear(year))
            {
                return day >= 1 && day <= 29;
            }
            else
            {
                return day >= 1 && day <= 28;
            }
        }
        return false;
    }

}
