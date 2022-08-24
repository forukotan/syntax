namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            string response;
           var equal = (answer < 9) ? response = $"{answer} is less than nine " : response = $"{ answer} greater than or equal to nine ";
            Console.WriteLine($"{response}");

        }
    }
}