using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP2
{
	public interface IGoodBodyGirl
	{

		//要有姣好的面孔
		 void goodLooking();

		//要有好身材
		 void niceFigure();

	}
	public interface IGoodTemperamentGirl
	{
		//要有气质
		void greatTemperament();
	}

	public class PettyGirl : IGoodBodyGirl, IGoodTemperamentGirl
	{
	private String name;
	//美女都有名字
	public PettyGirl(String _name)
	{
		this.name = _name;
	}

	//脸蛋漂亮
	public void goodLooking()
	{
		Console.WriteLine(this.name + "---脸蛋很漂亮!");
	}

	//气质要好
	public void greatTemperament()
	{
		Console.WriteLine(this.name + "---气质非常好!");
	}

	//身材要好
	public void niceFigure()
	{
		Console.WriteLine(this.name + "---身材非常棒!");
	}

}
}
