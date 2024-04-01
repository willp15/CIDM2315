using System;
using System.Collections.Generic;

public class Student
{
    private int studentID;
    private string studentName;

    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create students
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        // Create gradebook
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8}
        };

        // Check if "Tom" exists in gradebook
        if (!gradebook.ContainsKey("Tom"))
        {
            // If not, add "Tom" with GPA 3.3
            gradebook.Add("Tom", 3.3);
        }

        // Calculate average GPA
        double totalGPA = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;

        Console.WriteLine($"Average GPA: {averageGPA}");

        // Print information about students with GPA greater than average
        Console.WriteLine("Students with GPA greater than average:");
        foreach (var student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.studentName) && gradebook[student.studentName] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}