using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP1
{
    public interface ICar
    {
        void run();
    }
    public class BMW : ICar
    {
        public void run()
        {
            Console.WriteLine("BMW Run...");
        }

    }

    public class Benz : ICar
    {
        public void run()
        {
            Console.WriteLine("Benz Run...");
        }

    }
}
