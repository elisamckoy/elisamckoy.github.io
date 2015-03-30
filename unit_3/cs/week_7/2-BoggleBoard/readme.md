[Week 6 Home](../)

# U2.W6: Create a BoggleBoard Class


## Learning Competencies
- Create, access, and traverse nested data structures
- Implement a basic class and identify when to use instance variables

## Summary
Create a class `BoggleBoard` that includes the functionality of your methods from the [Boggle Board](../../week_5/4_boggle_board/my_solution.rb) challenge. 

To do this, take a look at the methods you've created. How can they be integrated into your BoggleBoard class? What needs to change? 

## Release 0: Create a new board
Write code so that the `BoggleBoard` constructor takes in the original jagged array as an argument. (Let's call that `dice_grid` because boggle_board is going to be its own object now!) 

```
public class BoggleBoard
{
// your code here
}

String[][] dice_grid = new String[][]
    {
         new String[] {"b", "r", "a", "e"},
         new String[] {"i", "o", "d", "t"},
         new String[] {"e", "c", "l", "r"},
         new String[] {"t", "a", "k", "e"}
    };

BoggleBoard boggle_board = new BoggleBoard(dice_grid);
```

 How does the `boggle_board` object hold the `dice_grid`?

## Release 1: Implement your methods
One method at a time, create a test to access your new `boggle_board` object. The first method should be ` CreateWord`. Write out a test with it's expectation in a comment, and then create the method in the `BoggleBoard` class. Try these coordinates: (1,2), (1,1), (2,1), (3,2).

Then, write methods for `GetRow` and `GetCol`.  Can you interact with the boggle_board object and get the values you expect?  Now print out all the rows and columns of the board as strings. You should end up with 8 four letter words. Are there any real words shown? Add your total output as a comment in your my_solution.cs file.

## Release 2: Access the coordinates
Now write some driver code to access an individual coordinate in your `boggle_board` object. Make this as simple as possible. Can you access the "k" character at row 3 column 2?

## Release 3: [Refactor](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/refactoring.md)

## Release 4: [Reflect](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/reflection-guidelines.md)
You just made a transition from procedural programming to object-oriented programming!  How is the implementation different?  What are the benefits to using the Object Oriented approach (even if it is a bit more code?) 

## Release 5: Push your solution to Github

## Release 6: [Review](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/review.md)
Write feedback for at least two other solutions!

## Optimize your Learning (Optional)
###Create a `GetDiagonal` method
Just like the `GetCol` or `GetRow` method, the `GetDiagonal` method should return an array of values, but it will need 2 coordinates entered to define the diagonal.  Error checking to make sure the coordinates are actually a diagonal would probably be a good idea.