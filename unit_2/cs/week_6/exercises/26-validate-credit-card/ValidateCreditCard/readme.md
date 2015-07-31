#Validate Credit Card

Given a credit card number we should be able to validate whether it is valid based on the [Luhn algorithm](http://en.wikipedia.org/wiki/Luhn_algorithm).

While the word [algorithm](http://en.wikipedia.org/wiki/Algorithm) sounds scary you can just think of them as a series of steps you use to solve a specific problem.  An example algorithm:

>1. Heat water until boiling
>2. Add pasta
>3. If pasta cooked, strain

The above steps if followed explicitly give us cooked pasta!

Starting with the second to last digit, double every other digit until you reach the first digit

Sum all the untouched digits and the doubled digits (doubled digits need to be broken apart, 10 becomes 1 + 0)

If the total is a multiple of ten, you have received a valid credit card number!

```
Example given 4563 9601 2200 1999  
Origin: 4   5   6   3   9   6   0   1   2   2   0   0   1   9   9   9  
Step 1: 8   5  12   3  18   6   0   1   4   2   0   0   2   9  18   9  
Step 2: 8 + 5 + 1 + 2 + 3 + 1 + 8 + 6 + 0 + 1 + 4 + 2 + 0 + 0 +2+ 9 + 1 + 8 + 9  
Step 3: 70 (total above) % 10 == 0  
Step 4: Profit
```

Your class will need to return `true` or `false` when we call the `CheckCard`.  Your class needs to be initialized with a credit card number that is exactly 16 digits otherwise you should receive an `ArgumentException`.