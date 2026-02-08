using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptiondemo
{
    public class BankException:Exception

    {
        int acc;
        int bal;

        public BankException(int acc, int bal)
        {
            this.acc = acc;
            this.bal = bal;
        }
        public void Inform()
        {
            Console.WriteLine("Withdrawal Denied!");
            Console.WriteLine($"Available Balance : Rs. {bal} Minimum balance of Rs.100 must be maintained.");
        }
    }
}
