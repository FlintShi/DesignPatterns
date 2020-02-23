using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生三毛这个狙击手
            Snipper sanMao = new Snipper();
            sanMao.setRifle(new AUG());
            sanMao.KillEnemy();
            Console.ReadLine();
        }
    }
}
