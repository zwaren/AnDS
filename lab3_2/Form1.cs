using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_2
{
	public partial class Form1 : Form
	{
		Dictionary<string, List<string>> adj_list;

		public Form1()
		{
			InitializeComponent();
			adj_list = new Dictionary<string, List<string>>();
		}

		private bool BFS(string start, string goal)
		{
			Queue<string> q = new Queue<string>();
			q.Enqueue(start);
			HashSet<string> visited = new HashSet<string>();
			visited.Add(start);
			
			while (q.Count > 0)
			{
				string s = q.Dequeue();
				if (s == goal) return true;
				foreach (string ss in adj_list[s])
				{
					if (!visited.Contains(ss))
					{
						visited.Add(ss);
						q.Enqueue(ss);
					}
				}
			}
			return false;
		}

		private void bAdd_Click(object sender, EventArgs e)
		{
			var arr = inbox.Text.Split(';').Select(x => x.Trim()).ToArray();
			foreach (string s in arr)
			{
				var tmp = s.Split(':').Select(x => x.Trim()).ToArray();
				adj_list.Add(tmp[0], tmp[1].Split(',').Select(x => x.Trim()).ToList());
			}
		}

		private void bCalc_Click(object sender, EventArgs e)
		{
			string[] indexes = inbox.Text.Split(' ').ToArray();
			outbox.Text = BFS(indexes[0], indexes[1]).ToString();
		}
	}
}
