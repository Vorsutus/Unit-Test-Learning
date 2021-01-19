using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; //needed for using unit testing framework
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //CTRL R and then R again to rename Class
    [TestClass]
    public class ReservationTest //convention is NameOfClassTest
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue() //convention is NameOfMethod_Scenario_ExpectedBehavior
        {
            //Arrange - where we initialize our objects
            var reservation = new Reservation();

            //Act - where we act on this object (call method we are going to test) (store as a result)
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true}); //give the method a user that is an admin user

            //Assert -  where we verify that the result is correct by passing it the result
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_MadeByUser_ReturnsTrue()
        {
            //Arrange
            var user = new User();                              //simulated user
            var reservation = new Reservation{MadeBy = user};   //set MadeBy to our simulated user

            //Act
            var result = reservation.CanBeCancelledBy(user);    //canceled by simulated user

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingRes_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation {MadeBy = new User()};   //set MadeBy to a simulated user

            //Act
            var result = reservation.CanBeCancelledBy(new User());    //canceled by a different simulated user

            //Assert
            Assert.IsFalse(result);
        }
    }
}
