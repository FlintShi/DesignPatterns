using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			ConcreteMediator concreteMediator = new ConcreteMediator();
			ConcreteColleague1 colleague1 = new ConcreteColleague1(concreteMediator);
			ConcreteColleague2 colleague2 = new ConcreteColleague2(concreteMediator);
			concreteMediator.setC1(colleague1);
			concreteMediator.setC2(colleague2);
			concreteMediator.doSomething1();
			concreteMediator.doSomething2();

			concreteMediator.getC1().depMethod1();
			concreteMediator.getC2().depMethod2();
			Console.ReadLine();
		}
	}
	public abstract class Mediator
	{
		//定义同事类
		protected ConcreteColleague1 c1;
		protected ConcreteColleague2 c2;

		//通过getter/setter方法吧同事类注入进来
		public ConcreteColleague1 getC1() { return c1; }
		public void setC1(ConcreteColleague1 c1) { this.c1 = c1; }
		public ConcreteColleague2 getC2() { return c2; }
		public void setC2(ConcreteColleague2 c2) { this.c2 = c2; }

		//中介者模式的业务逻辑
		public abstract void doSomething1();
		public abstract void doSomething2();
	}
	public class ConcreteMediator : Mediator
	{

		public override void doSomething1()
		{
			//调用同事类的方法，只要是public方法都可以调用
			base.c1.selfMethod1();
			base.c2.selfMethod2();
		}

		public override void doSomething2()
		{
			base.c1.selfMethod1();
			base.c2.selfMethod2();
		}

	}
	public abstract class Colleague
	{
		protected Mediator mediator;
		public Colleague(Mediator _mediator)
		{
			this.mediator = _mediator;
		}
	}
	public class ConcreteColleague1 : Colleague
	{
		//通过构造函数传递中介者
		public ConcreteColleague1(Mediator _mediator) : base(_mediator)
		{ }
		//自有方法 self-method
		public void selfMethod1()
		{
			Console.WriteLine("ConcreteColleague1 自有方法 selfMethod1");
		}
		//依赖方法 dep-method
		public void depMethod1()
		{
			Console.WriteLine("ConcreteColleague1 依赖方法 depMethod1");
			//自己不能处理的业务逻辑，委托给中介者处理
			base.mediator.doSomething1();

		}
	}
	public class ConcreteColleague2 : Colleague
	{
		//通过构造函数传递中介者
		public ConcreteColleague2(Mediator _mediator) : base(_mediator)
		{ }

		//自有方法 self-method
		public void selfMethod2()
		{
			Console.WriteLine("ConcreteColleague2 自有方法 selfMethod2");
		}
		//依赖方法 dep-method
		public void depMethod2()
		{
			Console.WriteLine("ConcreteColleague2 依赖方法 depMethod2");
			//自己不能处理的业务逻辑，委托给中介者处理
			base.mediator.doSomething2();
		}
	}
}
