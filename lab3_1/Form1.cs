using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_1
{
	public partial class Form1 : Form
	{
		BinaryTree tree;

		public Form1()
		{
			InitializeComponent();
			tree = new BinaryTree();
		}

		private void bAdd_Click(object sender, EventArgs e)
		{
			int[] values = inbox.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
			foreach (int value in values)
			{
				tree.insert(value);
			}
			Bitmap bmp = new Bitmap(outbox.Width, outbox.Height);
			Graphics gr = Graphics.FromImage(bmp);
			tree.draw(gr);
			outbox.Image = bmp;
		}

		private void bDel_Click(object sender, EventArgs e)
		{
			int[] values = inbox.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
			foreach (int value in values)
			{
				tree.remove(value);
			}
			Bitmap bmp = new Bitmap(outbox.Width, outbox.Height);
			Graphics gr = Graphics.FromImage(bmp);
			tree.draw(gr);
			outbox.Image = bmp;
		}
	}
}
