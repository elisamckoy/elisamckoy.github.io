using System;
using System.Reflection;
using NUnit.Framework;
using REPLTestSupport;
using GuessingGame;

namespace UnitTestProject
{
    [TestFixture]
    public class SimpleGuessingGameTests
    {
        GuessGame _subject;

        [SetUp]
        public void Init()
        {
            _subject = new GuessGame(7);
        }

        [Test]
        public void HasConstructor()
        {
            Type type = typeof(GuessGame);
            ConstructorInfo constructor = type.GetConstructor(new[] { typeof(int) });

            Assert.IsNotNull(constructor);
        }

        [Test]
        public void ConstructorHasOneParameter()
        {
            Type type = typeof(GuessGame);
            ConstructorInfo constructor = type.GetConstructor(new[] { typeof(int) });
            ParameterInfo[] parameters = constructor.GetParameters();

            Assert.AreEqual(1, parameters.Length);
        }

        [Test]
        public void HasGuessMethod()
        {
            MethodInfo guessMethod = HelperMethods.getMethod(typeof(GuessGame), "Guess");

            Assert.IsNotNull(guessMethod);
        }

        [Test]
        public void GuessHasOneParameter()
        {
            ParameterInfo[] guessParameterInfo = HelperMethods.getMethodParameters(typeof(GuessGame), "Guess");

            Assert.AreEqual(1, guessParameterInfo.Length);
        }

        [Test]
        public void ReturnsHighWhenGuessHigh()
        {
            Assert.AreEqual(_subject.Guess(100), "high");
        }

        [Test]
        public void ReturnsLowWhenGuessLow()
        {
            Assert.AreEqual(_subject.Guess(0), "low");
        }

        [Test]
        public void ReturnsCorrectWhenGuessCorrect()
        {
            Assert.AreEqual(_subject.Guess(7), "correct");
        }

        [Test]
        public void HasIsSolvedMethod()
        {
            MethodInfo isSolvedMethod = HelperMethods.getMethod(typeof(GuessGame), "IsSolved");

            Assert.IsNotNull(isSolvedMethod);
        }

        [Test]
        public void IsSolvedHasNoParameters()
        {
            ParameterInfo[] isSolvedParameterInfo = HelperMethods.getMethodParameters(typeof(GuessGame), "IsSolved");

            Assert.AreEqual(0, isSolvedParameterInfo.Length);
        }

        [Test]
        public void NotSolvedBeforeGuessMade()
        {
            Assert.IsFalse(_subject.IsSolved());
        }

        [Test]
        public void ChangesIsSolvedToTrueWhenGuessedCorrectly()
        {
            Assert.IsFalse(_subject.IsSolved());

            _subject.Guess(7);

            Assert.IsTrue(_subject.IsSolved());
        }

        [Test]
        public void DoesntChangeIsSolvedToTrueWhenGuessedIncorrectly()
        {
            Assert.IsFalse(_subject.IsSolved());

            _subject.Guess(5);

            Assert.IsFalse(_subject.IsSolved());
        }

        [Test]
        public void ChangesIsSolvedToFalseWhenGuessedCorrectly()
        {
            _subject.Guess(10);
            Assert.IsTrue(_subject.IsSolved());

            _subject.Guess(5);

            Assert.IsFalse(_subject.IsSolved());
        }
    }
}