using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Forms
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			LogonForm logon = new LogonForm();
			logon.LogonSuccessful = true;
			Application.Run(logon);
			if (logon.LogonSuccessful)
			{
				Main_Form main_Form = new Main_Form();
				main_Form.User = logon.User;
				Application.Run(main_Form);
			}
		}
	}
}
