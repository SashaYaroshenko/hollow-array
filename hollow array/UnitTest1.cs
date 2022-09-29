namespace Solution
{
    using NUnit.Framework;
    using System;
    using ConsoleApp1;

    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("Sample Test")]
        public void SampleTest()
        {
            Assert.AreEqual(true, Kata.IsHollow(new int[] { -1, 0, 0, 0, 3 }));
            Assert.AreEqual(false, Kata.IsHollow(new int[] { -1, 0, 0, 0, 0 }));
        }
    }
}