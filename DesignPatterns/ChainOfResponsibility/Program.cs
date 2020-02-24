using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
		{//声明出所有的处理节点
			Handler handler1 = new ConcreteHandler1();
			Handler handler2 = new ConcreteHandler2();
			Handler handler3 = new ConcreteHandler3();
			//设置链中的阶段顺序,1-->2-->3
			handler1.setNext(handler2);
			handler2.setNext(handler3);
			//提交请求，返回结果
			Response response = handler1.handlerMessage(new Request(new Level() { num=2}));
	
			Console.WriteLine(response);


			Demo.Handler PM = new Demo.PM();
			Demo.Handler DM = new Demo.DM();
			Demo.Handler VP = new Demo.VP();
			//设置链中的阶段顺序,1-->2-->3
			PM.setNext(DM);
			DM.setNext(VP);
			//提交请求，返回结果
			Demo.Response Response1 = PM.handlerMessage(new Demo.Request(1));
			Demo.Response Response2 = PM.handlerMessage(new Demo.Request(2));
			Demo.Response Response3 = PM.handlerMessage(new Demo.Request(3));

			Console.ReadLine();

		}
    }
	public class Response
	{
		//处理者返回的数据
	}
	public class Level
	{
		public int num { get; set; }
	}
	public class Request
	{
		private Level level;
		public Request(Level level) { this.level = level; }
		//请求的等级
		public Level getRequestLevel()
		{
			return level;
		}
	}
	public abstract class Handler
	{
		private Handler nextHandler;

		//每个处理者都必须对请求做出处理
		public  Response handlerMessage(Request request)
		{
			Response response = null;

			//判断是否是自己的处理级别
			if (this.getHandlerLevel().num.Equals(request.getRequestLevel().num))
			{
				response = this.echo(request);
			}
			else
			{  //不属于自己的处理级别
			   //判断是否有下一个处理者
				if (this.nextHandler != null)
				{
					response = this.nextHandler.handlerMessage(request);
				}
				else
				{
					//没有适当的处理者，业务自行处理
				}
			}
			return response;
		}
		//设置下一个处理者是谁
		public void setNext(Handler _handler)
		{
			this.nextHandler = _handler;
		}
		//每个处理者都有一个处理级别
		protected abstract Level getHandlerLevel();

		//每个处理者都必须实现处理任务
		protected abstract Response echo(Request request);

	}
	public class ConcreteHandler1 : Handler
	{
		//定义自己的处理逻辑
		protected override Response echo(Request request)
		{
			//完成处理逻辑
			return null;
		}
		//设置自己的处理级别
		protected override Level getHandlerLevel()
		{
			//设置自己的处理级别
			return new Level() { num=1};
		}

	}
	public class ConcreteHandler2 : Handler
	{
		//定义自己的处理逻辑
		protected override Response echo(Request request)
		{
			//完成处理逻辑
			return null;
		}
		//设置自己的处理级别
		protected override Level getHandlerLevel()
		{
			//设置自己的处理级别
			return new Level() { num = 2 };
		}

	}

	public class ConcreteHandler3 : Handler
	{
		//定义自己的处理逻辑
		protected override Response echo(Request request)
		{
			//完成处理逻辑
			return null;
		}
		//设置自己的处理级别
		protected override Level getHandlerLevel()
		{
			//设置自己的处理级别
			return new Level() { num = 3 };
		}

	}
}
