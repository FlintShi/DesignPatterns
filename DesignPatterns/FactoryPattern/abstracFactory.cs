using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.abstracFactory
{



    public interface Phone
    {
        void make();
    }

    public class MiPhone : Phone
    {
        public void make()
        {
            Console.WriteLine("make xiaomi phone!");
        }
    }
    public class IPhone : Phone
    {

        public void make()
        {
            Console.WriteLine("make iphone!");
        }
    }

    public interface PC
    {
        void make();
    }

    public class MiPC : PC
    {
        public void make()
        {
            Console.WriteLine("make xiaomi PC!");
        }
    }
    public class Mac : PC
    {

        public void make()
        {
            Console.WriteLine("make Mac!");
        }
    }


    //工厂方法
    public interface AbstractFactory
    {
        Phone getPhone();
        PC getPc();
    }
    public class MiFactory : AbstractFactory
    {
        public Phone getPhone()
        {
            return new MiPhone(); 
        }
        public PC getPc()
        {
            return new MiPC(); 
        }
    }
    public class AppleFactory : AbstractFactory
    {
        public Phone getPhone()
        {
            return new IPhone();
        }
        public PC getPc()
        {
            return new Mac();
        }
    }
}
