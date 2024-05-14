using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class CarFactoryTests
    {
        // Exception Assert

        [Fact]
        public void NewCar_AskForHonda_Exception()
        {
            //arange
            //assert
            Assert.ThrowsAny<Exception>(() =>
            {
                // act
                var result = CarFactory.NewCar(CarTypes.Honda);
            });

        }
    }
}
