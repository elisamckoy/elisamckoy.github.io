#A Nested Array to Model a Boggle Board 


## Learning Competencies
- Break down problems into implementable pseudocode 
- Create, access, and traverse nested data structures
- Explain how data structures and classes can model a real-world object

## Summary

 We've already worked with lists and arrays as data structures. They are handy ways of collecting and organizing data, and ideal for modeling a group of objects. In this challenge, we're going to model a grid or a board that has coordinates for each of it's cells. A logical way of modeling a board is to use a nested array (or jagged array), where a row and column are its coordinates.

Let's explore a boggle board as an example.

```
String[][] boggle_board = new String[][]  
    {  
        new String[] {"b", "r", "a", "e"},  
        new String[] {"i", "o", "d", "t"},  
        new String[] {"e", "c", "l", "r"},  
        new String[] {"t", "a", "k", "e"}  
    };  
```

If we wanted to access the "r" character in the first row, we'd use the syntax below because "r" is in row 0 and under column 1. (Remember that arrays start counting from 0).

```
boggle_board[0][1] == "r"  
boggle_board[2][1] == "c"  
boggle_board[3][3] == "e"  
boggle_board[2][3] == "r"  
```

In boggle, you can spell out words by collecting letters that are immediately next to one another. (up, down, across, or diagonally). One of the words possible in the above boggle board is "code".  
If you look in UnitTest1.cs you will see the final test is for the CreateWord method. It takes a nested array of coordinates as below:

```
int[][] coords = { new[] { 2, 1 }, new[] { 1, 1 }, new[] { 1, 2 }, new[] { 0, 3 } };
```

While looking in the UnitTest1.cs take note of the two last commented out tests. You will need to uncomment these later 

ProTip: Use the VS shortcut "Ctrl + k, c" to comment out and "Ctrl + k, u" to uncomment.

Your task: Make all the tests pass! There are four failing tests that define the requirement to make two new methods.


## External Resources
* [Boggle on Wikipedia](http://en.wikipedia.org/wiki/Boggle)
* [Play Boggle online](http://www.wordplays.com/boggle)

## Release 0
Run the tests and determine which tests are failing, look at what they are expecting to exist in order to pass and add it to the BoggleBoard class.

Once you have created the required methods you will only have two failing tests. It is now time to uncomment the last two tests in the UnitTest1.cs file.

You will now have 2-4 failing tests.

At this point you should write the Psuedocode you need in the my_solution.cs for the two methods in order to make the tests pass.

## Release 1: 
Write your initial solution - time box this for 10 min a method.

Ideally you will have all the tests passing. If not its ok - add it to the my_solution.cs file.

*add and commit your changes on git*

## Release 2:
Refactor your code and keep the tests passing. If you haven't yet got the tests passing work towards it.

*add and commit your changes on git*

## Release 3:  
Include your reflection in the appropriate section in your `my_solution.cs` file. ***Note: Reflections solidify learnings!*** 

## Release 4: Commit and Push your changes to Github
When you feel confident with your solution, push your changes through the command line to your repo on GitHub. 
