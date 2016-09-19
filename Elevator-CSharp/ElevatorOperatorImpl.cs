using System;

namespace Elevator_CSharp
{
    public class ElevatorOperatorImpl : IElevatorOperator
    {
        /*
         int globStartingFloor = 0;
        int globTopFloor = 0;
        bool globIntialDoorState;
        int globCurrentFloor;
        */

        ElevatorMain Elevator1 = new ElevatorMain();
        int DestinationFloor = 0;
        public void Initialize(int startingFloor, bool initialDoorState, int topFloor)
        {
            

            /*globStartingFloor = startingFloor;
            globIntialDoorState = initialDoorState; 
            globTopFloor = topFloor;
            globCurrentFloor = startingFloor;*/

            //Setting the Elevator Objects current floor and doorstate and Elevator state
            Elevator1.CurrentFloor = startingFloor;
            Elevator1.DoorState = initialDoorState;
            Elevator1.CurrentState = (int)ElevatorMain.ElevatorState.Idle;
            //throw new NotImplementedException();
        }

        public int GetCurrentFloor()
        {
            
            throw new NotImplementedException();
        }

        public bool AreDoorsOpen()
        {
            return Elevator1.DoorState;
            //throw new NotImplementedException();
        }

        public void Step()
        {
            // Elevator going up
            if (Elevator1.CurrentFloor < DestinationFloor)
            {
                Elevator1.CurrentState = (int)ElevatorMain.ElevatorState.Up;
                Elevator1.CurrentFloor++;
                if (Elevator1.CurrentFloor < DestinationFloor)
                    Elevator1.DoorState = false; // Since the Elevator is still going up door should be closed
            }
            // Elevator going down
            if (Elevator1.CurrentFloor > DestinationFloor)
                Elevator1.CurrentState = (int)ElevatorMain.ElevatorState.Down;
            //throw new NotImplementedException();
        }

        public void RequestPickup(int floor)
        {
            // When The Elevator is idle and someone from the same floor requests pickup ---> Simply open the door (Assuming doorstate false means closed and true means open) 
            if (Elevator1.CurrentState == (int)ElevatorMain.ElevatorState.Idle && Elevator1.CurrentFloor == floor)
                Elevator1.DoorState = true;
            //When Elevator is going up and someone from up requests pickup

            //throw new NotImplementedException();
        }

        public void RequestDropoff(int floor)
        {
            throw new NotImplementedException();
        }
    }
}
