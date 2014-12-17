using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laskin1;

namespace UnitTestProject1
{
    [TestClass]
    public class laskinTest
    {
        [TestMethod]
        public void Test_Sum_Method()
        {
            laskin laskin = new laskin();
            int sum, a = 3, b = 6;
            int sum2;

            for (int i = 0; i < 100; i++)
            {
                sum = (a + i) + (b + i);
                sum2 = laskin.sum((a + i), (b + i));

                Assert.AreEqual(sum, sum2);
            }

            for (int i = 0; i < 9999999; i++)
            {
                sum = (a + i) + (b + i);
                sum2 = laskin.sum((a + i), (b + i));

                Assert.AreEqual(sum, sum2);
            }
        }
        [TestMethod]
        public void Test_Sub_Method()
        {
            laskin laskin = new laskin();
            int sub, a = 3, b = 6;
            int sub2;

            for (int i = 0; i < 100; i++)
            {
                sub = (a + i) - (b + i);
                sub2 = laskin.sub((a + i), (b + i));

                Assert.AreEqual(sub, sub2);
            }
            for (int i = 0; i < 9999999; i++)
            {
                sub = (a + i) - (b + i);
                sub2 = laskin.sub((a + i), (b + i));

                Assert.AreEqual(sub, sub2);
            }
        }
    }
}
