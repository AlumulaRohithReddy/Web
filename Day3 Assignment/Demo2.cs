namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;

            BV(a);
            BR(ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void BV(int x)
        {
            x = 100;
        }

        static void BR(ref int x)
        {
            x = 100;
        }
    }
}
