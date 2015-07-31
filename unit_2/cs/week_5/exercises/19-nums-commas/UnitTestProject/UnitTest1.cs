using System.Text.RegularExpressions;
using NumsCommas;
using NUnit.Framework;
using REPLTestSupport;

namespace UnitTestProject
{
    [TestFixture]
    public class Exercise34SeparateNumbersWithCommasTests
    {
        [Test]
        public void ReturnsNoCommaWhenNumberIsLessThan1000()
        {
            var regex = new Regex(@"^\d{1,3}$");
            var rand = HelperMethods.getRandom(0, 999);
            Assert.IsTrue(regex.Matches(Program.SeparateComma(rand)).Count == 1);
        }

        [Test]
        public void ReturnsOneCommaWhenNumberIsMoreThan1000LessThan999999()
        {
            var regex = new Regex(@"^\d{1,3},\d{3}$");
            var rand = HelperMethods.getRandom(1000, 999999);
            Assert.IsTrue(regex.Matches(Program.SeparateComma(rand)).Count == 1);
        }

        [Test]
        public void ReturnsTwoCommasWhenNumberIsMoreThan1000000LessThan999999999()
        {
            var regex = new Regex(@"^\d{1,3},\d{3},\d{3}$");
            var rand = HelperMethods.getRandom(1000000, 999999999);
            Assert.IsTrue(regex.Matches(Program.SeparateComma(rand)).Count == 1);
        }
    }
}