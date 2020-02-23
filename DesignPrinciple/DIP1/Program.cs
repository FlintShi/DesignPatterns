using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDriver san = new Driver();
            ICar benz = new Benz();
            //san 开奔驰
            san.driver(benz);
            Console.ReadLine();
        }
    }
}
