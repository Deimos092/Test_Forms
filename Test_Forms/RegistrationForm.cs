using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Forms.Properties;

namespace Test_Forms
{
	public partial class RegistrationForm : Form
	{
		public RegistrationForm()
		{
			InitializeComponent();
		}
		MoveForm moveForm = new MoveForm();
		public Students StudentsList { get; set; }
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
		private void btn_MouseLeave(object sender, EventArgs e)
		{
			toolLable.ForeColor = Color.FromArgb(208, 208, 208);
			toolLable.Text = "Регистрация нового ученика";
		}
		private void btn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_OK_Click(object sender, EventArgs e)
		{
			try
			{
				if (!StudentsList.Contains(tb_log.Text, tb_pas.Text))
				{
					StudentsList.Registration(tb_log.Text, tb_pas.Text);
					toolLable.ForeColor = Color.GreenYellow;
					toolLable.Text = "Добавлен Новый пользователь!";
				}
				else
				{
					toolLable.ForeColor = Color.Yellow;
					toolLable.Text = "Введенный пользователь уже имеется в базе!";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка : " + ex.Message);
			}
		}		
	}
}
