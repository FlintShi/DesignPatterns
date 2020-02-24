using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Demo
{

	public class Response
	{
		//处理者返回的数据
	}
	public class Request
	{
		private int level;

		public Request(int level)
		{
			this.level = level;
		}

		//请求的等级
		public int getRequestLevel()
		{
			return level;
		}
	}

	public abstract class Handler
	{
		private Handler nextHandler;
		// 每个处理者都必须对请求做出处理
		public Response handlerMessage(Request request)
		{
			Response response = null;
			// 判断是否是自己的处理级别
			if (this.getHandlerLevel() == request.getRequestLevel())
			{
				response = this.echo(request);
			}
			else
			{ // 不属于自己的处理级别
			  // 判断是否有下一个处理者
				if (this.nextHandler != null)
				{
					response = this.nextHandler.handlerMessage(request);
				}
				else
				{
					// 没有适当的处理者，业务自行处理
				}
			}
			return response;
		}
		// 设置下一个处理者是谁
		public void setNext(Handler _handler)
		{
			this.nextHandler = _handler;
		}
		// 每个处理者都有一个处理级别
		protected abstract int getHandlerLevel();

		// 每个处理者都必须实现处理任务
		protected abstract Response echo(Request request);
	}

	public class VP : Handler
	{
		protected override int getHandlerLevel()
		{
			return 3;
		}

		protected override Response echo(Request request)
		{
			Console.WriteLine("员工的请求level是："
					+ request.getRequestLevel());
			Console.WriteLine("副总的答复是：同意");
			return new Response();
		}

	}
	public class DM : Handler
	{

		protected override int getHandlerLevel()
		{
			return 2;
		}

		protected override Response echo(Request request)
		{
			Console.WriteLine("员工的请求level是："
					+ request.getRequestLevel());
			Console.WriteLine("部门经理的答复是：同意");
			return new Response();
		}
	}
	public class PM : Handler
	{
		protected override int getHandlerLevel()
		{
			return 1;
		}

		protected override Response echo(Request request)
		{
			Console.WriteLine("员工的请求level是："
					+ request.getRequestLevel());
			Console.WriteLine("项目经理的答复是：同意");
			return new Response();
		}
	}
}
