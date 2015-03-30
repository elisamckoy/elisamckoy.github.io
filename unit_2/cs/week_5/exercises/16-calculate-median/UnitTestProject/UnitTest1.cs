using System.Collections.Generic;
using CalculateMedian;
using NUnit.Framework;
using REPLTestSupport;

namespace CalculateMedianTests
{
    [TestFixture]
    public class ProgramTests
    {
        private List<int> _array1, _array2, _array3;

        [SetUp]
        public void Init()
        {
            _array1 = new List<int> {1, 2, 3, 4, 5, 5, 7};
            _array2 = new List<int> {4, 4, 5, 5, 6, 6, 6, 7};
            _array3 = new List<int> {7, 4, 3, 5, 6, 2, 6, 4};
        }

        [Test]
        public void HasMedianMethod()
        {
            var medianMethod = HelperMethods.getMethod(typeof (Program), "Median");

            Assert.IsNotNull(medianMethod);
        }

        [Test]
        public void MedianHasOneParameter()
        {
            var medianParameterInfo = HelperMethods.getMethodParameters(typeof (Program), "Median");

            Assert.AreEqual(1, medianParameterInfo.Length);
        }

        [Test]
        public void ReturnsCorrectMedianForOddLengthArrayList()
        {
            var result = Program.Median(_array1);

            Assert.AreEqual(4.0, result);
        }

        [Test]
        public void ReturnsCorrectMedianForEvenLengthArray()
        {
            var result = Program.Median(_array2);

            Assert.AreEqual(5.5, result);
        }

        [Test]
        public void ReturnsCorrectMedianForUnsortedArrayList()
        {
            var result = Program.Median(_array3);

            Assert.AreEqual(4.5, result);
        }
    }
}