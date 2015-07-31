[Week 6 Home](../)

# U2.W6: Create a PezDispenser Class from User Stories 
**[SOLO CHALLENGE](https://github.com/weka-2014/phase-0-handbook/blob/master/solo-challenges.md) OPTION 1**


## Learning Competencies
- Implement a basic class and identify when to use instance variables
- Translate a user story into driver test code and solutions
- Translate driver test code into a class structure using object-oriented design

## Summary
In this challenge, you will translate user stories into an object (using a class). If you aren't sure what a user story is, use the power of google to do some research.

Your task is to create a class that represents a pez dispenser, a real world object (that has tasty treats!) We'll be taking a look at user stories that describe the functionality of the pez dispenser, and seeing how they relate to driver test code. The challenge is to create the proper class structure based on the driver code! 

## Release 0: Review the User Stories: 
  - As a pez user, I'd like to be able to "create" a new pez dispenser with a group of flavors that represent pez so it's easy to start with a full pez dispenser.
  - As a pez user, I'd like to be able to easily count the number of pez remaining in a dispenser so I can know how many are left.
  - As a pez user, I'd like to be able to take a pez from the dispenser so I can eat it.
  - As a pez user, I'd like to be able to add a pez to the dispenser so I can save a flavor for later.
  - As a pez user, I'd like to be able to see all the flavors inside the dispenser so I know the order of the flavors coming up.

## Release 1: Review the [Driver Code](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/driver-code.md)
Look at the driver code in `my_solution.cs`. Identify the code that seems to be satisfying each of the user stories. How many methods are represented by the test code?

## Release 2: [Pseudocode](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/pseudocode.md)
Let's take a look at the output of the above driver code:

```cs
A new pez dispenser has been created. You have 9 pez!
Here's a look inside the dispenser:
["cola", "chocolate", "strawberry", "raspberry", "grape", "orange", "cherry", "peppermint", "lemon"]
Adding a purple pez.
Now you have 10 pez!
Oh, you want one do you?
The pez flavor you got is: purple
Now you have 9 pez!
```

We definitely know we have a PezDispenser class, but what are it's innards? What are PezDispenser's attribute(s) and method(s)? Take a moment to list out all the methods, and show the input and output. It's good to be clear when there isn't an input or output!

## Release 3: Write your [Initial Solution](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/initial-solution.md) 
Is the test code working? Make sure your class satisfies the expected output. You'll probably run into bugs. Be methodical in your approach to bugs! Read the Error completely. What line number does the error appear on? What can be inferred from the error? Make one change at a time and retest your code. 

## Release 4: [Refactor](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/refactoring.md)

## Release 5: [Reflect](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/reflection-guidelines.md)

## Release 6: Push your solution to Github

## Release 7: [Review](https://github.com/weka-2014/phase-0-handbook/blob/master/coding-references/review.md)
Write feedback for at least two other solutions!