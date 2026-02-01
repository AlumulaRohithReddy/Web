namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Runs");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i*(i-1)*(i+1)+" ");
            }
        }
    }
}
