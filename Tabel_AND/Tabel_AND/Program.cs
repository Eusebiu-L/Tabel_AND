namespace Tabel_AND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| A     | B     | A AND B  |");
            Console.WriteLine("|-------|-------|----------|");
            Console.WriteLine("| true  | true  | " + (true & true) + "     |");
            Console.WriteLine("| true  | false | " + (true & false) + "    |");
            Console.WriteLine("| false | true  | " + (false & true) + "    |");
            Console.WriteLine("| false | false | " + (false & false) + "    |");
        }
    }
}