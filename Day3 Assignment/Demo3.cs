namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5, 10));
            Console.WriteLine(Sum(2.5, 3.5));
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
           return a + b;
        }
 }
}
