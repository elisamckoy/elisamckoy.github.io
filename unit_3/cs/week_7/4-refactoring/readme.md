[Week 6 Home](../)

# U2.W6: Refactoring for Code Readability


## Learning Competencies
- Explain what code is doing
- Refactor for clarity and readability

## Summary
Using the goals below, choose a challenge solution from [Class Warfare, Validate a Credit Card Number](../../week_5/6_validate_credit_card). This can be anyone's solution, but if you notice there's a lot of room for improvement with your own code, start with that. Find other's solutions by browsing the branches (just like you would to comment on a random person's solution).

Paste the original unrefactored code in your `my_solution.cs`, and as you refactor, make notes of the changes you are making to achieve optimal readability. Include those notes along with the refactored version in your [my_solution.cs](my_solution.cs) file.

#### Goals of Readable Code
- Eliminate repetition by using looping and branching wisely
- Complex operations are decomposed into constituent parts
- Descriptive names for methods, variables, classes, and modules
- Methods are small and behavior is obvious
- Minimizes need for comments because the code tells you what it is doing
- Code is formatted with proper indentation for optimal readability

## Release 0: Write exception throwing statements
Take the driver code and turn it into exception throwing statements with valid and invalid card numbers. Ex:

```cs
CreditCard card_1 = new CreditCard(1111111111111111);
if (card_1.CheckCard() != false) // Bad credit card, should return false, if it returns true instead then throw the exception and stop the program
	throw new Exception("CheckCard Failed!")
```

Exception throwing is a drastic measure to warn us when something goes wrong. Instead of simply printing out `True` or `False` as we've been doing until now, which can be easily missed, throwing an exception will actually interrupt the running of the code and print out the exception in the console, forcing us to address the issue.

## Release 1: [Pseudocode](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/pseudocode.md)

## Release 2: Comment the code 
Comment each chunk of code in the original solution

## Release 3: [Refactor](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/refactoring.md) the solution for readability

## Release 4: [Reflect](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/reflection-guidelines.md)

## Release 5: Push your solution to Github

## Release 6: [Review](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/review.md)
Write feedback for at least two other solutions!
