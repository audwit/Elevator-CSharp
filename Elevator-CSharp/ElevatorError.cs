using System;

namespace Elevator_CSharp
{
    class ElevatorError : SystemException
    {
        public ElevatorError() {
        }

        public ElevatorError(string message) : base(message) {
        }
    }
}
