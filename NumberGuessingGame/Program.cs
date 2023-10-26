internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        int winNum = r.Next(1, 100);
        bool win = false;
        do
        {
            Console.Write("Please guess a number inbetween 1 and 100: ");
            string s = Console.ReadLine();
            int i = int.Parse(s);
            if (i > winNum)
            {
                Console.WriteLine("To high! Guess lower...");
            }
            else if (i < winNum)
            {
                Console.WriteLine("To low! Guess higher...");
            }
            else
            {
                Console.WriteLine("YOU WİN...");
                Console.WriteLine("Congratulations");
                win = true;
            }


            Console.WriteLine();
        } while (win == false);
        Console.WriteLine("Thank you for playing game!");
        Console.Write("Press any key to finish...");
        Console.ReadKey(true);
    }
}