using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    public class parkedTimeComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle v1, Vehicle v2)
        {
            return v1.ticket.parkedTime.CompareTo(v2.ticket.parkedTime);
        }
    }

}
