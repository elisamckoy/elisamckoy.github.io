// Pseudo-code

// Initial solution
using System;
using System.Collections;

class PezDispenser {
	public static void Main() {
		String[] flavors = new String[] { "cola", "chocolate", "strawberry", "raspberry", "grape", "orange", "cherry", "peppermint", "lemon" };
		PezDispenser super_mario = new PezDispenser(flavors);
		Console.WriteLine( "A new pez dispenser has been created. You have " + super_mario.PezCount + " pez!");
		Console.WriteLine( "Here's a look inside the dispenser:" + super_mario.SeeAllPez() );
		Console.WriteLine( "Adding a purple pez." );
		super_mario.AddPez("purple");   // mmmmm, purple flavor
		Console.WriteLine( "Now you have " + super_mario.PezCount + " pez!" );
		Console.WriteLine( "Oh, you want one do you?" );
		Console.WriteLine( "The pez flavor you got is: " + super_mario.GetPez() );
		Console.WriteLine( "Now you have " + super_mario.PezCount + " pez!" );
	}
}

// Refactored solution

// Reflections
