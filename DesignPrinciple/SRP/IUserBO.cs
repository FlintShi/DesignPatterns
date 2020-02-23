using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
	public interface IUserBO
	{
		 void setUserID(String userID);

		 String getUserID();

		 void setPassword(String password);

		 String getPassword();

		 void setUserName(String userName);

		 String getUserName();
	}
}
