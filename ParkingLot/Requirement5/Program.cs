namespace Requirement5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of vehicles:");
            int n = int.Parse(Console.ReadLine());
            List<Vehicle> vehicleList = new List<Vehicle>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                vehicleList.Add(Vehicle.CreateVehicle(input));
            }
            Console.WriteLine("Enter a type to sort:");
            Console.WriteLine("1.Sort by weight");
            Console.WriteLine("2.Sort by parked time");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                vehicleList.Sort();
            }
            else if (ch == 2)
            {
                vehicleList.Sort(new parkedTimeComparer());
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                return;
            }
            Console.Write("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n", "Registration No", "Name", "Type", "Weight", "Ticket No");
            foreach (Vehicle vehicle in vehicleList)
            {
                {
                    Console.Write($"{vehicle.registrationNo,-15} {vehicle.name,-10} {vehicle.type,-12} {vehicle.weight:F1} {vehicle.ticket.ticketNo,8}\n");
                }
            }
        }
    }
}
