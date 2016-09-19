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

        ElevatorMain Elevator1 = null;
        int TopFloor=0;
        int DestinationFloor = 0;
        public void Initialize(int startingFloor, bool initialDoorState, int topFloor)
        {
            
            ElevatorMain Elevator1 = new ElevatorMain(startingFloor,(int)ElevatorMain.ElevatorState.Idle,initialDoorState);  //public ElevatorMain(int currentFloor, int currentState, bool doorState)
            
            //throw new NotImplementedException();
        }

        public int GetCurrentFloor()
        {
            
            throw new NotImplementedException();
        }

        public bool AreDoorsOpen()
        {
            return Elevator1.getDoorState();
            //throw new NotImplementedException();
        }

        public void Step()
        {
            int currentFloor = Elevator1.GetCurrentFloor();
            // Elevator going up
            if (currentFloor < DestinationFloor)
            {
                Elevator1.setCurrentState((int)ElevatorMain.ElevatorState.Up);
                Elevator1.SetCurrentFloor(currentFloor++);
                if (currentFloor < DestinationFloor)
                    Elevator1.setDoorState(false); // Since the Elevator is still going up door should be closed
            }
            // Elevator going down
            if (currentFloor > DestinationFloor)
                Elevator1.setCurrentState((int)ElevatorMain.ElevatorState.Down);
            //throw new NotImplementedException();
        }

        public void RequestPickup(int floor)
        {
            int currentState = 0;
            int currentFloor = 0;
            currentState = Elevator1.getCurrentState();
            currentFloor = Elevator1.GetCurrentFloor();
            // When The Elevator is idle and someone from the same floor requests pickup ---> Simply open the door (Assuming doorstate false means closed and true means open) 
            if (currentState == (int)ElevatorMain.ElevatorState.Idle && currentFloor == floor)
                Elevator1.setDoorState(true);
            //When Elevator is going up and someone from up requests pickup
            else if(currentState == (int)ElevatorMain.ElevatorState.Up && currentFloor < floor)  // Start thinking from here ..... Such a case is not mentioned in the test case
                
            //throw new NotImplementedException();
        }

        public void RequestDropoff(int floor)
        {
            throw new NotImplementedException();
        }
    }
}
