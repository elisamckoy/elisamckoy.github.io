using System;
using System.Reflection;
using NUnit.Framework;
using ReversePolishNotationCalculater;
using REPLTestSupport;

namespace UnitTestProject
{
    [TestFixture]
    public class Exercise31ReversePolishNotationCalculatorTests
    {
        RPNCalculator subject;

        [SetUp]
        public void Init()
        {
            subject = new RPNCalculator();
        }

        [Test]
        public void hasEvaluateMethod()
        {
            MethodInfo evaluateMethod = HelperMethods.getMethod(typeof(RPNCalculator), "Evaluate");

            Assert.IsNotNull(evaluateMethod);
        }

        [Test]
        public void evaluateHasOneParameter()
        {
            ParameterInfo[] evaluateParameterInfo = HelperMethods.getMethodParameters(typeof(RPNCalculator), "Evaluate");

            Assert.AreEqual(1, evaluateParameterInfo.Length);
        }

        [Test]
        public void evaluatesZero()
        {
            Assert.AreEqual(0, subject.Evaluate("0"));
        }

        [Test]
        public void evaluatesNegativeConstant()
        {
            Assert.AreEqual(-1, subject.Evaluate("-1"));
        }

        [Test]
        public void evaluatesPositiveConstant()
        {
            Assert.AreEqual(3, subject.Evaluate("3"));
        }

        [Test]
        public void evaluatesAddition()
        {
            String formula = "1 1 +";
            int answer = 1 + 1;
            Assert.AreEqual(answer, subject.Evaluate(formula));
        }

        [Test]
        public void addsNegativeNumbers()
        {
            String formula = "7 -7 +";
            int answer = 7 + -7;
            Assert.AreEqual(answer, subject.Evaluate(formula));
        }

        [Test]
        public void evaluatesSubtraction()
        {
            String formula = "5 7 -";
            int answer = 5 - 7;
            Assert.AreEqual(answer, subject.Evaluate(formula));
        }

        [Test]
        public void evaluatesMultiplication()
        {
            String formula = "2 3 *";
            int answer = 2 * 3;
            Assert.AreEqual(answer, subject.Evaluate(formula));
        }

        [Test]
        public void supportsMultipleOperators()
        {
            String formula = "1 2 3 4 + + +";
            int answer = 1 + 2 + 3 + 4;
            Assert.AreEqual(answer, subject.Evaluate(formula));
        }

        [Test]
        public void supportsMixOfOperators()
        {
            String formula = "1 2 + 3 4 + *";
            int answer = (2 + 1) * (4 + 3);
            Assert.AreEqual(answer, subject.Evaluate(formula));
        }

        [Test]
        public void supportsVarietyOfOperators()
        {
            String formula = "20 10 5 4 + * -";
            int answer = (20 - 10 * (5 + 4));
            Assert.AreEqual(answer, subject.Evaluate(formula));
        }

        [Test]
        public void supportsArbitraryInput()
        {
            int a, b, c;
            a = HelperMethods.getRandom(0, 100);
            b = HelperMethods.getRandom(0, 100);
            c = HelperMethods.getRandom(0, 100);
            String formula = a + " " + b + " - " + c + " *";
            int answer = (a - b) * c;
            Assert.AreEqual(answer, subject.Evaluate(formula));
        }
    }
}