using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
	public abstract class AbstractSearcher
	{
		protected IPettyGirl pettyGirl;
		public AbstractSearcher(IPettyGirl _pettyGirl)
		{
			this.pettyGirl = _pettyGirl;
		}

		//搜索美女，列出美女信息
		public abstract void show();
	}
	public class Searcher : AbstractSearcher
	{
		public Searcher(IPettyGirl _pettyGirl) : base(_pettyGirl)
		{

		}

		//展示美女的信息
		public override void show()
		{
			Console.WriteLine("--------美女的信息如下：---------------");
			//展示面容
			base.pettyGirl.goodLooking();
			//展示身材
			base.pettyGirl.niceFigure();
			//展示气质
			base.pettyGirl.greatTemperament();
		}
	}
}
