using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public abstract class CarModel
	{
		//这个参数是各个基本方法执行的顺序
		private List<String> sequence = new List<String>();
		//模型是启动开始跑了
		protected abstract void start();
		//能发动，那还要能停下来，那才是真本事
		protected abstract void stop();
		//喇叭会出声音，是滴滴叫，还是哔哔叫
		protected abstract void alarm();
		//引擎会轰隆隆的响，不响那是假的
		protected abstract void engineBoom();
		//那模型应该会跑吧，别管是人推的，还是电力驱动，总之要会跑
		public void run()
		{
			//循环一边，谁在前，就先执行谁
			for (int i = 0; i < this.sequence.Count(); i++)
			{
				String actionName = this.sequence[i];

				if (actionName.ToLower().Equals("start"))
				{  //如果是start关键字，
					this.start();  //开启汽车
				}
				else if (actionName.ToLower().Equals("stop"))
				{ //如果是stop关键字
					this.stop(); //停止汽车   
				}
				else if (actionName.ToLower().Equals("alarm"))
				{ //如果是alarm关键字
					this.alarm(); //喇叭开始叫了
				}
				else if (actionName.ToLower().Equals("engine boom"))
				{  //如果是engine boom关键字
					this.engineBoom();  //引擎开始轰鸣
				}

			}

		}
		//把传递过来的值传递到类内
		public void setSequence(List<String> sequence)
		{
			this.sequence = sequence;
		}
	}

	public class BenzModel : CarModel
	{
		protected override void alarm(){Console.WriteLine("奔驰车的喇叭声音是这个样子的...");}
		protected override void engineBoom() { Console.WriteLine("奔驰车的引擎室这个声音的..."); }
		protected override void start() { Console.WriteLine("奔驰车跑起来是这个样子的..."); }
		protected override void stop() { Console.WriteLine("奔驰车应该这样停车..."); }

	}
	public abstract class CarBuilder
	{
		//建造一个模型，你要给我一个顺序，就是组装顺序
		public abstract void setSequence(List<String> sequence);

		//设置完毕顺序后，就可以直接拿到这个这两模型
		public abstract CarModel getCarModel();
	}

	public class BenzBuilder : CarBuilder
	{
		private BenzModel benz = new BenzModel();

		public override CarModel getCarModel()
		{
			return this.benz;
		}
		public override void setSequence(List<String> sequence)
		{
			this.benz.setSequence(sequence);
		}

	}

	public class CarDirector
	{
		private List<String> sequence = new List<String>();
		private BenzBuilder benzBuilder = new BenzBuilder();

		 //* A类型的奔驰车模型，先start,然后stop,其他什么引擎了，喇叭一概没有
		public BenzModel getABenzModel()
		{
			//清理场景，这里是一些初级程序员不注意的地方
			this.sequence.Clear();

			//这只ABenzModel的执行顺序
			this.sequence.Add("start");
			this.sequence.Add("stop");

			//按照顺序返回一个奔驰车
			this.benzBuilder.setSequence(this.sequence);
			return (BenzModel)this.benzBuilder.getCarModel();

		}

		 //* B型号的奔驰车模型，是先发动引擎，然后启动，然后停止，没有喇叭
		public BenzModel getBBenzModel()
		{
			this.sequence.Clear();

			this.sequence.Add("engine boom");
			this.sequence.Add("start");
			this.sequence.Add("stop");

			this.benzBuilder.setSequence(this.sequence);
			return (BenzModel)this.benzBuilder.getCarModel();
		}

	}
}
