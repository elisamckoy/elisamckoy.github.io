#Challenge-Anatomy

##Assumed setup
These challenges have been created in visual studio for visual studio.
Visual Studio has the Nunit extension installed - if you have not yet done this open Visual Studio and look for the tool menu across the top, inside which you will find manage extensions. Open this and do a search fur NUnit and add it to your dev environment.  
If you have any trouble reach out on slack.

##Opening a challenge
1. Navigate to the folder in explorer and double click the solution file (extension = .sln).
2. Navigate to the folder in powershell and use the Invoke-Item (ii) command on the solution file.

##Whats in a challenge
These challenges have been created to train you how to think like a programmer and understand the C# language. To do this a unit test project has been provided to automate the testing of your logic. While testing is not something you are expected to be able to write at this point it is an industry staple. By coding against the tests you will come to appreciate how valuable they are. You should run the tests whenever you want to test that your logic is sound. Your goal is to have all the tests passing.

In each challenge you will find 4 key files, to view these you will need to have the solution explorer open (View => Solution Explorer). 

- readme.md - contains the challenge brief.
- Program.cs - contains the compiled solution, this is where you write your code.
- my_solution.cs - file to put your psuedocode and iterations of your code.
- example_solution.cs - an example solution to the challenge.

**Note: The my_solution.cs and example_solution.cs files have been set to not compile through there properties. This effectively removes them from the program and allows you to put repeating code in them that otherwise would break.**

##Running tests
So long as you have the NUnit extension installed the tests can be run through the testing window (Test => Window => Test Explorer). Once open you may run all the tests at any time by clicking "Run All".

##Challenge work flow
1. Read the reademe.md.
2. Open the my_solution.cs file and write out your psuedocode. (10-15 min)
3. Open Program.cs and write your Initial Solution - Translate your psuedocode into real code off memory.(5-10 min)
4. Copy paste your initial solution to the corresponding place in my_solution.cs.
5. Refactor (make changes to simplify) your code if you can. (5-10 min)
6. Copy paste your refactored solution to the corresponding place in my_solution.cs.
7. At this point you should ideally be passing all the tests. If not its ok - just try to understand why your not.
8. Look at the provided solution and study how it differs from your program. (5-10 min)
9. Refactor your code in Program.cs based upon any insights you have.
10. Copy paste the second refactored solution to the corresponding place in my_solution.cs
11. Write a short reflection on the challenge - try to articulate what you have learned and acknowledge anything you could do better and would like to focus on.