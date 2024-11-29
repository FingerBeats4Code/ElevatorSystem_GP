
/// <summary>
/// Handles internal button presses inside the elevator.
/// </summary>
public class ElevatorButtonPanel
{
    private readonly int _totalFloors;

    public ElevatorButtonPanel(int totalFloors)
    {
        _totalFloors = totalFloors;
    }

    public void PressButton(int floor)
    {
        if (floor < 1 || floor > _totalFloors)
        {
            Console.WriteLine($"Invalid floor {floor}. Choose between 1 and {_totalFloors}.");
            return;
        }

        Console.WriteLine($"Internal button pressed to go to floor {floor}.");
    }
}