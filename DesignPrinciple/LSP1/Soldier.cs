using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP1
{
    public class Soldier
    {
        private AbstractGun abstractGun;
        public void SetGun(AbstractGun gun)
        {
            this.abstractGun = gun;
        }
        public void KillEnemy()
        {
            Console.WriteLine("士兵开始杀死敌人...");
            this.abstractGun.shoot();
        }
    }
}
