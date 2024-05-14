using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class ToyotaTests
    {
        // Boolean Assert
        [Fact]
        public void IsMoving_Velocity10_true()
        {
            // arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 10;

            // act
            bool actualResult = toyota.IsMoving();

            // assert
            Assert.True(actualResult);
        }

        //Numeric Assert
        [Fact]
        public void TimeToCoverDistance_Distence20velocity10_time2()
        {
            // arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 10;

            // act
            double Result = toyota.TimeToCoverDistance(20);

            // assert
            Assert.InRange(Result, 0, 1000);
            Assert.Equal(Result, 2);   
        }

        [Theory]
        [InlineData(90, 45, 45)]
        [InlineData(100, 40, 60)]
        [InlineData(50, 30, 20)]
        public void DecreaseVelocity_useTestData_useTestOutput
            (double intialVelocity, double DecreasedVelocity, double ExpectedOutput)
        {
            // arrange
            Toyota toyota = new Toyota()
            { 
                velocity = intialVelocity
            };
            // act
            toyota.DecreaseVelocity(DecreasedVelocity);

            // assert
            Assert.Equal(ExpectedOutput, toyota.velocity);
           
        }


        //String Assert

        [Fact]
        public void GetDirection_DirectionBackword_backword()
        {
            // arrange
            Toyota toyota = new Toyota()
            {
                drivingMode = DrivingMode.Backward 
            };

            // act
            string result = toyota.GetDirection();

            // string Assert
            Assert.NotEqual("Forward", result);

            Assert.Contains("ck", result);
            Assert.DoesNotContain("zx", result);
        }
        [Fact]  
        public void IncreaseVelocity_velocity10Add20DirectionBackword_Velocity30DirectionBackword()
        {
            // arrange
            Toyota toyota = new Toyota() { velocity = 10};
            double addedVelocity = 20;

            // act
            toyota.IncreaseVelocity(addedVelocity,DrivingMode.Backward);

            // assert
            Assert.Equal(30, toyota.velocity);
            Assert.StartsWith("Ba", toyota.GetDirection());
            Assert.EndsWith("rd", toyota.GetDirection());
        }






    }
}
