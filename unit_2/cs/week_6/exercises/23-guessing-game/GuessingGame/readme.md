#Guessing Game

Create a `GuessingGame` class which is initialized with an integer called `answer`.

Define an instance method `Guess` which takes an integer called `guess` as its input. The method `Guess` should return the string `"high"` if `guess` is larger than the `answer`, `"correct"` if `guess` is equal to the `answer`, and `"low"` if `guess` is lower than the `answer`.

Define an instance method `IsSolved` which returns `true` if the most recent guess was correct and `false` otherwise.

Example usage:

```
game.IsSolved;     
=> false  
game.Guess(5);   
=> "low"  
game.Guess(20);  
=> "high"  
game.IsSolved;   
=> false  
game.Guess(7);  
=> "correct"  
game.IsSolved;  
=> true  
```

Or a program might do the guessing :)  

```
Random random = new Random();
GuessingGame game = GuessingGame.new(random.Next(100));
int lastGuess  = null;
int lastResult = null;

while(!game.IsSolved)
{
  if(lastGuess != null)
  {
    Console.WriteLine("Oops! Your last guess" + "(" + lastGuess + ")" + " was " + lastResult + ".");
  }
  Console.WriteLine("Enter your guess: ");
  int lastGuess  = (int) Console.ReadLine();
  int lastResult = game.Guess(lastGuess);
}

Console.WriteLine(lastGuess + " was correct!");

```