using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOD1
{
	public class Teacher
	{

		//老师对学生发布命令,清一下女生
		public void commond(GroupLeader groupLeader)
		{
			List<Girl> listGirls = new List<Girl>();
			//初始化女生
			for (int i = 0; i < 20; i++)
			{
				listGirls.Add(new Girl());
			}

			//告诉体育委员开始执行清查任务
			groupLeader.countGirls(listGirls);
		}
	}
}
