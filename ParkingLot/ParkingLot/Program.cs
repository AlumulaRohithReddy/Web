namespace ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Vehicle 1 details:");
                string[] s1 = Console.ReadLine().Split(',');
                Ticket t1 = new Ticket(s1[4], DateTime.Parse(s1[5]), double.Parse(s1[6]));
                Vehicle v1 = new Vehicle(s1[0], s1[1], s1[2], double.Parse(s1[3]), t1);
                Console.WriteLine("Enter Vehicle 2 details:");
                string[] s2 = Console.ReadLine().Split(',');
                Ticket t2 = new Ticket(s2[4], DateTime.Parse(s2[5]), double.Parse(s2[6]));
                Vehicle v2 = new Vehicle(s2[0], s2[1], s2[2], double.Parse(s2[3]), t1);
                Console.WriteLine("Vehicle 1");
                Console.WriteLine();
                Console.WriteLine(v1.ToString());
                Console.WriteLine();
                Console.WriteLine("Vehicle 2");
                Console.WriteLine();
                Console.WriteLine(v2.ToString());
                Console.WriteLine();
                if (v1.Equals(v2))
                {
                    Console.WriteLine("Vehicle 1 is same as Vehicle 2");
                }
                else
                {
                    Console.WriteLine("Vehicle 1 and Vehicle 2 are different");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
