using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            outbox.Text = string.Join(" ", inbox.Text
                    .Split(' ')
                    .Select(x => Convert.ToInt32(x))
                    .ToArray()
                    .findLongestIncreasingSequence()
                    .Select(x => x.ToString())
                );
        }
    }
}
