using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class HandlingButtonPress
{

    
    public static void HandleExternalButtonPress(ElevatorController controller)
    {
        int floor;
       //Added loop to retry floor input until valid
        while (true)
        {
            Console.WriteLine("Enter the floor number (1-5):");
            if (int.TryParse(Console.ReadLine(), out floor) && floor >= 1 && floor <= 5)
                break; // Valid floor input, exit loop

            Console.WriteLine("Invalid floor. Choose between 1 and 5.");
        }

        Direction? direction = null;
        if (floor > 1 && floor < 5)
        {
            // Added loop to retry direction input until valid
            while (true)
            {
                Console.WriteLine("Enter the direction (Up/Down):");
                var dirInput = Console.ReadLine()?.ToLower();
                direction = dirInput switch
                {
                    "up" => Direction.Up,
                    "down" => Direction.Down,
                    _ => null
                };

                if (direction != null) break; // Valid direction input, exit loop

                Console.WriteLine("Invalid direction. Please enter 'Up' or 'Down'.");
            }
        }

        controller.PressExternalButton(floor, direction);
    }

    // Added method to handle internal button press logic
    public static void HandleInternalButtonPress(ElevatorController controller)
    {
        int floor;
        // Added loop to retry floor input until valid
        while (true)
        {
            Console.WriteLine("Enter the destination floor number (1-5):");
            if (int.TryParse(Console.ReadLine(), out floor) && floor >= 1 && floor <= 5)
                break; // Valid floor input, exit loop

            Console.WriteLine("Invalid floor. Choose between 1 and 5.");
        }

        controller.PressInternalButton(floor);
    }
}
