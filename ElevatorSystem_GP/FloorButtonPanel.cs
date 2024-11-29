/// <summary>
/// Handles external floor button presses.
/// </summary>
public class FloorButtonPanel
{
    private readonly int _totalFloors;

    public FloorButtonPanel(int totalFloors)
    {
        _totalFloors = totalFloors;
    }

    public void PressButton(int floor, Direction? direction = null)
    {
        if (floor < 1 || floor > _totalFloors)
        {
            Console.WriteLine($"Invalid floor {floor}. Choose between 1 and {_totalFloors}.");
            return;
        }

        if ((floor == 1 || floor == _totalFloors) && direction != null)
        {
            Console.WriteLine($"Floor {floor} only has a call button.");
            return;
        }

        if (floor > 1 && floor < _totalFloors && direction == null)
        {
            Console.WriteLine($"Floor {floor} requires a direction (Up or Down).");
            return;
        }

        Console.WriteLine($"External button pressed at floor {floor}{(direction.HasValue ? $" ({direction})" : "")}.");
    }
}
