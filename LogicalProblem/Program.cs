namespace LogicalProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Logical Programming Practice Problem");


            Console.WriteLine("Enter the length of the copun code");
            int length = Convert.ToInt32(Console.ReadLine());
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var convString = new String(stringChars);
            Console.WriteLine("The Unique Coupon Code is "+convString);

        }
    }
}