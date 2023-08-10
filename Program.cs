namespace AgeCalculator
{
    internal class Program
    {
        static void Main()
        {
            // Awaiting input
            Console.Clear();
            Console.WriteLine("Input the day, month, and year you were born with this format: DD/MM/YYYY");
            string Input = Console.ReadLine()!;

            try
            {
                DateTime Birthday = DateTime.ParseExact(Input, "dd/MM/yyyy", null);

                DateTime Now = DateTime.Now;

                // How many years between given birthday and now
                TimeSpan Difference = Now - Birthday;

                int Years = (int)Math.Floor(Difference.TotalDays / 365.2425);

                // How many days between the calculated years and now
                Birthday = Birthday.AddYears(Years);
                Difference = Now - Birthday;

                int Days = (int)Math.Floor(Difference.TotalDays);

                Console.Clear();
                Console.WriteLine($"You are {Years} years old and {Days} days old.");
                Console.ReadKey();
                Main();
            }
            // Unexpected format input
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Incorrect format. Example: 02/12/1960");
                Console.ReadKey();
                Main();
            }
        }
    }
}