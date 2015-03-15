#Create a Method to Pad a Collection

## Learning Competencies
- Use tests to guide development
- Break down problems into implementable pseudocode
- Differentiate between and produce destructive and non-destructive methods

## Summary:

Implement the method `PadNew` and `PadOriginal`.  Each method accepts a minimum size (non-negative integer) and an optional pad value as arguments.

If the `List<int>` length is less than the minimum size, `Pad` should return a new `List<int>` padded with the pad value up to the minimum size.

For example,  

```
List<int> numbers = new List<int>(){1,2,3};  
PadNew(numbers, 5);  
=> {1,2,3,null,null}  
```

And

```
List<int> numbers = new List<int>(){1,2,3};  
PadNew(numbers, 5, "apple");  
=> {1,2,3,"apple","apple"}  
```

If the minimum size is less than or equal to the length of the `List<int>`, it should just return the `List<int>`.

That is, 

```
PadOriginal(new List<int>(){1,2,3}, 3);   
=> {1,2,3}
```


`PadNew(myArray, 0)` should always return a `List<int>` equal to `myArray`.  `PadNew` should always return a new `List<int>` and the original should be intact.

If there is no padding element specified, it should pad the `List<int>` with 0.

ToDo:  
  
1. [Pseudocode](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/pseudocode.md).  
2. Add and commit your changes.  
3. Write your best Initial Solution (Remember this is off of memory).  
4. Refactor the initial solution to pass the tests.  
5. Peek at the solution and if you dont understand something put a post on slack and start a discussion.  
6. Add, commit and push your code up to GitHub.  

Pro-Tip: When you come across a something you don't know give yourself a set amount of time to research it, do 3-5 minutes of googling and start with "msdn + Thing in question"
