using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement2
{
    public class ParkingLot
    {
        private string _name = default!;
        private List<Vehicle> _vehicleList;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Vehicle> VehicleList
        {
            get { return _vehicleList; }
            set { _vehicleList = value; }
        }
        public ParkingLot()
        {
            _vehicleList = new List<Vehicle>();
        }
        public ParkingLot(string _name, List<Vehicle> _vehicleList)
        {
            this._name = _name;
            this._vehicleList = new List<Vehicle>();
        }
        public void AddVehicleToParkingLot(Vehicle vehicle)
        {
            _vehicleList.Add(vehicle);
        }

        public bool RemoveVehicleFromParkingLot(string registrationNo)

        {
            Vehicle v = _vehicleList.Find(x => x.registrationNo == registrationNo);
            if (v != null)
            {
                _vehicleList.Remove(v);
                return true;
            }
            return false;
        }

        public void DisplayVehicles()
        {
            if (_vehicleList != null)
            {
                Console.WriteLine("Vehicles in " + _name);
                Console.Write("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n", "Registration No", "Name", "Type", "Weight", "Ticket No");
                foreach (Vehicle vehicle in _vehicleList)
                {
                    if (vehicle != null)
                    {
                        Console.Write($"{vehicle.registrationNo,-15} {vehicle.name,-10} {vehicle.type,-12} {vehicle.weight:F1} {vehicle.ticket.ticketNo,8}\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("No vehicles to show");
            }
        }
    }
}
