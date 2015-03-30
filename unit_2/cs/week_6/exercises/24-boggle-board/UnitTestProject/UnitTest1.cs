using System;
using System.Reflection;
using BoggleBoardChallenge;
using NUnit.Framework;
using REPLTestSupport;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        private BoggleBoard _subject;

        [SetUp]
        public void Init()
        {
            _subject = new BoggleBoard();
        }

        [Test]
        public void HasCreateWordMethod()
        {
            MethodInfo sidesMethod = HelperMethods.getMethod(typeof(BoggleBoard), "CreateWord");

            Assert.IsNotNull(sidesMethod);
        }

        [Test]
        public void HasGetRowMethod()
        {
            MethodInfo sidesMethod = HelperMethods.getMethod(typeof(BoggleBoard), "GetRow");

            Assert.IsNotNull(sidesMethod);
        }

        [Test]
        public void HasGetColumnMethod()
        {
            MethodInfo sidesMethod = HelperMethods.getMethod(typeof(BoggleBoard), "GetColumn");

            Assert.IsNotNull(sidesMethod);
        }

        [Test]
        public void GetRowHasExpectedParameters()
        {
            ParameterInfo[] actual;

            actual = HelperMethods.getMethodParameters(typeof(BoggleBoard), "GetRow");

            Assert.AreEqual(1, actual.Length);
        }

        [Test]
        public void GetColumnHasExpectedParameters()
        {
            ParameterInfo[] actual;

            actual = HelperMethods.getMethodParameters(typeof(BoggleBoard), "GetColumn");

            Assert.AreEqual(1, actual.Length);
        }

        [Test]
        public void CreateWordReturnsExpectedWord()
        {
            //Arrange
            int[][] coords = { new[] { 2, 1 }, new[] { 1, 1 }, new[] { 1, 2 }, new[] { 0, 3 } };
            string expected = "code";

            //Act
            string actual = _subject.CreateWord(coords);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public void GetRowReturnsExpected()
        //{
        //    //Arrange
        //    string[] expected = {"i", "o", "d","t"};
        //    string[] actual;

        //    //Act
        //    actual = _subject.GetRow(1);
            
        //    //Assert

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void GetColumnReturnsExpected()
        //{
        //    //Arrange
        //    string[] expected = {"r", "o", "c", "a"};
        //    string[] actual;

        //    //Act
        //    actual = _subject.GetColumn(1);

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
