using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Represents directions for elevator calls.
/// </summary>
public enum Direction
{
    Up,
    Down
}

/// <summary>
/// Represents the state and movement of the elevator.
/// </summary>
public class Elevator
{
    public int CurrentFloor { get; private set; }
    public bool DoorOpen { get; private set; }

    public Elevator()
    {
        CurrentFloor = 1; // Assume starting on the first floor
        DoorOpen = false;
    }

    public void MoveToFloor(int floor)
    {
        Console.WriteLine($"Elevator moving from floor {CurrentFloor} to floor {floor}.");
        CurrentFloor = floor;
        OpenDoor();
    }

    public void OpenDoor()
    {
        DoorOpen = true;
        Console.WriteLine($"Door opened at floor {CurrentFloor}.");
    }

    public void CloseDoor()
    {
        DoorOpen = false;
        Console.WriteLine($"Door closed at floor {CurrentFloor}.");
    }
}

