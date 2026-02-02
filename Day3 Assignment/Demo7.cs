namespace Demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 50, 100 ,90 };
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
            int[,] m = { { 21, 29 }, { 93, 44 } };
            Console.WriteLine(m[1, 1]);
            int[][] j = new int[2][];
            j[0] = new int[] { 1, 2, 3 };
            j[1] = new int[] { 4, 5 };
            Console.WriteLine(j[0][2]);
            }
        }
 }
