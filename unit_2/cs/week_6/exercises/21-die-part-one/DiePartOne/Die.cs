/******************** Summary *************************
Exercise: Die Part One - Numeric

The Die constructor has been completed for you.
The Sides method has been stubbed out for you, you will need to add the logic.
The Roll method needs to be stubbed out and then completed.

If you try to run the tests at the moment you will have a compile error for the test project as it is expecting there to be a Roll method.
As such the first thing you should do is Stub out the Roll method so the project compiles. Then run the tests.

Remember to run the tests often.
*******************************************************/

using System;

namespace DiePartOne
{
    public class Die
    {
        private int _sides;

        //This is the constructor for the Die class - it is a method with no return and the same name as the class.
        //It will run once when an instance of a class is created and will take an argument in in the brackets.
        //This future argument is represented here by a variable in the brackets - this is called a parameter and like all variables in C# it has a type.
        public Die(int numberOfSides)
        {
            //Here the constructor is wired up to take the parameter and assign it to a field in the class.
            //If a parameter is not assigned to a field or property then it will simply disappear with the executed method.
            _sides = numberOfSides;
        }

        //Add logic to the method Sides
        public int Sides()
        {
            //This exception can be used to stub out a method. Delete it when you right your logic here.
            throw new NotImplementedException();
        }

        //Stub out a method called Roll


    }
}