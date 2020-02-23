using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

            //老师发布命令
            teacher.commond(new GroupLeader());
            Console.ReadLine();
        }
    }
}
