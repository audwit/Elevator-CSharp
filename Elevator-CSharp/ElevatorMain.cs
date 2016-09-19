namespace Elevator_CSharp
{
    class ElevatorMain
    {
        public enum ElevatorState { Idle = 0, Up = 1, Down = 1 };

        private int CurrentFloor = 0;
        private int CurrentState = (int)ElevatorState.Idle;
        private bool DoorState;

        public int GetCurrentFloor()
        {
            return CurrentFloor;
        }
        public void SetCurrentFloor(int currentFloor)
        {
            CurrentFloor = currentFloor;
        }
        public int getCurrentState()
        {
            return CurrentState;
        }
        public void setCurrentState(int currentState)
        {
            CurrentState = currentState;
        }
        public bool getDoorState()
        {
            return DoorState;
        }
        public void setDoorState(bool doorState)
        {
            DoorState = doorState;
        }
        
        public ElevatorMain(int currentFloor, int currentState, bool doorState)
        {
            CurrentFloor = 0;
            CurrentState = (int)ElevatorState.Idle;
            DoorState = false;
        }

        public static void Main(string[] args) {
            // Logic is exercised via the unit tests.
        }
    }
}
