#How to write a my_solution

To help teach you how to break challenges down and help you be able to review your own code we have devised the process as foll

##Psuedocode
This is fake code, though the goal is to get it looking as close to code as you can. Effectively this is your logical intent - with the barest of lip service to the 	programming language it will later be writ in. One thing to note is that the objective with psuedocode is to remove barriers to writing logic - in C# this means you don't have to worry about syntax. If at any time it feels hard it most likely because the logic is hard or you have gone down the wrong path/have missed something.

Here are some guidelines:
1. Follow strict tab indenting to denote code blocks.
```
if (x < 5)
{
	Console.WriteLine("This Console.WriteLine that prints out a string is in the 'if' block of code shown by it being indented and inside the body brackets '{ }'")
}
```
2. Use simple English and focus on using doing words to denote actions that will happen in your code. eg create, add, loop, take etc...

3. Name all the variables and collections rather than just saying "create int variable"

4. Keep it loose and spend 5-10 min at tops on it  - you can always amend it as you go

##Initial Solution
This should be the Psuedocode implemented off memory in code - you will most likely have errors, thats ok this is a memory exercise. Don't spend more than 5-10 min on this.

##First Refactor
The goal here is to make whatever code you wrote in the initial run with no compile errors, ie fix syntax errors. Once you have it compiling, it will most likely fail a unit test. Implement changes to the code to try and get the tests passing. Feel free to Google as much as you like at this point - there is only one guide: don't use code you don't understand!

##When Stuck! - Cheat!!!
Well its not really cheating - during your programming career you will always be looking at others code and learning from it. So take a look at the provided solution and use it to inform you in how to fix your code so that you pass all the tests. Don't spend to much time on this, your code may be so different that it doesn't help. Also note some of the solutions are written using items you may not have come across - in this case have a google and see if you can understand the solution. Secondly reach out on slack to see what other people have done.

Take a look at the provided solution file [my_solution.cs](./my_solution.cs)