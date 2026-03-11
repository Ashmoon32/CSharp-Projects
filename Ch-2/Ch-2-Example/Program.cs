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


        int? AGE = null;
        bool? isGraduated = null;

        Console.WriteLine("Age: " + (AGE.HasValue ? AGE.ToString() : "No value"));
        Console.WriteLine("Graduated: " + (isGraduated.HasValue ? isGraduated.ToString() : "No value"));

        float a = 3, b = 10;

        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Remainder: " + (a % b));

        Console.WriteLine("Is a greater than b? " + (a > b));
        Console.WriteLine("Is a equal to b? " + (a == b));

        bool I = true, J = false;
        Console.WriteLine("I AND J : " + (I && J));
        Console.WriteLine("I OR J : " + (I || J));
        Console.WriteLine("NOT I: " + (!I));

        int x = 5;

        Console.WriteLine("Initial value of x: " + x);
        x += 3;
        Console.WriteLine("After ( x += 3): " + x);

        x *= 2;
        Console.WriteLine("After ( x *= 2): " + x);

        int y = 10;
        Console.WriteLine("Initial value of y: " + y);

        Console.WriteLine("Post-increment (y++): " + y++);
        Console.WriteLine("Value of y after post-increment: " + y);

        Console.WriteLine("Pre-decrement (--y): " + --y);
        Console.WriteLine("Value of y after pre-decrement: " + y);

        Console.Write("Enter radius of a circle: ");
        int r = int.Parse(Console.ReadLine());
        double perimeter = 2 * (Math.PI * r);
        double area = Math.PI * r * r;
        Console.WriteLine("The perimeter of the circle: " + perimeter);
        Console.WriteLine("The area of the circle: " + area);

        string name, address, phoneNo, faxNo, web;
        string ManagerName, surname, ManagerphNo;
        Console.WriteLine("For Company, ");
        Console.Write("Enter name : ");
        name = Console.ReadLine();
        Console.Write("Enter address : ");
        address = Console.ReadLine();
        Console.Write("Enter phone number : ");
        phoneNo = Console.ReadLine();
        Console.Write("Enter fax : ");
        faxNo = Console.ReadLine();
        Console.Write("Enter web site : ");
        web = Console.ReadLine();
        Console.WriteLine("For Manager, ");
        Console.Write("Enter Manager name : ");
        ManagerName = Console.ReadLine();
        Console.Write("Enter surename : ");
        surname = Console.ReadLine();
        Console.Write("Manager phone number : ");
        ManagerphNo = Console.ReadLine();

        Console.WriteLine(" Company Information ");
        Console.WriteLine(name + '\n' + address + '\n' + phoneNo + '\n' + faxNo + '\n' + web);
        Console.WriteLine(" Manager Information ");
        Console.WriteLine(ManagerName + '\n' + surname + '\n' + ManagerphNo);


    }
}