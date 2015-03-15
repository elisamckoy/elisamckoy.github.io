#Get the numbers in a range

## Learning Competencies
- Write kick ass pseudocode
- Write a method
- Read data from a data structure
- Use primitive types - string, int, hash etc...

## Summary, The user stories:

Write a method `CountBetween` which takes takes three arguments as input - `List<int>` numbers, int lowerBound and int upperBound.

CountBetween should return the number of integers in the `List<int>` between the two bounds, including the bounds

It should return 0 if the `List<int>` is empty.

Example Psueodo-Driver code:

// Simulates the use of the psuedocode you are to write
CountBetween for the List of ints [1,2,3] and arguments 0 and 10 should result in '3'  
CountBetween for the List of ints [-10,1,2] and arguments 0 and 10 should result in '2'  
CountBetween for the List of ints [10,20,30] and arguments 10 and 30 should result in '3'  
CountBetween for the List of ints [] and arguments -100 and 100 should result in '0'  
CountBetween for the List of ints [0] and arguments 0 and 0 should result in '1'  
// You will see lines similar to this in the tests - this code drives the app, ie it uses it to make stuff happen.  

ToDo:  

1. [Pseudocode](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/pseudocode.md).  
2. Add and commit your changes.  
3. Look in the test class and see where CountBetween is being used. This is driver code that uses the method.
4. Write your best Initial Solution (Remember this is off of memory).  
5. Refactor the initial solution to pass the tests.  
6. Peek at the solution and if you dont understand something put a post on slack and start a discussion.  
7. Add, commit and push your code up to GitHub.    

Pro-Tip: It will be tempting to just dive in and start to short cut eg skip Pseudocoding. Don't!!! if you feel its taking to long - time box it and add to it later. Pseudocoding involves thinking through how you will solve a task and in a way is the creative part of programming and is language agnostic - ie by Pseudocoding you are programming and really it is then just a case of learning the syntax, peculiarities and extra features of a language.  

PS: C# Rules!!!