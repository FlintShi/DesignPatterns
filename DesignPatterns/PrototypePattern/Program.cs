using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mail = new Mail(new AdvTemplate());
            mail.Tail = "XX银行版权所有";
            int i = 0;
            while (i < 6)
            {
                var cloneMail = (Mail)mail.Clone();
                cloneMail.Appellation = GetRandString(5) + " 先生（ 女士） ";
                cloneMail.Receiver = GetRandString(5) + "@" + GetRandString(8) + ".com";
                SentMail(cloneMail);
                i++;
            }
            Console.ReadLine();
        }
        static void SentMail(Mail mail)
        {
            Console.WriteLine("标题： " + mail.Subject + "\t收件人：" + mail.Receiver + "\t...发送成功！ ");
        }
        static string GetRandString(int maxLength)
        {
            string source = "abcdefghijklmnopqrskuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var sb = new StringBuilder();

            for (int i = 0; i < maxLength; i++)
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                sb.Append(source.ToCharArray()[r.Next(source.Length)]);
            }

            return sb.ToString();
        }
    }
    public class AdvTemplate
    {
        private string advSubject = "XX银行国庆信用卡抽奖活动";   //广告信名称
        private string advContext = "国庆抽奖活动通知： 只要刷卡就送你一百万！ ...";    //广告信内容
        //取得广告信的名称
        public string GetAdvSubject()
        {
            return this.advSubject;
        }
        //取得广告信的内容
        public string GetAdvContext()
        {
            return this.advContext;
        }
    }
    public class Mail : ICloneable
    {
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Appellation { get; set; }
        public string Contxt { get; set; }
        public string Tail { get; set; }
        public Mail(AdvTemplate advTemplate)
        {
            this.Contxt = advTemplate.GetAdvContext();
            this.Subject = advTemplate.GetAdvSubject();
            Console.WriteLine("构造函数执行");
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
