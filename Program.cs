using Mission_02;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create new Rolling instance and declare variables
        Rolling roll = new Rolling();
        int numDice = 0;
        int[] diceRolls = new int[11];

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        numDice = Int32.Parse(System.Console.ReadLine()); // Get user input for number of dice to use

        // Passing in the number of dice and the diceRolls array, call the rollDice "function" from the Rolling class
        roll.RollDice(numDice, diceRolls);

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\r\n" +
                                 "Each \"*\" represents 1% of the total number of rolls.\r\n" +
                                 "Total number of rolls = " + numDice + ".\n");

        // Write the results of RollDice
        for (int i = 0; i < diceRolls.Length; i++)
        {
            int pctRolls = (diceRolls[i] * 100) / numDice;
            string pctAsterisks = "";
            for (int j = 0; j < pctRolls; j++) // Print an asterisk for every percent of rolls this number contains
            {
                pctAsterisks += "*";
            }
            System.Console.WriteLine($"{i + 2}: {pctAsterisks}");
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}