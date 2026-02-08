using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    //Ticket class
    public class Ticket
    {
        //properties
        private string _ticketNo;
        public string ticketNo
        {
            get { return _ticketNo; }
            set { _ticketNo = value; }
        }
        private DateTime _parkedTime;
        public DateTime parkedTime
        {
            get { return _parkedTime; }
            set { _parkedTime = value; }
        }
        private double _cost;
        public double cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        //Zero Argument Constructor
        public Ticket()
        {
        }
        //Parameterized constructor
        public Ticket(string _ticketNo, DateTime _parkedTime, double _cost)
        {
            this._cost = _cost;
            this._ticketNo = _ticketNo;

            this._parkedTime = _parkedTime;
        }
        //Overrided ToString
        override public string ToString()
        {
            return $"Ticket No:{_ticketNo}\nParkedTime:{_parkedTime}\nCost:{_cost:F1}";
        }
        //Overrided GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
