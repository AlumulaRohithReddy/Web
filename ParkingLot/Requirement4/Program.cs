namespace Requirement4
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of vehicles:");
            int n = int.Parse(Console.ReadLine());
            List<Vehicle> vehicleList = new List<Vehicle>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                vehicleList.Add(Vehicle.CreateVehicle(input));
            }
            Console.WriteLine("Enter a search type:");
            Console.WriteLine("1.By type");
            Console.WriteLine("2.By parked time");
            int ch = int.Parse(Console.ReadLine());
            VehicleBO b = new VehicleBO();
            List<Vehicle> vehiclelist = null;
            if (ch == 1)
            {
                Console.WriteLine("Enter the vehicle type");
                string type = Console.ReadLine();
                vehiclelist = b.FindVehicle(vehicleList, type);
            }
            else if (ch == 2)
            {
                Console.WriteLine("Enter the parked time:");
                DateTime time = DateTime.ParseExact(
                    Console.ReadLine(),
                    "dd-MM-yyyy HH:mm:ss",
                    null
                );
                vehiclelist = b.FindVehicle(vehicleList, time);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                return;
            }
            if (vehiclelist == null || vehiclelist.Count == 0)
            {
                Console.WriteLine("No such vehicle is present");
                return;
            }
            Console.Write("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n", "Registration No", "Name", "Type", "Weight", "Ticket No");
            foreach (Vehicle vehicle in vehiclelist)
            {
                if (vehicle != null)
                {
                    Console.Write($"{vehicle.registrationNo,-15} {vehicle.name,-10} {vehicle.type,-12} {vehicle.weight:F1} {vehicle.ticket.ticketNo,8}\n");
                }
            }
        }
    }
}
