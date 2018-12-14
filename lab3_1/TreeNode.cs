using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
	class TreeNode
	{
		public TreeNode left;
		public TreeNode right;
		public int value;
		public int weight {
			get
			{
				int weight = 1;
				if (right != null)
				{
					weight += right.weight;
				}
				if (left != null)
				{
					weight += left.weight;
				}
				return weight;
			}
		}

		public TreeNode(int value)
		{
			this.value = value;
			this.left = null;
			this.right = null;
		}

		public void draw(Graphics g, int tabspace, int level)
		{
			Brush br = new SolidBrush(Color.Black);
			Font f = new Font("Verdana", 10);
			if (left != null)
			{
				g.DrawString("" + value, f, br, (tabspace + left.weight) * 20, level * 20);
			}
			else
			{
				g.DrawString("" + value, f, br, tabspace * 20, level * 20);
			}
			if (left != null) left.draw(g, tabspace, level + 1);
			if (right != null)
			{
				if (left != null)
				{
					right.draw(g, tabspace + left.weight + 1, level + 1);
				}
				else
				{
					right.draw(g, tabspace + 1, level + 1);
				}
			}
		}
	}
}
