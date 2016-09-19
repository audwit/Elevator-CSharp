namespace Elevator_CSharp
{
    class ElevatorMain
    {
        public enum ElevatorState { Idle = 0, Up = 1, Down = 1 };

        public int CurrentFloor = 0;
        public int CurrentState = (int)ElevatorState.Idle;
        public bool DoorState;


        public static void Main(string[] args) {
            // Logic is exercised via the unit tests.
        }
    }
}
