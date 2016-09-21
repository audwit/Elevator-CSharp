using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elevator_CSharp;

namespace ElevatorTests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void TestPickupRequest()
        {
            IElevatorOperator elevatorOp = new ElevatorOperatorImpl();
            elevatorOp.Initialize(0, false, 10);

            elevatorOp.RequestPickup(1);
            elevatorOp.Step();
            Assert.AreEqual(1, elevatorOp.GetCurrentFloor());

            elevatorOp.Step();
            Assert.IsTrue(elevatorOp.AreDoorsOpen());
            // Person enters elevator.
            elevatorOp.Step();
            Assert.IsFalse(elevatorOp.AreDoorsOpen());
        }

        [TestMethod]
        public void TestDropoffRequest()
        {
            IElevatorOperator elevatorOp = new ElevatorOperatorImpl();
            elevatorOp.Initialize(7, false, 10);

            elevatorOp.RequestPickup(7);

            elevatorOp.Step();
            Assert.IsTrue(elevatorOp.AreDoorsOpen());
            // Person enters elevator.
            elevatorOp.Step();
            Assert.IsFalse(elevatorOp.AreDoorsOpen());

            elevatorOp.RequestDropoff(3);

            elevatorOp.Step();
            Assert.AreEqual(6, elevatorOp.GetCurrentFloor());
            elevatorOp.Step();
            Assert.AreEqual(5, elevatorOp.GetCurrentFloor());
            elevatorOp.Step();
            Assert.AreEqual(4, elevatorOp.GetCurrentFloor());
            elevatorOp.Step();
            Assert.AreEqual(3, elevatorOp.GetCurrentFloor());


            elevatorOp.Step();
            Assert.IsTrue(elevatorOp.AreDoorsOpen());
            // Person leaves elevator.
            elevatorOp.Step();
            Assert.IsFalse(elevatorOp.AreDoorsOpen());
        }

        [TestMethod]
        public void MyTests()
        {
            IElevatorOperator elevatorOp = new ElevatorOperatorImpl();
            elevatorOp.Initialize(7, true, 10);  // What should happen if the elevator object is initialized with doorstate true/door open
            elevatorOp.Step();
            Assert.IsFalse(elevatorOp.AreDoorsOpen());
            elevatorOp.RequestPickup(6);
        }
    }
}
