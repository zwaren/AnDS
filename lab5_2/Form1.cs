using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
			Graphics gr = Graphics.FromImage(bmp);
			DrawSquare(gr, 100, 100, 100);
			pictureBox.Image = bmp;
		}

		private void DrawSquare(Graphics gr, int x, int y, int r)
		{
			Brush br = new SolidBrush(Color.White);
			gr.FillRectangle(br, x, y, r, r);
			if (r > 1)
			{
				int r3 = r / 3;
				DrawSquare(gr, x - r + r3, y - r + r3, r3);
				DrawSquare(gr, x + r3, y - r + r3, r3);
				DrawSquare(gr, x + r + r3, y - r + r3, r3);

				DrawSquare(gr, x - r + r3, y + r3, r3);
				DrawSquare(gr, x + r + r3, y + r3, r3);

				DrawSquare(gr, x - r + r3, y + r + r3, r3);
				DrawSquare(gr, x + r3, y + r + r3, r3);
				DrawSquare(gr, x + r + r3, y + r + r3, r3);
			}
		}
	}
}
