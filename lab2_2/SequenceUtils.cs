using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    static class SequenceUtils
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
}
