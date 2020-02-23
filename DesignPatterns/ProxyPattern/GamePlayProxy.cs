using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
	//强制代理模式
	public interface IGamePlayer
	{
		//登录游戏
		void login(String user, String password);
		//杀怪，这是网络游戏的主要特色
		void killBoss();
		//升级
		void upgrade();
		//每个人都可以找一下自己的代理
		IGamePlayer getProxy();
	}

	public interface IProxy
	{
		//费用
		void count();

	}
	public class GamePlayer : IGamePlayer
	{
		private String name = "";
		//我的代理是谁
		private IGamePlayer proxy = null;

		public GamePlayer(String _name)
		{
			this.name = _name;
		}

		//找到自己的代理
		public IGamePlayer getProxy()
		{
			this.proxy = new GamePlayerProxy(this);
			return this.proxy;
		}

		//打怪，最期望的就是杀老怪
		public void killBoss()
		{
			if (this.isProxy())
			{
				Console.WriteLine(this.name + "在打怪！");
			}
			else
			{
				Console.WriteLine("请使用指定的代理访问");
			}

		}

		//进游戏之前你肯定要登录吧，这是一个必要条件
		public void login(String user, String password)
		{
			if (this.isProxy())
			{
				Console.WriteLine("登录名为" + user + " 的用户 " + this.name + "登录成功！");
			}
			else
			{
				Console.WriteLine("请使用指定的代理访问"); ;
			}

		}

		//升级，升级有很多方法，花钱买是一种，做任务也是一种
		public void upgrade()
		{
			if (this.isProxy())
			{
				Console.WriteLine(this.name + " 又升了一级！");
			}
			else
			{
				Console.WriteLine("请使用指定的代理访问");
			}
		}

		//校验是否是代理访问
		private bool isProxy()
		{
			if (this.proxy == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
	public class GamePlayerProxy : IGamePlayer, IProxy
	{
		private IGamePlayer gamePlayer = null;

		//构造函数传递用户名
		public GamePlayerProxy(IGamePlayer _gamePlayer)
		{
			this.gamePlayer = _gamePlayer;
		}

		//代练杀怪
		public void killBoss()
		{
			this.gamePlayer.killBoss();
		}

		//代练登录
		public void login(String user, String password)
		{
			this.gamePlayer.login(user, password);

		}

		//代练升级
		public void upgrade()
		{
			this.gamePlayer.upgrade();
			this.count();
		}

		//代理的代理暂时还没有,就是自己
		public IGamePlayer getProxy()
		{
			return this;
		}

		public void count()
		{
			Console.WriteLine("代理花费150");
		}
	}
}
