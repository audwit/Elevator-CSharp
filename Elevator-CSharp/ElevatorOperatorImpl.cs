using System;

namespace Elevator_CSharp
{
    public class ElevatorOperatorImpl : IElevatorOperator
    {
        int globStartingFloor = 0;
        int globTopFloor = 0;
        bool globIntialDoorState;
        int globCurrentFloor;

        
        public void Initialize(int startingFloor, bool initialDoorState, int topFloor)
        {
            globStartingFloor = startingFloor;
            globIntialDoorState = initialDoorState; 
            globTopFloor = topFloor;
            globCurrentFloor = startingFloor;
            //throw new NotImplementedException();
        }

        public int GetCurrentFloor()
        {
            return globCurrentFloor;
            //throw new NotImplementedException();
        }

        public bool AreDoorsOpen()
        {
            throw new NotImplementedException();
        }

        public void Step()
        {
            throw new NotImplementedException();
        }

        public void RequestPickup(int floor)
        {
            if()
            throw new NotImplementedException();
        }

        public void RequestDropoff(int floor)
        {
            throw new NotImplementedException();
        }
    }
}
