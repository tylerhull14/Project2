using System;

class DiceRollingSimulator
    
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        int totalRolls = int.Parse(Console.ReadLine());

        DiceRoller roller = new DiceRoller();
        int[] results = roller.RollDice(totalRolls);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");

        for (int i = 2; i <= 12; i++)
        {
            Console.Write($"{i}: ");
            int percentage = (results[i] * 100) / totalRolls;
            Console.WriteLine(new string('*', percentage));
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}

class DiceRoller
{
    public int[] RollDice(int numberOfRolls)
    {
        Random rnd = new Random();
        int[] rollCounts = new int[13]; // Indexes 0 and 1 will not be used

        for (int i = 0; i < numberOfRolls; i++)
        {
            int roll = rnd.Next(1, 7) + rnd.Next(1, 7);
            rollCounts[roll]++;
        }

        return rollCounts;
    }
}