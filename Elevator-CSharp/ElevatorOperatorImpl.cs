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

        ElevatorMain elevator1 = null;
        int DestinationFloor = 0;
        //bool DoorState;
        public void Initialize(int startingFloor, bool initialDoorState, int topFloor)
        {
            
            elevator1 = new ElevatorMain(startingFloor,initialDoorState,topFloor);  //public ElevatorMain(int currentFloor, int currentState, bool doorState)
            //throw new NotImplementedException();
        }

        public int GetCurrentFloor()
        {
            return elevator1.GetCurrentFloor();
            //throw new NotImplementedException();
        }

        public bool AreDoorsOpen()
        {
            return elevator1.getDoorState();
            //throw new NotImplementedException();
        }

        public void Step()
        {
            int currentFloor = elevator1.GetCurrentFloor();
            // Elevator going up
            if (currentFloor < DestinationFloor)
            {
                elevator1.setCurrentState((int)ElevatorMain.ElevatorState.Up);
                currentFloor = currentFloor + 1;
                elevator1.SetCurrentFloor(currentFloor);
                if (currentFloor < DestinationFloor)
                    elevator1.setDoorState(false); // Since the Elevator is still going up door should be closed
            }
            // Elevator going down
            else if (currentFloor > DestinationFloor)
            {
                elevator1.setCurrentState((int)ElevatorMain.ElevatorState.Down);
                elevator1.SetCurrentFloor(elevator1.GetCurrentFloor() - 1);
                if (elevator1.GetCurrentFloor() > DestinationFloor)
                    elevator1.setDoorState(false);
            }
            // Elevator is on the destination floor and the door is closed --> open the door
            else if (currentFloor == DestinationFloor && elevator1.getDoorState() == false)
                elevator1.setDoorState(true);
            // Elevator door needs to be closed as Elevator has reached destination floor and the door is open --> Close door
            else if (currentFloor == DestinationFloor && elevator1.getDoorState() == true)
                elevator1.setDoorState(false);
            //throw new NotImplementedException();
        }

        public void RequestPickup(int floor)
        {
            //int currentState = 0;
            //int currentFloor = 0;
            //currentState = elevator1.getCurrentState();
            //currentFloor = elevator1.GetCurrentFloor();
            DestinationFloor = floor;

            // When The Elevator is idle and someone from the same floor requests pickup ---> Simply open the door (Assuming doorstate false means closed and true means open) 
            //if (currentState == (int)ElevatorMain.ElevatorState.Idle && currentFloor == floor)
                //Do Nothing //elevator1.setDoorState(true);
            //When Elevator is going up and someone from up requests pickup
            //else if(currentState == (int)ElevatorMain.ElevatorState.Up && currentFloor < floor)  // Start thinking from here ..... Such a case is not mentioned in the test case
                
            //throw new NotImplementedException();
        }

        public void RequestDropoff(int floor)
        {
            DestinationFloor = floor;
            //throw new NotImplementedException();
        }
    }
}
