namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"You entered: {num}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            try
            {
                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters long.");
                }

                Console.WriteLine("Password accepted.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}