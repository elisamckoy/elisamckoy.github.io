// Pseudo-code

/*
Create a public method called mode that returns an Arraylist and takes an arraylist as a parameter called input
	Create a private method property ReturnList of type ArrayList
	Create private method property called frequency of type Hashtable
	Create private method property called MaxFrequency of type int
	Foreach int element in input
		if frequency[element] != null
			frequency[element] = frequency[element] +1
		else if frequency[element] == null
			frequency[element] = 1
	Create array sorted = frequency.Values
	Sort sorted by using array helper method .Sort()
	MaxFrequency = sorted[sorted.count -1]
	foreach DictionaryEntry element in frequency
		if element.Value == MaxFrequency
			ReturnList.Add(element.Key)
	return ReturnList
*/


// Initial solution
public Arraylist Mode[input]
	private Hashtable frequency = new Hashtable()
	private MaxFrequency(int)

	foreach(int element in input)
		if frequency[element] != null;
				frequency[element] = frequency[element] +1;
		else if frequency[element] == null
			frequency[element] = 1

	int[] sorted = frequency.Values;
	Array.Sort(sorted);

	foreach(DictionaryEntry element in frequency)
		if element.Value == MaxFrequency;
			ReturnList.Add(element.Key)

	return ReturnList


// Refactored solution

public Arraylist Mode(input)
{
	private Hashtable frequency = new Hashtable()
	private MaxFrequency(int)

	foreach(int element in input)
	{
		if frequency[element] != null;
			frequency[element] = frequency[element] +1;
		else if frequency[element] == null
			frequency[element] = 1
	}


	int[] sorted = frequency.Values;
	Array.Sort(sorted);

	foreach(DictionaryEntry element in frequency)
	{
		if element.Value == MaxFrequency;
			//not implemented
	}
	return ReturnList
}
	

/*******Look at Solution*******/
// Second Refactored solution

using System;
using System.Collections;
namespace CalcIt
{
	public class CalcIt
	{
		public ArrayList Calcing(ArrayList input)
		{
			ArrayList ReturnList = new ArrayList();
			Hashtable frequency = new Hashtable();
			// access type name
			int MaxFrequency;
			foreach(int element in input)
			{
				//some logic here
			}
			ArrayList sorted = new ArrayList(frequency.Values);
			sorted.Sort();
			MaxFrequency = (int)sorted[sorted.Count -1];
			foreach(DictionaryEntry element in frequency)
			{
				//some more logic
			}
			return ReturnList;
		}
	}
}


/* Reflections
What parts of your strategy worked? What problems did you face?
I feel asking Dan (coach) and searching google for aswers was very beneficial. I faced feeling pretty lost and not really knowing where to start.
I had limited knowledge of how to execute the challenge and a limited amount of time.

What questions did you have while coding? What resources did you find to help you answer them?
I wanted to know how to execute pseudo code and formulate a loose solution to the challenge.
I needed to know more about syntax and built-in methods and helper methods. 

What concepts are you having trouble with, or did you just figure something out? If so, what?
I'm havig trouble with formulating a solution from a set of instructions. I believe this is due to a lack of knowledge and the requirement to practice more.

Did you learn any new skills or tricks?
I found that I learned more about syntax and the structure of the solution.

How confident are you with each of the Learning Competencies?
I feel as if I am getting there and will need more time to establish all elements.
*/