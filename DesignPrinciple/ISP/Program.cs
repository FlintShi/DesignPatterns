using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个美女
            IPettyGirl yanYan = new PettyGirl("嫣嫣");
            AbstractSearcher searcher = new Searcher(yanYan);
            searcher.show();
            Console.ReadLine();
        }
    }
}
