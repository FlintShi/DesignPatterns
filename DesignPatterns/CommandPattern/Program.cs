using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
class Program
{
	private static Invoker invoker;
	private static Command command;
	static void Main(string[] args)
	{
		//首先声明出调用者Invoker
		invoker = new Invoker();
		//定义一个发送给接收者的命令
		command = new ConcreteCommand1();
		//把命令交给调用者去执行
		invoker.setCommand(command);
		invoker.action();
	}
}
public abstract class Command
{
	//定义一个子类的全局共享变量
	protected readonly Receiver receiver;
	//实现类必须定义一个接收者
	public Command(Receiver _receiver)
	{
		this.receiver = _receiver;
	}
	//每个命令类都必须有一个执行命令的方法
	public abstract void execute();
}
public class ConcreteCommand1 : Command
{
	//声明自己的默认接收者
	public ConcreteCommand1() : base(new ConcreteReciver1())
	{ }
	//设置新的接收者
	public ConcreteCommand1(Receiver _receiver) : base(_receiver)
	{ }
	//每个具体的命令都必须实现一个命令
	public override void execute()
	{
		//业务处理
		base.receiver.doSomething();
	}
}
public class ConcreteCommand2 : Command
{
	//声明自己的默认接收者
	public ConcreteCommand2() : base(new ConcreteReciver2())
	{ }
	//设置新的接收者
	public ConcreteCommand2(Receiver _receiver) : base(_receiver)
	{ }
	//每个具体的命令都必须实现一个命令
	public override void execute()
	{
		//业务处理
		base.receiver.doSomething();
	}
}
public abstract class Receiver
{
	//抽象接收者，定义每个接收者都必须完成的业务
	public abstract void doSomething();
}
public class ConcreteReciver1 : Receiver
{
	//每个接受者都必须处理一定的业务逻辑
	public override void doSomething()
	{ Console.WriteLine("ConcreteReciver1 执行命令");	}
}
public class ConcreteReciver2 : Receiver
{
	//每个接受者都必须处理一定的业务逻辑
	public override void doSomething()
	{ Console.WriteLine("ConcreteReciver2 执行命令"); }
}
public class Invoker
{
	private Command command;
	//受气包，接受命令
	public void setCommand(Command _command)
	{
		this.command = _command;
	}
	//执行命令
	public void action()
	{
		this.command.execute();
	}
}
}
