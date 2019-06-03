using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Forms
{
	public partial class HelpInfo : Form
	{
		public HelpInfo()
		{
			InitializeComponent();
			RefreshDate = DateTime.Now.ToLongDateString();
			lb_Refresh.Text = RefreshDate;
		}
		public string RefreshDate { get; set; }
		MoveForm moveForm = new MoveForm();
		private void btn_Close_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void HelpInfo_MouseUp( object sender , MouseEventArgs e )
		{
			moveForm.MouseUP(e);
		}

		private void HelpInfo_MouseMove( object sender , MouseEventArgs e )
		{
			Location = moveForm.MouseMove(e,Location);
		}

		private void HelpInfo_MouseDown( object sender , MouseEventArgs e )
		{
			moveForm.MouseDown(e);
		}

	}
}
