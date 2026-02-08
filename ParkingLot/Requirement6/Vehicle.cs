using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement6
{
    public class Vehicle
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
       
        //Zero Argument Constructor
        public Vehicle()
        {
        }
        //Parameterized constructor
        public Vehicle(string _registrationNo, string _name, string _type, double
 _weight)
        {
            this._registrationNo = _registrationNo;
            this._name = _name;
            this._type = _type;
            this._weight = _weight;
        }
        //Overrided ToString
        override public string ToString()
        {
            return $"Registration No:{_registrationNo}\nName:{_name}\nType:{_type}\nWeight:{_weight:F1}\n";
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
            return new Vehicle(regno, n, type, w);

        }
        public static SortedDictionary<string, int> TypeWiseCount(List<Vehicle> vehicleList)
        {
            SortedDictionary<string, int> result = new SortedDictionary<string, int>();
            foreach (Vehicle v in vehicleList)
            {
                if (result.ContainsKey(v.type))
                    result[v.type]++;
                else
                    result[v.type] = 1;
            }
            return result;
        }
    }

}
