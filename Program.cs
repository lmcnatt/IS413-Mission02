using Mission_02;

internal class Program
{
    private static void Main(string[] args)
    {
        //Create new Rolling instance
        Rolling roll = new Rolling();
        int numDice = 0;
        int[] diceRolls = new int[11];

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        numDice = Int32.Parse(System.Console.ReadLine());

        roll.RollDice(numDice, diceRolls);

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\r\n" +
                                 "Each \"*\" represents 1% of the total number of rolls.\r\n" +
                                 "Total number of rolls = " + numDice + ".\n");

        for (int i = 0; i < diceRolls.Length; i++)
        {
            int pctRolls = (diceRolls[i] * 100) / numDice;
            string pctAsterisks = "";
            for (int j = 0; j < pctRolls; j++)
            {
                pctAsterisks += "*";
            }
            System.Console.WriteLine($"{i + 2}: {pctAsterisks}");
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}