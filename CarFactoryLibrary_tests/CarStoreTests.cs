using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class CarStoreTests
    {
        [Fact]
        public void AddCar_AddRangeCarsBMW_ListContainObjects()
        {
            // arrange
            CarStore store = new CarStore();
            List<Car> bmwCars = new List<Car>
            {
                new BMW(),
                new BMW(),
                new BMW(),
            };

            // act
            store.AddCars(bmwCars);

            // asserts
            Assert.NotEmpty(store.cars);
        }

        [Fact]
        public void AddCar_AddRangeCarsBMW_ListCarsOfTypeBMW()
        {
            // arrange
            CarStore store = new CarStore();
            List<Car> bmwCars = new List<Car>
            {
                new BMW(),
                new BMW(),
                new BMW(),
            };

            // act
            store.AddCars(bmwCars);

            // asserts
            Assert.Contains<Car>(store.cars,c=>c.GetType()== typeof(BMW));
        }
    }
}
