#Cipher Challenge

##Learning Competencies
- Identify and explain what code is doing
- Write driver code that uses a class
- Observe how classes interact

##Summary
Those pesky martians have made a cipher so that we cannot understand their radio communications about the fast approaching invasion! We wrote the following program to decipher the messages. As the GSB's (yes you could work there!) best programmer on staff, your job is to refactor the code.
In this challenge, you will refactor some existing code to make it more readable and follow best practices. When done reach out on slack and see compare and discuss your different refactorings.

#Releases
Releases will be how we now refer to the parts of a challenge they are less specific than the ToDo Lists of the previouse exercises. They are relying on your growing knowledge and understanding of workflow, remember to make small commits.

##Release 0: Run the code
Execute the code and look at the output. You should see a few different "I am comparing x and y" statements, and than a print out of the converted string.

##Release 1: Read the code
Identify what each line of code is doing.
Write comments above each line with an explanation.
Really focus on breaking each step down. You want to understand every line. This may take some time - talk about it on slack as needed.

Pro-Tip: If your not sure what something is doing Console WriteLine it with some identifying text.

```
Console.Writeline("The name variable is currently " + Name);
```

##Release 2: Right a test
A test project and class have been created for you. In the class a setup method has been created to instantiate on instance of the Program class in the test class.
We can then test the methods of the instance and determine if they are functioning as expected.

Go to the test class and follow the instructions to write the first test. 

Once finished see if you can right a couple more testing other string inputs. You will want to make a new call in the main method so you can see what the output is:

```
Console.WriteLine(cipher.MartianCipher("your string"));
```

Just add it below the one that is already there.

##Release 3: Tests to Mars
Feeling on top of the world right more tests!!! 