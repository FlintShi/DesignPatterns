using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
			AbstractClass class1 = new ConcreteClass1();
			AbstractClass class2 = new ConcreteClass2();

			//调用模版方法
			class1.templateMethod();
			class2.templateMethod();
			Console.ReadLine();
		}
    }

	public abstract class AbstractClass
	{
		//基本方法
		protected abstract void doSomething();
		//基本方法
		protected abstract void doAnything();
		//模版方法
		public void templateMethod()
		{
			 //调用基本方法，完成相关的逻辑
			this.doAnything();
			this.doSomething();
		}
	}
	public class ConcreteClass1 : AbstractClass
	{
		//实现基本方法
		protected override void doAnything()
		{
			Console.WriteLine("ConcreteClass1 doAnything");
		}
		protected override void doSomething()
		{
			Console.WriteLine("ConcreteClass1 doSomething");
		}
	}
	public class ConcreteClass2 : AbstractClass
	{
		//实现基本方法
		protected override void doAnything()
		{
			Console.WriteLine("ConcreteClass2 doAnything");
		}
		protected override void doSomething()
		{
			Console.WriteLine("ConcreteClass2 doSomething");
		}
	}
}
