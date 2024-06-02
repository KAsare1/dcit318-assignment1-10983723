using System;

class TicketPriceCalculator
{
    static void Main()
    {
        while (true)
        {
            
            Console.Write("Enter your age (or -1 to quit): ");
            string input = Console.ReadLine();

            if (input == "-1")
            {
                break; 
            }

            if (int.TryParse(input, out int age))
            {
                
                if (age < 0)
                {
                    Console.WriteLine("Invalid age. Please enter a positive age.");
                    continue; 
                }

                
                int ticketPrice = age switch
                {
                    <= 12 => 7,
                    >= 65 => 7,
                    _ => 10
                };

                
                Console.WriteLine($"The ticket price for age {age} is GHC{ticketPrice}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical value.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
