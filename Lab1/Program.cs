using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests"), InternalsVisibleTo("App")]

namespace Lab1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter number of items:");
            int numberOfItems = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter seed: ");
            int seed = int.Parse(Console.ReadLine());

            Problem problem = new Problem(numberOfItems, seed);
            foreach (var item in problem.items) {
                Console.WriteLine("id: " + item.id + " value: " + item.value + " weight: " + item.weight + " ratio: " + item.vwRatio);
            }

            Console.WriteLine("Enter capacity:");
            int capacity = int.Parse(Console.ReadLine());

            Result result = problem.Solve(capacity);
            Console.WriteLine(result.ToString());
        }
    }
}
