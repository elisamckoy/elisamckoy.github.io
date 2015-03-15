using System;
using System.Collections.Generic;
using DiePartOne;
using NUnit.Framework;
using REPLTestSupport;

namespace UnitTestProject
{
    [TestFixture]
    public class Exercise46NumericDieTests
    {
        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void HasConstructor()
        {
            var type = typeof (Die);
            var constructor = type.GetConstructor(new[] {typeof (int)});

            Assert.IsNotNull(constructor);
        }

        [Test]
        public void ConstructorHasOneParameter()
        {
            var type = typeof (Die);
            var constructor = type.GetConstructor(new[] {typeof (int)});
            var parameters = constructor.GetParameters();

            Assert.AreEqual(1, parameters.Length);
        }

        [Test]
        public void ConstructorAcceptsPositiveNumber()
        {
            try
            {
                var die = new Die(-1);
                Assert.Fail("Created a bad die with 1 side!");
            }
            catch (ArgumentException e)
            {
            }
        }

        [Test]
        public void ConstructorAcceptsNonZeroNumber()
        {
            try
            {
                var die = new Die(0);
                Assert.Fail("Created a bad die with 0 sides!");
            }
            catch (ArgumentException e)
            {
            }
        }

        [Test]
        public void HasSidesMethod()
        {
            var sidesMethod = HelperMethods.getMethod(typeof (Die), "Sides");

            Assert.IsNotNull(sidesMethod);
        }

        [Test]
        public void SidesHasNoParameters()
        {
            var sidesParameterInfo = HelperMethods.getMethodParameters(typeof (Die), "Sides");

            Assert.AreEqual(0, sidesParameterInfo.Length);
        }

        [Test]
        public void SidesShouldEqualConstructedSides()
        {
            var sides = HelperMethods.getRandom(1, 800);
            var die = new Die(sides);
            Assert.AreEqual(sides, die.Sides());
        }

        [Test]
        public void HasRollMethod()
        {
            var rollMethod = HelperMethods.getMethod(typeof (Die), "Roll");

            Assert.IsNotNull(rollMethod);
        }

        [Test]
        public void RollHasNoParameters()
        {
            var rollParameterInfo = HelperMethods.getMethodParameters(typeof (Die), "Roll");

            Assert.AreEqual(0, rollParameterInfo.Length);
        }

        [Test]
        public void RollsBetween1AndNumberOfSides()
        {
            var sides = HelperMethods.getRandom(1, 100) + 100;
            var die = new Die(sides);

            var actualRolls = new List<int>();
            for (var i = 1; i < 200; i++)
            {
                actualRolls.Add(die.Roll());
            }

            foreach (var roll in actualRolls)
            {
                Assert.IsTrue(roll <= sides);
                Assert.IsTrue(roll > 0);
            }
        }
    }
}