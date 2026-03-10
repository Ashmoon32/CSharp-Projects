using System;

class MathOperation
{
    public int CalculateArea(int side)
    {
        return side * side;
    }

    public int CalculateArea(int length, int width)
    {
        return length * width;
    }

    public double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathOperation obj = new MathOperation();
        int squareArea = obj.CalculateArea(5);
        Console.WriteLine("Square Area: " + squareArea);
        int rectangleArea = obj.CalculateArea(10, 5);
        Console.WriteLine("Rectangle Area: " + rectangleArea);
        double circleArea = obj.CalculateArea(2.3);
        Console.WriteLine("Circle Area: " + circleArea);
    }

}