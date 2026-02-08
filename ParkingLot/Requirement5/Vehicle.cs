using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    public class Vehicle:IComparable<Vehicle>
    {
        //properties
        private string _registrationNo;
        public string registrationNo
        {
            get { return _registrationNo; }
            set { _registrationNo = value; }
        }
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _type;

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        private double _weight;

        public double weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        private Ticket _ticket;

        public Ticket ticket
        {
            get { return _ticket; }
            set { _ticket = value; }
        }
        //Zero Argument Constructor
        public Vehicle()
        {
        }
        //Parameterized constructor
        public Vehicle(string _registrationNo, string _name, string _type, double
 _weight, Ticket _ticket)
        {
            this._registrationNo = _registrationNo;
            this._name = _name;
            this._type = _type;
            this._weight = _weight;
            this._ticket = _ticket;
        }
        //Overrided ToString
        override public string ToString()
        {
            return $"Registration No:{_registrationNo}\nName:{_name}\nType:{_type}\nWeight:{_weight:F1}\nTicket:{_ticket.ticketNo}";
        }

        //Overrided Equals
        override public bool Equals(object obj)
        {
            Vehicle other = (Vehicle)obj;
            return _registrationNo == other._registrationNo &&
                   _name.ToLower() == other._name.ToLower();
        }
        //Overrided GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static Vehicle CreateVehicle(string detail)
        {
            string[] data = detail.Split(',');
            string regno = data[0];
            string n = data[1];
            string type = data[2];
            double w = double.Parse(data[3]);
            string t = data[4];
            DateTime parkedTime = DateTime.ParseExact(
                data[5],
                "dd-MM-yyyy HH:mm:ss",
                null
            );
            double cost = double.Parse(data[6]);
            Ticket ticket = new Ticket(t, parkedTime, cost);
            return new Vehicle(regno, n, type, w, ticket);

        }

        public int CompareTo(Vehicle? other)
        {
            return this._weight.CompareTo(other._weight);
        }
    }

}
