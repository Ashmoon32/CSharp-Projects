using System;

struct Employee
{
    public int ID;
    public string Name;
    public double Salary;
}

class Program
{
    const double PI = 3.14159;
    static readonly int version = 1;
    static void Main(string[] args)
    {

        Console.WriteLine("PI = " + PI);
        Console.WriteLine("version = " + version);

        Console.WriteLine(new String('-', 40));
        Employee emp;
        emp.ID = 40;
        emp.Name = "MLPH";
        emp.Salary = 5000000.0;

        Console.WriteLine("Employee ID: " + emp.ID);
        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Employee Salary: $" + emp.Salary);

        int intVal = 23;
        double doubleVal = intVal;

        Console.WriteLine("Integer Value: " + intVal);
        Console.WriteLine("Double Value after conversion: " + doubleVal);

        double douVal = 3.14;
        int integerVal = (int)douVal;
        Console.WriteLine("Double Value: " + douVal);
        Console.WriteLine("Double value after casting: " + integerVal);

        string numberString = "123";
        int val1 = int.Parse(numberString);
        int val2 = Convert.ToInt32(numberString);
        Console.WriteLine("Original String: " + numberString);
        Console.WriteLine("Convert using int.Parse(): " + val1);
        Console.WriteLine("Convert using Convert.ToInt32(): " + val2);

        
       
    }
}