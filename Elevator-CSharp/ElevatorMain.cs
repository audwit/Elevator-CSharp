using System.Collections.Generic;
namespace Elevator_CSharp
{
    class ElevatorMain
    {
        public enum ElevatorState { Idle = 0, Up = 1, Down = 1 };

        private int _currentFloor;
        private int _currentState;
        private bool _doorState;
        private int _topFloor;

        public ElevatorMain(int currentFloor, bool doorState, int topFloor)
        {
            _currentState = (int)ElevatorState.Idle;
            _currentFloor = currentFloor;
            _doorState = doorState;
            _topFloor = topFloor;
        }

        public int GetCurrentFloor()
        {
            return _currentFloor;
        }
        public void SetCurrentFloor(int currentFloor)
        {
            _currentFloor = currentFloor;
        }
        public int GetCurrentState()
        {
            return _currentState;
        }
        public void SetCurrentState(int currentState)
        {
            _currentState = currentState;
        }
        public bool GetDoorState()
        {
            return _doorState;
        }
        public void SetDoorState(bool doorState)
        {
            _doorState = doorState;
        }
        public int GetTopFloor()
        {
            return _topFloor;
        }
        public void SetTopFloor(int topFloor)
        {
            _topFloor = topFloor;
        }



        public static void Main(string[] args)
        {
            // Logic is exercised via the unit tests.
        }
    }
}
