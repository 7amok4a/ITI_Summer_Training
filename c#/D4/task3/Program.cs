using System;

class Student
{
    // Properties for SSN, Name, Age, and Address
    public string SSN { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    // Print function to display student details
    public void Print()
    {
        Console.WriteLine($"SSN: {SSN}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
    }
}

class Program
{
    static void Main()
    {
        // Take data for one student from the user and print
        Console.WriteLine("Enter details for one student:");
        Student singleStudent = new Student();
        singleStudent.SSN = ReadInput("SSN");
        singleStudent.Name = ReadInput("Name");
        singleStudent.Age = int.Parse(ReadInput("Age"));
        singleStudent.Address = ReadInput("Address");

        Console.WriteLine("\nDetails of the single student:");
        singleStudent.Print();

        // Take data for an array of students from the user and print
        Console.WriteLine("\nEnter the number of students:");
        int numberOfStudents = int.Parse(Console.ReadLine());

        Student[] students = new Student[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nEnter details for student {i + 1}:");
            students[i] = new Student();
            students[i].SSN = ReadInput("SSN");
            students[i].Name = ReadInput("Name");
            students[i].Age = int.Parse(ReadInput("Age"));
            students[i].Address = ReadInput("Address");
        }

        Console.WriteLine("\nDetails of all students:");
        foreach (var student in students)
        {
            student.Print();
            Console.WriteLine(); // For better readability
        }
    }

    // Helper method to read input from the user
    static string ReadInput(string prompt)
    {
        Console.WriteLine($"Enter {prompt}:");
        return Console.ReadLine();
    }
}

