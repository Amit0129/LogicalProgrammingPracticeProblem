using System.Diagnostics;

namespace LogicalProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Logical Programming Practice Problem");


            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            stopWatch.Stop();
            Console.WriteLine(" Time elapsed: {0} ", stopWatch.Elapsed);

        }
    }
}