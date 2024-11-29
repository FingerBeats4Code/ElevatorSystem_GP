/// <summary>
/// Coordinates the elevator system's components.
/// </summary>
public class ElevatorController
{
    private readonly Elevator _elevator;
    private readonly FloorButtonPanel _floorButtonPanel;
    private readonly ElevatorButtonPanel _elevatorButtonPanel;
    private readonly Queue<int> _floorQueue = new Queue<int>();

    public ElevatorController(int totalFloors)
    {
        _elevator = new Elevator();
        _floorButtonPanel = new FloorButtonPanel(totalFloors);
        _elevatorButtonPanel = new ElevatorButtonPanel(totalFloors);
    }

    public void PressExternalButton(int floor, Direction? direction = null)
    {
        _floorButtonPanel.PressButton(floor, direction);
        AddFloorToQueue(floor);
    }

    public void PressInternalButton(int floor)
    {
        _elevatorButtonPanel.PressButton(floor);
        AddFloorToQueue(floor);
    }

    private void AddFloorToQueue(int floor)
    {
        if (!_floorQueue.Contains(floor))
        {
            _floorQueue.Enqueue(floor);
            ProcessQueue();
        }
    }

    private void ProcessQueue()
    {
        while (_floorQueue.Any())
        {
            int nextFloor = _floorQueue.Dequeue();
            _elevator.MoveToFloor(nextFloor);
            _elevator.CloseDoor();
        }
    }
}