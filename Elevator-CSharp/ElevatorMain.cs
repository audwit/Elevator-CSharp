namespace Elevator_CSharp
{
    class ElevatorMain
    {
        public enum ElevatorState { Idle = 0, Up = 1, Down = 1 };

        private int CurrentFloor = 0;
        private int CurrentState = (int)ElevatorState.Idle;
        private bool DoorState;
        private int TopFloor;
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
        public int getTopFloor()
        {
            return TopFloor;
        }
        public void setTopFloor(int topFloor)
        {
            TopFloor = topFloor;
        }
        public ElevatorMain(int currentFloor, bool doorState, int topFloor)
        {
            CurrentState = (int)ElevatorState.Idle;
            CurrentFloor = currentFloor;
            DoorState = doorState;
            TopFloor = topFloor;
        }

        public static void Main(string[] args) {
            // Logic is exercised via the unit tests.
        }
    }
}
