using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_2
{
	public partial class Form1 : Form
	{
		SeparateСhainingHashTable<string> hashTable;

		public Form1()
		{
			InitializeComponent();
			hashTable = new SeparateСhainingHashTable<string>();
			for (int i = 0; i < 10; i++)
			{
				listbox.Items.Add(i + ") ");
			}
		}

		private void bInsert_Click(object sender, EventArgs e)
		{
			int index = hashTable.insert(Convert.ToInt32(keybox.Text), valuebox.Text);
			if (index != -1)
			{
				listbox.Items[index] = index + ") " + hashTable.chains[index].ToString();
			}
		}

		private void bDelete_Click(object sender, EventArgs e)
		{
			int index = hashTable.delete(Convert.ToInt32(keybox.Text));
			if (index != -1)
			{
				listbox.Items[index] = index + ") " + hashTable.chains[index].ToString();
			}
		}

		private void listbox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
