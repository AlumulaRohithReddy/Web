using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    public class VehicleBO
    {
        public List<Vehicle> FindVehicle(List<Vehicle> vehicleList, string type)
        {
            return vehicleList
                   .Where(v => v.type.Equals(type))
                   .ToList();
        }
        public List<Vehicle> FindVehicle(List<Vehicle> vehicleList, DateTime parkedTime)
        {
            return vehicleList
                   .Where(v => v.ticket.parkedTime == parkedTime)
                   .ToList();
          
        }
    }
}
