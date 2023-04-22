using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Hosts_Test
{
    public class Solution
    {
        public static int[] solution(string[] A, string[] B)
        {
            var list = new HashSet<string>(A);
            foreach (var itemB in B)
            {
                list.RemoveWhere(x => x.EndsWith(itemB));
            }

            return Enumerable.Range(0, A.Length).Where(i => list.Contains(A[i])).ToArray();
        }

        public static int[] solution1(string[] A, string[] B)
        {
            if (B.Length == 0)
                return Enumerable.Range(0, A.Length).ToArray();
            if (A.Length == 0)
                return new int[0];

            var list = new HashSet<string>(A);
            foreach (var str in list)
            {
                foreach (var itemB in B)
                {
                    if (str.EndsWith(itemB))
                    {
                        list.Remove(str);
                        break;
                    }
                }
            }

            return Enumerable.Range(0, A.Length).Where(i => list.Contains(A[i])).ToArray();
        }
    }
}
