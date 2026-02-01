namespace Exercise2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            double ax = double.Parse(a[0]);
            double ay = double.Parse(a[1]);
            double ar = double.Parse(a[2]);
            string[] b = Console.ReadLine().Split();
            double bx = double.Parse(b[0]);
            double by = double.Parse(b[1]);
            double br = double.Parse(b[2]);
            double d = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));

            if (d + br < ar)
            {
                Console.WriteLine("B is in A");
            }
            else if (d + ar < br)
            {
                Console.WriteLine("A is in B");
            }
            else if (d <= ar + br && d >= Math.Abs(ar - br))
            {
                Console.WriteLine("A and B intersect");
            }
            else
            {
                Console.WriteLine("A and B do not intersect");
            }
        }
    }
}
