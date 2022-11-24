namespace LogicalProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Logical Programming Practice Problem");


            Console.Write("Emter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sumOfDivisors = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sumOfDivisors += i;
                }
            }
            if (number == sumOfDivisors)
            {
                Console.WriteLine("Number {0} is a perfect number",number);
            }
            else
            {
                Console.WriteLine("Number {0} is Not a perfect number",number);
            }

        }
    }
}