using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
	public interface IUserBiz
	{

		 bool changePassword(String oldPassword);

		 bool deleteUser();

		 void mapUser();
		 void addOrg(IUserBO userBO, int orgID);
		 void addRole(IUserBO userBO, int roleID);
	}
}
