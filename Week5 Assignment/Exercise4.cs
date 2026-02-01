namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        Console.Write("Customer ID : ");
        int custId = int.Parse(Console.ReadLine());

        Console.Write("Customer Name : ");
        string name = Console.ReadLine();

        Console.Write("Address  : ");
        string addr = Console.ReadLine();

        Console.Write("Phone Number : ");
        string phone = Console.ReadLine();

        Console.Write("Email ID  : ");
        string email = Console.ReadLine();

        Console.Write("Connection Type  : ");
        string type = Console.ReadLine().ToLower();

        Console.Write("Previous Reading  : ");
        int prev = int.Parse(Console.ReadLine());

        Console.Write("Current Reading : ");
        int curr = int.Parse(Console.ReadLine());

        int u = curr - prev;
        double billAmt = CalBill(u);
        double meterRent = GetRent(type);
        double totalAmount = billAmt + meterRent;

        PrintBill(custId, name, addr, phone, email, type,
                  prev, curr, u, billAmt, meterRent, totalAmount);
    }

    static double CalBill(int units)
    {
        double amount = 0;

        if (units <= 100)
            amount = units * 1.5;
        else if (units <= 250)
            amount = 100 * 1.5 + (units - 100) * 2.5;
        else if (units <= 550)
            amount = 100 * 1.5 + 150 * 2.5 + (units - 250) * 4.5;
        else
            amount = 100 * 1.5 + 150 * 2.5 + 300 * 4.5 + (units - 550) * 7.5;

        return amount;
    }

    static double GetRent(string type)
    {
        switch (type)
        {
            case "industrial": return 2500;
            case "business": return 1500;
            case "domestic": return 1000;
            case "agricultural": return 0;
            default: return 0;
        }
    }

    static void PrintBill(int id, string name, string address, string phone,
                          string email, string type, int prev, int curr,
                          int units, double bill, double rent, double total)
    {
        Console.WriteLine();
        Console.WriteLine("+------------------------------------------------------+");
        Console.WriteLine("|               ELECTRICITY BILL RECEIPT               |");
        Console.WriteLine("+------------------------------------------------------+");
        Console.WriteLine("| Customer ID      : {0,-33} |", id);
        Console.WriteLine("| Customer Name    : {0,-33} |", name);
        Console.WriteLine("| Address          : {0,-33} |", address);
        Console.WriteLine("| Phone            : {0,-33} |", phone);
        Console.WriteLine("| Email            : {0,-33} |", email);
        Console.WriteLine("| Connection Type  : {0,-33} |", type);
        Console.WriteLine("+------------------------------------------------------+");
        Console.WriteLine("| Previous Reading : {0,-33} |", prev);
        Console.WriteLine("| Current Reading  : {0,-33} |", curr);
        Console.WriteLine("| Units Consumed   : {0,-33} |", units);
        Console.WriteLine("+------------------------------------------------------+");
        Console.WriteLine("| Energy Charges   : ₹ {0,-31} |", bill);
        Console.WriteLine("| Meter Rent       : ₹ {0,-31} |", rent);
        Console.WriteLine("+------------------------------------------------------+");
        Console.WriteLine("| TOTAL AMOUNT     : ₹ {0,-31} |", total);
        Console.WriteLine("+------------------------------------------------------+");
    }
}
}