using System;

struct Employee
{
    public int ID;
    public string Name;
    public double Salary;
}

class Student
{
    public string Name;
    public int Age;

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

        Student s1 = new Student();

        s1.Name = "Kyal Sin La Min";
        s1.Age = 20;

        Console.WriteLine("Student Name: " + s1.Name);
        Console.WriteLine("Student Age: " + s1.Age);

        Student[] students = new Student[2];

        students[0] = new Student();
        students[0].Name = "Kyal Sin";
        students[0].Age = 19;

        students[1] = new Student();
        students[1].Name = "La Min";
        students[1].Age = 21;

        foreach (Student s in students)
        {
            Console.WriteLine("Name: " + s.Name + ", Age: " + s.Age);
        }
    }
}