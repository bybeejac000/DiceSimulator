using Dicegame;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int rolls;

        Console.WriteLine("How many times do you want to roll?");
        rolls = int.Parse(Console.ReadLine());

     
        DiceFunctions df = new DiceFunctions(rolls);

        df.Simulate();

    }
}