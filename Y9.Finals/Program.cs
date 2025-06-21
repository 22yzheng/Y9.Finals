
namespace Y9.Finals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalmark = 0;

            for (int i = 0; i < 3; i++) {
                totalmark = totalmark + Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter number of essays handed in late");
            int late = Convert.ToInt32(Console.ReadLine());
            if (late == 1)
            {
                totalmark = totalmark - 10;
            }
            else if (late > 1)
            {
                totalmark = totalmark / 2;
            }
            if (totalmark < 0)
            {
                totalmark = 0;
            }
            Console.WriteLine(totalmark);

        }
    }
}
