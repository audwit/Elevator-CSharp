namespace Elevator_CSharp
{
    public interface IElevatorOperator
    {
        /**
         * Initializes this ElevatorOperator instance, setting the top
         * floor in the building.
         */
        void Initialize(int startingFloor, bool initialDoorState, int topFloor);


        /**
         * The current location (floor number) of the elevator.
         */
        int GetCurrentFloor();

        /**
         * A boolean indication of whether or not the elevator 
         * doors are currently open.
         */
        bool AreDoorsOpen();


        /**
         * Takes one of the following actions, updating the state of 
         * the elevator:
         *  - Moves up
         *  - Moves down
         *  - Opens doors
         *  - Closes doors
         *  - Do nothing
         */
        void Step();

        /**
         * Indicates that a customer is waiting on the specified floor 
         * to be picked up.
         * 
         */
        void RequestPickup(int floor);

        /**
         * Indicates that a customer inside the elevator has requested 
         * to be dropped off at the specified floor.
         */
        void RequestDropoff(int floor);
    }
}
