using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp.DA_Programs
{
    public class CombineSortedList
    {
        public List<int> MergeSortedList(List<int> l1, List<int> l2)
        {
            List<int> result = new List<int>();

            int i = 0, j = 0;

            while (i < l1.Count && j< l2.Count)
            {
                if (l1[i] < l2[j])
                {
                    result.Add(l1[i]);
                    i++;
                }
                else
                {
                    result.Add(l2[j]);
                    j++;
                }
            }

            while (i < l1.Count)
            {
                result.Add(l1[i]);
                i++;
            }

            while (j < l2.Count)
            {
                result.Add(l2[j]);
                j++;
            }

            return result;

        }
    }
}
