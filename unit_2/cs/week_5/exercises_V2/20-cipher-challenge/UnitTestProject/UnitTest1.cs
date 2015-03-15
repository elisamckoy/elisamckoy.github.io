using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using CipherChallenge;
namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        //class fields
        private CipherChallengeClass _subject;

        [SetUp]
        public void Init()
        {
            //Because of the Setup Attribute above (attributes will be covered later) this method is set to run before each of the tests in the class
            //Here it is used to assign a new instance of the CipherChallengeClass class to a class field.
            //This means the class field will be overwritten at the beginning of each test.
            //Assignment is always from right to left and is denoted with a single =

            _subject = new CipherChallengeClass();
        }

        [Test]
        public void MartianCipherReturnsTheExpectedString()
        { 
            //Arrange 
                //Arrange is responsible for setting up any fields or instances you might need.
                //Create a string called expected and assign it what you expect the result of martiancipher to be. (hint run the app and read the result)
                //Create a second empty field of type string called actual.


            //Act
                //Act is where any methods needing to be called are executed.
                //Call on the MartianCipher method inside _subject which is an instance of the CipherChallengeClass and assign it to expected.
                //MartianCipher takes a string argument - in this case it will be the same as that given in the main method of program.


            //Assert
                //Assert is where we determine if the test passes or fails. In this case it is a comparison between actual and expected.
                //To do this we use the Assert class. Look at a previous challenge to see how this is used.
        }
    }
}
