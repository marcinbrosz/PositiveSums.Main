using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PositiveSumUnit.Test
{
    [TestClass]
    public class PositiveSumTest
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [DataRow(new int[] { 1, -2, 3, 4, 5 }, 13)]
        [DataRow(new int[] { -1, 2, 3, 4, -5 }, 9)]
        [DataRow(new int[] { },  0)]
        [DataRow(new int[] { -1, -2, -3, -4, -5 }, 0)]
        public void Test_PosSum(int[] arr, int expected)
        {
            Assert.AreEqual(expected, PositiveSum.Library.PositiveSum.PosSum(arr));
        }

        [TestMethod]
        public void RandomTest_PosSum()
        {
            Random rnd = new Random();
            int length = rnd.Next(10,20);
            int[] arr = RandomArray(length);
            Assert.AreEqual(Solution(arr), 
                PositiveSum.Library.PositiveSum.PosSum(arr), string.Format("Failed when arr = {0}", arr));
        }

        public static int[] RandomArray(int length)
        {
            int[] result = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; ++i)
            {
                result[i] = rnd.Next(-100, 100);
            }
            return result;
        }

        private static int Solution(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }
    }
}
