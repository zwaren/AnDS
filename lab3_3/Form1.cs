using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_3
{
	public partial class Form1 : Form
	{
		int[][] matrix;
		int size;
		Dictionary<string, int> d;
		Dictionary<int, string> rd;
		public Form1()
		{
			InitializeComponent();
		}

		private Dictionary<string, int> dijkstra(string vertex)
		{
			Dictionary<string, int> vertexWeights = new Dictionary<string, int>();
			foreach (var x in d.Keys)
			{
				if (x == vertex) vertexWeights.Add(x, 0);
				else vertexWeights.Add(x, 10000);
			}
			HashSet<string> visited = new HashSet<string>();
			List<string> buffer = new List<string>();
			buffer.Add(vertex);
			while (buffer.Count > 0)
			{
				string v = buffer.OrderBy(x => vertexWeights[x]).First();
				buffer.Remove(v);
				visited.Add(v);
				for (int i = 0; i < size; i++)
				{
					if (matrix[d[v]][i] > 0)
					{
						if (vertexWeights[rd[i]] == 10000)
						{
							vertexWeights[rd[i]] = matrix[d[v]][i];
						}
						else if (matrix[d[v]][i] + vertexWeights[v] < vertexWeights[rd[i]])
						{
							vertexWeights[rd[i]] = matrix[d[v]][i] + vertexWeights[v];
						}
						if (!visited.Contains(rd[i]) && !buffer.Contains(rd[i])) buffer.Add(rd[i]);
					}
				}
			}
			return vertexWeights;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			d = new Dictionary<string, int>();
			rd = new Dictionary<int, string>();
			int i = 0;
			foreach (string s in inbox.Text.Split(' '))
			{
				d.Add(s, i);
				rd.Add(i, s);
				i += 1;
			}
			size = i;
			matrix = new int[i][];
			for (int j = 0; j < i; j++)
			{
				matrix[j] = new int[i];
				for (int k = 0; k < i; k++)
				{
					matrix[j][k] = 0;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var s = inbox.Text.Split(' ');
			int a = d[s[0]];
			int b = d[s[1]];
			int value = Convert.ToInt32(s[2]);
			matrix[a][b] = matrix[b][a] = value;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dijkstra(inbox.Text);
		}
	}
}
