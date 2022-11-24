namespace LogicalProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Logical Programming Practice Problem");


            Console.Write("Emter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i ==0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine($"The number {number} is Prime Number");
            }
            else 
            { 
                Console.WriteLine($"The number {number} is Not Prime Number");
            }

        }
    }
}