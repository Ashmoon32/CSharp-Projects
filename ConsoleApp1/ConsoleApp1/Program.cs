using System;
struct Employee
{
    public int ID;
public string Name;
public double salary;

}
class Program
{
    static void Main(string[] args)
    {
        Employee emp;
        emp.ID = 102;
        emp.Name = "Dick";
        emp.salary = 3000000;
        Console.WriteLine("Employee ID: " + emp.ID);
        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Employee Salary: " + emp.salary);
    }
}