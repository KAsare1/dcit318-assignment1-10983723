using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle (or -1 to quit):");


            Console.Write("Side 1: ");
            string input1 = Console.ReadLine();
            if (input1 == "-1") break;

            Console.Write("Side 2: ");
            string input2 = Console.ReadLine();
            if (input2 == "-1") break;

            Console.Write("Side 3: ");
            string input3 = Console.ReadLine();
            if (input3 == "-1") break;

            if (double.TryParse(input1, out double side1) &&
                double.TryParse(input2, out double side2) &&
                double.TryParse(input3, out double side3))
            {
                if (IsValidTriangle(side1, side2, side3))
                {

                    string triangleType = GetTriangleType(side1, side2, side3);

                    Console.WriteLine($"The triangle with sides {side1}, {side2}, and {side3} is {triangleType}.");
                }
                else
                {
                    Console.WriteLine("The lengths do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter numerical values for the sides.");
            }
        }

        Console.WriteLine("Goodbye!");
    }


    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }


    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "an Equilateral triangle";
        }
        else if (a == b || a == c || b == c)
        {
            return "an Isosceles triangle";
        }
        else
        {
            return "a Scalene triangle";
        }
    }
}
