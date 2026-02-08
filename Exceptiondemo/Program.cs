namespace Exceptiondemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer c = new Customer("Rohith", 101, 500);

                Console.WriteLine("Initial Balance: Rs. " + c.GetBalance());

                Console.Write("Enter amount to withdraw: ");
                int amt = int.Parse(Console.ReadLine());

                c.Withdraw(amt);

                Console.WriteLine("Final Balance: Rs. " + c.GetBalance());
            }
            catch (BankException e)
            {
               e.Inform();
            }
        }
    }
}
