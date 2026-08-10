namespace AbstractWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HourlyWorker worker = new HourlyWorker(
                    "Pam",
                    "Sam",
                    40,
                    50
                );

                Console.WriteLine("Hourly Worker Details");
                Console.WriteLine("---------------------");
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid worker data: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}