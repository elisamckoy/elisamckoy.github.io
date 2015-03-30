#Calculate the Mode

## Learning Competencies
- Break down problems into implementable pseudocode
- Iterate through data structures and manipulate the content
- Use strings, integers, arrays, and/or hashes


## Summary, The user stories:

Write a method `Mode` which takes an `List<int>` of numbers or strings as its input and returns an `List<int>` of the most frequent values.

If there's only one most-frequent value, it returns a single-element `List<int>`.

For example the driver code might look like this:
(Driver code is code that uses a method.)

```
Mode(new List<int>() {1, 2, 3, 3});  
=> [3]  
Mode( new List<int>() {4.5, 0, 0});  
=> [0]  
Mode(new List<int>() {1.5, -1, 1, 1.5});   
=> [1, 5]  
Mode(new List<int>() {1, 1, 2, 2});  
=> [1, 2]  
Mode(new List<int>() {1, 2, 3});  
=> [1, 2, 3] //because all occur with equal frequency  
```

ToDo:  
 
1. [Pseudocode](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/pseudocode.md).  
2. Add and commit your changes.  
3. Look at the driver code in the test file. Use the above as a guide.
4. Write your best Initial Solution (Remember this is off of memory).  
5. Refactor the initial solution to pass the tests.  
6. Peek at the solution and if you dont understand something put a post on slack and start a discussion.  
7. Add, commit and push your code up to GitHub.  

Pro-Tip: Practice making lots of small commits to git - with descriptive messages. This will focus your time to solving a particular part of the problem as well as making it far easier to undo mistakes, as the messages will provide a synopsis of what happened on each commit.
