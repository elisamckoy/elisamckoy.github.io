using System.Collections.Generic;
using NUnit.Framework;
using PadArray;
using REPLTestSupport;

namespace UnitTestProject
{
    [TestFixture]
    public class Exercise29PadAListTests
    {
        private List<List<object>> _allArrays;
        private List<object> _emptyArray, _array, _longArray, _randomArray;
        private Pad _subject;

        [SetUp]
        public void Init()
        {
            _subject = new Pad();
            _emptyArray = new List<object>();
            _array = new List<object> { 1, 2, 3 };
            _longArray = new List<object>();
            for (var i = 0; i < 10; i++)
            {
                _longArray.AddRange(_array);
            }

            _randomArray = new List<object>();
            var arrayLength = HelperMethods.getRandom(1, 101);
            for (var i = 0; i < arrayLength; i++)
            {
                _randomArray.Add(HelperMethods.getRandom(1, 10));
            }

            _allArrays = new List<List<object>> { _emptyArray, _array, _longArray, _randomArray };
        }

        [Test]
        public void HasPadOriginalMethod()
        {
            var padOriginalMethod = HelperMethods.getMethod(typeof(Pad), "PadOriginal");

            Assert.IsNotNull(padOriginalMethod);
        }

        [Test]
        public void HasPadNewMethod()
        {
            var padNewMethod = HelperMethods.getMethod(typeof(Pad), "PadNew");

            Assert.IsNotNull(padNewMethod);
        }

        [Test]
        public void PadOriginalReturnsOriginalObject()
        {
            var result = _subject.PadOriginal(_array, 10);

            Assert.AreEqual(_array, result);
            Assert.IsTrue(result == _array);
        }

        [Test]
        public void PadOriginalDoesntChangeLongArray()
        {
            var result = _subject.PadOriginal(_longArray, 10);

            Assert.AreEqual(result.Count, _longArray.Count);
        }

        [Test]
        public void PadNewReturnsNewObject()
        {
            var result = _subject.PadNew(_array, 10);

            Assert.IsFalse(_array == result);
        }

        [Test]
        public void PadsElementsToEndOfList()
        {
            foreach (var theArray in _allArrays)
            {
                var padSize = 1 + HelperMethods.getRandom(0, 50);
                var newSize = theArray.Count + padSize;

                var result = _subject.PadNew(theArray, newSize, "apple");
                var expectedResult = theArray;
                for (var i = 0; i < padSize; i++)
                    expectedResult.Add("apple");

                Assert.AreEqual(result.Count, newSize);
                Assert.AreEqual(expectedResult, result);
            }
        }

        [Test]
        public void DoesntPadIfMinSizeIsArraySize()
        {
            foreach (var theArray in _allArrays)
            {
                var result = _subject.PadNew(theArray, theArray.Count);

                Assert.AreEqual(result, theArray);
            }
        }

        [Test]
        public void DoesntPadIfMinSizeIsZero()
        {
            foreach (var theArray in _allArrays)
            {
                var result = _subject.PadNew(theArray, 0);

                Assert.AreEqual(result, theArray);
            }
        }

        [Test]
        public void PadsWithZeroByDefault()
        {
            var result = _subject.PadNew(_emptyArray, 2);
            Assert.AreEqual(result, new List<object> { 0, 0 });
        }

        [Test]
        public void CanPadWithAString()
        {
            var result = _subject.PadNew(_emptyArray, 2, "hello");
            Assert.AreEqual(result, new List<object> { "hello", "hello" });
        }

        [Test]
        public void CanPadWithAnObject()
        {
            var awesome = new AwesomeClass();
            var result = _subject.PadNew(_emptyArray, 2, awesome);
            Assert.AreEqual(result, new List<object> { awesome, awesome });
        }

        public class AwesomeClass
        {
        }
    }
}