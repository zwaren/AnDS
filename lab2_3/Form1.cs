using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_3
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

		private int[] countingSort(int[] nums, int max)
		{
			var op = new int[max];

			for (int i = 0; i < nums.Length; i++)
			{
				op[nums[i]] += 1;
			}

			int cur = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				while (op[cur] == 0) cur += 1;
				nums[i] = cur;
				op[cur] -= 1;
			}

			return nums;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			TimeSpan ts;
			Stopwatch stopWatch = new Stopwatch();
			int max = Convert.ToInt32(inbox.Text);
			int count = Convert.ToInt32(inbox2.Text);
			int[] array = new int[count].Select(_ => r.Next(max)).ToArray();
			
			stopWatch.Start();
			bubbleSort(array);
			stopWatch.Stop();
			ts = stopWatch.Elapsed;
			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
			outbox.Text = elapsedTime;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			TimeSpan ts;
			Stopwatch stopWatch = new Stopwatch();
			int max = Convert.ToInt32(inbox.Text);
			int count = Convert.ToInt32(inbox2.Text);
			int[] array = new int[count].Select(_ => r.Next(max)).ToArray();
			
			stopWatch.Start();
			fastSort(array, 0, array.Length);
			stopWatch.Stop();
			ts = stopWatch.Elapsed;
			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
			outbox.Text = elapsedTime;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			TimeSpan ts;
			Stopwatch stopWatch = new Stopwatch();
			int max = Convert.ToInt32(inbox.Text);
			int count = Convert.ToInt32(inbox2.Text);
			int[] array = new int[count].Select(_ => r.Next(max)).ToArray();

			stopWatch.Start();
			countingSort(array, max);
			stopWatch.Stop();
			ts = stopWatch.Elapsed;
			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
			outbox.Text = elapsedTime;
		}
	}
}
