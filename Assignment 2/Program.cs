internal class Program
{
    private static void Main(string[] args)
    {
        int amount;

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        amount = int.Parse(Console.ReadLine());

        DiceSimulator simulator = new DiceSimulator();
        int[] results = simulator.RollDice(amount);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = 1000.");

        for (int r = 2; r <= 12; r++)
        {
            int percent = results[r] * 100 / amount;
            Console.Write(r + ": ");
            for (int p = 0; p < percent; p++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");


    }
}
class DiceSimulator
{
    public int[] RollDice(int amount)
    {
        int sum;

        Random random = new Random();
        int[] results = new int[13];

        for (int i = 0; i < amount; i++)
        {
            int dieOne = random.Next(1, 7);
            int dieTwo = random.Next(1, 7);
            sum = dieOne + dieTwo;
            results[sum]++;
        }
        return results;
    }
}