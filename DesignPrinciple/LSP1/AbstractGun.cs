using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP1
{
    public abstract class AbstractGun
    {
        //抢是用来干嘛的？杀敌！
        public abstract void shoot();
    }
    public class Handgun : AbstractGun
    {
        public override void shoot()
        {
            Console.WriteLine("手枪射击...");
        }
    }

    public class MachineGun : AbstractGun
    {
        public override void shoot()
        {
            Console.WriteLine("机枪射击...");
        }
    }

    public class Rifle : AbstractGun
    {
        public override void shoot()
        {
            Console.WriteLine("步枪射击...");
        }
    }

    public class ToyGun : AbstractGun
    {
        //玩具手枪不能射击，虚构一个
        public override void shoot()
        {
           
        }
    }
}
