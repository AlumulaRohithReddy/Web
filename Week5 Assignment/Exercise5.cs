namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wgt = int.Parse(Console.ReadLine());

            if (wgt < 0 || wgt > 120)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (wgt <= 48)
            {
                Console.WriteLine("light fly");
            }
            else if (wgt <= 51)
            {
                Console.WriteLine("fly");
            }
            else if (wgt <= 54)
            {
                Console.WriteLine("bantam");
            }
            else if (wgt <= 57)
            {
                Console.WriteLine("feather");
            }
            else if (wgt <= 60)
            {
                Console.WriteLine("light");
            }
            else if (wgt <= 64)
            {
                Console.WriteLine("light welter");
            }
            else if (wgt <= 69)
            {
                Console.WriteLine("welter");
            }
            else if (wgt <= 75)
            {
                Console.WriteLine("light middle");
            }
            else if (wgt <= 81)
            {
                Console.WriteLine("middle");
            }
            else if (wgt <= 91)
            {
                Console.WriteLine("light heavy");
            }
            else
            {
                Console.WriteLine("heavy");
            }
        }
    }
}
