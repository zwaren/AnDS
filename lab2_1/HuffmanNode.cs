using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    class HuffmanNode
    {
        public int frequency;
        public string value;
        public HuffmanNode leftLeaf;
        public HuffmanNode rightLeaf;
        

        public HuffmanNode(int frequency, string value, HuffmanNode leftLeaf, HuffmanNode rightLeaf)
        {
            this.frequency = frequency;
            this.value = value;
            this.leftLeaf = leftLeaf;
            this.rightLeaf = rightLeaf;
        }

        public string[] getEncoding(string bits)
        {
            if (leftLeaf == null && rightLeaf == null)
            {
                return new string[] { this.value + ": " + bits };
            }
            else
            {
                return leftLeaf.getEncoding(bits + "0")
                    .Concat(rightLeaf.getEncoding(bits + "1"))
                    .ToArray();
            }
        }
    }
}
