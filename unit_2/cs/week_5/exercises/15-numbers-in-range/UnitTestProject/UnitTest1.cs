using System.Collections.Generic;
using NumbersInRange;
using NUnit.Framework;
using REPLTestSupport;

namespace NumbersInRangeTests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void HasCountBetweenMethod()
        {
            var countBetweenMethod = HelperMethods.getMethod(typeof (Program), "CountBetween");

            Assert.IsNotNull(countBetweenMethod);
        }

        [Test]
        public void CountBetweenHasThreeParameters()
        {
            var countBetweenParameterInfo =
                HelperMethods.getMethodParameters(typeof (Program), "CountBetween");

            Assert.AreEqual(3, countBetweenParameterInfo.Length);
        }

        [Test]
        public void Returns0ForEmptyArrayList()
        {
            var result = Program.CountBetween(new List<int>(), -100, 100);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Returns0IfLowerBoundGreaterThanUpperBound()
        {
            var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var result = Program.CountBetween(numbers, 100, -100);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ReturnsCountIfLowerBoundEqualsUpperBound()
        {
            var numbers = new List<int> {1, 1, 1};
            var result = Program.CountBetween(numbers, 1, 1);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void DoesntCountIntegersBelowLowerBound()
        {
            var numbers = new List<int> {-10, 1, 2};
            var result = Program.CountBetween(numbers, 0, 100);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void DoesntCountIntegersAboveUpperBound()
        {
            var numbers = new List<int> {1, 2, 200};
            var result = Program.CountBetween(numbers, 0, 100);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void returnsArraySizeIfAllIntegersWithinBounds()
        {
            var numbers = new List<int>();

            for (var i = 0; i < 100; i++)
            {
                numbers.Add(HelperMethods.getRandom(-50, 50));
            }

            var result = Program.CountBetween(numbers, -50, 50);
            Assert.AreEqual(100, result);
        }
    }
}