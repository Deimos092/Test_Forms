using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Forms
{
	class MoveForm
	{
		public MoveForm() { }

		private bool isMouseDown { get; set; }
		private Point mouseOffset { get; set; }
		public void MouseUP(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				isMouseDown = false;
		}
		public void MouseDown(MouseEventArgs e)
		{
			int xOffset;
			int yOffset;

			if (e.Button == MouseButtons.Left)
			{
				xOffset = -e.X - SystemInformation.FrameBorderSize.Width - 4;
				yOffset = -e.Y - SystemInformation.CaptionHeight +
					SystemInformation.FrameBorderSize.Height - 12;
				isMouseDown = true;
				mouseOffset = new Point(xOffset, yOffset);
			}
		}
		public Point MouseMove(MouseEventArgs e,Point Location)
		{
			if (isMouseDown)
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(mouseOffset.X, mouseOffset.Y);
				return mousePos;
			}
			return Location;
		}
	}
}
