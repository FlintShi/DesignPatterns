using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP2
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

    public class AK47 : Rifle
    {
        public override void shoot()
        {
            Console.WriteLine("AK47射击...");
        }
    }

    public class AUG : Rifle
    {
        public override void shoot()
        {
            Console.WriteLine("AUG射击...");
        }
        public  void zoomOut()
        {
            Console.WriteLine("AUG通过望远镜观测敌人...");
        }
    }
}
