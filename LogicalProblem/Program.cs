namespace LogicalProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Logical Programming Practice Problem");


            Console.Write("Emter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int reverse = 0;
            int temp = number;
            while (number > 0)
            {
                int rem = number % 10;
                reverse = (reverse * 10) + rem;
                number = number / 10;
            }
            Console.WriteLine($"Reverse of the number {temp} is {reverse}");

        }
    }
}