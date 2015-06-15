using System;
using System.Collections.Generic;
using NUnit;
using Moq;
using NUnit.Framework;


namespace InterviewPreps
{
    [TestFixture]
    public class UnitTest1
    {

        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(4, 4, 16)]
        [TestCase(2, 3, 6)]
        [TestCase(3, 2, 6)]
        [TestCase(2, -3, -6)]
        [TestCase(2, -9, -18)]
        [TestCase(-2, 3, -6)]
        [TestCase(-2, -3, 6)]
        [TestCase(-2, 0, 0)]
        [TestCase(-0, 0, 0)]
        public void TestMultiplier(int a, int b, int ans)
        {
            // Arrange
            Multiplier m = new Multiplier(a, b);
            int expected = ans;

            // Act
            int actual = m.Multiply();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
