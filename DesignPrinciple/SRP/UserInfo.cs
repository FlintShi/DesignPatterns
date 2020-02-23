using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
	class UserInfo : IUserInfo
	{

		private String userName;
		private String userID;
		private String password;

		public String getUserName()
		{
			return userName;
		}

		public void setUserName(String userName)
		{
			this.userName = userName;
		}

		public String getUserID()
		{
			return userID;
		}

		public void setUserID(String userID)
		{
			this.userID = userID;
		}

		public String getPassword()
		{
			return password;
		}

		public void setPassword(String password)
		{
			this.password = password;
		}


		public bool changePassword(String oldPassword)
		{
			Console.WriteLine("changePassword");
			return true;
		}


		public bool deleteUser()
		{
			Console.WriteLine("deleteUser");
			return true;
		}

		public void mapUser()
		{
			Console.WriteLine("mapUser");
		}

		public void addOrg(IUserBO userBO, int orgID)
		{
			Console.WriteLine($"{userBO.getUserName()} addOrg {orgID}");
		}

		public void addRole(IUserBO userBO, int roleID)
		{
			Console.WriteLine($"{userBO.getUserName()} addRole {roleID}");
		}

	}
}
