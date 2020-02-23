
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Subject realSub = new RealSubject();
			Subject proxy = new Proxy(realSub);
			proxy.request();


			IGamePlayer player = new GamePlayer("张三");
			//然后再定义一个代练者
			IGamePlayer constraintProxy = player.getProxy();

			//开始打游戏，记下时间戳
			Console.WriteLine("开始时间是："+DateTime.Now);
			constraintProxy.login("zhangSan", "password");
			//开始杀怪
			constraintProxy.killBoss();
			//升级
			constraintProxy.upgrade();
			//记录结束游戏时间
			Console.WriteLine("结束时间是："+DateTime.Now);


			DynamicProxy proxy1 = new DynamicProxy(typeof(DynamicGamePlayer), new DynamicGamePlayer("张三"));
			DynamicGamePlayer plane = (DynamicGamePlayer)proxy1.GetTransparentProxy();
			plane.login("zhangSan", "password");
			plane.killBoss();
			plane.upgrade();
			Console.ReadLine();
		}
	}
	public interface Subject
	{
		//定义一个方法
		void request();
	}
	public class RealSubject : Subject
	{
		//实现方法
		public void request()
		{
			Console.WriteLine("RealSubject request ");
		}

	}
	public class Proxy : Subject
	{
		//要代理哪个实现类
		private Subject subject = null;

		//默认被代理者
		public Proxy()
		{
			this.subject = new RealSubject();
		}

		public Proxy(Subject _subject)
		{
			this.subject = _subject;
		}


		//实现接口中定义的方法
		public void request()
		{
			this.before();
			this.subject.request();
			this.after();
		}

		//预处理
		private void before()
		{
			Console.WriteLine("预处理");
		}

		//善后处理
		private void after()
		{
			Console.WriteLine("善后处理");
		}
	}
}
