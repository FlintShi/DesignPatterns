using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOD2
{
	public class GroupLeader
	{
		List<Girl> listGirls;
		public GroupLeader(List<Girl> _listGirls)
		{
			this.listGirls = _listGirls;
		}

		//有清查女生的工作
		public void countGirls()
		{

			Console.WriteLine("女生数量是：" + listGirls.Count());
		}
	}
}
