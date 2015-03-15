#NET REPL

Our custom NET REPL also contains an instructional section with associated exercises, called Labs.

Through this week we'll be using the Labs extensively, so the first thing you'll want to do is head over to Enspiral's [NET REPL](http://net-repl.enspiral.info)

* Username: devacademy
* Password: iamnice

On the left hand side navigate to labs and you will see a new page with 5 sections in it. These sections represent the key principles of programming in any language, once you learn them in C# you will be able to see them in almost all others.

Except for the first section, each contains a list of exercises to work through, be sure to time box these as you can easily get stuck on a challenge, becoming frustrated and lost because you made a syntax error. Agile is the process of iterative development - think of this as iterative learning, if you are efficient you will have time to come back to a given problem.

Unfortunately the NET REPL does not save your code - if you navigate away from the page you will loose your work. As such you should open the corresponding solution file in the exercises folder or a LinqPad file and treat it as your primary code base. (LinqPad has the benefit of checking your code for errors and printing Console.WriteLines() to its own output window).

##The Goal
Test Suite Passed - if your logic is sound and syntax ok, you will be rewarded with green text!

Test Suite Failed - but with less errors than before! It is unlikely you will pass them all in one go, but failing less can only be good (you will see something like . . . F . F . . indicating 2 out of 8 tests failed).

##Errors
There are 4 different errors that can happen and they can be grouped like this

Test Suite Failed - this is saying that your syntax is ok but that your logic is not meeting that required. These are test written by a programmer - not a computer.

Compile Failure - something is wrong with your syntax, read the error! there will be a line number telling you where it is.

###Less Common

Test Compile Failure - tests didnt compile, most likely some funky code is happening

Test Suite Time Out - most likely infinite loops

WTF - very rare = wow! if you get it.

##The box
Developing in the tiny box on NET REPL is horrible - so do it in sublime or LinqPad and copy/paste it in to run the code against the tests.