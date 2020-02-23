using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOD3
{
    public class Wizard
    {
		private Random rand = new Random();
		//第一步
		public int first()
		{
			Console.WriteLine("执行第一个方法...");
			return rand.Next(100);
		}

		//第二步
		public int second()
		{
			Console.WriteLine("执行第二个方法...");
			return rand.Next(100);
		}

		//第三个方法
		public int third()
		{
			Console.WriteLine("执行第三个方法...");
			return rand.Next(100);
		}

	}
}
