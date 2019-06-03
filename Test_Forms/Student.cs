using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Forms
{
	public class Student
	{
		private string _login, _password;
		private int _grade;
		public Student() { }

		public Student(string login, string password)
		{
			Login = login;
			Password = password;
		}
		public Student(string login,string password,int grade)
		{
			Login = login;
			Password = password;
			Grade = grade;
		}
		public string Login
		{
			get { return _login; }
			set { _login = (value != "") ? value : "NoLogin"; }
		}
		public string Password
		{
			get { return _password; }
			set { _password = (value != "") ? value : "NoPassword"; }
		}
		public int Grade
		{
			get { return _grade; }
			set { _grade = (value >= 0 && value <= 100) ? value : 0; }
		}

		public override string ToString()
		{
			return string.Format($"{Login}:{Password}:{Grade}\n");
		}
	}
}
