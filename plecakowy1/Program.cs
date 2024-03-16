namespace plecakowy1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the the number of items:");
            int.TryParse(Console.ReadLine(), out int number);

            Console.WriteLine("Enter the seed:");
            int.TryParse(Console.ReadLine(), out int seed);

            Problem Problem = new Problem(number, seed);
            Console.WriteLine(Problem.ToString());

            Console.WriteLine("Enter the capacity:");
            int.TryParse(Console.ReadLine(), out int capacity);

            if (number >= 0 && seed > 0 && capacity >= 0)
            {
                Console.WriteLine(Problem.Solve(capacity));
            }
            else { Console.WriteLine("Error: incorrect data type"); }

        }
    }
}
