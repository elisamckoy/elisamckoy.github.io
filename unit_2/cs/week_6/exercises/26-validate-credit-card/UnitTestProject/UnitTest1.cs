using System;
using System.Reflection;
using NUnit.Framework;
using REPLTestSupport;
using ValidateCreditCard;

namespace UnitTestProject
{
    [TestFixture]
    public class Exercise51CreditCardValidator
    {
        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void HasConstructor()
        {
            Type type = typeof(CreditCard);
            ConstructorInfo longConstructor = type.GetConstructor(new[] { typeof(long) });

            Assert.IsNotNull(longConstructor);
        }

        [Test]
        public void ConstructorHasOneParameter()
        {
            Type type = typeof(CreditCard);
            ConstructorInfo longConstructor = type.GetConstructor(new[] { typeof(long) });
            ParameterInfo[] parameters = longConstructor.GetParameters();

            Assert.AreEqual(1, parameters.Length);
        }

        [Test]
        public void ThrowsArgumentExceptionIfCardLengthGreaterThan16()
        {
            try
            {
                CreditCard card = new CreditCard(12345678901234567);
                Assert.Fail("Created a bad card! That wasn't supposed to happen!");
            }
            catch (ArgumentException e)
            {
            }
        }

        [Test]
        public void ThrowsArgumentExceptionIfCardLengthLessThan16()
        {
            try
            {
                CreditCard card = new CreditCard(123456789012345);
                Assert.Fail("Created a bad card! That wasn't supposed to happen!");
            }
            catch (ArgumentException e)
            {
            }
        }

        [Test]
        public void HasCheckCardMethod()
        {
            MethodInfo checkCardMethod = HelperMethods.getMethod(typeof(CreditCard), "CheckCard");

            Assert.IsNotNull(checkCardMethod);
        }

        [Test]
        public void CheckCardHasNoParameters()
        {
            ParameterInfo[] checkCardParameterInfo = HelperMethods.getMethodParameters(typeof(CreditCard), "CheckCard");

            Assert.AreEqual(0, checkCardParameterInfo.Length);
        }

        [Test]
        public void ChecksValidCard()
        {
            CreditCard card = new CreditCard(4408041234567893);
            Assert.IsTrue(card.CheckCard());
        }

        [Test]
        public void ChecksInvalidCard()
        {
            CreditCard card = new CreditCard(4408041234567892);
            Assert.IsFalse(card.CheckCard());
        }
    }
}