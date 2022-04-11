using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace W3_schools
{
    class program
    {

        public static void Main(string[] args)
        {

            int[] Union(int[] firstArr, int[] secondArr)
            {
                List<int> union = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                union.AddRange(firstArr);
                foreach (int item in secondArr)
                    if (!union.Contains(item))
                        union.Add(item);
                return union.ToArray();
                Console.WriteLine(union.ToArray());
            }
            int[] Intersection(int[] firstArr, int[] secondArr)
            {
                List<int> intersect = new List<int>() { 2, 4, 6, 8 };
                foreach (int item in firstArr)
                    if (Array.IndexOf(secondArr, item) != -1)
                        intersect.Add(item);
                return intersect.ToArray();
                Console.WriteLine(Intersection(firstArr));
            }



        }

    }
}