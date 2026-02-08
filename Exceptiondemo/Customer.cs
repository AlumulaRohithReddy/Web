using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptiondemo
{
    public class Customer
    {
		private string _name;

		public string name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _acc;

		public int acc	
		{
			get { return _acc; }
			set { _acc = value; }
		}

		private int _balance;	

		public int balance
		{
			get { return _balance; }
			set { _balance = value; }
		}

        public Customer(string name, int accno, int balance)
        {
            _name = name;
            _acc = accno;
            _balance = balance;

        }
        public void Withdraw(int amount)
        {
                if (balance - amount < 100)
                {
                    throw new BankException(_acc, _balance);
                }
                balance -= amount;
                Console.WriteLine("Withdrawal Successful!");
        }
        public int GetBalance()
        {
            return balance;
        }
    }
}
