namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
            try
            {
            int x = int.MaxValue;
            x = x + 1; 
            }
            catch (OverflowException)
            {
            Console.WriteLine("Overflow detected");
            }
            }
            unchecked
            {
            int y = int.MaxValue;
            y = y + 1;
            Console.WriteLine(y); 
            }
            }
        }

    }
