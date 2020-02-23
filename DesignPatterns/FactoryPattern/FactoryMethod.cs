using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
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


    //工厂方法
    public interface IFactory
    {
        Phone getPhone();
    }
    public class MiFactory : IFactory
    {
        public Phone getPhone()
        {
            return new MiPhone();
        }
    }
    public class AppleFactory : IFactory
    {
        public Phone getPhone()
        {
            return new IPhone(); 
        }
    }
   
}
