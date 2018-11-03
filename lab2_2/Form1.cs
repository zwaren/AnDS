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
    static class utils
    {
        class sequence
        {
            public int index;
            public int length;

            public sequence(int index, int length)
            {
                this.index = index;
                this.length = length;
            }
        }

        static public int[] findLongestIncreasingSequence(this int[] seq)
        {
            List<sequence> sl = new List<sequence>();
            sl.Add(new sequence(0, 1));
            int current = 0;
            for (int i = 0; i < seq.Length - 1; i++)
            {
                if (seq[i] < seq[i + 1])
                {
                    sl[current].length += 1;
                }
                else if (sl[current].length > 1)
                {
                    sl.Add(new sequence(i + 1, 1));
                    current += 1;
                }
                else
                {
                    sl[current].index += 1;
                }
            }
            var longestSeq = sl.OrderBy(x => x.length).Last();
            return seq.Skip(longestSeq.index).Take(longestSeq.length).ToArray();
        }
    }
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
