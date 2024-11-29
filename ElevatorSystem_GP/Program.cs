/// <summary>
/// Developer: Durga
/// Description: This application simulates an elevator control system using an event-command-based architecture.
/// Requirements: 
/// - State management (position, movement, doors).
/// - Handles internal/external controls.
/// - Designed for testing with xUnit.
/// </summary>


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Elevator Simulation ===");
        Console.WriteLine("1. External Button Press");
        Console.WriteLine("2. Internal Button Press");
        Console.WriteLine("3. Exit");

        var controller = new ElevatorController(5);
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                continue;
            }

            if (choice == 3)
            {
                Console.WriteLine("Exiting the simulation. Goodbye!");
                break;
            }

            switch (choice)
            {
                case 1:
                    HandlingButtonPress.HandleExternalButtonPress(controller); 
                    break;

                case 2:
                    HandlingButtonPress.HandleInternalButtonPress(controller); 
                    break;
            }
        }
    }
}

