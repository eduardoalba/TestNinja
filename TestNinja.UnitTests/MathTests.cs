﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        //SetUp
        //TearDown
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGeatherArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        #region Tests without parameters
        //[Test]
        //public void Add_WhenCalled_ReturnSumOfArguments()
        //{
        //    var result = _math.Add(1, 2);

        //    Assert.That(result, Is.EqualTo(3));
        //}

        //[Test]
        //public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        //{
        //    var result = _math.Max(2, 1);
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        //{
        //    var result = _math.Max(1, 2);
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_ArgumentsAreEqual_ReturnSameArgument()
        //{
        //    var result = _math.Max(1, 1);
        //    Assert.That(result, Is.EqualTo(1));
        //}

        #endregion

        #region Testing Arrays and Collections

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);
        }

        #endregion
    }
}
