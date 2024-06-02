using System;

class GradeCalculator
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a numerical grade between 0 and 100 (or -1 to quit): ");
            string input = Console.ReadLine();

            if (input == "-1")
            {
                break; // Exit the loop if the user enters -1
            }

            if (double.TryParse(input, out double grade))
            {
                // Check if the grade is within the valid range
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");
                    continue; // Continue to the next iteration of the loop
                }

                // Determine the letter grade based on the numerical grade using switch case
                string letterGrade = grade switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"
                };

                Console.WriteLine($"The letter grade for a numerical grade of {grade} is {letterGrade}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical value.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
