
using FactoryPattern.abstracFactory;
using FactoryPattern.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string DataBaseType = "IPhone";
            Factory factory = new Factory(DataBaseType);
            factory.phone.make();

            IFactory FactoryMethod = new FactoryMethod.MiFactory();
            var phone = FactoryMethod.getPhone();
            phone.make();

            AbstractFactory AbstractFactory = new abstracFactory.MiFactory();
            var abPhone = AbstractFactory.getPhone();
            var abPc = AbstractFactory.getPc();
            abPhone.make();
            abPc.make();

            Console.ReadKey();
        }
    }
}
