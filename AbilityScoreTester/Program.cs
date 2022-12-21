namespace AbilityScoreTester
{
	internal class Program
	{
		static void Main(string[] args)
		{
			AbilityScoreCalculator calculator = new AbilityScoreCalculator();

			while (true)
			{
				calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
				calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by amount");
				calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
				calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");

				calculator.CalculateAbilityScore();
				Console.WriteLine("Calculated ability score: " + calculator.Score);
				
				Console.WriteLine("Press Q to quit, any other key to continue");
				char keyChar = Console.ReadKey(true).KeyChar;
				if ((keyChar == 'Q') || (keyChar == 'q')) return;
				Console.WriteLine();
			}
		}

		/// <summary>
		/// Writes a prompt and reads a double value from the console.
		/// </summary>
		/// <param name="lastValueUsed">The default value</param>
		/// <param name="v"></param>
		/// <returns>The double value read, or the default value if unable to parse</returns>
		private static double ReadDouble(double lastValueUsed, string prompt)
		{
			Console.Write($"{prompt} [{lastValueUsed}]: ");
			string input = Console.ReadLine();
			if (double.TryParse(input, out double value))
			{
				Console.WriteLine("     using value " + value);
				return value;
			}
			else
			{
				Console.WriteLine("     using default value " + lastValueUsed);
				return lastValueUsed;
			}
		}

		/// <summary>
		/// Writes a prompt and reads an integer value from the console.
		/// </summary>
		/// <param name="lastValueUsed">The default value</param>
		/// <param name="v"></param>
		/// <returns>The integer value read, or the default value if unable to parse</returns>
		private static int ReadInt(int lastValueUsed, string prompt)
		{
			Console.Write($"{prompt} [{lastValueUsed}]: ");
			string input = Console.ReadLine();
			if (int.TryParse(input, out int value))
			{
				Console.WriteLine("     using value " + value);
				return value;
			}
			else
			{
				Console.WriteLine("     using default value " + lastValueUsed);
				return lastValueUsed;
			}
		}
	}
}