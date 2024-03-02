using System;

public class Professor
{
    private string profName;
    private string classTeach;
    private double salary;

    public Professor(string name, string className, double salaryAmount)
    {
        profName = name;
        classTeach = className;
        salary = salaryAmount;
    }

    public void SetSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

public class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    public Student(string name, string className, double grade)
    {
        studentName = name;
        classEnroll = className;
        studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create 2 new Professors
        Professor professor1 = new Professor("Alice", "Java", 9000);
        Professor professor2 = new Professor("Bob", "Math", 8000);

        // Create 2 new Students
        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);
    }