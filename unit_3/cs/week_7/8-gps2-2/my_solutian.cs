using System;
using System.Collections;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		State_Data Data = new State_Data();
		VirusPredictor Alabama = new VirusPredictor("Alabama", Data.Set["Alabama"][0], Data.Set["Alabama"][1], Data.Set["Alabama"][2], Data.Set["Alabama"][3]);
		Alabama.VirusEffects();
		VirusPredictor Jersey = new VirusPredictor("New Jersey", Data.Set["New Jersey"][0], Data.Set["New Jersey"][1], Data.Set["New Jersey"][2], Data.Set["New Jersey"][3]);
		Jersey.VirusEffects();
		VirusPredictor California = new VirusPredictor("California", Data.Set["California"][0], Data.Set["California"][1], Data.Set["California"][2], Data.Set["California"][3]);
		California.VirusEffects();
		VirusPredictor Alaska = new VirusPredictor("Alaska", Data.Set["Alaska"][0], Data.Set["Alaska"][1], Data.Set["Alaska"][2], Data.Set["Alaska"][3]);
		Alaska.VirusEffects();
	}
}

public class VirusPredictor{
	private string _state;
	private string _populationDensity;
	private string _population;
	private string _region;
	private string _regionalSpread;
	
	public VirusPredictor(string state_of_origin, string population_density, string population, string region, string regional_spread)
	{
		_state = state_of_origin;
		_populationDensity = population_density;
		_population = population;
		_region = region;
		_regionalSpread = regional_spread;
	}
	
	public void VirusEffects()
	{
		PreditcedDeaths(_populationDensity, _population, _state);
		SpeedOfSpread(_populationDensity, _state);
	}
	
	private void PreditcedDeaths (string popDens, string pop, string state)
	{
		decimal _numberOfDeaths;
		string[] popDensWords = popDens.Split(' ');
		string[] popWords = popDens.Split(' ');
	    if (decimal.Parse(popDensWords[1]) >= 200)
		{
			_numberOfDeaths = decimal.Multiply(decimal.Parse(popWords[1]), (decimal) 0.4);
		}
		else if(decimal.Parse(popDensWords[1]) >= 150)
		{
			_numberOfDeaths = decimal.Multiply(decimal.Parse(popWords[1]), (decimal) 0.3);
		}
		else if(decimal.Parse(popDensWords[1]) >= 100)
		{
			_numberOfDeaths = decimal.Multiply(decimal.Parse(popWords[1]), (decimal) 0.2);
		}
		else if(decimal.Parse(popDensWords[1]) >= 50)
		{
			_numberOfDeaths = decimal.Multiply(decimal.Parse(popWords[1]), (decimal) 0.1);
		}
		else
		{
			_numberOfDeaths = decimal.Multiply(decimal.Parse(popWords[1]), (decimal) 0.05);
		}
		Console.WriteLine("{0} will lose {1} people in this outbreak", state, _numberOfDeaths);
	}
	
	private void SpeedOfSpread (string popDens, string state)
	{
		double speed = 0;
		string[] popDensWords = popDens.Split(' ');
	    if (decimal.Parse(popDensWords[1]) >= 200)
		{
			speed += 0.5;
		}
		else if (decimal.Parse(popDensWords[1]) >= 150)
		{
			speed += 1;
		}
		else if (decimal.Parse(popDensWords[1]) >= 100)
		{
			speed += 1.5;
		}
		else if (decimal.Parse(popDensWords[1]) >= 50)
		{
			speed += 2;
		}
		else
		{
			speed += 2.5;
		}
		Console.WriteLine(" and will spread across the state in {0} months.\n\n", speed);
	}
}

public class State_Data {
	public Dictionary<string, List<string>> Set = new Dictionary<string, List<string>>
	{
		{"Alabama", new List<string>{"population_density: 94.65", "population: 4822023", "region: 5", "regional_spread: 3"}},
		{"Alaska", new List<string>{"population_density: 1.1111"," population: 731449", "region: 10", "regional_spread: 9"}},
		{"Arizona", new List<string>{"population_density: 57.05", "population: 6553255", "region: 8", "regional_spread: 8"}},
		{"Arkansas", new List<string>{"population_density: 56.43", "population: 2949131", "region: 7", "regional_spread: 5"}},
		{"California", new List<string>{"population_density: 244.2", "population: 38041430"," region: 9", "regional_spread: 8"}},
		{"Colorado", new List<string>{"population_density: 49.33", "population: 5187582", "region: 8", "regional_spread: 6"}},
		{"Connecticut", new List<string>{"population_density: 741.4", "population: 3590347", "region: 1", "regional_spread: 2"}},
		{"Delaware", new List<string>{"population_density: 470.7", "population: 917092,", "region: 3", "regional_spread: 2"}},
		{"Florida", new List<string>{"population_density: 360.2", "population: 19317568"," region: 3", "regional_spread: 5"}},
		{"Georgia", new List<string>{"population_density: 172.5", "population: 9919945", "region: 3", "regional_spread: 5"}},
		{"Hawaii", new List<string>{"population_density: 216.8", "population: 1392313", "region: 11", "regional_spread: 9"}},
		{"Idaho", new List<string>{"population_density: 19.15", "population: 1595728", "region: 8", "regional_spread: 9"}},
		{"Illinois", new List<string>{"population_density: 231.9", "population: 12875255", "region: 4", "regional_spread: 6"}},
		{"Indiana", new List<string>{"population_density: 182.5", "population: 6537334", "region: 4", "regional_spread: 5"}},
		{"Iowa", new List<string>{"population_density: 54.81", "population: 3074186", "region: 6", "regional_spread: 4"}},
		{"Kansas", new List<string>{"population_density: 35.09", "population: 2885905", "region: 6", "regional_spread: 7"}},
		{"Kentucky", new List<string>{"population_density: 110.0", "population: 4380415", "region: 5", "regional_spread: 4"}},
		{"Louisiana", new List<string>{"population_density: 105.0", "population: 4601893", "region: 7", "regional_spread: 5"}},
		{"Maine", new List<string>{"population_density: 43.04", "population: 1329192", "region: 1", "regional_spread: 2"}},
		{"Maryland", new List<string>{"population_density: 606.2", "population: 5884563", "region: 3", "regional_spread: 2"}},
		{"Massachusetts", new List<string>{"population_density: 852.1", "population: 6646144", "region: 1", "regional_spread: 2"}},
		{"Michigan", new List<string>{"population_density: 174.8", "population: 9883360", "region: 4", "regional_spread: 2"}},
		{"Minnesota", new List<string>{"population_density: 67.14", "population: 5379139", "region: 6", "regional_spread: 4"}},
		{"Mississippi", new List<string>{"population_density: 63.50", "population: 2984926", "region: 5", "regional_spread: 7"}},
		{"Missouri", new List<string>{"population_density: 87.26", "population: 6021988", "region: 6", "regional_spread: 4"}},
		{"Montana", new List<string>{"population_density: 6.86", "population: 1005141", "region: 8", "regional_spread: 9"}},
		{"Nebraska", new List<string>{"population_density: 23.97", "population: 1855525", "region: 6", "regional_spread: 8"}},
		{"Nevada", new List<string>{"population_density: 24.8", "population: 2758931", "region: 8", "regional_spread: 9"}},
		{"New Hampshire", new List<string>{"population_density: 147.0", "population: 1320718", "region: 1, region: 1", "regional_spread: 2"}},
		{"New Jersey", new List<string>{"population_density: 1205", "population: 8864590", "region: 2", "regional_spread: 3"}},
		{"New Mexico", new List<string>{"population_density: 17.16", "population: 2085538", "region: 8", "regional_spread: 7"}},
		{"New York", new List<string>{"population_density: 415.3", "population: 19570261","region: 2", "regional_spread: 1"}},
		{"North Carolina", new List<string>{"population_density: 200.6", "population: 9752073", "region: 3", "regional_spread: 5"}},
		{"North Dakota", new List<string>{"population_density: 9.92", "population: 699628", "region: 6", "regional_spread: 8"}},
		{"Ohio", new List<string>{"population_density: 282.5", "population: 11544225"," region: 4", "regional_spread: 2"}},
		{"Oklahoma", new List<string>{"population_density: 55.22", "population: 3814820", "region: 7", "regional_spread: 6"}},
		{"Oregon", new List<string>{"population_density: 40.33", "population: 3899353", "region: 9", "regional_spread: 8"}},
		{"Pennsylvania", new List<string>{"population_density: 285.3", "population: 12763536"," region: 2", "regional_spread: 3"}},
		{"Rhode Island", new List<string>{"population_density: 1016", "population: 1050292", "region: 1", "regional_spread: 2"}},
		{"South Carolina", new List<string>{"population_density: 157.1", "population: 4723723", "region: 3", "regional_spread: 5"}},
		{"South Dakota", new List<string>{"population_density: 10.86", "population: 833354", "region: 6", "regional_spread: 8"}},
		{"Tennessee", new List<string>{"population_density: 156.6", "population: 6456243", "region: 5", "regional_spread: 3"}},
		{"Texas", new List<string>{"population_density: 98.07", "population: 26059203"," region: 7", "regional_spread: 3"}},
		{"Utah", new List<string>{"population_density: 34.3", "population: 2855287", "region: 8", "regional_spread: 9"}},
		{"Vermont", new List<string>{"population_density: 67.73", "population: 626011", "region: 1", "regional_spread: 2"}},
		{"Virginia", new List<string>{"population_density: 207.3", "population: 8185867", "region: 3", "regional_spread: 2"}},
		{"Washington", new List<string>{"population_density: 102.6", "population: 6724540", "region: 9", "regional_spread: 8"}},
		{"Washington,D.C.", new List<string>{"population_density: 10357", "population: 632323", "region: 3", "regional_spread: 2"}},
		{"West Virginia", new List<string>{"population_density: 77.06", "population: 1855413", "region: 3", "regional_spread: 4"}},
		{"Wisconsin", new List<string>{"population_density: 105.2", "population: 5726398", "region: 4", "regional_spread: 6"}},
		{"Wyoming", new List<string>{"population_density: 5.851", "population: 576412", "region: 8", "regional_spread: 6"}}
	};
}
