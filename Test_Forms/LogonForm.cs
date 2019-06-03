using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Test_Forms.Properties;


namespace Test_Forms
{
	public partial class LogonForm : Form
	{
		public LogonForm()
		{
			InitializeComponent();
		}
		public bool LogonSuccessful { get; set; }//Свойство которое определяет корректнось ввода и перехода к тестированию через Program.cs
		public Student User { get; set; }
		Students StudentsList { get; set; }
		private void btn_exit_Click(object sender, EventArgs e)
		{
			LogonSuccessful = false;
			this.Close();
		}

		private void btn_about_Click(object sender, EventArgs e)
		{
			new HelpInfo().Show();
		}

		private void btn_OK_Click(object sender, EventArgs e)
		{
			try
			{
				if (StudentsList.Contains(tb_log.Text, tb_pas.Text))
				{
					User = StudentsList.Find(tb_log.Text);
					LogonSuccessful = true;
					this.Close();
				}
				else
				{
					toolLable.ForeColor = Color.Yellow;
					toolLable.Text = "Неверный логин или пароль!";
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Ошибка : " + ex.Message);
			}
		}

		private void btn_reg_Click(object sender, EventArgs e)
		{
			RegistrationForm registrationForm = new RegistrationForm();
			this.Hide();
			registrationForm.StudentsList = StudentsList;
			registrationForm.ShowDialog();
			StudentsList = registrationForm.StudentsList;
			this.Show();
		}

		//Основная загрузка наших пользователей из файла в нашу коллекцию StudentList
		private void LogonForm_Load(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "*.txt(.txt)|*.txt";
			openFileDialog1.FileName = "Выберите путь до файла с пользователями";
			openFileDialog1.Title = "Выбор пути для пользователей";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				Settings.Default.PathStudents = openFileDialog1.FileName;
			openFileDialog1.FileName = "Выберите путь до файла с вопросами";
			openFileDialog1.Title = "Выбор пути для базы вопросв";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				Settings.Default.PathQA = openFileDialog1.FileName;

			tb_log.Select();
			StudentsList = new Students();
			using (StreamReader sr = new StreamReader(Settings.Default.PathStudents))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					string[] User = line.Split(':').ToArray();
					StudentsList.AddNew(User[0], User[1], int.Parse(User[2]));
				}
			}
			this.Activate();
		}

		private void tb_MouseClick(object sender, MouseEventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			textBox.Text = "";
		}

		private void tb_log_Leave(object sender, EventArgs e)
		{
			if (tb_log.Text != "Введите Логин" && tb_log.Text.Length < 4)
				tb_log.Text = "Введите Логин";
		}
		private void btn_MouseLeave(object sender, EventArgs e)
		{
			toolLable.ForeColor = Color.FromArgb(208, 208, 208);
			toolLable.Text = "Форма для ввода логина и пароля";

		}
		#region ----------- Перетаскивание мышкой форму ----------
		MoveForm moveForm = new MoveForm();
		private void LogonForm_MouseDown(object sender, MouseEventArgs e)
		{
			moveForm.MouseDown(e);
		}
		private void LogonForm_MouseUp(object sender, MouseEventArgs e)
		{
			moveForm.MouseUP(e);
		}
		private void LogonForm_MouseMove(object sender, MouseEventArgs e)
		{
			Location = moveForm.MouseMove(e, Location);
		}
		private void btn_MouseEnter(object sender, EventArgs e)
		{
			if (sender.GetType() == btn_OK.GetType())
			{
				Button button = (Button)sender;
				toolLable.Text = button.Tag.ToString();
			}
			else
			{
				TextBox textBox = (TextBox)sender;
				toolLable.Text = textBox.Tag.ToString();
			}

		}
		#endregion

		private void tb_pas_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
				btn_OK_Click(sender, e);
		}
	}
}
