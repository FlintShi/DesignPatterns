using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DIP1;
using Moq;

namespace DIPunitTest
{
    public class DIPTest
    {
        private Mock<IDriver> mockDriver;
        private Mock<ICar> mockCar;
        public DIPTest()
        {
            mockCar = new Mock<ICar>();
            mockDriver = new Mock<IDriver>();
            mockDriver.Setup(t => t.driver(It.IsAny<ICar>())).Callback<ICar>(t=> {
                Console.WriteLine("run");
            });
        }


        [Fact]
        public void DriverTest()
        {
            ICar benz = new Benz();
            //san 开奔驰
            mockDriver.Object.driver(benz);
            mockDriver.Verify(t => t.driver(It.IsAny<ICar>()), Times.Once);
          
        }
    
    }
}
