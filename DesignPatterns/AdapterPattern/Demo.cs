using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
	public interface IUserInfo
	{
		//获得用户姓名
		String getUserName();
		//获得家庭地址
		String getHomeAddress();
		//这个人的职位是啥
		String getJobPosition();

	}
	public class UserInfo : IUserInfo
	{
		public String getHomeAddress()
		{
			Console.WriteLine("这里是员工的家庭地址....");
			return null;
		}

		public String getJobPosition()
		{
			Console.WriteLine("这个人的职位是BOSS....");
			return null;
		}

		public String getUserName()
		{
			Console.WriteLine("姓名叫做...");
			return null;
		}
	}
	public interface IOuterUserHomeInfo
	{
		//用户的家庭信息
		Dictionary<object, object> getUserHomeInfo();
	}
	public interface IOuterUserOfficeInfo
	{
		//工作区域信息
		Dictionary<object, object> getUserOfficeInfo();
	}
	public interface IOuterUserBaseInfo
	{
		//基本信息，比如名称，性别，手机号码了等
		Dictionary<object, object> getUserBaseInfo();
	}

	public class OuterUserOfficeInfo : IOuterUserOfficeInfo
	{
		public Dictionary<object, object> getUserOfficeInfo()
		{
			Dictionary<object, object> officeInfo = new Dictionary<object, object>();
			officeInfo.Add("jobPosition", "这个人的职位是BOSS...");
			return officeInfo;
		}

	}
	public class OuterUserHomeInfo : IOuterUserHomeInfo
	{
		public Dictionary<object, object> getUserHomeInfo()
		{
			Dictionary<object, object> homeInfo = new Dictionary<object, object>();

			homeInfo.Add("homeAddress", "员工的家庭地址是....");
			return homeInfo;
		}
	}

	public class OuterUserBaseInfo : IOuterUserBaseInfo
	{
		public Dictionary<object, object> getUserBaseInfo()
		{
			Dictionary<object, object> homeInfo = new Dictionary<object, object>();
			homeInfo.Add("userName", "这个员工叫混世魔王....");
			return homeInfo;
		}
	}
	public class OuterUserInfo : IUserInfo
	{
		//源目标对象
		private IOuterUserBaseInfo baseInfo = null;  //员工的基本信息
		private IOuterUserHomeInfo homeInfo = null; //员工的家庭 信息
		private IOuterUserOfficeInfo officeInfo = null; //工作信息

		//数据处理
		private Dictionary<object, object> baseMap = null;
		private Dictionary<object, object> homeMap = null;
		private Dictionary<object, object> officeMap = null;

		//构造函数传递对象
		public OuterUserInfo(IOuterUserBaseInfo _baseInfo, IOuterUserHomeInfo _homeInfo, IOuterUserOfficeInfo _officeInfo)
		{
			this.baseInfo = _baseInfo;
			this.homeInfo = _homeInfo;
			this.officeInfo = _officeInfo;

			//数据处理
			this.baseMap = this.baseInfo.getUserBaseInfo();
			this.homeMap = this.homeInfo.getUserHomeInfo();
			this.officeMap = this.officeInfo.getUserOfficeInfo();
		}

		//家庭地址
		public String getHomeAddress()
		{
			String homeAddress = (String)this.homeMap["homeAddress"];
			Console.WriteLine(homeAddress);
			return homeAddress;
		}

		//职位信息
		public String getJobPosition()
		{
			String jobPosition = (String)this.officeMap["jobPosition"];
			Console.WriteLine(jobPosition);
			return jobPosition;
		}

		// 员工的名称
		public String getUserName()
		{
			String userName = (String)this.baseMap["userName"];
			Console.WriteLine(userName);
			return userName;
		}

	}
}
