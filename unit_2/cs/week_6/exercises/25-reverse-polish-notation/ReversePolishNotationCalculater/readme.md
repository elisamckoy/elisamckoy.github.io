#Reverse Polish Notation Calculator
Create an `RPNCalculator` class which can evaluate expressions written in [Reverse Polish notation](http://en.wikipedia.org/wiki/Reverse_Polish_notation).

It should have an `Evaluate` instance method which takes as its input a valid RPN expression and returns its evaluation.  Your calculator only needs to handle addition, multiplication, and subtraction (not division).

Operators and numbers should be separated by a single space.

For example,


RPNCalculator calc = new RPNCalculator();

calc.Evaluate("1 2 +");    
=> 3  
calc.Evaluate("2 5 *");   
=> 10   
calc.Evaluate("50 20 -");  
=> 30  

// The general rule is that 'A B op' is the same as 'A op B'  
// i.e., 5 4 - is 5 - 4.  
calc.Evaluate("70 10 4 + 5 * -");  
=> 0  

The above breaks down into these steps.  
10 + 4 = 14  
14 * 5 = 70  
70 - 70 = 0.  

Note: The first two numbers before the first operator are resolved first. Effectively thes three characters can be thought to have been replaced with the result. 14 in this case. After this the equation would be reassesed to work out where the next operator is and what the two preceeding numbers are. In this case the next operator is * and the preceeding numbers 14 and 5. This is repeated intil there is one numbor and no operators.