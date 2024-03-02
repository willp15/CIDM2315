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

        // Print details for each professor
        Console.WriteLine("Professor Details:");
        Console.WriteLine($"Name: {professor1.profName}");
        Console.WriteLine($"Class they teach: {professor1.classTeach}");
        Console.WriteLine($"Salary: {professor1.GetSalary()}");
        Console.WriteLine();

        Console.WriteLine($"Name: {professor2.profName}");
        Console.WriteLine($"Class they teach: {professor2.classTeach}");
        Console.WriteLine($"Salary: {professor2.GetSalary()}");
        Console.WriteLine();

        // Print details for each student
        Console.WriteLine("Student Details:");
        Console.WriteLine($"Name: {student1.studentName}");
        Console.WriteLine($"Class they're enrolled in: {student1.classEnroll}");
        Console.WriteLine($"Grade: {student1.GetGrade()}");
        Console.WriteLine();

        Console.WriteLine($"Name: {student2.studentName}");
        Console.WriteLine($"Class they're enrolled in: {student2.classEnroll}");
        Console.WriteLine($"Grade: {student2.GetGrade()}");
        Console.WriteLine();

        // Calculate and print the difference in salary between the two professors
        double salaryDifference = Math.Abs(professor1.GetSalary() - professor2.GetSalary());
        Console.WriteLine($"Difference in salary between the two professors: {salaryDifference}");

        // Calculate and print the total grade of Lisa’s Java course and Tom’s Math course
        double totalGradeJava = student1.GetGrade();
        double totalGradeMath = student2.GetGrade();
        Console.WriteLine($"Total grade of Lisa's Java course: {totalGradeJava}");
        Console.WriteLine($"Total grade of Tom's Math course: {totalGradeMath}");
    }
}