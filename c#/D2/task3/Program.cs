using System;

class Program
{
    static void Main()
    {
        // Example 2D array where each row represents a student and each column represents a subject
        int[,] studentsSubjectsGrades = {
            { 85, 92, 78 },
            { 88, 79, 95 },
            { 90, 81, 87 },
            { 77, 88, 91 }
        };

        int numStudents = studentsSubjectsGrades.GetLength(0);
        int numSubjects = studentsSubjectsGrades.GetLength(1);

        double[] subjectsAverages = CalculateSubjectsAverages(studentsSubjectsGrades, numStudents, numSubjects);

        for (int i = 0; i < numSubjects; i++)
        {
            Console.WriteLine($"Average grade for subject {i + 1}: {subjectsAverages[i]:F2}");
        }
    }

    static double[] CalculateSubjectsAverages(int[,] grades, int numStudents, int numSubjects)
    {
        double[] averages = new double[numSubjects];

        for (int j = 0; j < numSubjects; j++)
        {
            int sum = 0;
            for (int i = 0; i < numStudents; i++)
            {
                sum += grades[i, j];
            }
            averages[j] = (double)sum / numStudents;
        }

        return averages;
    }
}

