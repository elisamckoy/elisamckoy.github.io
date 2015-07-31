# Die Class 1: Numeric

## Learning Competencies
- Break a large problem down into smaller steps
- Implement a method or class based on pseudocode
- Research and use Ruby methods
- Define a Ruby class and describe why you would use one
- Identify the scope of different variables

## Summary
In this challenge you'll want to implement a basic `Die` class which can be initialized with some number of sides.  We can then roll the die, returning a random number. It should work like this:

```ruby
die = Die.new(6) #This creates a new die object with 6 sides
die.sides # returns 6
die.roll # returns a random number between 1 and 6
```

If we pass `Die.new` a number less than `1`, we should raise an `ArgumentError`.  This is done using the `raise` keyword.  See the [ArgumentError documentation](http://apidock.com/ruby/ArgumentError) for how to do this.

## Release 0: [Pseudocode](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/pseudocode.md)

## Release 1: Write your [Initial Solution](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/initial-solution.md)

## Release 2: Run the tests
Once your code passes the tests, move on to refactoring.

## Release 3: [Refactor](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/refactoring.md) your solution
Make sure your code still passes the tests!

## Release 4: Push!
If you want feedback, continue using Slack and G+ to request it!
