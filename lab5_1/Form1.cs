using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_1
{
	public partial class Form1 : Form
	{
		List<string> log;
		Stack<int>[] s;

		public void updateLog()
		{

			log.Add(
				string.Join(" ", s.Select(
					x => "[" + string.Join(", ", x.ToArray().Reverse()) + "]"
					))
				);
		}

		public Form1()
		{
			InitializeComponent();
		}

		public void hanoi(Stack<int> from, Stack<int> buff, Stack<int> to, int count)
		{
			if (count == 2)
			{
				buff.Push(from.Pop());
				updateLog();
				to.Push(from.Pop());
				updateLog();
				to.Push(buff.Pop());
				updateLog();
			}
			else if (count > 2)
			{
				hanoi(from, to, buff, count - 1);
				to.Push(from.Pop());
				updateLog();
				hanoi(buff, from, to, count - 1);
			}
		}

		private void bApply_Click(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(inbox.Text);
			log = new List<string>();
			s = new Stack<int>[3];
			s[0] = new Stack<int>(n);
			s[1] = new Stack<int>(n);
			s[2] = new Stack<int>(n);
			for (int i = 0; i < n; i++)
			{
				s[0].Push(n - i);
			}
			updateLog();

			if (n > 1)
			{
				hanoi(s[0], s[1], s[2], n);
			}

			outbox.Items.Clear();
			outbox.Items.AddRange(log.ToArray());
		}
	}
}
