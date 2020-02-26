using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Context context = new Context();
			context.setState(new BlueState());

			context.pull();
			context.pull();
			context.pull();
			context.pull();
			context.pull();
			Console.ReadLine();
		}
	}

	public abstract class State
	{
		public abstract void handlepush(Context c);
		public abstract void handlepull(Context c);
		public abstract Color getcolor();
	}
	//状态切换顺序
	//push：blue-->green-->black-->red-->blue
	//pull：blue-->red-->black-->green-->blue
	public class BlueState : State
	{
		public override void handlepush(Context c)
		{
			Console.WriteLine("变成绿色");
			c.setState(new GreenState());
		}
		public override void handlepull(Context c)
		{
			Console.WriteLine("变成红色");
			c.setState(new RedState());
		}
		public override Color getcolor()
		{ return Color.Blue; }
	}
	public class GreenState : State
	{
		public override void handlepush(Context c)
		{
			Console.WriteLine("变成黑色");
			c.setState(new BlackState());
		}
		public override void handlepull(Context c)
		{
			Console.WriteLine("变成蓝色");
			c.setState(new BlueState());
		}
		public override Color getcolor()
		{ return Color.Green; }
	}
	public class BlackState : State
	{
		public override void handlepush(Context c)
		{
			Console.WriteLine("变成红色");
			c.setState(new RedState());
		}
		public override void handlepull(Context c)
		{
			Console.WriteLine("变成绿色");
			c.setState(new GreenState());
		}
		public override Color getcolor()
		{ return Color.Black; }
	}
	public class RedState : State
	{
		public override void handlepush(Context c)
		{
			Console.WriteLine("变成蓝色");
			c.setState(new BlueState());
		}
		public override void handlepull(Context c)
		{
			Console.WriteLine("变成黑色");
			c.setState(new BlackState());
		}
		public override Color getcolor()
		{ return Color.Red; }
	}
	public class Context
	{
		private State state = null;
		//setState是用来改变state的状态 使用setState实现状态的切换
		public void setState(State state)
		{ this.state = state; }

		public void push()
		{
			//状态的切换的细节部分,在本例中是颜色的变化,已经封装在子类的handlepush中实现,这里无需关心
			state.handlepush(this);
		}

		public void pull()
		{ state.handlepull(this); }
	}
}
