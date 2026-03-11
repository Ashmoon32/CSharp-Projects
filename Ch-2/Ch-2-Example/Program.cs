using System;

struct Employee
{
    public int ID;
    public string Name;
    public double Salary;
}
class Program
{
    static void Main(string[] args)
    {
        string studentName = "La Min Kyal Sin";
        int studentAge = 20;
        double marksPercentage = 99.9;
        char grade = 'A';
        bool isEnrolled = true;

        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Student Age: " + studentAge);
        Console.WriteLine("Marks Percentage: " + marksPercentage + "%");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Enrolled: " + isEnrolled);

        Employee emp;
        emp.ID = 1;
        emp.Name = "La Min Kyal Sin";
        emp.Salary = 500000.00;

        Console.WriteLine("Employee ID: " + emp.ID);
        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Employee Salary: $" + emp.Salary);

    }
}