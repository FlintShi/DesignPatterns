using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        public static List<IBook> bookList = new List<IBook>();
        static void Main(string[] args)
        {

            bookList.Add(new NovelBook("天龙八部", 3200, "金庸"));
            bookList.Add(new NovelBook("巴黎圣母院", 5600, "雨果"));
            bookList.Add(new NovelBook("悲惨世界", 3500, "雨果"));
            bookList.Add(new NovelBook("金瓶梅", 4300, "兰陵笑笑生"));
            Console.WriteLine("------------书店买出去的书籍记录如下：---------------------");
            foreach (IBook book in bookList)
            {
                Console.WriteLine("书籍名称：" + book.getName() + "\t书籍作者：" + book.getAuthor() + "\t书籍价格：" + Convert.ToDecimal(book.getPrice() / 100.0) + "元");
            }
            bookList.Clear();

            bookList.Add(new OffNovelBook("天龙八部", 3200, "金庸"));
            bookList.Add(new OffNovelBook("巴黎圣母院", 5600, "雨果"));
            bookList.Add(new OffNovelBook("悲惨世界", 3500, "雨果"));
            bookList.Add(new OffNovelBook("金瓶梅", 4300, "兰陵笑笑生"));
            Console.WriteLine("------------书店买出去的打折书籍记录如下：---------------------");
            foreach (IBook book in bookList)
            {
               Console.WriteLine("书籍名称：" + book.getName() + "\t书籍作者：" + book.getAuthor() + "\t书籍价格：" + Convert.ToDecimal(book.getPrice() / 100.0) + "元");
            }
            Console.ReadLine();
        }
        
    
    }
}
