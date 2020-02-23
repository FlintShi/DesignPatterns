using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP1
{
    public interface IDriver
    {
        void driver(ICar car);
    }

    public class Driver : IDriver
    {
        public void driver(ICar car)
        {
            car.run();
        }
    }
}
