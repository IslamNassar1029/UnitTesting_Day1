using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class BMWTests
    {
        //Reference Assert

        [Fact]
        public void GetMyCar_AskForRefrence_notNull()
        {
            // arrange
            BMW  bmw = new BMW();

            // act
            Car result = bmw.GetMyCar();

            // assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetMyCar_AskForRefrence_NotTheSame()
        {
            // arrange
            BMW bmw = new BMW();
            BMW bmwNotMyCar = new BMW();

            // act
            Car result = bmw.GetMyCar();

            // assert
            Assert.NotSame(bmwNotMyCar, result);
        }

        //Reference Assert


        [Fact]
        public void GetMyCar_AskForType_BMW()
        {
            // arrange
            BMW bmw = new BMW();

            // act
            Car result = bmw.GetMyCar();

            // assert
            Assert.IsType<BMW>(result);
        }

        [Fact]
        public void GetMyCar_AskForType_NotToyota()
        {
            // arrange
            BMW bmw = new BMW();
            BMW bmwNotMyCar = new BMW();

            // act
            Car result = bmw.GetMyCar();

            // assert
            Assert.IsNotType<Toyota>(result);
        }
        [Fact]
        public void GetMyCar_AskForTypeParant_car()
        {
            // arrange
            BMW bmw = new BMW();

            // act
            Car result = bmw.GetMyCar();

            // assert
            Assert.IsAssignableFrom<Car>(result);
        }
    }
}
