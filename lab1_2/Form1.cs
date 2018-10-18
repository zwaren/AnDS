using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void swap(int[] nums, int a, int b)
		{
			if (a != b)
			{
				int tmp = nums[a];
				nums[a] = nums[b];
				nums[b] = tmp;
			}
		}

		private int[] bubbleSort(int[] nums)
		{
			var output = (int[])nums.Clone();
			for (int i = 0; i < output.Length - 1; i++)
			{
				for (int j = output.Length - 1; j > i; j--)
				{
					if (output[j] < output[j - 1])
					{
						swap(output, j, j - 1);
					}
				}
			}
			return output;
		}

		private void fastSort(int[] nums, int start, int end)
		{
			if (end - start > 1)
			{
				int state = end - 1;
				for (int i = state - 1; i >= start; i--)
				{
					if (nums[i] > nums[state])
					{
						swap(nums, i, state - 1);
						swap(nums, state - 1, state);
						state -= 1;
					}
				}
				fastSort(nums, start, state);
				fastSort(nums, state + 1, end);
			}

		}

		private void buttonSort_Click(object sender, EventArgs e)
		{
			int[] nums = textBoxInput.Text.Split(' ').Select(x => int.Parse(x)).ToArray();
			nums = bubbleSort(nums);
			richTextBoxOutput.Text = string.Join(" ", nums.Select(x => x.ToString()).ToArray());
		}

		private void buttonFastSort_Click(object sender, EventArgs e)
		{
			int[] nums = textBoxInput.Text.Split(' ').Select(x => int.Parse(x)).ToArray();
			fastSort(nums, 0, nums.Length);
			richTextBoxOutput.Text = string.Join(" ", nums.Select(x => x.ToString()).ToArray());
		}
	}
}
