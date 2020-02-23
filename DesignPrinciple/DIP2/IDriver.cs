using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP2;



namespace DIP2
{
    public interface IDriver
    {
        void driver();
    }

    public class Driver : IDriver
    {
        private ICar car;

        //构造函数依赖注入
        public Driver(ICar _car)
        {
            this.car = _car;
        }

        
        public void driver()
        {
            car.run();
        }
    }
}
namespace DIP3
{
    public interface IDriver
    {
        void setCar(ICar car);
        void driver();
    }

    public class Driver : IDriver
    {
        private ICar car;

        //Setter 依赖注入
        public void setCar(ICar _car)
        {
            this.car = _car;
        }


        public void driver()
        {
            car.run();
        }
    }
}
namespace DIP4
{
    public interface IDriver
    {
        void driver(ICar car);
    }

    public class Driver : IDriver
    {
        //接口注入
        public void driver(ICar car)
        {
            car.run();
        }
    }
}
