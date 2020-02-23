using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOD2
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生一个女生群体
            List<Girl> listGirls = new List<Girl>();
            //初始化女生
            for (int i = 0; i < 20; i++)
            {
                listGirls.Add(new Girl());
            }
            
            Teacher teacher = new Teacher();

            //老师发布命令
            teacher.commond(new GroupLeader(listGirls));
            Console.ReadLine();
        }
    }
}
