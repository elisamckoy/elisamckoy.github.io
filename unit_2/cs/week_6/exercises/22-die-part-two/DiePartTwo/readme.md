Working off your previous `Die` class from [Die Class 1](http://socrates.devbootcamp.com/exercises/46), implement a new `Die` class which takes an List<string>
    as its input.  When `Die.Roll()` is called, it randomly returns one of these strings.  If your Die constructor is passed an empty array, throw an `ArgumentError`.  It should work like this:

    
    List<String> list = new List<String> {"A", "B", "C", "D", "E", "F" };
    Die die = new Die(list);
    die.Sides();  
    // should return 6, which is the number of sides in this case   
    die.Roll();  
    // returns one of {"A", "B", "C", "D", "E", "F" } randomly  
    

    Just to reiterate, in the previous exercise you passed in a number of sides, `sides`, and the labels were assumed to be the integers `1..sides`.  Now we're passing in a list of arbitrary labels.  We could use this to represent a [Dreidel](http://en.wikipedia.org/wiki/Dreidel) or [Boggle dice](http://en.wikipedia.org/wiki/Boggle), for example.
