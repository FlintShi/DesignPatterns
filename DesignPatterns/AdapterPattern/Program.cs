using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //原有的业务逻辑
            Target target = new ConcreteTarget();
            target.request();

            //现在增加了适配器角色后的业务逻辑
            Target target2 = new Adapter();
            target2.request();


            //外系统的人员信息
            IOuterUserBaseInfo baseInfo = new OuterUserBaseInfo();
            IOuterUserHomeInfo homeInfo = new OuterUserHomeInfo();
            IOuterUserOfficeInfo officeInfo = new OuterUserOfficeInfo();
            //传递三个对象
            IUserInfo youngGirl = new OuterUserInfo(baseInfo, homeInfo, officeInfo);
            //从数据库中查到10个
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"-------{i}-----");
                youngGirl.getUserName();
                youngGirl.getHomeAddress();
                youngGirl.getJobPosition();
            }
            Console.ReadLine();
        }
    }

    public class Adaptee
    {
        //原有的业务逻辑
        public void doSomething()
        {
            Console.WriteLine("I'm kind of busy,leave me alone,pls!");
        }
    }
    public class Adapter : Adaptee, Target
    {
        public void request()
        {
            base.doSomething();
        }

    }
    public interface Target
    {

        //目标角色有自己的方法
        void request();
    }
    public class ConcreteTarget : Target
    {
        public void request()
        {
            Console.WriteLine("I have nothing to do. if you need any help,pls call me!");
        }

    }
}
