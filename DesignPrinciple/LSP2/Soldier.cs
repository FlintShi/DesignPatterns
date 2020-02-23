using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP2
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
    public class Snipper {

        private AUG aug;

        //给狙击手一般狙击枪
        public void setRifle(AUG _aug)
        {
            this.aug = _aug;
        }
        public void KillEnemy()
        {
            //首先看看敌人的情况，别杀死敌人，自己也被人干掉
            aug.zoomOut();
            //开始射击
            aug.shoot();
        }
    }
}
