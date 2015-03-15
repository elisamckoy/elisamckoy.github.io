# Readme.md


Implement a basic `Die` class which can be initialized with some number of sides.  We can then roll the die, returning a random number.  It should work like this:

```
Die sixSidedDie = new Die(6);  
die.Sides();  
=> 6  
die.Roll();  
=> 1-6  
```

If we pass `new Die(-1)`, that is, with a number less than `1`, we should raise an `ArgumentException`.  This is done using the `throw` keyword.  See the [ArgumentException documentation](http://msdn.microsoft.com/en-us/library/system.argumentexception(v=vs.110).aspx) for how to do this.