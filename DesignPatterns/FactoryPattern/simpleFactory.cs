using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.FactoryMethod;
namespace FactoryPattern
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
    public class Factory
    {
        public Phone phone { get; set; }
        public Factory(string DbType)
        {
            switch (DbType)
            {
                case "MiPhone":
                    phone = new MiPhone();
                    break;
                case "IPhone":
                    phone = new IPhone();
                    break;
              
            }
        }
    }
}
