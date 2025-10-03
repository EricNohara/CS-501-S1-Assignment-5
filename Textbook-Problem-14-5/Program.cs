using Textbook_Problem_14_5;

partial class Program
{
    static List<DJIA> rows = new List<DJIA>();

    public static decimal getThresholdFromInput()
    {
        // get threshold from user input
        Console.WriteLine("Enter a closing value threshold: ");
        decimal threshold;
        while (!decimal.TryParse(Console.ReadLine(), out threshold))
        {
            Console.WriteLine("Enter a closing value threshold: ");
        }

        return threshold;
    }

    public static void handleQueryOne()
    {
        decimal threshold = getThresholdFromInput();

        // find the first date the closing >= threshold
        var first = rows.FirstOrDefault(r => r.ClosingValue >= threshold);
        if (first != null)
        {
            Console.WriteLine($"\nFirst date with closing >= {threshold}:");
            Console.WriteLine($"{first.Date:d} (ClosingValue = {first.ClosingValue})");
        }
        else
        {
            Console.WriteLine("\nNo dates found with that threshold.");
        }
    }

    public static void handleQueryTwo() 
    {
        decimal threshold = getThresholdFromInput();

        // find all dates where closing >= threshold
        var all = rows.Where(r => r.ClosingValue >= threshold).ToList();
        if (all.Count() > 0)
        {
            Console.WriteLine($"\nAll dates with closing >= {threshold}:");
            foreach (var match in all)
            {
                Console.WriteLine($"Date: {match.Date:d} Closing Value: {match.ClosingValue}");
            }
        } else
        {
            Console.WriteLine($"\nThere are no dates with closing >= {threshold}");
        }
    }

    public static void Main(string[] args)
    {
        // parse the file
        string[] lines = File.ReadAllLines("../../../DJIA.csv");
        foreach (string line in lines)
        {
            // split by , and create new DJIA object from the line
            string[] parts = line.Split(',');
            var data = new DJIA
            (
                DateTime.Parse(parts[0].Trim()),
                decimal.Parse(parts[1].Trim()),
                decimal.Parse(parts[2].Trim()),
                decimal.Parse(parts[3].Trim()),
                decimal.Parse(parts[4].Trim())
            );

            rows.Add(data);
        }

        // test to make sure it worked
        Console.WriteLine($"There are {rows.Count} rows loaded.");

        // loop for user input queries
        bool isDone = false;
        while (!isDone)
        {
            Console.WriteLine("\nPlease select an option number to perform a given query:");
            Console.WriteLine("1: Get the first date that the closing value was at a specified value, or greater");
            Console.WriteLine("2: Get the dates that the closing value was at or greater than a specified value");
            Console.WriteLine("3: Exit the application");

            string? input = Console.ReadLine();

            // route the input to the correct action
            switch (input)
            {
                case "1":
                    handleQueryOne();
                    break;
                case "2":
                    handleQueryTwo();
                    break;
                case "3":
                    isDone = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }
    }
}