using System;

namespace SporksFun
{
	class Program
	{
		// this line indiates that this is the beginning of the program.. you can only have one!
		// static is referring to the class itself
		// if we're modifying and not creating we use static. We aren't creating an instance, it is the class

		static void Main(string[] args)
		{
			// this line says write to the console these words...
			// Console.WriteLine("Hello World!");
			//this line says that we're doing an integer array (the square brackets indicate array)
			//rollTotals is the descriptive variable name
			// {} is the array we're creating, below we have created three elements.
			//int[] rollTotals = {20, 40, 80};

			//This line asks what is in the second place of the array?
			//The answer it will show will be 80!
			//Console.WriteLine(rollTotal[2]);

			int rolls;
			int intVal;

			Console.WriteLine("Welcome to the Dice Throwing Simulator.");
			Console.WriteLine("How many dice rolls would you like to simulate ? Ex: 1000");
			rolls = Convert.ToInt32(Console.ReadLine());
			// Converts to integer type

			Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
			Console.WriteLine("Each  *  represents 1% of the total number of rolls.");
			Console.WriteLine("Total number of rolls = " + 12);



			//This is how we create a new random number generator
			Random r = new Random();

			//Here we build a new array with 12 objects
			int[] totals = new int[13]; // array to keep track of totals
			Random rand = new Random(); // random number generator
			for (int i = 0; i < rolls; i++)
			{
				int roll1 = rand.Next(1, 7); // roll the first die
				int roll2 = rand.Next(1, 7); // roll the second die
				int total = roll1 + roll2; // calculate the total
				totals[total]++; // increment the total in the array
			}

			for (int i = 2; i <= 12; i++)
			{
				double percentage = ((double)totals[i] / rolls) * 100; // calculate the percentage
				Console.Write(i + ": " );
				int histogram = (int)Math.Round(percentage); // calculate the number of * to print
				for (int j = 0; j < histogram; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}

	}

}
