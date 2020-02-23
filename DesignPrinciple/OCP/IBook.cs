using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
	public interface IBook
	{
		//书籍有名称
		String getName();

		//书籍有售价
		int getPrice();

		//书籍有作者
		String getAuthor();
	}
	public class NovelBook : IBook
	{
		//书籍名称
		private String name;

		//书籍的价格
		private int price;

		//书籍的作者
		private String author;



		//通过构造函数传递书籍数据
		public NovelBook(String _name, int _price, String _author)
		{
			this.name = _name;
			this.price = _price;
			this.author = _author;
		}

		//获得作者是谁
		public String getAuthor()
		{
			return this.author;
		}

		//书籍叫什么名字
		public String getName()
		{
			return this.name;
		}

		//获得书籍的价格
		public virtual int getPrice()
		{
			return this.price;
		}

	}

	public class OffNovelBook : NovelBook
	{
		public OffNovelBook(String _name, int _price, String _author) : base(_name, _price, _author)
		{

		}

		//覆写销售价格

		public override int getPrice()
		{
			//原价
			int selfPrice = base.getPrice();
			int offPrice = 0;
			if (selfPrice > 4000)
			{  //原价大于40元，则打9折
				offPrice = selfPrice * 90 / 100;
			}
			else
			{
				offPrice = selfPrice * 80 / 100;
			}

			return offPrice;
		}

	}
}