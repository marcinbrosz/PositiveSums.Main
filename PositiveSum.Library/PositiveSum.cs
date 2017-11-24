using System;
using System.Linq;

namespace PositiveSum.Library
{
    public class PositiveSum
    {
        public static int PosSum(int[] arr)
        {
            //----------------------------------
            //int result = 0;
            //arr.ToList().ForEach(n => {if (n > 0) result += n;});
            //return result;
            //----------------------------------
            return arr.Where(x => x > 0).Sum(x => x);
            //----------------------------------
            /*
                int result = 0;
                foreach (int x in arr)
                {
                    if (x > 0)
                        result += x;
                }
                return result;
            */
            //----------------------------------
            //return arr.


        }
    }
}
