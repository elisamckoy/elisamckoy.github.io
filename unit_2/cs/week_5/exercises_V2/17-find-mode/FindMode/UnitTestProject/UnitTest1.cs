using System.Collections.Generic;
using FindMode;
using NUnit.Framework;
using REPLTestSupport;

namespace UnitTestProject
{
    [TestFixture]
    public class ModeTests
    {
        private List<int> array1, array2, array3;
        private ModeClass subject;

        [SetUp]
        public void Init()
        {
            subject = new ModeClass();
            array1 = new List<int> { 1, 2, 3, 4, 5, 5, 7 };
            array2 = new List<int> { 4, 4, 5, 5, 6, 6, 6, 7, 5 };
        }

        [Test]
        public void HasModeMethod()
        {
            var modeMethod = HelperMethods.getMethod(typeof(ModeClass), "Mode");

            Assert.IsNotNull(modeMethod);
        }

        [Test]
        public void ModeHasOneParameter()
        {
            var modeParameterInfo = HelperMethods.getMethodParameters(typeof(ModeClass), "Mode");

            Assert.AreEqual(1, modeParameterInfo.Length);
        }

        [Test]
        public void ReturnsCorrectModeForUniqueModeList()
        {
            var result = subject.Mode(array1);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(5, result[0]);
        }

        [Test]
        public void ReturnsCorrectModeForNonUniqueModeList()
        {
            var result = subject.Mode(array2);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(6, result[1]);
        }
    }
}