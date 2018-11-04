using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            Dictionary<char, int> freqDict = new Dictionary<char, int>();
            foreach (char chr in inbox.Text)
            {
                if (!freqDict.ContainsKey(chr))
                {
                    freqDict.Add(chr, 0);
                }
                freqDict[chr] += 1;
            }

            List<HuffmanNode> freeNodeList = new List<HuffmanNode>();
            foreach (var item in freqDict)
            {
                freeNodeList.Add(new HuffmanNode(item.Value, "" + item.Key, null, null));
            }

            while (freeNodeList.Count > 1)
            {
                freeNodeList = freeNodeList.OrderBy(x => x.frequency).ToList();
                var left = freeNodeList[0];
                var right = freeNodeList[1];
                freeNodeList.Add(new HuffmanNode(
                    left.frequency + right.frequency,
                    left.value + right.value,
                    left, right));
                freeNodeList.RemoveAt(0);
                freeNodeList.RemoveAt(0);
            }
            outbox.Text = string.Join("\n", freeNodeList[0].getEncoding(""));

        }
    }
}
