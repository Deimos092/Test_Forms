using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Test_Forms.Properties;

namespace Test_Forms
{
	public class Students
	{
		List<Student> _ListStudents = new List<Student>();

		public void AddNew(string Login, string Password, int Grade)
		{
			_ListStudents.Add(new Student(Login, Password, Grade));
		}
		public void AddNew(string Login, string Password)
		{
			_ListStudents.Add(new Student(Login, Password));
		}
		public Student this[int index]
		{
			get { return _ListStudents[index]; }
			set { _ListStudents[index] = value; }
		}
		public Student this[string login]
		{
			get { return _ListStudents[_ListStudents.FindIndex(x => x.Login == login)]; }
			set { _ListStudents[_ListStudents.FindIndex(x => x.Login == login)] = value; }
		}
		public int Count
		{
			get { return _ListStudents.Count(); }
		}
		public bool Contains(string login, string password)
		{
			foreach (var student in _ListStudents)
				if (student.Login == login)
					return ContatinsPass(student, HashPassword(password));
			return false;
		}
		public Student Find(string login)
		{
			return _ListStudents.Find(x => x.Login == login);
		}
		private bool ContatinsPass(Student student, string password)
		{
			if (student.Password == password) return true;
			return false;
		}

		public void Registration(string Login, string Password, int Grade = 0)
		{
			AddNew(Login, HashPassword(Password), Grade);
			File.AppendAllText(Settings.Default.PathStudents, _ListStudents[_ListStudents.Count - 1].ToString());
		}
		private bool ChekPassword(string Password)
		{
			return false;
		}
		private string HashPassword(string Password)
		{
			return Convert.ToString(Convert.ToUInt32(Password.GetHashCode() % 10000000001), 16);//Правило шифрования пароля
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (var item in _ListStudents)
				stringBuilder.AppendFormat("{0}", item);
			return stringBuilder.ToString();
		}

	}
}
