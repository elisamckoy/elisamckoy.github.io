using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DiePartTwo;
using NUnit.Framework;
using REPLTestSupport;

namespace UnitTestProject
{
    [TestFixture]
    public class Exercise47AritraryDieTests
    {
        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void HasConstructor()
        {
            Type type = typeof(Die);
            ConstructorInfo constructor = type.GetConstructor(new[] { typeof(List<String>) });

            Assert.IsNotNull(constructor);
        }

        [Test]
        public void ConstructorHasOneParameter()
        {
            Type type = typeof(Die);
            ConstructorInfo constructor = type.GetConstructor(new[] { typeof(List<String>) });
            ParameterInfo[] parameters = constructor.GetParameters();

            Assert.AreEqual(1, parameters.Length);
        }

        [Test]
        public void ConstructorAcceptsNonZeroNumber()
        {
            try
            {
                List<String> list = new List<String>();
                Die die = new Die(list);
                Assert.Fail("Created a bad die with 0 sides! That wasn't supposed to happen!");
            }
            catch (ArgumentException e)
            {
            }
        }

        [Test]
        public void HasSidesMethod()
        {
            MethodInfo sidesMethod = HelperMethods.getMethod(typeof(Die), "Sides");

            Assert.IsNotNull(sidesMethod);
        }

        [Test]
        public void SidesHasNoParameters()
        {
            ParameterInfo[] sidesParameterInfo = HelperMethods.getMethodParameters(typeof(Die), "Sides");

            Assert.AreEqual(0, sidesParameterInfo.Length);
        }

        [Test]
        public void SidesShouldEqualConstructedSides()
        {
            List<String> sides = new List<String>();
            int number = HelperMethods.getRandom(1, 100);
            for (int i = 0; i < number; i++)
                sides.Add("A");
            Die die = new Die(sides);
            Assert.AreEqual(number, die.Sides());
        }

        [Test]
        public void HasRollMethod()
        {
            MethodInfo rollMethod = HelperMethods.getMethod(typeof(Die), "Roll");

            Assert.IsNotNull(rollMethod);
        }

        [Test]
        public void RollHasNoParameters()
        {
            ParameterInfo[] rollParameterInfo = HelperMethods.getMethodParameters(typeof(Die), "Roll");

            Assert.AreEqual(0, rollParameterInfo.Length);
        }

        [Test]
        public void RollsAllPossibleRollsForSingleLabel()
        {
            List<String> sides = new List<String>();
            int number = HelperMethods.getRandom(0, 26);
            char letter = (char)('A' + number);
            String label = letter.ToString();
            sides.Add(label);
            Die die = new Die(sides);

            Assert.AreEqual(label, die.Roll());
        }

        [Test]
        public void RollsValidRolls()
        {
            List<String> sides = new List<String>();

            for (int i = 0; i < 200; i++)
            {
                StringBuilder builder = new StringBuilder();
                for (int j = 0; j < 4; j++)
                {
                    int number = HelperMethods.getRandom(0, 26);
                    builder.Append((char)('A' + number));
                }

                sides.Add(builder.ToString());
            }

            Die die = new Die(sides);

            List<String> actualRolls = new List<String>();
            for (int i = 1; i < 200; i++)
            {
                actualRolls.Add(die.Roll());
            }

            foreach (String roll in actualRolls)
            {
                Assert.IsTrue(sides.Contains(roll));
            }
        }
    }
}