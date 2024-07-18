using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of employees: ");
        int numOfEmployees = int.Parse(Console.ReadLine());
        Employee[] employees = new Employee[numOfEmployees];

        for (int i = 0; i < numOfEmployees; i++)
        {
            Employee employee = new Employee();
            Console.WriteLine($"Enter data for employee {i + 1}:");

            Console.Write("SSN: ");
            employee.Ssn = Console.ReadLine();

            Console.Write("First Name: ");
            employee.Fname = Console.ReadLine();

            Console.Write("Last Name: ");
            employee.Lname = Console.ReadLine();

            Console.Write("Age: ");
            try
            {
                employee.Age = int.Parse(Console.ReadLine());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                i--;
                continue;
            }

            Console.Write("Address (cairo, alex, or giza): ");
            try
            {
                employee.Address = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                i--;
                continue;
            }

            employees[i] = employee;
        }

        Console.WriteLine("\nEmployee Data:");
        foreach (var employee in employees)
        {
            employee.PrintOnConsole();
            Console.WriteLine();
        }
    }
}
struct Employee
{
    private string ssn;
    private string fname;
    private string lname;
    private int age;
    private string address;

    // Properties with validation
    public string Ssn
    {
        get { return ssn; }
        set { ssn = value; }
    }

    public string Fname
    {
        get { return fname; }
        set { fname = value; }
    }

    public string Lname
    {
        get { return lname; }
        set { lname = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 23 && value <= 45)
                age = value;
            else
                throw new ArgumentException("Age must be between 23 and 45.");
        }
    }

    public string Address
    {
        get { return address; }
        set
        {
            if (value == "cairo" || value == "alex" || value == "giza")
                address = value;
            else
                throw new ArgumentException("Address must be 'cairo', 'alex', or 'giza'.");
        }
    }

    // Method to print employee data on the console
    public void PrintOnConsole()
    {
        Console.WriteLine($"SSN: {ssn}");
        Console.WriteLine($"First Name: {fname}");
        Console.WriteLine($"Last Name: {lname}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
    }

    // Method to return employee data as a string
    public string PrintAsString()
    {
        return $"SSN: {ssn}, First Name: {fname}, Last Name: {lname}, Age: {age}, Address: {address}";
    }
}

