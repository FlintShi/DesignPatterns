using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
			IUserBiz userInfo = new UserInfo();


			IUserBO userBO = (IUserBO)userInfo;
			userBO.setUserName("abc");
			userBO.setPassword("abc");

	
			IUserBiz userBiz = (IUserBiz)userInfo;
			userBiz.deleteUser();
			userBiz.addRole(userBO,22);
			Console.ReadLine();
		}
    }
}
