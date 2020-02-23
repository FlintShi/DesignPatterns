using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{

	public class DynamicProxy : RealProxy
	{
		public DynamicGamePlayer instance = null;
		public DynamicProxy(Type t, DynamicGamePlayer plane) : base(t)
		{
			this.instance = plane;
		}
		public override IMessage Invoke(IMessage msg)
		{

			var methodCall = (IMethodCallMessage)msg;
			Console.WriteLine($"{methodCall.MethodName} 执行前");
			var result = methodCall.MethodBase.Invoke(instance, methodCall.Args);
			Console.WriteLine($"{methodCall.MethodName} 执行后");
			return new ReturnMessage(result, null, 0, methodCall.LogicalCallContext, methodCall);
		}

	}
	public class DynamicGamePlayer : MarshalByRefObject
	{
		private String name = "";
		//我的代理是谁
		private IGamePlayer proxy = null;

		public DynamicGamePlayer(String _name)
		{
			this.name = _name;
		}


		//打怪，最期望的就是杀老怪
		public void killBoss()
		{
			Console.WriteLine(this.name + "在打怪！");
		}

		//进游戏之前你肯定要登录吧，这是一个必要条件
		public void login(String user, String password)
		{
			Console.WriteLine("登录名为" + user + " 的用户 " + this.name + "登录成功！");
		}

		//升级，升级有很多方法，花钱买是一种，做任务也是一种
		public void upgrade()
		{
			Console.WriteLine(this.name + " 又升了一级！");
		}
	}
}
