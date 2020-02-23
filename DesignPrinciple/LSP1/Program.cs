using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            soldier.SetGun(new Handgun());
            soldier.KillEnemy();
            Console.ReadLine();
        }
    }
}
