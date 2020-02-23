using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDirector director = new CarDirector();

            //1辆A类型的奔驰车
            for (int i = 0; i < 1; i++)
            {
                director.getABenzModel().run();
            }

            //10辆B类型的奔驰车
            for (int i = 0; i < 10; i++)
            {
                director.getBBenzModel().run();
            }
            Console.ReadLine();

        }
    }

    public abstract class Builder
    {
        //设置产品的不同部分，以获得不同的产品
        public abstract void setPart();
        //建造产品
        public abstract Product buildProduct();
    }
    public class Product
    {
        public void doSomething()
        {
            //独立业务处理
        }
    }
    public class Director
    {
        private Builder builder = new ConcreteProduct();

        //构建不同的产品
        public Product getAProduct()
        {
            builder.setPart();
            /*
             * 设置不同的零件，产生不同的产品
             */
            return builder.buildProduct();
        }
    }
    public class ConcreteProduct : Builder
    {
        private Product product = new Product();

        //设置产品零件
        public override void setPart()
        {
            /*
             * 产品类内的逻辑处理
             */
        }

        //组建一个产品
        public override Product buildProduct()
        {
            return product;
        }

    }
}
