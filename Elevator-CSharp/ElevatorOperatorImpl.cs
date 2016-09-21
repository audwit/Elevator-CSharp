using System;

namespace Elevator_CSharp
{
    public class ElevatorOperatorImpl : IElevatorOperator
    {
        ElevatorMain _elevator1;
        int _destinationFloor;
        //bool DoorState;


        public void Initialize(int startingFloor, bool initialDoorState, int topFloor)
        {
            _elevator1 = new ElevatorMain(startingFloor, initialDoorState, topFloor);  //public ElevatorMain(int currentFloor, int currentState, bool doorState)
            //throw new NotImplementedException();
        }

        public int GetCurrentFloor()
        {
            return _elevator1.GetCurrentFloor();
            //throw new NotImplementedException();
        }

        public bool AreDoorsOpen()
        {
            return _elevator1.GetDoorState();
            //throw new NotImplementedException();
        }

        public void Step()
        {
            int currentFloor = _elevator1.GetCurrentFloor();
            // Elevator going up
            if (currentFloor < _destinationFloor)
            {
                _elevator1.SetCurrentState((int)ElevatorMain.ElevatorState.Up);
                currentFloor = currentFloor + 1;
                _elevator1.SetCurrentFloor(currentFloor);
                if (currentFloor < _destinationFloor)
                    _elevator1.SetDoorState(false); // Since the Elevator is still going up door should be closed
            }
            // Elevator going down
            else if (currentFloor > _destinationFloor)
            {
                _elevator1.SetCurrentState((int)ElevatorMain.ElevatorState.Down);
                _elevator1.SetCurrentFloor(_elevator1.GetCurrentFloor() - 1);
                if (_elevator1.GetCurrentFloor() > _destinationFloor)
                    _elevator1.SetDoorState(false);
            }
            // Elevator is on the destination floor and the door is closed --> open the door
            else if (currentFloor == _destinationFloor && _elevator1.GetDoorState() == false)
                _elevator1.SetDoorState(true);
            // Elevator door needs to be closed as Elevator has reached destination floor and the door is open --> Close door
            else if (currentFloor == _destinationFloor && _elevator1.GetDoorState() == true)
                _elevator1.SetDoorState(false);
            //throw new NotImplementedException();
        }

        public void RequestPickup(int floor)
        {
            _destinationFloor = floor;
            //throw new NotImplementedException();
        }

        public void RequestDropoff(int floor)
        {
            _destinationFloor = floor;
            //throw new NotImplementedException();
        }
    }
}
